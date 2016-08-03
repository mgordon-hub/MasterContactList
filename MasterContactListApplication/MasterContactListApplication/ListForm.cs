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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.TestTable' table. You can move, or remove it, as needed.
            this.testTableTableAdapter.Fill(this.testDataSet.TestTable);

        }
    }
}
