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
    public partial class Drinks : Form
    {
        public Drinks()  {InitializeComponent(); }
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

                SharedData.drinkProducts[SharedData.drinkCount] = saved;
                SharedData.drinkCount++;

                AddProductPanel(saved, SharedData.drinkCount - 1);
            }
            else
            {
                MessageBox.Show("No product saved yet!");
            }
            this.Show();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Product juice = new Product();
            juice.Name = "juice";
            juice.Price = 10;
            juice.Amount = 1;

            SharedData.drinkProducts[SharedData.drinkCount] = juice;
            SharedData.drinkCount++;
            SharedData.addedProducts[SharedData.productCount] = juice;
            SharedData.productCount++;
        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SharedData.drinkCount; i++)
            {
           
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Product cola = new Product();
            cola.Name = "cola";
            cola.Price = 20;
            cola.Amount = 1;

            SharedData.drinkProducts[SharedData.drinkCount] = cola;
            SharedData.drinkCount++;
            SharedData.addedProducts[SharedData.productCount] = cola;
            SharedData.productCount++;
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            Product water = new Product();
            water.Name = "Water";
            water.Price = 7;
            water.Amount = 1;

            SharedData.drinkProducts[SharedData.drinkCount] = water;
            SharedData.drinkCount++;
            SharedData.addedProducts[SharedData.productCount] = water;
            SharedData.productCount++;
        }
    }
 }
    

