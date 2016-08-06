using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MasterContactListApplication
{
    public partial class ListForm : Form
    {
        DataSet ds = new DataSet();
        DataTable searchDt = new DataTable();
        string constring = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        SqlDataAdapter da;

        Boolean searchDataGridHasChanged;
        string searchQuery;
      
        public ListForm()
        {

            InitializeComponent();
            da = new SqlDataAdapter("Select * from Contact_List", constring);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
     
            da.Fill(ds, "Contact_List");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Contact_List";

            searchDataGridHasChanged = false;
            dataGridView_SearchResults.AllowUserToAddRows = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    var cm = dataGridView1.BindingContext[ds, "Contact_List"];
                    cm.EndCurrentEdit();
                    con.Open();
                    da.Update(ds, "Contact_List");
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Combobox_LastOrEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_LastOrEmail.SelectedIndex == 0)
            {
                Label_LastOrEmail.Text = Combobox_LastOrEmail.Text + ": ";
                Label_LastOrEmail.Visible = true;
                Textbox_LastOrEmail.Visible = true;
                Button_Search.Visible = true;
                
            }
            else if(Combobox_LastOrEmail.SelectedIndex == 1)
            {
                Label_LastOrEmail.Text = Combobox_LastOrEmail.Text + ": ";
                Label_LastOrEmail.Visible = true;
                Textbox_LastOrEmail.Visible = true;
                Button_Search.Visible = true;
            }
            else
            {
                MessageBox.Show("Whoops");
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {

            searchDt.Clear();

            if (Textbox_LastOrEmail.TextLength > 0)
            {
                Label_LastOrEmail.ForeColor = Color.Black;

                if (Combobox_LastOrEmail.SelectedIndex == 0)
                {
                    searchQuery = "SELECT * FROM Contact_List WHERE Last_Name = '" + Textbox_LastOrEmail.Text + "'";

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        da = new SqlDataAdapter(searchQuery, con);
                        da.Fill(searchDt);

                        if (searchDt.Rows.Count > 0)
                        {
                            dataGridView_SearchResults.DataSource = searchDt;
                            dataGridView_SearchResults.Visible = true;

                            searchDataGridHasChanged = false;

                            Label_SearchResults.Text = searchDt.Rows.Count.ToString() + " Result(s) found with Last Name: " + Textbox_LastOrEmail.Text;
                            Label_SearchResults.ForeColor = Color.Black;
                            Label_SearchResults.Visible = true;

                            Button_SaveSearchEdit.BackColor = Color.Transparent;
                            Button_SaveSearchEdit.Visible = true;

                        }
                        else
                        {
                            Label_SearchResults.Text = searchDt.Rows.Count.ToString() + " Result(s) found with Last Name: " + Textbox_LastOrEmail.Text;
                            Label_SearchResults.ForeColor = Color.Red;
                            Label_SearchResults.Visible = true;
                            dataGridView_SearchResults.Visible = false;
                            Button_SaveSearchEdit.Visible = false;

                        }
                    }
                }
                else if (Combobox_LastOrEmail.SelectedIndex == 1)
                {
                    searchQuery = "SELECT * FROM Contact_List WHERE email_address = '" + Textbox_LastOrEmail.Text + "'";

                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        da = new SqlDataAdapter(searchQuery, con);
                        da.Fill(searchDt);

                        if (searchDt.Rows.Count > 0)
                        {
                            dataGridView_SearchResults.DataSource = searchDt;
                            dataGridView_SearchResults.Visible = true;

                            searchDataGridHasChanged = false;

                            Label_SearchResults.Text = searchDt.Rows.Count.ToString() + " Result(s) found with Email Address: " + Textbox_LastOrEmail.Text;
                            Label_SearchResults.ForeColor = Color.Black;
                            Label_SearchResults.Visible = true;

                            Button_SaveSearchEdit.BackColor = Color.Transparent;
                            Button_SaveSearchEdit.Visible = true;
                        }
                        else
                        {
                            Label_SearchResults.Text = searchDt.Rows.Count.ToString() + " Result(s) found with Email Address: " + Textbox_LastOrEmail.Text;
                            Label_SearchResults.ForeColor = Color.Red;
                            Label_SearchResults.Visible = true;
                            dataGridView_SearchResults.Visible = false;

                            Button_SaveSearchEdit.Visible = false;
                        }
                    }
                }
            }
            else
            {
                Label_LastOrEmail.ForeColor = Color.Red;
            }
            
        }

        private void Button_SaveSearchEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constring))
                {
                    SqlDataAdapter searchDa = new SqlDataAdapter(searchQuery,con);
                    SqlCommandBuilder cmd = new SqlCommandBuilder(searchDa);
                    var cm = dataGridView_SearchResults.BindingContext[searchDt];
                    cm.EndCurrentEdit();

         
                    con.Open();
                    searchDa.Update(searchDt);
                    con.Close();

                    searchDataGridHasChanged = false;

                    MessageBox.Show("Upates Saved Succesfully");
                    Button_SaveSearchEdit.BackColor = Color.Transparent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_SearchResults_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            searchDataGridHasChanged = true;
            Button_SaveSearchEdit.BackColor = Color.Red;
        }

        private void dataGridView_SearchResults_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            searchDataGridHasChanged = true;
            Button_SaveSearchEdit.BackColor = Color.Red;
        }

        private void ListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView_SearchResults.EndEdit();

            if(searchDataGridHasChanged == true)
            {
              //  MessageBox.Show("Do you want to save your changes? If you click ");
                SaveForm saveForm = new SaveForm();
                saveForm.ShowDialog();

                if(saveForm.WantToSave == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            SqlDataAdapter searchDa = new SqlDataAdapter(searchQuery, con);
                            SqlCommandBuilder cmd = new SqlCommandBuilder(searchDa);
                            var cm = dataGridView_SearchResults.BindingContext[searchDt];
                            cm.EndCurrentEdit();


                            con.Open();
                            searchDa.Update(searchDt);
                            con.Close();

                            searchDataGridHasChanged = false;

                            MessageBox.Show("Upates Saved Succesfully");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            


        }
    }
}
