namespace JSONVisualizer
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.btnSource = new System.Windows.Forms.Button();
            this.listUser = new System.Windows.Forms.ListBox();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.listContacts = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Controls.Add(this.tabMessages);
            this.tabControl.Controls.Add(this.tabContacts);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(523, 288);
            this.tabControl.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.btnSource);
            this.tabUser.Controls.Add(this.listUser);
            this.tabUser.Location = new System.Drawing.Point(4, 22);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(515, 262);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(434, 236);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(75, 23);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Locate Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.BtnLocate_Click);
            // 
            // listUser
            // 
            this.listUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUser.FormattingEnabled = true;
            this.listUser.Location = new System.Drawing.Point(3, 2);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(166, 260);
            this.listUser.TabIndex = 0;
            // 
            // tabMessages
            // 
            this.tabMessages.Controls.Add(this.listMessages);
            this.tabMessages.Controls.Add(this.cmbPerson);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabMessages.Size = new System.Drawing.Size(515, 262);
            this.tabMessages.TabIndex = 1;
            this.tabMessages.Text = "Messages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // listMessages
            // 
            this.listMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listMessages.FormattingEnabled = true;
            this.listMessages.HorizontalScrollbar = true;
            this.listMessages.Location = new System.Drawing.Point(0, 0);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(349, 260);
            this.listMessages.TabIndex = 1;
            // 
            // cmbPerson
            // 
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Location = new System.Drawing.Point(355, 6);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(157, 21);
            this.cmbPerson.TabIndex = 0;
            this.cmbPerson.SelectedIndexChanged += new System.EventHandler(this.cmbPerson_SelectedIndexChanged);
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.listContacts);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(515, 262);
            this.tabContacts.TabIndex = 2;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // listContacts
            // 
            this.listContacts.FormattingEnabled = true;
            this.listContacts.HorizontalScrollbar = true;
            this.listContacts.Location = new System.Drawing.Point(9, 7);
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(500, 251);
            this.listContacts.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 288);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Database Visualizer";
            this.tabControl.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog sourceFolderBrowser;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabMessages;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.ListBox listContacts;
    }
}

