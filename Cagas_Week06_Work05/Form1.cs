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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelShop_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin"
                && txtpassword.Text == "1234")
            {
                MessageBox.Show("Login successful!");
                var inventoryForm =
                    new frmInventory();
                inventoryForm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password!",
                    "Invalid");

                txtpassword.Clear();
                txtusername.Focus();
            }
        }
    }
}
