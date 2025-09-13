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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }
        private void UpdateTotalPrice()
        {
            decimal total = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string priceText = dataGridView1.Rows[i].Cells[1].Value + "";
                string amountText = dataGridView1.Rows[i].Cells[2].Value + "";

                if (priceText != "" && amountText != "")
                {
                    decimal price = Convert.ToDecimal(priceText);

                    int amount = Convert.ToInt32(amountText);

                    total += price * amount;

                    SharedData.addedProducts[i].Amount = amount;
                }
            }
            lblTotal.Text = "Total: " + total.ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        private void List_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Amount", "Amount");

            for (int i = 0; i < SharedData.productCount; i++)
            {
                Product p = SharedData.addedProducts[i];
                dataGridView1.Rows.Add(p.Name, p.Price, p.Amount); 
            }

            UpdateTotalPrice();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
