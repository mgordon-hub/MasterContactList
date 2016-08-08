namespace MasterContactListApplication
{
    partial class DeleteRowConfirmation
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
            this.Button_ConfirmDelete = new System.Windows.Forms.Button();
            this.Button_RejectDelete = new System.Windows.Forms.Button();
            this.Label_DeleteConfirmation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_ConfirmDelete
            // 
            this.Button_ConfirmDelete.Location = new System.Drawing.Point(69, 50);
            this.Button_ConfirmDelete.Name = "Button_ConfirmDelete";
            this.Button_ConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.Button_ConfirmDelete.TabIndex = 0;
            this.Button_ConfirmDelete.Text = "Yes";
            this.Button_ConfirmDelete.UseVisualStyleBackColor = true;
            this.Button_ConfirmDelete.Click += new System.EventHandler(this.Button_ConfirmDelete_Click);
            // 
            // Button_RejectDelete
            // 
            this.Button_RejectDelete.Location = new System.Drawing.Point(150, 50);
            this.Button_RejectDelete.Name = "Button_RejectDelete";
            this.Button_RejectDelete.Size = new System.Drawing.Size(75, 23);
            this.Button_RejectDelete.TabIndex = 1;
            this.Button_RejectDelete.Text = "No";
            this.Button_RejectDelete.UseVisualStyleBackColor = true;
            this.Button_RejectDelete.Click += new System.EventHandler(this.Button_RejectDelete_Click);
            // 
            // Label_DeleteConfirmation
            // 
            this.Label_DeleteConfirmation.AutoSize = true;
            this.Label_DeleteConfirmation.Location = new System.Drawing.Point(45, 21);
            this.Label_DeleteConfirmation.Name = "Label_DeleteConfirmation";
            this.Label_DeleteConfirmation.Size = new System.Drawing.Size(201, 13);
            this.Label_DeleteConfirmation.TabIndex = 2;
            this.Label_DeleteConfirmation.Text = "Are you sure you want to delete this row?";
            // 
            // DeleteRowConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 96);
            this.Controls.Add(this.Label_DeleteConfirmation);
            this.Controls.Add(this.Button_RejectDelete);
            this.Controls.Add(this.Button_ConfirmDelete);
            this.Name = "DeleteRowConfirmation";
            this.Text = "DeleteRowConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ConfirmDelete;
        private System.Windows.Forms.Button Button_RejectDelete;
        private System.Windows.Forms.Label Label_DeleteConfirmation;
    }
}