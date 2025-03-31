using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography; 

namespace MotoShop
{
    public partial class UserLog : UserControl
    {
        private const string Uname = "Admin";
        private const string Password = "123";
        string role = "User";
        string iPathHide = Path.Combine(Application.StartupPath, "Images", "hide.png");
        string iPathshow = Path.Combine(Application.StartupPath, "Images", "show.png");


        public UserLog()
        {
            InitializeComponent();

        }


        private void btnNewUser_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.FindForm() as Form1;
            if (parentForm != null)
            {
                parentForm.LoadNewAcc();
            }
        }
        private bool VerifyPassword(string enteredPassword, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); // Convert byte to hex string
                }
                return builder.ToString() == storedHash; // Compare hashed values
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.FindForm() as Form1;
           
            // First, check if login is for Admin
            if (tbxUname.Text == Uname && tbxPass.Text == Password)
            {
               Dashboard admin = new Dashboard();
                admin.FormClosed += (s, args) => parentForm?.Close(); // Close Form1 when Dashboard closes
                admin.Show();
                parentForm?.Hide();
                return;

                /*Dash dash = new Dash();
                dash.FormClosed += (s, args) => parentForm?.Close();
                dash.Show();
                parentForm?.Hide();
                return;*/

            }
            using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb"))
            {
                myConn.Open();
                string query = "SELECT UserID, Password FROM Users WHERE UserName = @UserName";

                using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                {
                    cmd.Parameters.AddWithValue("@UserName", tbxUname.Text);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // If username exists in database
                    {
                        int userID = Convert.ToInt32(reader["UserID"]); // Fetch UserID
                        string storedHash = reader["Password"].ToString(); // Fetch hashed password

                        if (VerifyPassword(tbxPass.Text, storedHash)) // Compare input password with stored hash
                        {
                            Dashboard dashboard = new Dashboard(userID,role);
                            dashboard.FormClosed += (s, args) => parentForm?.Close(); 
                            dashboard.Show();
                            parentForm?.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            if (tbxPass.Text == "Password")
            {
                tbxPass.Text = "";
                tbxPass.UseSystemPasswordChar = true;
            }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPass.Text))
            {
                tbxPass.Text = "Password";
                tbxPass.UseSystemPasswordChar = false;
            }
        }

        private void tbxPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void btnVpass_Click(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !tbxPass.UseSystemPasswordChar;

            btnVpass.BackgroundImage = tbxPass.UseSystemPasswordChar ? Image.FromFile(iPathHide) : Image.FromFile(iPathshow);

        }

        private void tbxUname_Enter(object sender, EventArgs e)
        {
            if (tbxUname.Text == "Username")
            {
                tbxUname.Text = "";

            }
        }

        private void tbxUname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxUname.Text))
            {
                tbxUname.Text = "Username";

            }
        }

        private void tbxUname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}
