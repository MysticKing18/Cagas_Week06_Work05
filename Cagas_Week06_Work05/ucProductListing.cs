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
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }
        string[] units = {"Piece", "Box", "Kilogram", "Liter", "cm", "ft", "g", "lb", "in", "L", "m", "oz" };

        List<string> shoppingList = new List<string>();

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            comboBoxAmount.Items.AddRange(units);
            comboBoxAmount.SelectedIndex = 0;

            updateGUI();
        }
        private void updateGUI()
        {
            lbxItems.DataSource = null;
            lbxItems.DataSource = shoppingList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtdescription.Text.Trim();
            string unit = comboBoxAmount.SelectedItem?.ToString(); 

            if (!double.TryParse(txtamount.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                txtamount.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item))
            {
                string row = $"{item}\t\t {amount} {unit}";
                shoppingList.Add(row);
                updateGUI();

                MessageBox.Show("Item Added");
                txtamount.Clear();
                txtdescription.Clear();
                comboBoxAmount.SelectedIndex = 0;
                txtdescription.Focus();
            }
            else
            {
                MessageBox.Show("Please enter an item description");
                txtdescription.Focus ();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = lbxItems.SelectedIndex ;

            if (index != -1)
            {
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to" +
                    "delete?", "Delete Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                MessageBox.Show(shoppingList[index] + "deleted");

                shoppingList.RemoveAt(index);
                updateGUI();
            }
            else
            {
                lblprompt.Text = "Please select an item to delete.";
                lblprompt.Visible = true;
            }
        }
    }
}
