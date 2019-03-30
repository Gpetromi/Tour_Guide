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
    public partial class Bar : Form
    {
        //Function to connect to a webpage via linkLabel.
        private void VisitLink(String s)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(s);
        }
        public Bar()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;

        }

        private void Bar_Load(object sender, EventArgs e)
        {

        }
        //If radiobutton 1,2 or 3 is checked,pictureboxes show up and load in real time photos
        //from bin file.
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            try
            {
                pictureBox1.Load("sr1.jpg");
                pictureBox2.Load("sr2.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading the pictures.");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            try
            {
                pictureBox1.Load("ml1.jpg");
                pictureBox2.Load("ml2.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the pictures.");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            try
            {
                pictureBox1.Load("sc1.jpg");
                pictureBox2.Load("sc2.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading the pictures.");
            }
        }
        //Reference to designer.
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Button that kills the application.
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LinkLabel that uses the function above, sending the connection link as a string.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("https://www.tripadvisor.com.gr/Attractions-g657463-Activities-c20-Koufonissi_Cyclades_South_Aegean.html");
            }
            catch
            {
                MessageBox.Show("Error loading the website");
            }
        }
    }
}
