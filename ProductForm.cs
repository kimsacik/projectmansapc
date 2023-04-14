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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminform userf = new Adminform();
            userf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productTb.Text == "" || priceTb.Text == "" || stockTb.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "insert into product (name_product, price, stock) values('" + productTb.Text + "','" + priceTb.Text + "','" + stockTb.Text + "');";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("product Successfully Created");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM product", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    productGv.DataSource = dt;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void reset()
        {
            productTb.Text = "";
            priceTb.Text = "";
            stockTb.Text = "";
            idproduct.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idproduct.Text = productGv.Rows[e.RowIndex].Cells[0].Value.ToString();
            productTb.Text = productGv.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceTb.Text = productGv.Rows[e.RowIndex].Cells[2].Value.ToString();
            stockTb.Text = productGv.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;user id=root;database=mansa_coffe;";
                //Display query
                string Query = "select id_product, name_product, price, stock from product;";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MyConn2.Open();
                //For offline connection we weill use  MySqlDataAdapter class.
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dt = new DataTable();
                MyAdapter.Fill(dt);
                productGv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (productTb.Text == "" || priceTb.Text == "" || stockTb.Text == "")
            {
                MessageBox.Show("Fill All the Data");
            }
            else
            {
                try
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "UPDATE `product` SET `name_product`= '" + productTb.Text + "',`price`='" + priceTb.Text + "',`stock`='" + stockTb.Text + "' WHERE id_product = '" + idproduct.Text + "' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("User Successfully Updated");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM product", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    productGv.DataSource = dt;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Do you want to remove this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string MyConnection2 = "Server=localhost;Port=3306;UID=root;PWD=;Database=mansa_coffe";
                    string Query = "DELETE FROM `product` WHERE id_product = '" + idproduct.Text + "' ;";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                    MyConn2.Open();
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;

                    MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
                    MessageBox.Show("product Successfully Deleted");

                    MyReader2.Close(); // Close the DataReader after reading the data
                    reset();
                    // Fetch data from t_user table and display in userGv DataGridView
                    MySqlDataAdapter MyAdapter = new MySqlDataAdapter("SELECT * FROM product", MyConn2);
                    DataTable dt = new DataTable();
                    MyAdapter.Fill(dt);
                    productGv.DataSource = dt;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void priceTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder us = new UserOrder();
            us.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDetails od = new OrderDetails();
            od.Show();
        }

        private void idproduct_Click(object sender, EventArgs e)
        {

        }
    }
}
