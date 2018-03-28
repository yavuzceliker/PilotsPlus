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
namespace PilotsPlus
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pilotsplus.accdb");
        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex != 0)
            {

                OleDbCommand cmd = new OleDbCommand("update pilot set rota=@rota ", baglan);
                OleDbCommand cmd2 = new OleDbCommand("select * from rota where rota='"+comboBox1.Text+"'",baglan);
                baglan.Open();
                OleDbDataReader dr = cmd2.ExecuteReader();
                dr.Read();
                cmd.Parameters.AddWithValue("@rota",dr[0].ToString());
                baglan.Close();
                try
                {
                    baglan.Open();
                    cmd.ExecuteNonQuery();
                    baglan.Close();
                    
                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.Show();
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Hata Oluştu " + hata.Message);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            OleDbCommand cmd = new OleDbCommand("select * from rota", baglan);
            baglan.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["rota"]);
            }
            baglan.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
