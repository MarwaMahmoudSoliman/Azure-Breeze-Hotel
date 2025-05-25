using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp3.Context.WinFormsApp3.Context;

namespace Hotel_Manager
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
       
        
        private void signinButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            try
            {
                using (var context = new LOGIN_MANAGERContext())
                {
                   
                    if (context.FrontendUsers.Any(u => u.user_name == username && u.pass_word == password))
                    {
                        MessageBox.Show(this, "Frontend Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Frontend().Show();
                        return;
                    }

               
                    if (context.KitchenUsers.Any(u => u.user_name == username && u.pass_word == password))
                    {
                        MessageBox.Show(this, "Kitchen Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        new Kitchen().Show();
                        return;
                    }

                    
                    MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

 


        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }

        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
