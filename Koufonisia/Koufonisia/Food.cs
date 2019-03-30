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
    public partial class Food : Form
    {
        private void VisitLink(String s)
        {
           // linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(s);
        }
        public Food()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
            radioButton4.BackColor = Color.Transparent;
        //    linkLabel1.BackColor = Color.Transparent;
      //      label2.BackColor = Color.Transparent;
        }

        private void Food_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            try
            {
                pictureBox1.Load("kapnik.jpg");
                pictureBox2.Load("kapnikp.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading images.");
            }
            textBox1.Text = "Simple family tavern with very good traditional cooking. It is at the edge of Chora " +
                        "and serves fresh fish and seafood that arrive at your table and garnish with sea. Taste delicious homemade pies, garlic" +
                        "and lobster. If you are lucky you will also find cod with sparrows.";
            linkLabel1.Visible = true;
            linkLabel1.Text = "Kapetan Nikolas";
 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            try
            {
                pictureBox1.Load("klfg.jpg");
                pictureBox2.Load("klfgp.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading images");
            }
            textBox1.Text = "Where the waves pop out in Pori, Alexander, Natasha and George serve deliciously cooked foods. That's why they have so many customers, " +
                    "including Italians who are crazy for their pasta, but also for the local goat in the oven that melts in the mouth." +
                    "Starring banoffee is a must.";
            linkLabel1.Visible = true;
            linkLabel1.Text = "Kalofeggo";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            try
            {
                pictureBox1.Load("nr1.jpg");
                pictureBox2.Load("kapnikp.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading images.");
            }
            textBox1.Text = "High up, having your entire island on your feet, you will enjoy sargs, black and white, and lobsters and octopuses. The 'fisherman's spaghetti' " +
                 "is a must, like the mussel, the fish and the seafood are coming straight from the captain of Captain George's fishing boat. Don't forget to taste a sweet"+
                 "from  chocolate that they call 'temptation'.";
            linkLabel1.Visible = true;
            linkLabel1.Text = "Neo Remezzo";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            try
            {
                pictureBox1.Load("krn.jpg");
                pictureBox2.Load("kapnikp.jpg");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error loading images");
            }
            textBox1.Text = "You will need to walk 10 minutes outside Chora to reach Yiannis Ouzeri. Next to the wave and in a carob, " +
        "from where it gets its name, you will taste octopus and squid hot on the charcoal. They have excellent  pies with crunchy dough and you " +
        "should also must try the crab salad";
            linkLabel1.Visible = true;
            linkLabel1.Text = "To Karnagio";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    VisitLink("https://www.tripadvisor.com.gr/Restaurant_Review-g657463-d3528779-Reviews-Captain_Nikolas_Taverna-Koufonissi_Cyclades_South_Aegean.html");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading page.");
                }
            }
            if (radioButton2.Checked)
            {
                try
                {
                    VisitLink("https://www.tripadvisor.com.gr/Restaurant_Review-g657463-d2103107-Reviews-Kalofego-Koufonissi_Cyclades_South_Aegean.html");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading page.");
                }
            }
            if (radioButton3.Checked)
            {
                try
                {
                    VisitLink("https://www.tripadvisor.com.gr/Restaurant_Review-g657463-d3235888-Reviews-Neo_Remezzo-Koufonissi_Cyclades_South_Aegean.html");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error loading page.");
                }
            }
            if (radioButton4.Checked)
            {
                try
                {
                    VisitLink("https://www.tripadvisor.com.gr/Restaurant_Review-g657463-d2277198-Reviews-Ouzerie_Restaurant_Karnagio-Koufonissi_Cyclades_South_Aegean.html");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading page.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTxt wr = new WriteTxt();
                wr.WriteText(textBox1.Text);
                MessageBox.Show("Info saved!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
