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
    public partial class DeleteRowConfirmation : Form
    {
        private Boolean areYouSureYouWantToDeleteThisRow;

        public Boolean AreYouSureYouWantToDeleteThisRow
        {
            get
            {
                return areYouSureYouWantToDeleteThisRow;
            }
        }
        public DeleteRowConfirmation()
        {
            InitializeComponent();
        }

        private void Button_ConfirmDelete_Click(object sender, EventArgs e)
        {
            areYouSureYouWantToDeleteThisRow = true;
            this.Close();
        }

        private void Button_RejectDelete_Click(object sender, EventArgs e)
        {
            areYouSureYouWantToDeleteThisRow = false;
            this.Close();
        }
    }
}
