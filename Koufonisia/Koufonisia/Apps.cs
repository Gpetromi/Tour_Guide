using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koufonisia
{
    public partial class Apps : Form
    {
        public Apps()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }
        //Button for Creator's Info
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Kills the Application
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Starts the Timer
        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        //Every timer's Tick hides previous textbox and shows the next one,
        //thus a sslideshow has been created.
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            else if (pictureBox9.Visible)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
            }
            else if (pictureBox10.Visible)
            {
                pictureBox10.Visible = false;
                pictureBox1.Visible = true;
            }
        }
        //Stops the Timer
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        //On click Shows the selected date on the textbox
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString();
        }
        //Button click creates a text file, saving all textbox's Text usinf a function from 
        // WriteTxt class.There is a try-catch check in case something goes wrong.
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTxt wr = new WriteTxt();
                wr.WriteEvent(textBox1.Text);
                MessageBox.Show("Information saved!", "Message");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving.","Error");
            }
        }

        private void Apps_Load(object sender, EventArgs e)
        {

        }
    }
}
