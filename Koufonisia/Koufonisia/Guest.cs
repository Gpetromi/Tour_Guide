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
    public partial class Guest : Form
    {
        //Functions that takes a string as argument and uses it to redirect user to webpage.
        private void VisitLink(String s)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(s);
        }
        public Guest()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
        }
        //Kills the application.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Reference to creator.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Button click that makes pictureboxes visible and loads them with photos
        //located on bin file.
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label2.Text = "Ammos beach";
            label3.Text = "Fanos beach";
            label4.Text = "Hondros Kavos beach";
            try
            {
                pictureBox1.Load("am1.jpg");
                pictureBox2.Load("f1.jpg");
                pictureBox3.Load("xk1.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error load image.", "Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label2.Text = "Myrto Hotel";
            label3.Text = "Oceanides Residence";
            label4.Text = "Paradise Resort";
            try
            {
                pictureBox1.Load("mh1.jpg");
                pictureBox2.Load("oc1.jpg");
                pictureBox3.Load("p2.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load image.", "Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label2.Text = "To Kalofeggo(restaurant)";
            label3.Text = "To Sholio(bar)";
            label4.Text = "Sorokos bar";
            try
            {
                pictureBox1.Load("klfg.jpg");
                pictureBox2.Load("sc2.jpg");
                pictureBox3.Load("sr2.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load image.", "Error");
            }
        }
        //Returns to log-in Form.
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Close();
            fr1.Show();
        }
        //Button that shows linklabels.
        private void button7_Click(object sender, EventArgs e)
        {
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;

        }
        //linklabels that sends the webpage address as string in the VisitLink function.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("http://www.koufonisia.gr/?page_id=797&lang=en");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading page","Error");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("http://www.koufonisia.gr/?page_id=1108&lang=en");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading page", "Error");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("http://www.koufonisia.gr/?page_id=2058&lang=en");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading page", "Error");
            }
        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }
    }
}
