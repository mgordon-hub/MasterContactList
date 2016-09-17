namespace MasterContactListApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_MasterContactList = new System.Windows.Forms.Label();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Textbox_Password = new System.Windows.Forms.TextBox();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Label_GovernmentPrograms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_MasterContactList
            // 
            this.label_MasterContactList.AutoSize = true;
            this.label_MasterContactList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MasterContactList.Location = new System.Drawing.Point(53, 80);
            this.label_MasterContactList.Name = "label_MasterContactList";
            this.label_MasterContactList.Size = new System.Drawing.Size(235, 29);
            this.label_MasterContactList.TabIndex = 0;
            this.label_MasterContactList.Text = "Master Contact List";
            this.label_MasterContactList.Click += new System.EventHandler(this.label1_Click);
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.Location = new System.Drawing.Point(76, 189);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(191, 20);
            this.Textbox_Username.TabIndex = 1;
            // 
            // Textbox_Password
            // 
            this.Textbox_Password.Location = new System.Drawing.Point(76, 251);
            this.Textbox_Password.Name = "Textbox_Password";
            this.Textbox_Password.PasswordChar = '*';
            this.Textbox_Password.Size = new System.Drawing.Size(191, 20);
            this.Textbox_Password.TabIndex = 2;
            this.Textbox_Password.Text = "4";
            // 
            // Button_Login
            // 
            this.Button_Login.Location = new System.Drawing.Point(76, 306);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(191, 28);
            this.Button_Login.TabIndex = 3;
            this.Button_Login.Text = "Login";
            this.Button_Login.UseVisualStyleBackColor = true;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(73, 173);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(55, 13);
            this.Label_Username.TabIndex = 4;
            this.Label_Username.Text = "Username";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(73, 235);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(53, 13);
            this.Label_Password.TabIndex = 5;
            this.Label_Password.Text = "Password";
            // 
            // Label_GovernmentPrograms
            // 
            this.Label_GovernmentPrograms.AutoSize = true;
            this.Label_GovernmentPrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Label_GovernmentPrograms.Location = new System.Drawing.Point(34, 51);
            this.Label_GovernmentPrograms.Name = "Label_GovernmentPrograms";
            this.Label_GovernmentPrograms.Size = new System.Drawing.Size(274, 29);
            this.Label_GovernmentPrograms.TabIndex = 6;
            this.Label_GovernmentPrograms.Text = "Government Programs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 403);
            this.Controls.Add(this.Label_GovernmentPrograms);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Button_Login);
            this.Controls.Add(this.Textbox_Password);
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.label_MasterContactList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Master Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MasterContactList;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.TextBox Textbox_Password;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_GovernmentPrograms;
    }
}

