using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace PilotsPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int rotaid = 0;
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pilotsplus.accdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("select * from pilot", baglan);
            baglan.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            rotaid = Convert.ToInt32(dr["rota"].ToString());
            baglan.Close();
            OleDbCommand cmd2 = new OleDbCommand("select * from rota where id=" + rotaid + "", baglan);
            baglan.Open();
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                gif.ImageLocation = dr2["gif"].ToString();
                gif.SizeMode = PictureBoxSizeMode.StretchImage;
                for (int i = 1; i < 7; i++)
                {
                    if (dr2["sehir" + i].ToString() != "")
                    {
                        listBox1.Items.Add(dr2["sehir" + i].ToString());

                    }
                }
                if (listBox1.Items.Count == 6) button8.Text = listBox1.Items[5].ToString();
                else button8.Visible = false;
                

                label1.Text = dr2["rota"].ToString();

            }
            baglan.Close();
            button3.Text = listBox1.Items[0].ToString();
            button4.Text = listBox1.Items[1].ToString();
            button5.Text = listBox1.Items[2].ToString();
            button6.Text = listBox1.Items[3].ToString();
            button7.Text = listBox1.Items[4].ToString();
            listBox1.SelectedIndex = 0;
            pic1.ImageLocation = "images/pics/1/" + listBox1.SelectedItem.ToString() + "1.jpg";
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;

            pic2.ImageLocation = "images/pics/2/" + listBox1.SelectedItem.ToString() + "2.jpg";
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;

            pic3.ImageLocation = "images/pics/3/" + listBox1.SelectedItem.ToString() + "3.PNG";
            pic3.SizeMode = PictureBoxSizeMode.Normal;

            string text = System.IO.File.ReadAllText(@"txt/" + listBox1.SelectedItem.ToString() + ".txt", UTF8Encoding.Default);
            textBox1.Text = text;
            textBox1.Select(0, 0);
            button3.BackColor = Color.SkyBlue;
            timer1.Start();
        }
        int zaman = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            zaman++;

            pic1.ImageLocation = "images/pics/1/" + listBox1.SelectedItem.ToString() + "1.jpg";
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;

            pic2.ImageLocation = "images/pics/2/" + listBox1.SelectedItem.ToString() + "2.jpg";
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;

            pic3.ImageLocation = "images/pics/3/" + listBox1.SelectedItem.ToString() + "3.PNG";
            pic3.SizeMode = PictureBoxSizeMode.Normal;

            if (zaman == 1)
            {
                button3.BackColor = DefaultBackColor;
                button4.BackColor = Color.SkyBlue;
              
            }
            else if (zaman == 2)
            {
                button4.BackColor = DefaultBackColor;
                button5.BackColor = Color.SkyBlue;
            }
            else if (zaman == 3)
            {
                button5.BackColor = DefaultBackColor;
                button6.BackColor = Color.SkyBlue;
            }
            else if (zaman == 4)
            {
                button6.BackColor = DefaultBackColor;
                button7.BackColor = Color.SkyBlue;
            }
            else if (zaman == 5 && listBox1.Items.Count==6)
            {
                button7.BackColor = DefaultBackColor;
                button8.BackColor = Color.SkyBlue;
            }

            if (zaman == listBox1.Items.Count)
            {
                timer1.Stop();
                gif.Enabled = false;
                MessageBox.Show(label1.Text+" yolculuğu sona ermiştir, Hoşgeldiniz!");
            }
            else listBox1.SelectedIndex = zaman;

            string text = File.ReadAllText(@"txt/" + listBox1.SelectedItem.ToString() + ".txt", Encoding.Default);
            textBox1.Text = text;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pic1.ImageLocation = "images/pics/1/" + listBox1.SelectedItem.ToString() + "1.jpg";
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;

            pic2.ImageLocation = "images/pics/2/" + listBox1.SelectedItem.ToString() + "2.jpg";
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;

            pic3.ImageLocation = "images/pics/3/" + listBox1.SelectedItem.ToString() + "3.PNG";
            pic3.SizeMode = PictureBoxSizeMode.Normal;

            string text = System.IO.File.ReadAllText(@"txt/" + listBox1.SelectedItem.ToString() + ".txt",Encoding.Default);
            textBox1.Text = text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count==6) listBox1.SelectedIndex = 5;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Close();
            frm2.Show();
        }
    }
}
