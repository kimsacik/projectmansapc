using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMgmt
{
    public partial class OrderDetails: Form
    {
        public OrderDetails()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editadmin_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm item = new ProductForm();
            item.Show();
        }

        private void addadmin_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uorder = new UserOrder();
            uorder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminform uf = new Adminform();
            uf.Show();
        }
    }
}
