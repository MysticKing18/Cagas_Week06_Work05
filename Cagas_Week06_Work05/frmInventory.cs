using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cagas_Week06_Work05
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        private void showPage (UserControl page)
        {
            panelContainer.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(page);
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPage(new ucProductListing
                 ());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
