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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            string[] usernames = { "mariam", "faris", "Abdullah" };
            string[] passwords = { "123", "56mo", "momo" };

            string enteredUsername = Name1.Text.Trim();
            string enteredPassword = Password.Text;


            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == enteredUsername && passwords[i] == enteredPassword)
                {
                    MessageBox.Show("Login successful!");
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Invalid username or password.");

        }
    

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
