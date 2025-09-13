using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket__project
{
    public partial class Meat : Form
    {
        public Meat()
        { InitializeComponent(); }
        private void AddProductPanel(Product saved, int index)
        {
            Panel panel = new Panel
            {
                Size = new Size(161, 200),
                Location = new Point(700, index * 220 + 200),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblName = new Label
            {
                Text = "Name:",
                Top = 20,
                Left = 10,
                AutoSize = true
            };

            TextBox txtName = new TextBox
            {
                Text = saved?.Name ?? "No Name",
                Top = 20,
                Left = 90,
                Width = 100
            };

            Label lblPrice = new Label
            {
                Text = "Price:",
                Top = 70,
                Left = 10,
                AutoSize = true
            };

            TextBox txtPrice = new TextBox
            {
                Text = saved?.Price.ToString() ?? "No Price",
                Top = 70,
                Left = 90,
                Width = 100
            };

            Button btnAdd = new Button
            {
                Text = "Add",
                Width = 100,
                Height = 30,
                Top = 130,
                Left = 30
            };
            btnAdd.Click += (s, args) =>
            {
                Product p = new Product();
                p.Name = txtName.Text;
                p.Price = int.Parse(txtPrice.Text);
                p.Amount = 1;
                SharedData.addedProducts[SharedData.productCount] = p;
                SharedData.productCount++;

             
            };
            panel.Controls.Add(lblName);
            panel.Controls.Add(txtName);
            panel.Controls.Add(lblPrice);
            panel.Controls.Add(txtPrice);
            panel.Controls.Add(btnAdd);
            this.Controls.Add(panel);
        }
        private void AddProduct1_Click(object sender, EventArgs e)
        {
            AddProduct AddProducts = new AddProduct();

            this.Hide();
            DialogResult result = AddProducts.ShowDialog();

            if (result == DialogResult.OK && AddProducts.SavedProduct != null)
            {
                Product saved = AddProducts.SavedProduct;

                SharedData.meatProducts[SharedData.meatCount] = saved;
                SharedData.meatCount++;
                AddProductPanel(saved, SharedData.meatCount - 1);
            }
            else
            {
                MessageBox.Show("No product saved yet!");
            }
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        private void GroundBeef_Click(object sender, EventArgs e)
        {

        }

        private void Add4_Click(object sender, EventArgs e)
        {
            Product GroundBeef = new Product();
            GroundBeef.Name = "GroundBeef";
            GroundBeef.Price = 450;
            GroundBeef.Amount = 1;

            SharedData.meatProducts[SharedData.meatCount] = GroundBeef;
            SharedData.meatCount++;
            SharedData.addedProducts[SharedData.productCount] = GroundBeef;
            SharedData.productCount++;

        }

        private void Add5_Click(object sender, EventArgs e)
        {
            Product ChickenBreast = new Product();
            ChickenBreast.Name = "ChickenBreast";
            ChickenBreast.Price = 270;
            ChickenBreast.Amount = 1;

            SharedData.meatProducts[SharedData.meatCount] = ChickenBreast;
            SharedData.meatCount++;
            SharedData.addedProducts[SharedData.productCount] = ChickenBreast;
            SharedData.productCount++;

        }

        private void Add6_Click(object sender, EventArgs e)
        {
            Product salmon = new Product();
            salmon.Name = "salmon";
            salmon.Price = 580;
            salmon.Amount = 1;

            SharedData.meatProducts[SharedData.meatCount] = salmon;
            SharedData.meatCount++;
            SharedData.addedProducts[SharedData.productCount] = salmon;
            SharedData.productCount++;

        }

        private void Meat_Load(object sender, EventArgs e)
        {
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
