namespace ActiveUp.Net.Samples.IMAP4
{
    partial class FlagMessage
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
            this._tbImap4Server = new System.Windows.Forms.TextBox();
            this._lUserName = new System.Windows.Forms.Label();
            this._tbUserName = new System.Windows.Forms.TextBox();
            this._lImap4Server = new System.Windows.Forms.Label();
            this._tbPassword = new System.Windows.Forms.TextBox();
            this._lPassword = new System.Windows.Forms.Label();
            this._bRetrieveMessages = new System.Windows.Forms.Button();
            this._bSetFlag = new System.Windows.Forms.Button();
            this._lvMessages = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._bSetFlag);
            this.splitContainer1.Panel1.Controls.Add(this._lvMessages);
            this.splitContainer1.Panel1.Controls.Add(this._tbImap4Server);
            this.splitContainer1.Panel1.Controls.Add(this._lUserName);
            this.splitContainer1.Panel1.Controls.Add(this._bRetrieveMessages);
            this.splitContainer1.Panel1.Controls.Add(this._tbUserName);
            this.splitContainer1.Panel1.Controls.Add(this._lPassword);
            this.splitContainer1.Panel1.Controls.Add(this._lImap4Server);
            this.splitContainer1.Panel1.Controls.Add(this._tbPassword);
            this.splitContainer1.TabIndex = 1;
            // 
            // _tbImap4Server
            // 
            this._tbImap4Server.Location = new System.Drawing.Point(15, 104);
            this._tbImap4Server.Name = "_tbImap4Server";
            this._tbImap4Server.Size = new System.Drawing.Size(270, 20);
            this._tbImap4Server.TabIndex = 5;
            // 
            // _lUserName
            // 
            this._lUserName.AutoSize = true;
            this._lUserName.Location = new System.Drawing.Point(12, 10);
            this._lUserName.Name = "_lUserName";
            this._lUserName.Size = new System.Drawing.Size(61, 13);
            this._lUserName.TabIndex = 0;
            this._lUserName.Text = "User name:";
            // 
            // _tbUserName
            // 
            this._tbUserName.Location = new System.Drawing.Point(15, 26);
            this._tbUserName.Name = "_tbUserName";
            this._tbUserName.Size = new System.Drawing.Size(270, 20);
            this._tbUserName.TabIndex = 1;
            // 
            // _lImap4Server
            // 
            this._lImap4Server.AutoSize = true;
            this._lImap4Server.Location = new System.Drawing.Point(12, 88);
            this._lImap4Server.Name = "_lImap4Server";
            this._lImap4Server.Size = new System.Drawing.Size(248, 13);
            this._lImap4Server.TabIndex = 4;
            this._lImap4Server.Text = "IMAP4 server address (will use 143 as default port):";
            // 
            // _tbPassword
            // 
            this._tbPassword.Location = new System.Drawing.Point(15, 65);
            this._tbPassword.Name = "_tbPassword";
            this._tbPassword.Size = new System.Drawing.Size(270, 20);
            this._tbPassword.TabIndex = 3;
            // 
            // _lPassword
            // 
            this._lPassword.AutoSize = true;
            this._lPassword.Location = new System.Drawing.Point(12, 49);
            this._lPassword.Name = "_lPassword";
            this._lPassword.Size = new System.Drawing.Size(56, 13);
            this._lPassword.TabIndex = 2;
            this._lPassword.Text = "Password:";
            // 
            // _bRetrieveMessages
            // 
            this._bRetrieveMessages.Location = new System.Drawing.Point(15, 130);
            this._bRetrieveMessages.Name = "_bRetrieveMessages";
            this._bRetrieveMessages.Size = new System.Drawing.Size(270, 36);
            this._bRetrieveMessages.TabIndex = 6;
            this._bRetrieveMessages.Text = "Retrieves messages";
            this._bRetrieveMessages.UseVisualStyleBackColor = true;
            this._bRetrieveMessages.Click += new System.EventHandler(this._bRetrieveMessages_Click);
            // 
            // _bSetFlag
            // 
            this._bSetFlag.Enabled = false;
            this._bSetFlag.Location = new System.Drawing.Point(163, 286);
            this._bSetFlag.Name = "_bSetFlag";
            this._bSetFlag.Size = new System.Drawing.Size(122, 23);
            this._bSetFlag.TabIndex = 12;
            this._bSetFlag.Text = "Set flag (answered)";
            this._bSetFlag.UseVisualStyleBackColor = true;
            this._bSetFlag.Click += new System.EventHandler(this._bSetFlag_Click);
            // 
            // _lvMessages
            // 
            this._lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this._lvMessages.FullRowSelect = true;
            this._lvMessages.GridLines = true;
            this._lvMessages.HideSelection = false;
            this._lvMessages.Location = new System.Drawing.Point(16, 172);
            this._lvMessages.MultiSelect = false;
            this._lvMessages.Name = "_lvMessages";
            this._lvMessages.Size = new System.Drawing.Size(269, 108);
            this._lvMessages.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._lvMessages.TabIndex = 11;
            this._lvMessages.UseCompatibleStateImageBehavior = false;
            this._lvMessages.View = System.Windows.Forms.View.Details;
            this._lvMessages.DoubleClick += new System.EventHandler(this._lvMessages_DoubleClick);
            this._lvMessages.SelectedIndexChanged += new System.EventHandler(this._lvMessages_SelectedIndexChanged);
            this._lvMessages.KeyDown += new System.Windows.Forms.KeyEventHandler(this._lvMessages_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 226;
            // 
            // FlagMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 514);
            this.Name = "FlagMessage";
            this.Text = "Flag a message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlagMessage_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox _tbImap4Server;
        private System.Windows.Forms.Label _lUserName;
        private System.Windows.Forms.TextBox _tbUserName;
        private System.Windows.Forms.Label _lImap4Server;
        private System.Windows.Forms.TextBox _tbPassword;
        private System.Windows.Forms.Label _lPassword;
        private System.Windows.Forms.Button _bRetrieveMessages;
        private System.Windows.Forms.Button _bSetFlag;
        private System.Windows.Forms.ListView _lvMessages;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
