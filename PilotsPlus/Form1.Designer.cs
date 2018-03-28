namespace PilotsPlus
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gif = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gif.Image = ((System.Drawing.Image)(resources.GetObject("gif.Image")));
            this.gif.Location = new System.Drawing.Point(12, 69);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(797, 409);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 0;
            this.gif.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(-386, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 410);
            this.listBox1.TabIndex = 1;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Location = new System.Drawing.Point(12, 483);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(485, 273);
            this.pic1.TabIndex = 2;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Location = new System.Drawing.Point(503, 484);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(459, 273);
            this.pic2.TabIndex = 2;
            this.pic2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(986, 484);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(368, 272);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(550, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(170, 50);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-250, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(815, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 63);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(815, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 63);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.Maroon;
            this.button5.Location = new System.Drawing.Point(815, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 63);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.Location = new System.Drawing.Point(815, 276);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 63);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.Maroon;
            this.button7.Location = new System.Drawing.Point(815, 345);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 63);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.Maroon;
            this.button8.Location = new System.Drawing.Point(815, 414);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 63);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(0, 1);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(338, 637);
            this.pic3.TabIndex = 10;
            this.pic3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pic3);
            this.panel1.Location = new System.Drawing.Point(986, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 411);
            this.panel1.TabIndex = 11;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(1252, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 32);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gif);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKapat;
    }
}

