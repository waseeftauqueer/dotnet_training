using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Day12WindowsFormsApp
{
   
    public partial class Form1 : Form
    {

        public delegate void LoginSuccessEventHandler(object sender, LoginEventArgs e);
        public event LoginSuccessEventHandler LoginSuccess;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (userName == "admin" && password == "1234")
            {
                MessageBox.Show("Login Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginSuccess?.Invoke(this, new LoginEventArgs(userName));

                // Close the form (optional)
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    public class LoginEventArgs : EventArgs
    {
        public string Username { get; set; }
        public LoginEventArgs(string username)
        {
            Username = username;
        }
    }
}
