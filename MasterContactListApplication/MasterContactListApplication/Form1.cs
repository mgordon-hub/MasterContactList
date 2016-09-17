using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MasterContactListApplication
{
    public partial class Form1 : Form
    {
        MasterContactListEntities db = new MasterContactListEntities();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            var user = db.Users.Where(x => x.Username == Textbox_Username.Text).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Invalid Username or Password");
            }
            else
            {


                if (ValidateSHA1HashData(Textbox_Password.Text.ToString(), user.Password) == true)
                {

                    this.Hide();
                    ListForm lf = new ListForm();
                    lf.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }

        private string GetSHA1HashData(string data)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            return returnValue.ToString();
        }

        private bool ValidateSHA1HashData(string inputData, string storedHashData)
        {
            string getHashInputData = GetSHA1HashData(inputData);

            if(string.Compare(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
