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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Meat_Click(object sender, EventArgs e)
        {
            Meat meat = new Meat();
            meat.Show();
            this.Hide();
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            Drinks Drinks = new Drinks();
            Drinks.Show();
            this.Hide();
        }

        private void list_Click(object sender, EventArgs e)
        {
            List List = new List();
            List.Show();
            this.Hide();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
