using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertTicket
{
    public partial class frmLogin : Form
    {
        private int role;
        private int employeeID;
        private int customerID;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassWord.Text) && !string.IsNullOrEmpty(txtUserName.Text))
            {
                string hashedText = CalculateSHA256(txtPassWord.Text);
                try
                {
                    string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
                    using (SqlConnection myConnection = new SqlConnection(strConnect))
                    {
                        myConnection.Open();
                        string strCommand = "Select * from Account where UserName = '" + txtUserName.Text + "'" + "and HashedPassword = '" + hashedText + "'";
                        SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                        SqlDataAdapter da = new SqlDataAdapter(myCommand);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Account");
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            if (ds.Tables["Account"].Rows[0]["Role"].ToString() == "Admin")
                            {
                                this.role = 1;
                                this.employeeID = Int32.Parse(ds.Tables["Account"].Rows[0]["EmployeeID"].ToString());
                            }
                            else if (ds.Tables["Account"].Rows[0]["Role"].ToString() == "Customer")
                            {
                                this.role = 2;
                                this.customerID = Convert.ToInt32(ds.Tables["Account"].Rows[0]["CustomerID"].ToString());
                            }
                            MessageBox.Show("Login successful!");
                            this.Hide();
                            if (this.role == 1)
                            {
                                frmMain frmMain = new frmMain( employeeID);
                                frmMain.ShowDialog();
                            }
                            else
                            {
/*                                frmBuyOnline frmBuyOnline = new frmBuyOnline(customerID);
                                frmBuyOnline.ShowDialog();
*/                            }
                        }
                        else
                        {
                            MessageBox.Show("login failed!");
                        }
                        myConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred! " + ex.Message);
                }

            }
        }

            private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            lblUserName.Visible = false;
        }

        private void txtPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            lblPassWord.Visible = false;
        }

        private void lblUserName_MouseClick(object sender, MouseEventArgs e)
        {
            lblUserName.Visible = false;
            txtUserName.Focus();
        }

        private void lblPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            lblPassWord.Visible = false;
            txtPassWord.Focus();
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            lblPassWord.Visible = false;
        }
        private string CalculateSHA256(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

    }
}
