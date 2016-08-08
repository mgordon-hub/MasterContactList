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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contactListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactList_Dataset = new MasterContactListApplication.ContactList_Dataset();
            this.testTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new MasterContactListApplication.TestDataSet();
            this.testTableTableAdapter = new MasterContactListApplication.TestDataSetTableAdapters.TestTableTableAdapter();
            this.contact_ListTableAdapter = new MasterContactListApplication.ContactList_DatasetTableAdapters.Contact_ListTableAdapter();
            this.Tab_Control = new System.Windows.Forms.TabControl();
            this.Tab_ViewAllContact = new System.Windows.Forms.TabPage();
            this.Tab_Search = new System.Windows.Forms.TabPage();
            this.Button_SaveSearchEdit = new System.Windows.Forms.Button();
            this.Label_SearchResults = new System.Windows.Forms.Label();
            this.dataGridView_SearchResults = new System.Windows.Forms.DataGridView();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Label_LastOrEmail = new System.Windows.Forms.Label();
            this.Combobox_LastOrEmail = new System.Windows.Forms.ComboBox();
            this.Textbox_LastOrEmail = new System.Windows.Forms.TextBox();
            this.Label_SearchBy = new System.Windows.Forms.Label();
            this.Label_SearchContact = new System.Windows.Forms.Label();
            this.Tab_AddContact = new System.Windows.Forms.TabPage();
            this.Button_AddContact = new System.Windows.Forms.Button();
            this.Label_VISN = new System.Windows.Forms.Label();
            this.Label_Region = new System.Windows.Forms.Label();
            this.numericUpDown2_VISN = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_Region = new System.Windows.Forms.NumericUpDown();
            this.Label_EBulletin = new System.Windows.Forms.Label();
            this.Textbox_EBulletin = new System.Windows.Forms.TextBox();
            this.Textbox_AE = new System.Windows.Forms.TextBox();
            this.Textbox_State = new System.Windows.Forms.TextBox();
            this.Textbox_City = new System.Windows.Forms.TextBox();
            this.Textbox_ContractCodingCompany = new System.Windows.Forms.TextBox();
            this.Textbox_Company = new System.Windows.Forms.TextBox();
            this.Textbox_Department = new System.Windows.Forms.TextBox();
            this.Label_AE = new System.Windows.Forms.Label();
            this.Label_State = new System.Windows.Forms.Label();
            this.Label_City = new System.Windows.Forms.Label();
            this.Label_ContractCodingCompany = new System.Windows.Forms.Label();
            this.Label_Company = new System.Windows.Forms.Label();
            this.Label_Department = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6_ContactType = new System.Windows.Forms.Label();
            this.label5_Title = new System.Windows.Forms.Label();
            this.Textbox_ContactType = new System.Windows.Forms.TextBox();
            this.Textbox_Title = new System.Windows.Forms.TextBox();
            this.Textbox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.Textbox_Email = new System.Windows.Forms.TextBox();
            this.Textbox_Lname = new System.Windows.Forms.TextBox();
            this.Textbox_FName = new System.Windows.Forms.TextBox();
            this.label4_PhoneNumber = new System.Windows.Forms.Label();
            this.label3_email = new System.Windows.Forms.Label();
            this.label2_LastName = new System.Windows.Forms.Label();
            this.label1_FirstName = new System.Windows.Forms.Label();
            this.Label_AddContact = new System.Windows.Forms.Label();
            this.ContextMenuStrip_DeleteRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.Tab_Control.SuspendLayout();
            this.Tab_ViewAllContact.SuspendLayout();
            this.Tab_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchResults)).BeginInit();
            this.Tab_AddContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_VISN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Region)).BeginInit();
            this.ContextMenuStrip_DeleteRow.SuspendLayout();
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
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
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
            // Tab_Control
            // 
            this.Tab_Control.Controls.Add(this.Tab_ViewAllContact);
            this.Tab_Control.Controls.Add(this.Tab_Search);
            this.Tab_Control.Controls.Add(this.Tab_AddContact);
            this.Tab_Control.Location = new System.Drawing.Point(12, 13);
            this.Tab_Control.Name = "Tab_Control";
            this.Tab_Control.SelectedIndex = 0;
            this.Tab_Control.Size = new System.Drawing.Size(1126, 533);
            this.Tab_Control.TabIndex = 1;
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
            // Tab_Search
            // 
            this.Tab_Search.Controls.Add(this.Button_SaveSearchEdit);
            this.Tab_Search.Controls.Add(this.Label_SearchResults);
            this.Tab_Search.Controls.Add(this.dataGridView_SearchResults);
            this.Tab_Search.Controls.Add(this.Button_Search);
            this.Tab_Search.Controls.Add(this.Label_LastOrEmail);
            this.Tab_Search.Controls.Add(this.Combobox_LastOrEmail);
            this.Tab_Search.Controls.Add(this.Textbox_LastOrEmail);
            this.Tab_Search.Controls.Add(this.Label_SearchBy);
            this.Tab_Search.Controls.Add(this.Label_SearchContact);
            this.Tab_Search.Location = new System.Drawing.Point(4, 22);
            this.Tab_Search.Name = "Tab_Search";
            this.Tab_Search.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_Search.Size = new System.Drawing.Size(1118, 507);
            this.Tab_Search.TabIndex = 1;
            this.Tab_Search.Text = "Search";
            this.Tab_Search.UseVisualStyleBackColor = true;
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
            this.dataGridView_SearchResults.Size = new System.Drawing.Size(734, 204);
            this.dataGridView_SearchResults.TabIndex = 6;
            this.dataGridView_SearchResults.Visible = false;
            this.dataGridView_SearchResults.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SearchResults_CellMouseUp);
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
            // Tab_AddContact
            // 
            this.Tab_AddContact.Controls.Add(this.Button_AddContact);
            this.Tab_AddContact.Controls.Add(this.Label_VISN);
            this.Tab_AddContact.Controls.Add(this.Label_Region);
            this.Tab_AddContact.Controls.Add(this.numericUpDown2_VISN);
            this.Tab_AddContact.Controls.Add(this.numericUpDown1_Region);
            this.Tab_AddContact.Controls.Add(this.Label_EBulletin);
            this.Tab_AddContact.Controls.Add(this.Textbox_EBulletin);
            this.Tab_AddContact.Controls.Add(this.Textbox_AE);
            this.Tab_AddContact.Controls.Add(this.Textbox_State);
            this.Tab_AddContact.Controls.Add(this.Textbox_City);
            this.Tab_AddContact.Controls.Add(this.Textbox_ContractCodingCompany);
            this.Tab_AddContact.Controls.Add(this.Textbox_Company);
            this.Tab_AddContact.Controls.Add(this.Textbox_Department);
            this.Tab_AddContact.Controls.Add(this.Label_AE);
            this.Tab_AddContact.Controls.Add(this.Label_State);
            this.Tab_AddContact.Controls.Add(this.Label_City);
            this.Tab_AddContact.Controls.Add(this.Label_ContractCodingCompany);
            this.Tab_AddContact.Controls.Add(this.Label_Company);
            this.Tab_AddContact.Controls.Add(this.Label_Department);
            this.Tab_AddContact.Controls.Add(this.checkedListBox1);
            this.Tab_AddContact.Controls.Add(this.label6_ContactType);
            this.Tab_AddContact.Controls.Add(this.label5_Title);
            this.Tab_AddContact.Controls.Add(this.Textbox_ContactType);
            this.Tab_AddContact.Controls.Add(this.Textbox_Title);
            this.Tab_AddContact.Controls.Add(this.Textbox_PhoneNumber);
            this.Tab_AddContact.Controls.Add(this.Textbox_Email);
            this.Tab_AddContact.Controls.Add(this.Textbox_Lname);
            this.Tab_AddContact.Controls.Add(this.Textbox_FName);
            this.Tab_AddContact.Controls.Add(this.label4_PhoneNumber);
            this.Tab_AddContact.Controls.Add(this.label3_email);
            this.Tab_AddContact.Controls.Add(this.label2_LastName);
            this.Tab_AddContact.Controls.Add(this.label1_FirstName);
            this.Tab_AddContact.Controls.Add(this.Label_AddContact);
            this.Tab_AddContact.Location = new System.Drawing.Point(4, 22);
            this.Tab_AddContact.Name = "Tab_AddContact";
            this.Tab_AddContact.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_AddContact.Size = new System.Drawing.Size(1118, 507);
            this.Tab_AddContact.TabIndex = 2;
            this.Tab_AddContact.Text = "Add Contact";
            this.Tab_AddContact.UseVisualStyleBackColor = true;
            // 
            // Button_AddContact
            // 
            this.Button_AddContact.Location = new System.Drawing.Point(490, 91);
            this.Button_AddContact.Name = "Button_AddContact";
            this.Button_AddContact.Size = new System.Drawing.Size(75, 23);
            this.Button_AddContact.TabIndex = 32;
            this.Button_AddContact.Text = "Submit";
            this.Button_AddContact.UseVisualStyleBackColor = true;
            this.Button_AddContact.Click += new System.EventHandler(this.Button_AddContact_Click);
            // 
            // Label_VISN
            // 
            this.Label_VISN.AutoSize = true;
            this.Label_VISN.Location = new System.Drawing.Point(14, 439);
            this.Label_VISN.Name = "Label_VISN";
            this.Label_VISN.Size = new System.Drawing.Size(32, 13);
            this.Label_VISN.TabIndex = 31;
            this.Label_VISN.Text = "VISN";
            // 
            // Label_Region
            // 
            this.Label_Region.AutoSize = true;
            this.Label_Region.Location = new System.Drawing.Point(14, 413);
            this.Label_Region.Name = "Label_Region";
            this.Label_Region.Size = new System.Drawing.Size(41, 13);
            this.Label_Region.TabIndex = 30;
            this.Label_Region.Text = "Region";
            // 
            // numericUpDown2_VISN
            // 
            this.numericUpDown2_VISN.Location = new System.Drawing.Point(150, 439);
            this.numericUpDown2_VISN.Name = "numericUpDown2_VISN";
            this.numericUpDown2_VISN.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2_VISN.TabIndex = 29;
            // 
            // numericUpDown1_Region
            // 
            this.numericUpDown1_Region.Location = new System.Drawing.Point(150, 413);
            this.numericUpDown1_Region.Name = "numericUpDown1_Region";
            this.numericUpDown1_Region.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1_Region.TabIndex = 28;
            // 
            // Label_EBulletin
            // 
            this.Label_EBulletin.AutoSize = true;
            this.Label_EBulletin.Location = new System.Drawing.Point(14, 381);
            this.Label_EBulletin.Name = "Label_EBulletin";
            this.Label_EBulletin.Size = new System.Drawing.Size(51, 13);
            this.Label_EBulletin.TabIndex = 27;
            this.Label_EBulletin.Text = "E-Bulletin";
            // 
            // Textbox_EBulletin
            // 
            this.Textbox_EBulletin.Location = new System.Drawing.Point(150, 381);
            this.Textbox_EBulletin.Name = "Textbox_EBulletin";
            this.Textbox_EBulletin.Size = new System.Drawing.Size(100, 20);
            this.Textbox_EBulletin.TabIndex = 26;
            // 
            // Textbox_AE
            // 
            this.Textbox_AE.Location = new System.Drawing.Point(150, 354);
            this.Textbox_AE.Name = "Textbox_AE";
            this.Textbox_AE.Size = new System.Drawing.Size(100, 20);
            this.Textbox_AE.TabIndex = 25;
            // 
            // Textbox_State
            // 
            this.Textbox_State.Location = new System.Drawing.Point(150, 328);
            this.Textbox_State.Name = "Textbox_State";
            this.Textbox_State.Size = new System.Drawing.Size(100, 20);
            this.Textbox_State.TabIndex = 24;
            // 
            // Textbox_City
            // 
            this.Textbox_City.Location = new System.Drawing.Point(150, 302);
            this.Textbox_City.Name = "Textbox_City";
            this.Textbox_City.Size = new System.Drawing.Size(100, 20);
            this.Textbox_City.TabIndex = 23;
            // 
            // Textbox_ContractCodingCompany
            // 
            this.Textbox_ContractCodingCompany.Location = new System.Drawing.Point(150, 276);
            this.Textbox_ContractCodingCompany.Name = "Textbox_ContractCodingCompany";
            this.Textbox_ContractCodingCompany.Size = new System.Drawing.Size(100, 20);
            this.Textbox_ContractCodingCompany.TabIndex = 22;
            // 
            // Textbox_Company
            // 
            this.Textbox_Company.Location = new System.Drawing.Point(150, 253);
            this.Textbox_Company.Name = "Textbox_Company";
            this.Textbox_Company.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Company.TabIndex = 21;
            // 
            // Textbox_Department
            // 
            this.Textbox_Department.Location = new System.Drawing.Point(150, 230);
            this.Textbox_Department.Name = "Textbox_Department";
            this.Textbox_Department.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Department.TabIndex = 20;
            // 
            // Label_AE
            // 
            this.Label_AE.AutoSize = true;
            this.Label_AE.Location = new System.Drawing.Point(14, 354);
            this.Label_AE.Name = "Label_AE";
            this.Label_AE.Size = new System.Drawing.Size(21, 13);
            this.Label_AE.TabIndex = 19;
            this.Label_AE.Text = "AE";
            // 
            // Label_State
            // 
            this.Label_State.AutoSize = true;
            this.Label_State.Location = new System.Drawing.Point(14, 328);
            this.Label_State.Name = "Label_State";
            this.Label_State.Size = new System.Drawing.Size(32, 13);
            this.Label_State.TabIndex = 18;
            this.Label_State.Text = "State";
            // 
            // Label_City
            // 
            this.Label_City.AutoSize = true;
            this.Label_City.Location = new System.Drawing.Point(14, 302);
            this.Label_City.Name = "Label_City";
            this.Label_City.Size = new System.Drawing.Size(24, 13);
            this.Label_City.TabIndex = 17;
            this.Label_City.Text = "City";
            // 
            // Label_ContractCodingCompany
            // 
            this.Label_ContractCodingCompany.AutoSize = true;
            this.Label_ContractCodingCompany.Location = new System.Drawing.Point(14, 276);
            this.Label_ContractCodingCompany.Name = "Label_ContractCodingCompany";
            this.Label_ContractCodingCompany.Size = new System.Drawing.Size(130, 13);
            this.Label_ContractCodingCompany.TabIndex = 16;
            this.Label_ContractCodingCompany.Text = "Contract Coding Company";
            // 
            // Label_Company
            // 
            this.Label_Company.AutoSize = true;
            this.Label_Company.Location = new System.Drawing.Point(14, 253);
            this.Label_Company.Name = "Label_Company";
            this.Label_Company.Size = new System.Drawing.Size(51, 13);
            this.Label_Company.TabIndex = 15;
            this.Label_Company.Text = "Company";
            // 
            // Label_Department
            // 
            this.Label_Department.AutoSize = true;
            this.Label_Department.Location = new System.Drawing.Point(14, 230);
            this.Label_Department.Name = "Label_Department";
            this.Label_Department.Size = new System.Drawing.Size(62, 13);
            this.Label_Department.TabIndex = 14;
            this.Label_Department.Text = "Department";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Decision Maker",
            "Budget Holder",
            "EPS",
            "Simulator",
            "VACC",
            "VACC R Notes",
            "CDI Pro",
            "CDI Pro R Notes",
            "VERA Az",
            "VERA Az R Notes",
            "OI&T",
            "NHAC",
            "Svc Interrupt/Restor",
            "Webcast Bulletin",
            "iSupport Account",
            "Bulletin Reader",
            "NPS Fall 2016",
            "NPS Spring 2016",
            "NPS Spring 2015",
            "OI&T Building Relationships",
            "Klas"});
            this.checkedListBox1.Location = new System.Drawing.Point(302, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(209, 315);
            this.checkedListBox1.TabIndex = 13;
            // 
            // label6_ContactType
            // 
            this.label6_ContactType.AutoSize = true;
            this.label6_ContactType.Location = new System.Drawing.Point(14, 204);
            this.label6_ContactType.Name = "label6_ContactType";
            this.label6_ContactType.Size = new System.Drawing.Size(71, 13);
            this.label6_ContactType.TabIndex = 12;
            this.label6_ContactType.Text = "Contact Type";
            // 
            // label5_Title
            // 
            this.label5_Title.AutoSize = true;
            this.label5_Title.Location = new System.Drawing.Point(14, 181);
            this.label5_Title.Name = "label5_Title";
            this.label5_Title.Size = new System.Drawing.Size(27, 13);
            this.label5_Title.TabIndex = 11;
            this.label5_Title.Text = "Title";
            // 
            // Textbox_ContactType
            // 
            this.Textbox_ContactType.Location = new System.Drawing.Point(150, 204);
            this.Textbox_ContactType.Name = "Textbox_ContactType";
            this.Textbox_ContactType.Size = new System.Drawing.Size(100, 20);
            this.Textbox_ContactType.TabIndex = 10;
            // 
            // Textbox_Title
            // 
            this.Textbox_Title.Location = new System.Drawing.Point(150, 181);
            this.Textbox_Title.Name = "Textbox_Title";
            this.Textbox_Title.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Title.TabIndex = 9;
            // 
            // Textbox_PhoneNumber
            // 
            this.Textbox_PhoneNumber.Location = new System.Drawing.Point(150, 155);
            this.Textbox_PhoneNumber.Name = "Textbox_PhoneNumber";
            this.Textbox_PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.Textbox_PhoneNumber.TabIndex = 8;
            // 
            // Textbox_Email
            // 
            this.Textbox_Email.Location = new System.Drawing.Point(150, 129);
            this.Textbox_Email.Name = "Textbox_Email";
            this.Textbox_Email.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Email.TabIndex = 7;
            // 
            // Textbox_Lname
            // 
            this.Textbox_Lname.Location = new System.Drawing.Point(150, 103);
            this.Textbox_Lname.Name = "Textbox_Lname";
            this.Textbox_Lname.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Lname.TabIndex = 6;
            // 
            // Textbox_FName
            // 
            this.Textbox_FName.Location = new System.Drawing.Point(150, 77);
            this.Textbox_FName.Name = "Textbox_FName";
            this.Textbox_FName.Size = new System.Drawing.Size(100, 20);
            this.Textbox_FName.TabIndex = 5;
            // 
            // label4_PhoneNumber
            // 
            this.label4_PhoneNumber.AutoSize = true;
            this.label4_PhoneNumber.Location = new System.Drawing.Point(14, 155);
            this.label4_PhoneNumber.Name = "label4_PhoneNumber";
            this.label4_PhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.label4_PhoneNumber.TabIndex = 4;
            this.label4_PhoneNumber.Text = "Phone Number";
            // 
            // label3_email
            // 
            this.label3_email.AutoSize = true;
            this.label3_email.Location = new System.Drawing.Point(14, 127);
            this.label3_email.Name = "label3_email";
            this.label3_email.Size = new System.Drawing.Size(73, 13);
            this.label3_email.TabIndex = 3;
            this.label3_email.Text = "Email Address";
            // 
            // label2_LastName
            // 
            this.label2_LastName.AutoSize = true;
            this.label2_LastName.Location = new System.Drawing.Point(14, 101);
            this.label2_LastName.Name = "label2_LastName";
            this.label2_LastName.Size = new System.Drawing.Size(58, 13);
            this.label2_LastName.TabIndex = 2;
            this.label2_LastName.Text = "Last Name";
            // 
            // label1_FirstName
            // 
            this.label1_FirstName.AutoSize = true;
            this.label1_FirstName.Location = new System.Drawing.Point(14, 72);
            this.label1_FirstName.Name = "label1_FirstName";
            this.label1_FirstName.Size = new System.Drawing.Size(57, 13);
            this.label1_FirstName.TabIndex = 1;
            this.label1_FirstName.Text = "First Name";
            // 
            // Label_AddContact
            // 
            this.Label_AddContact.AutoSize = true;
            this.Label_AddContact.Location = new System.Drawing.Point(14, 26);
            this.Label_AddContact.Name = "Label_AddContact";
            this.Label_AddContact.Size = new System.Drawing.Size(66, 13);
            this.Label_AddContact.TabIndex = 0;
            this.Label_AddContact.Text = "Add Contact";
            // 
            // ContextMenuStrip_DeleteRow
            // 
            this.ContextMenuStrip_DeleteRow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem});
            this.ContextMenuStrip_DeleteRow.Name = "ContextMenuStrip_DeleteRow";
            this.ContextMenuStrip_DeleteRow.Size = new System.Drawing.Size(134, 26);
            this.ContextMenuStrip_DeleteRow.Click += new System.EventHandler(this.ContextMenuStrip_DeleteRow_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete Row";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 557);
            this.Controls.Add(this.Tab_Control);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactList_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.Tab_Control.ResumeLayout(false);
            this.Tab_ViewAllContact.ResumeLayout(false);
            this.Tab_Search.ResumeLayout(false);
            this.Tab_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchResults)).EndInit();
            this.Tab_AddContact.ResumeLayout(false);
            this.Tab_AddContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2_VISN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_Region)).EndInit();
            this.ContextMenuStrip_DeleteRow.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl Tab_Control;
        private System.Windows.Forms.TabPage Tab_ViewAllContact;
        private System.Windows.Forms.TabPage Tab_Search;
        private System.Windows.Forms.ComboBox Combobox_LastOrEmail;
        private System.Windows.Forms.TextBox Textbox_LastOrEmail;
        private System.Windows.Forms.Label Label_SearchBy;
        private System.Windows.Forms.Label Label_SearchContact;
        private System.Windows.Forms.Label Label_LastOrEmail;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DataGridView dataGridView_SearchResults;
        private System.Windows.Forms.Label Label_SearchResults;
        private System.Windows.Forms.Button Button_SaveSearchEdit;
        private System.Windows.Forms.TabPage Tab_AddContact;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6_ContactType;
        private System.Windows.Forms.Label label5_Title;
        private System.Windows.Forms.TextBox Textbox_ContactType;
        private System.Windows.Forms.TextBox Textbox_Title;
        private System.Windows.Forms.TextBox Textbox_PhoneNumber;
        private System.Windows.Forms.TextBox Textbox_Email;
        private System.Windows.Forms.TextBox Textbox_Lname;
        private System.Windows.Forms.TextBox Textbox_FName;
        private System.Windows.Forms.Label label4_PhoneNumber;
        private System.Windows.Forms.Label label3_email;
        private System.Windows.Forms.Label label2_LastName;
        private System.Windows.Forms.Label label1_FirstName;
        private System.Windows.Forms.Label Label_AddContact;
        private System.Windows.Forms.Label Label_EBulletin;
        private System.Windows.Forms.TextBox Textbox_EBulletin;
        private System.Windows.Forms.TextBox Textbox_AE;
        private System.Windows.Forms.TextBox Textbox_State;
        private System.Windows.Forms.TextBox Textbox_City;
        private System.Windows.Forms.TextBox Textbox_ContractCodingCompany;
        private System.Windows.Forms.TextBox Textbox_Company;
        private System.Windows.Forms.TextBox Textbox_Department;
        private System.Windows.Forms.Label Label_AE;
        private System.Windows.Forms.Label Label_State;
        private System.Windows.Forms.Label Label_City;
        private System.Windows.Forms.Label Label_ContractCodingCompany;
        private System.Windows.Forms.Label Label_Company;
        private System.Windows.Forms.Label Label_Department;
        private System.Windows.Forms.Label Label_VISN;
        private System.Windows.Forms.Label Label_Region;
        private System.Windows.Forms.NumericUpDown numericUpDown2_VISN;
        private System.Windows.Forms.NumericUpDown numericUpDown1_Region;
        private System.Windows.Forms.Button Button_AddContact;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_DeleteRow;
        private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
    }
}