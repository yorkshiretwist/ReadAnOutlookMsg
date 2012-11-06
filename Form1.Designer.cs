namespace ReadAnOutlookMsg
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.bodyTab = new System.Windows.Forms.TabPage();
            this.body = new System.Windows.Forms.RichTextBox();
            this.headersTab = new System.Windows.Forms.TabPage();
            this.headers = new System.Windows.Forms.TextBox();
            this.attachmentsTab = new System.Windows.Forms.TabPage();
            this.attachments = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.cc = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.data = new System.Windows.Forms.TextBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.selectFolder = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.bodyTab.SuspendLayout();
            this.headersTab.SuspendLayout();
            this.attachmentsTab.SuspendLayout();
            this.dataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CC: ";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.bodyTab);
            this.tabs.Controls.Add(this.headersTab);
            this.tabs.Controls.Add(this.attachmentsTab);
            this.tabs.Controls.Add(this.dataTab);
            this.tabs.Location = new System.Drawing.Point(192, 73);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(540, 351);
            this.tabs.TabIndex = 8;
            // 
            // bodyTab
            // 
            this.bodyTab.Controls.Add(this.body);
            this.bodyTab.Location = new System.Drawing.Point(4, 22);
            this.bodyTab.Name = "bodyTab";
            this.bodyTab.Padding = new System.Windows.Forms.Padding(3);
            this.bodyTab.Size = new System.Drawing.Size(532, 325);
            this.bodyTab.TabIndex = 0;
            this.bodyTab.Text = "Body";
            this.bodyTab.UseVisualStyleBackColor = true;
            // 
            // body
            // 
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.body.Location = new System.Drawing.Point(0, 0);
            this.body.Name = "body";
            this.body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.body.Size = new System.Drawing.Size(532, 325);
            this.body.TabIndex = 4;
            this.body.Text = "";
            // 
            // headersTab
            // 
            this.headersTab.Controls.Add(this.headers);
            this.headersTab.Location = new System.Drawing.Point(4, 22);
            this.headersTab.Name = "headersTab";
            this.headersTab.Padding = new System.Windows.Forms.Padding(3);
            this.headersTab.Size = new System.Drawing.Size(532, 325);
            this.headersTab.TabIndex = 1;
            this.headersTab.Text = "Headers";
            this.headersTab.UseVisualStyleBackColor = true;
            // 
            // headers
            // 
            this.headers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headers.Location = new System.Drawing.Point(0, 0);
            this.headers.Multiline = true;
            this.headers.Name = "headers";
            this.headers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.headers.Size = new System.Drawing.Size(532, 325);
            this.headers.TabIndex = 0;
            // 
            // attachmentsTab
            // 
            this.attachmentsTab.Controls.Add(this.attachments);
            this.attachmentsTab.Location = new System.Drawing.Point(4, 22);
            this.attachmentsTab.Name = "attachmentsTab";
            this.attachmentsTab.Size = new System.Drawing.Size(532, 325);
            this.attachmentsTab.TabIndex = 2;
            this.attachmentsTab.Text = "Attachments";
            this.attachmentsTab.UseVisualStyleBackColor = true;
            // 
            // attachments
            // 
            this.attachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachments.Location = new System.Drawing.Point(0, 0);
            this.attachments.Multiline = true;
            this.attachments.Name = "attachments";
            this.attachments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachments.Size = new System.Drawing.Size(532, 325);
            this.attachments.TabIndex = 1;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(255, 19);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(212, 20);
            this.subject.TabIndex = 9;
            // 
            // cc
            // 
            this.cc.Location = new System.Drawing.Point(516, 47);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(212, 20);
            this.cc.TabIndex = 10;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(255, 47);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(212, 20);
            this.to.TabIndex = 12;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(516, 19);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(212, 20);
            this.from.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "From: ";
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.data);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Size = new System.Drawing.Size(532, 325);
            this.dataTab.TabIndex = 3;
            this.dataTab.Text = "Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.data.Size = new System.Drawing.Size(532, 325);
            this.data.TabIndex = 1;
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(12, 73);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(174, 351);
            this.tree.TabIndex = 15;
            // 
            // selectFolder
            // 
            this.selectFolder.Image = global::ReadAnOutlookMsg.Properties.Resources.folder_explore;
            this.selectFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFolder.Location = new System.Drawing.Point(12, 37);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(99, 26);
            this.selectFolder.TabIndex = 2;
            this.selectFolder.Text = "Select folder";
            this.selectFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectFolder.UseVisualStyleBackColor = true;
            this.selectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 436);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.to);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectFolder);
            this.MinimumSize = new System.Drawing.Size(700, 472);
            this.Name = "Form1";
            this.Text = "Outlook Message Viewer";
            this.tabs.ResumeLayout(false);
            this.bodyTab.ResumeLayout(false);
            this.headersTab.ResumeLayout(false);
            this.headersTab.PerformLayout();
            this.attachmentsTab.ResumeLayout(false);
            this.attachmentsTab.PerformLayout();
            this.dataTab.ResumeLayout(false);
            this.dataTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage bodyTab;
        private System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.TabPage headersTab;
        private System.Windows.Forms.TextBox headers;
        private System.Windows.Forms.TabPage attachmentsTab;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox cc;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox attachments;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TreeView tree;
    }
}

