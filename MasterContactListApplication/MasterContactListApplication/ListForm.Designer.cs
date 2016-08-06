namespace MasterContactListApplication
{
    partial class ListForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactList_Dataset = new MasterContactListApplication.ContactList_Dataset();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new MasterContactListApplication.TestDataSet();
            this.testTableTableAdapter = new MasterContactListApplication.TestDataSetTableAdapters.TestTableTableAdapter();
            this.contact_ListTableAdapter = new MasterContactListApplication.ContactList_DatasetTableAdapters.Contact_ListTableAdapter();
            this.Tab_Search = new System.Windows.Forms.TabControl();
            this.Tab_ViewAllContact = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Button_SaveSearchEdit = new System.Windows.Forms.Button();
            this.Label_SearchResults = new System.Windows.Forms.Label();
            this.dataGridView_SearchResults = new System.Windows.Forms.DataGridView();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Label_LastOrEmail = new System.Windows.Forms.Label();
            this.Combobox_LastOrEmail = new System.Windows.Forms.ComboBox();
            this.Textbox_LastOrEmail = new System.Windows.Forms.TextBox();
            this.Label_SearchBy = new System.Windows.Forms.Label();
            this.Label_SearchContact = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.Tab_Search.SuspendLayout();
            this.Tab_ViewAllContact.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1115, 435);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // contactListBindingSource
            // 
            this.contactListBindingSource.DataMember = "Contact_List";
            this.contactListBindingSource.DataSource = this.contactList_Dataset;
            // 
            // contactList_Dataset
            // 
            this.contactList_Dataset.DataSetName = "ContactList_Dataset";
            this.contactList_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTableBindingSource
            // 
            this.testTableBindingSource.DataMember = "TestTable";
            this.testTableBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testTableTableAdapter
            // 
            this.testTableTableAdapter.ClearBeforeFill = true;
            // 
            // contact_ListTableAdapter
            // 
            this.contact_ListTableAdapter.ClearBeforeFill = true;
            // 
            // Tab_Search
            // 
            this.Tab_Search.Controls.Add(this.Tab_ViewAllContact);
            this.Tab_Search.Controls.Add(this.tabPage2);
            this.Tab_Search.Location = new System.Drawing.Point(12, 13);
            this.Tab_Search.Name = "Tab_Search";
            this.Tab_Search.SelectedIndex = 0;
            this.Tab_Search.Size = new System.Drawing.Size(1126, 533);
            this.Tab_Search.TabIndex = 1;
            // 
            // Tab_ViewAllContact
            // 
            this.Tab_ViewAllContact.Controls.Add(this.dataGridView1);
            this.Tab_ViewAllContact.Location = new System.Drawing.Point(4, 22);
            this.Tab_ViewAllContact.Name = "Tab_ViewAllContact";
            this.Tab_ViewAllContact.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_ViewAllContact.Size = new System.Drawing.Size(1118, 507);
            this.Tab_ViewAllContact.TabIndex = 0;
            this.Tab_ViewAllContact.Text = "View All Contacts";
            this.Tab_ViewAllContact.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Button_SaveSearchEdit);
            this.tabPage2.Controls.Add(this.Label_SearchResults);
            this.tabPage2.Controls.Add(this.dataGridView_SearchResults);
            this.tabPage2.Controls.Add(this.Button_Search);
            this.tabPage2.Controls.Add(this.Label_LastOrEmail);
            this.tabPage2.Controls.Add(this.Combobox_LastOrEmail);
            this.tabPage2.Controls.Add(this.Textbox_LastOrEmail);
            this.tabPage2.Controls.Add(this.Label_SearchBy);
            this.tabPage2.Controls.Add(this.Label_SearchContact);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1118, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Button_SaveSearchEdit
            // 
            this.Button_SaveSearchEdit.Location = new System.Drawing.Point(982, 79);
            this.Button_SaveSearchEdit.Name = "Button_SaveSearchEdit";
            this.Button_SaveSearchEdit.Size = new System.Drawing.Size(96, 20);
            this.Button_SaveSearchEdit.TabIndex = 8;
            this.Button_SaveSearchEdit.Text = "Save";
            this.Button_SaveSearchEdit.UseVisualStyleBackColor = true;
            this.Button_SaveSearchEdit.Visible = false;
            this.Button_SaveSearchEdit.Click += new System.EventHandler(this.Button_SaveSearchEdit_Click);
            // 
            // Label_SearchResults
            // 
            this.Label_SearchResults.AutoSize = true;
            this.Label_SearchResults.Location = new System.Drawing.Point(645, 67);
            this.Label_SearchResults.Name = "Label_SearchResults";
            this.Label_SearchResults.Size = new System.Drawing.Size(35, 13);
            this.Label_SearchResults.TabIndex = 7;
            this.Label_SearchResults.Text = "label1";
            this.Label_SearchResults.Visible = false;
            // 
            // dataGridView_SearchResults
            // 
            this.dataGridView_SearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchResults.Location = new System.Drawing.Point(344, 105);
            this.dataGridView_SearchResults.Name = "dataGridView_SearchResults";
            this.dataGridView_SearchResults.Size = new System.Drawing.Size(734, 136);
            this.dataGridView_SearchResults.TabIndex = 6;
            this.dataGridView_SearchResults.Visible = false;
            this.dataGridView_SearchResults.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SearchResults_CellValueChanged);
            this.dataGridView_SearchResults.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_SearchResults_CurrentCellDirtyStateChanged);
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(95, 158);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(182, 23);
            this.Button_Search.TabIndex = 5;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Visible = false;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Label_LastOrEmail
            // 
            this.Label_LastOrEmail.AutoSize = true;
            this.Label_LastOrEmail.Location = new System.Drawing.Point(20, 139);
            this.Label_LastOrEmail.Name = "Label_LastOrEmail";
            this.Label_LastOrEmail.Size = new System.Drawing.Size(35, 13);
            this.Label_LastOrEmail.TabIndex = 4;
            this.Label_LastOrEmail.Text = "label1";
            this.Label_LastOrEmail.Visible = false;
            // 
            // Combobox_LastOrEmail
            // 
            this.Combobox_LastOrEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_LastOrEmail.FormattingEnabled = true;
            this.Combobox_LastOrEmail.Items.AddRange(new object[] {
            "Last Name",
            "Email"});
            this.Combobox_LastOrEmail.Location = new System.Drawing.Point(95, 105);
            this.Combobox_LastOrEmail.Name = "Combobox_LastOrEmail";
            this.Combobox_LastOrEmail.Size = new System.Drawing.Size(121, 21);
            this.Combobox_LastOrEmail.TabIndex = 3;
            this.Combobox_LastOrEmail.SelectedIndexChanged += new System.EventHandler(this.Combobox_LastOrEmail_SelectedIndexChanged);
            // 
            // Textbox_LastOrEmail
            // 
            this.Textbox_LastOrEmail.Location = new System.Drawing.Point(95, 132);
            this.Textbox_LastOrEmail.Name = "Textbox_LastOrEmail";
            this.Textbox_LastOrEmail.Size = new System.Drawing.Size(182, 20);
            this.Textbox_LastOrEmail.TabIndex = 2;
            this.Textbox_LastOrEmail.Visible = false;
            // 
            // Label_SearchBy
            // 
            this.Label_SearchBy.AutoSize = true;
            this.Label_SearchBy.Location = new System.Drawing.Point(20, 108);
            this.Label_SearchBy.Name = "Label_SearchBy";
            this.Label_SearchBy.Size = new System.Drawing.Size(59, 13);
            this.Label_SearchBy.TabIndex = 1;
            this.Label_SearchBy.Text = "Search By:";
            // 
            // Label_SearchContact
            // 
            this.Label_SearchContact.AutoSize = true;
            this.Label_SearchContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SearchContact.Location = new System.Drawing.Point(28, 27);
            this.Label_SearchContact.Name = "Label_SearchContact";
            this.Label_SearchContact.Size = new System.Drawing.Size(112, 20);
            this.Label_SearchContact.TabIndex = 0;
            this.Label_SearchContact.Text = "Find Contact";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 557);
            this.Controls.Add(this.Tab_Search);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.Tab_Search.ResumeLayout(false);
            this.Tab_ViewAllContact.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource testTableBindingSource;
        private TestDataSetTableAdapters.TestTableTableAdapter testTableTableAdapter;
        private ContactList_Dataset contactList_Dataset;
        private System.Windows.Forms.BindingSource contactListBindingSource;
        private ContactList_DatasetTableAdapters.Contact_ListTableAdapter contact_ListTableAdapter;
        private System.Windows.Forms.TabControl Tab_Search;
        private System.Windows.Forms.TabPage Tab_ViewAllContact;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Combobox_LastOrEmail;
        private System.Windows.Forms.TextBox Textbox_LastOrEmail;
        private System.Windows.Forms.Label Label_SearchBy;
        private System.Windows.Forms.Label Label_SearchContact;
        private System.Windows.Forms.Label Label_LastOrEmail;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DataGridView dataGridView_SearchResults;
        private System.Windows.Forms.Label Label_SearchResults;
        private System.Windows.Forms.Button Button_SaveSearchEdit;
    }
}