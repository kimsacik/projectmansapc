using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CafeMgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (unameTb.Text == "" || passTb.Text == "")
            {
                MessageBox.Show("Enter a Username and Password");
            } else
            {
                try
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    //Display query
                    string Query = "select count(*) from admin where name_admin = '" + unameTb.Text + "' and password = '" + passTb.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MyConn2.Open();
                    //For offline connection we weill use  MySqlDataAdapter class.
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                    MyAdapter.SelectCommand = MyCommand2;
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);

                    if(dt.Rows[0][0].ToString() == "1")
                    {
                        UserOrder uorder = new UserOrder();
                        uorder.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }

                    MyConn2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }

}
