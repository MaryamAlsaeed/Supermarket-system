using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket__project
{
    public partial class AddProduct : Form
    {
        public string ProductID { get; private set; }
        public string ProductName { get; private set; }
        public decimal ProductPrice { get; private set; }
        public int amount { get; set; }
        public Product SavedProduct { get; set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxName.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            decimal price;
            if (decimal.TryParse(textBoxPrice.Text, out price) == false)
            {
                MessageBox.Show("Price must be a valid number without letters.");
                return;
            }

            SavedProduct = new Product
            {
                ID = textBoxID.Text,
                Name = textBoxName.Text,
                Price = decimal.Parse(textBoxPrice.Text)
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
