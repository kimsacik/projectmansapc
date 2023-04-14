
namespace CafeMgmt
{
    partial class Adminform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userGv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteadmin = new System.Windows.Forms.Button();
            this.editadmin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addadmin = new System.Windows.Forms.Button();
            this.passwTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGv
            // 
            this.userGv.AllowUserToAddRows = false;
            this.userGv.AllowUserToDeleteRows = false;
            this.userGv.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.userGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGv.Location = new System.Drawing.Point(405, 100);
            this.userGv.Margin = new System.Windows.Forms.Padding(4);
            this.userGv.Name = "userGv";
            this.userGv.ReadOnly = true;
            this.userGv.RowHeadersWidth = 51;
            this.userGv.Size = new System.Drawing.Size(625, 425);
            this.userGv.TabIndex = 14;
            this.userGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGv_CellContentClick);
            this.userGv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userGv_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.deleteadmin);
            this.panel1.Controls.Add(this.editadmin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addadmin);
            this.panel1.Controls.Add(this.userGv);
            this.panel1.Controls.Add(this.passwTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.phoneTb);
            this.panel1.Controls.Add(this.usernameTb);
            this.panel1.Location = new System.Drawing.Point(193, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 617);
            this.panel1.TabIndex = 27;
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(164, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(18, 16);
            this.txtid.TabIndex = 26;
            this.txtid.Text = "Id";
            this.txtid.Visible = false;
            this.txtid.Click += new System.EventHandler(this.txtid_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(15, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Password";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(15, 196);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phone";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Username";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteadmin
            // 
            this.deleteadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteadmin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.deleteadmin.Location = new System.Drawing.Point(243, 316);
            this.deleteadmin.Margin = new System.Windows.Forms.Padding(4);
            this.deleteadmin.Name = "deleteadmin";
            this.deleteadmin.Size = new System.Drawing.Size(124, 46);
            this.deleteadmin.TabIndex = 22;
            this.deleteadmin.Text = "Delete";
            this.deleteadmin.UseVisualStyleBackColor = true;
            this.deleteadmin.Click += new System.EventHandler(this.button5_Click);
            // 
            // editadmin
            // 
            this.editadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editadmin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.editadmin.Location = new System.Drawing.Point(136, 316);
            this.editadmin.Margin = new System.Windows.Forms.Padding(4);
            this.editadmin.Name = "editadmin";
            this.editadmin.Size = new System.Drawing.Size(99, 46);
            this.editadmin.TabIndex = 21;
            this.editadmin.Text = "Edit";
            this.editadmin.UseVisualStyleBackColor = true;
            this.editadmin.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(615, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Admin Lists";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addadmin
            // 
            this.addadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addadmin.ForeColor = System.Drawing.Color.DarkMagenta;
            this.addadmin.Location = new System.Drawing.Point(31, 316);
            this.addadmin.Margin = new System.Windows.Forms.Padding(4);
            this.addadmin.Name = "addadmin";
            this.addadmin.Size = new System.Drawing.Size(97, 46);
            this.addadmin.TabIndex = 17;
            this.addadmin.Text = "Add";
            this.addadmin.UseVisualStyleBackColor = true;
            this.addadmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwTb
            // 
            this.passwTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwTb.Location = new System.Drawing.Point(149, 250);
            this.passwTb.Margin = new System.Windows.Forms.Padding(4);
            this.passwTb.Name = "passwTb";
            this.passwTb.Size = new System.Drawing.Size(241, 26);
            this.passwTb.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(331, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Manage Admin";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // phoneTb
            // 
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTb.Location = new System.Drawing.Point(149, 196);
            this.phoneTb.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(241, 26);
            this.phoneTb.TabIndex = 15;
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(149, 140);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(241, 26);
            this.usernameTb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1203, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(49, 630);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Logout";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button3.Location = new System.Drawing.Point(16, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 46);
            this.button3.TabIndex = 29;
            this.button3.Text = "Product";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button2.Location = new System.Drawing.Point(16, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 46);
            this.button2.TabIndex = 28;
            this.button2.Text = "Orders";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LavenderBlush;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button6.Location = new System.Drawing.Point(16, 170);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 46);
            this.button6.TabIndex = 31;
            this.button6.Text = "Order Detail";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Adminform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1260, 678);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Adminform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userGv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteadmin;
        private System.Windows.Forms.Button editadmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addadmin;
        private System.Windows.Forms.TextBox passwTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Button button6;
    }
}