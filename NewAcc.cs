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
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Collections;

namespace MotoShop
{
    public partial class NewAcc : UserControl
    {
        string iPathHide = Path.Combine(Application.StartupPath, "Images", "hide.png");
        string iPathshow = Path.Combine(Application.StartupPath, "Images", "show.png");
        public NewAcc()
        {
            InitializeComponent();
            tbxPass.UseSystemPasswordChar = true;
            tbxCpass.UseSystemPasswordChar = true;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Check if passwords match
            if (tbxPass.Text != tbxCpass.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop execution if passwords do not match
            }

            string hashedPassword = HashPassword(tbxPass.Text);

            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(tbxName.Text) ||
                string.IsNullOrWhiteSpace(tbxAdd.Text) ||
                string.IsNullOrWhiteSpace(tbxNum.Text) ||
                string.IsNullOrWhiteSpace(tbxEmail.Text) ||
                string.IsNullOrWhiteSpace(tbxUname.Text) ||
                string.IsNullOrWhiteSpace(tbxPass.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string queryCheck = "SELECT COUNT(*) FROM Users WHERE UserName = @UserName";
            string queryInsert = "INSERT INTO Users ([Name], [Address], [Number], [Email], [UserName], [Password]) VALUES (@Name, @Address, @Number, @Email, @UserName, @Password)";

            try
            {
                using (OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Visitor\\OneDrive - Cebu Institute of Technology University\\Cpe262\\MotoShop\\MotoShop.accdb"))
                {
                    myConn.Open();

                    // Check if the username already exists
                    using (OleDbCommand checkCmd = new OleDbCommand(queryCheck, myConn))
                    {
                        checkCmd.Parameters.AddWithValue("@UserName", tbxUname.Text);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert new user
                    using (OleDbCommand insertCmd = new OleDbCommand(queryInsert, myConn))
                    {
                        insertCmd.Parameters.AddWithValue("@Name", tbxName.Text);
                        insertCmd.Parameters.AddWithValue("@Address", tbxAdd.Text);
                        insertCmd.Parameters.AddWithValue("@Number", tbxNum.Text);
                        insertCmd.Parameters.AddWithValue("@Email", tbxEmail.Text);
                        insertCmd.Parameters.AddWithValue("@UserName", tbxUname.Text);
                        insertCmd.Parameters.AddWithValue("@Password", hashedPassword);

                        insertCmd.ExecuteNonQuery();
                    }
                }


                MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 parentForm = this.FindForm() as Form1;
                if (parentForm != null)
                {
                    parentForm.LoadUserControl(); // Create this method in Form1 to switch back
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            tbxPass.UseSystemPasswordChar = !tbxPass.UseSystemPasswordChar;

            btnPass.BackgroundImage = tbxPass.UseSystemPasswordChar ? Image.FromFile(iPathHide) : Image.FromFile(iPathshow);
        }

        private void btnConpass_Click(object sender, EventArgs e)
        {
            tbxCpass.UseSystemPasswordChar = !tbxCpass.UseSystemPasswordChar;
            btnConpass.BackgroundImage = tbxPass.UseSystemPasswordChar ? Image.FromFile(iPathHide) : Image.FromFile(iPathshow);
        }

        private void tbxPass_Enter(object sender, EventArgs e)
        {
            if (btnPass.BackgroundImage == Image.FromFile(iPathHide))
            {
                tbxPass.UseSystemPasswordChar = true;
            }

        }

        private void tbxCpass_Enter(object sender, EventArgs e)
        {
            if (btnConpass.BackgroundImage == Image.FromFile(iPathHide))
            {
                tbxCpass.UseSystemPasswordChar = true;
            }
        }

        private void tbxCpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxCpass.Text))
            {
                tbxPass.UseSystemPasswordChar = false;
            }
        }

        private void tbxPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxPass.Text))
            {
                tbxPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.FindForm() as Form1;
            if (parentForm != null)
            {
                parentForm.LoadUserControl();
            }
            this.Hide();
        }
    }
}
