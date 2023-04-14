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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm item = new ProductForm();
            item.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameTb.Text == "" || phoneTb.Text == "" || passwTb.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "insert into admin (name_admin, phone, password) values('" + usernameTb.Text + "','" + phoneTb.Text + "','" + passwTb.Text + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("User Successfully Created");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM admin", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    userGv.DataSource = dt;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void reset ()
        {
            usernameTb.Text = "";
            passwTb.Text = "";
            phoneTb.Text = "";
            txtid.Text = "";
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                //Display query
                string Query = "select * from admin;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MyConn2.Open();
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                userGv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = userGv.Rows[e.RowIndex].Cells[0].Value.ToString();
            usernameTb.Text = userGv.Rows[e.RowIndex].Cells[1].Value.ToString();
            phoneTb.Text = userGv.Rows[e.RowIndex].Cells[2].Value.ToString();
            passwTb.Text = userGv.Rows[e.RowIndex].Cells[3].Value.ToString();
          

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (usernameTb.Text == "" || phoneTb.Text == "" || passwTb.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "UPDATE `admin` SET `name_admin`= '"+usernameTb.Text +"',`phone`='"+phoneTb.Text +"',`password`='"+passwTb.Text +"' WHERE id = '"+txtid.Text +"' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("User Successfully Updated");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM admin", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    userGv.DataSource = dt;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
    }

        private void userGv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to remove this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "DELETE FROM `admin` WHERE id_admin = '" + txtid.Text + "' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("User Successfully Deleted");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM admin", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    userGv.DataSource = dt;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails od = new OrderDetails();
            od.Show();
        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }
    }
    }
