using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterContactListApplication
{
    public partial class SaveForm : Form
    {
        private Boolean wantToSave;

        public Boolean WantToSave
        {
            get
            {
                return wantToSave;
            }
        }

        public SaveForm()
        {
            
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("../../Pictures/saveWarning.PNG");
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            wantToSave = true;
            this.Close();
        }

        private void Button_DontSave_Click(object sender, EventArgs e)
        {
            wantToSave = false;
            this.Close();
        }
    }
}
