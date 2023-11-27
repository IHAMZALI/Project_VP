using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Data Source=DESKTOP-S9O081E\\SQLEXPRESS;Initial Catalog=login;Integrated Security=True;Trust Server Certificate=True");
         SqlCommand cmd = new SqlCommand("select * from login where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'",con);
         SqlDataAdapter sda = new SqlDataAdapter(cmd);
         DataTable dt = new DataTable();
         sda.Fill(dt);
         string cmbItemValue = comboBox1.SelectedItem.ToString();

         if(dt.Rows.Count > 0)
            //{
                //for(int i = 0; i < dt.Rows.Count; i++)
                //{
                //    if ( dt.Rows[i]["usertype"].ToString() = cmbItemValue )
                    {
                int i = 0;
                MessageBox.Show("LOGIN SUCCESFULL AS" + dt.Rows[i][2]) ;
                    }
              //  }
            //}
         else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
