using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcertTicket
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Are you sure you want to add a record?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result2 == DialogResult.Yes)
            {
                AddData();
                ClearData();
            }
        }

        private void ClearData()
        {
            txtCustomerName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
        }

        private void AddData()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["MyConnectString"].ToString();
            using (SqlConnection myConnection = new SqlConnection(strConnect))
            {
                myConnection.Open();
                string strCommand = "CustomerAdd";
                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("CustomerName", SqlDbType.NVarChar));
                myCommand.Parameters["CustomerName"].Value = this.txtCustomerName.Text;
                myCommand.Parameters.Add(new SqlParameter("PhoneNumber", SqlDbType.VarChar));
                myCommand.Parameters["PhoneNumber"].Value = this.txtPhoneNumber.Text;
                myCommand.Parameters.Add(new SqlParameter("CustomerID", SqlDbType.Int));
                myCommand.Parameters["CustomerID"].Direction = ParameterDirection.Output;
                int row_effectd = myCommand.ExecuteNonQuery();
                if (row_effectd > 0)
                {
                    MessageBox.Show("Added " + row_effectd.ToString() + " Customer with ID is " + myCommand.Parameters["CustomerID"].Value.ToString());
                }
            }

        }
    }
}
