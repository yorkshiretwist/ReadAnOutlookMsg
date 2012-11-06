using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iwantedue;
using iwantedue.Windows.Forms;

namespace ReadAnOutlookMsg
{
    /// <summary>
    /// Read an Outlook message form
    /// </summary>
    /// <remarks>
    /// This code was partly taken from the project at http://www.codeproject.com/Articles/32899/Reading-an-Outlook-MSG-File-in-C
    /// </remarks>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Runs when the browse button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // show a folder browser dialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            // when a folder has been chosen
            if (result == DialogResult.OK)
            {
                // set up the images
                tree.ImageList = new ImageList();
                tree.ImageList.Images.Add("email", new Bitmap (ReadAnOutlookMsg.Properties.Resources.email));
                tree.ImageList.Images.Add("folder", new Bitmap(ReadAnOutlookMsg.Properties.Resources.folder));

                // load the directory
                DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
                
                // clear the current tree nodes
                tree.Nodes.Clear();

                // add the parent tree node
                TreeNode parentNode = new TreeNode(fbd.SelectedPath);
                parentNode.ImageKey = "folder";
                parentNode.SelectedImageKey = "folder";
                tree.Nodes.Add(parentNode);

                // populate the folders
                PopulateFolders(dir, tree.Nodes[0]);

                // populate the emails
                PopulateEmails(dir, tree.Nodes[0]);

                // set the event handler for when a tree item is selected
                tree.AfterSelect += new TreeViewEventHandler(tree_AfterSelect);
            }
        }

        /// <summary>
        /// Runs when a tree node is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void tree_AfterSelect(object sender, EventArgs e)
        {
            // get the selected node
            TreeNode node = tree.SelectedNode;
            if (node != null && node.Tag != null)
            {
                // load the message for this node
                LoadMessage(node.Tag.ToString());
            }
        }

        /// <summary>
        /// Populate the folders in the tree
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="parentNode"></param>
        private void PopulateFolders(DirectoryInfo dir, TreeNode parentNode)
        {
            try
            {
                DirectoryInfo[] subdirs = dir.GetDirectories();
                if (subdirs.Length != 0)
                {
                    foreach (DirectoryInfo subdir in subdirs)
                    {
                        TreeNode subdirNode = new TreeNode(subdir.Name);
                        subdirNode.ImageKey = "folder";
                        subdirNode.SelectedImageKey = "folder";
                        parentNode.Nodes.Add(subdirNode);
                        PopulateEmails(subdir, subdirNode);
                        PopulateFolders(subdir, subdirNode);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access denied");
            } // end catch
        }

        /// <summary>
        /// Populate the emails in the folder
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="parentNode"></param>
        private void PopulateEmails(DirectoryInfo dir, TreeNode parentNode)
        {
            FileInfo[] emails = dir.GetFiles("*.msg");
            if (emails.Length > 0)
            {
                foreach (FileInfo email in emails)
                {
                    TreeNode emailNode = new TreeNode(email.Name);
                    emailNode.ImageKey = "email";
                    emailNode.Tag = email.FullName;
                    parentNode.Nodes.Add(emailNode);
                }
            }
        }

        /// <summary>
        /// Load an individual email
        /// </summary>
        /// <param name="path"></param>
        private void LoadMessage(string path)
        {
            // open a message stream to get the message object
            Stream messageStream = File.Open(path, FileMode.Open, FileAccess.Read);
            OutlookStorage.Message message = new OutlookStorage.Message(messageStream);
            messageStream.Close();

            // set the basic properties
            body.Rtf = message.BodyRTF;
            subject.Text = message.Subject;
            from.Text = string.Format("{0} <{1}>", message.From, message.GetMapiPropertyString("5D01"));
            headers.Text = message.GetMapiPropertyString("007D");

            // add the recipients
            AddRecipients(message);

            // add any attachments
            AddAttachments(message);

            // populate the extended data
            PopulateData(message);
        }

        /// <summary>
        /// Populates the extended data for a message
        /// </summary>
        /// <param name="message"></param>
        private void PopulateData(OutlookStorage.Message message)
        {
            data.Text = "";
            foreach (string key in message.streamStatistics.Keys)
            {
                string hexKey = key.Substring(12, 4);
                try
                {
                    object property = message.GetMapiProperty(hexKey);
                    if (property == null)
                    {
                        data.AppendText((string.Format("Key {0} is null{1}", hexKey, Environment.NewLine)));
                    }
                    else if (property is byte[])
                    {
                        data.AppendText(string.Format("Key {0} is a byte array{1}", hexKey, Environment.NewLine));
                    }
                    else
                    {
                        data.AppendText(string.Format("{0}: {1}{2}", hexKey, property.ToString(), Environment.NewLine));
                    }
                }
                catch
                {
                    data.AppendText(string.Format("Key {0} threw an exception{1}", hexKey, Environment.NewLine));
                }
            }
        }

        /// <summary>
        /// Adds recipients for a message
        /// </summary>
        /// <param name="message"></param>
        private void AddRecipients(OutlookStorage.Message message)
        {
            to.Text = "";
            cc.Text = "";
            foreach (OutlookStorage.Recipient recipient in message.Recipients)
            {
                if (recipient.Type == OutlookStorage.RecipientType.To)
                {
                    to.AppendText(recipient.Email + ", ");
                }
                else if (recipient.Type == OutlookStorage.RecipientType.CC)
                {
                    cc.AppendText(recipient.Email + ", ");
                }
            }
            to.Text = to.Text.TrimEnd().TrimEnd(',');
            cc.Text = cc.Text.TrimEnd().TrimEnd(',');
        }

        /// <summary>
        /// Adds attachments for a message
        /// </summary>
        /// <param name="message"></param>
        private void AddAttachments(OutlookStorage.Message message)
        {
            foreach (OutlookStorage.Attachment attachment in message.Attachments)
            {
                attachments.AppendText(attachment.Filename + ": " + attachment.Data.Length + "b\r\n\r\n");
            }
        }
    }
}