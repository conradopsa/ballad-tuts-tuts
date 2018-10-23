using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;





namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            timer1.Interval = trackBar1.Value.GetHashCode();
            timer2.Interval = trackBar1.Value.GetHashCode();
            timer3.Interval = trackBar1.Value.GetHashCode();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                panel1.BackColor = Color.Red;
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                panel1.BackColor = Color.Blue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                panel1.BackColor = Color.Red;
            }
            if (radioButton2.Checked == true)
            {
                panel1.BackColor = Color.SkyBlue;
            }
            if (radioButton3.Checked == true)
            {
                panel1.BackColor = Color.Lime;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

           
        }


        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                panel1.BackColor = Color.Lime;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            timer2.Enabled = true;
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
            timer3.Enabled = true;
            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            timer1.Enabled = true;
            timer3.Enabled = false;
        }

        


              


        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Show();
            this.KeyPreview = true;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar2.Value.ToString();
            this.Opacity = trackBar2.Value * 0.01;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //F5 --> OCULTAR
            if (e.KeyCode == Keys.F5)
            {
                if (panel2.Visible == true)
                {
                    panel2.Visible = false;
                }

                    else if (panel2.Visible == false)
                    {
                        panel2.Visible = true;
                    }
            }


            //F11 --> TELA CHEIA
            if (e.KeyCode == Keys.F11)
            {
                if (WindowState == FormWindowState.Normal)
                { 
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
                this.Show();
                    }
            
            //SAIR TELA CHEIA
                else if (WindowState == FormWindowState.Maximized)
                {
                    if (WindowState == FormWindowState.Maximized)
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;
                    this.TopMost = false;
                    this.Show();
                }
            }
            //ESC SAIR TELA CHEIA
             if (e.KeyCode == Keys.Escape)
             {
                 if (WindowState == FormWindowState.Maximized)
                 {
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    this.WindowState = FormWindowState.Normal;
                    this.TopMost = false;
                    this.Show();
                 }
             }

            //ENTER
             if (e.KeyCode == Keys.Enter)
             {
                 timer1.Enabled = true;
             }
           
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }

            else if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
        }


    }
}
