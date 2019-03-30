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
    public partial class Info : Form
    {
       // Visited vs = new Visited();
        
        //Function that on-click takes a string as an arument and uses it to connect to the
        //proper webpage.All exceptions are handled.
        private void VisitLink(String s)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(s);
            
        }
        public Info()
        {
            InitializeComponent();
            label5.BackColor = Color.Transparent;
            
        }

        private void Info_Load(object sender, EventArgs e)
        {
            

        }
        //Click on label, fills textBox with custom Text.
        private void label1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            textBox3.Visible = true;
            textBox3.Text = "Koufonisia consists of two smaller islands, Ano and Kato Koufonisi, and are part of Mikres Kyklades. " +
    ". They are geographically dived by a small strait between them. In the map, you can find them 3n.m. southeast of Naxos and west of Amorgos.";        
        }
        //Click on label, fills textBox with custom Text.
        private void label2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            textBox3.Visible = true;
            textBox3.Text = "The Community of Koufonisia is one of eleven communities in the prefecture of Cyclades and includes the two Koufonissia, Keros and "+
                "nine more smaller islands scattered around the largest islands. The community has a population of 391 inhabitants (December 2011) and" +
                "the area of ​​26 square kilometers. The largest island of the community is Keros while the only inhabited is Ano Koufonissi that" +
                "is the seat of the community. From 1/1/2011 the Community of Koufonisia was abolished (plan Kallikratis)" +
                "and since then it is a Municipal Unity of the Municipality of Naxos and Small Cyclades.";
        }
        //Click on label, fills textBox with custom Text.
        private void label3_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            textBox3.Visible = true;
            textBox3.Text = "According to archaeological finds, Koufonisia has been inhabited since the Prehistoric times. Also, excavations in Epano Milli, surfaced " +
                            "important finds dating back to the early years of Cycladic civilization, these are quaint tommoral tombs in Agrilia and two other" +
                            "in the area of ​​Panos Mylos and Loutra. Other excavations have discovered objects of Hellenistic and Roman times. The current village seems to have been built" + 
                            "in the place of a large Roman settlement, which would extend to the cove of Loutra. Various early Christian relics, marble chairs etc. exist in the churches" +
                            "Agios Georgios and Agios Nikolaos, while the foundations of early Christian basilicas are visible in two parts of the island. The present settlement was probably built" +                        
                            "in the place of a great Roman settlement. A significant finding is, among other things, a frying vessel engraved with a nine-pointed star found in Epano Mylos" +
                            "and it is kept until today in the Archaeological Museum of Naxos. In the Map of Rigas Feraios the island was recorded as Kofinousa, while on maps of geographers " +
                            "and tourists, Up and Down" +
                             "Koufonissi had several names such as Pira (1590), Cofinissia(1745) and Phocussa(1791). During the passage of history, Koufonissia followed the fate of "+
                             "the rest of the Cyclades. They were originally placed in the Venetians and then in the Turks. The inhabitants of the islands, either because they were forced or " +
                             "because they wanted it, often joined"+
                              "their forces with the Maniotes and with other pirates who used Koufonisia as a refuge. In 1830 along with the rest of the Cyclades they came to the newly established" +
                              "Hellenic State. The inhabitants of the islands were tried hard during the Occupation, while in the first years of the post-war period a wave of " +
                               "internal migration that led the largest part of the population of Koufonissia to large urban centers.";
        }
        //Reference to creator.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Kill the application.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LinkLabel that on-click opens on broswer the given website.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            try
            {
                VisitLink("https://www.google.gr/maps?biw=1600&bih=758&q=%CE%BA%CE%BF%CF%85%CF%86%CE%BF%CE%BD%CE%AE%CF%83%CE%B9%CE%B1&um=1&ie=UTF-8&sa=X&ved=0ahUKEwjv84Xkjf_dAhXSDewKHSIlB4YQ_AUIDygC");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while page loading.");
            }
        }
        //Hides the textBox and shows Pictureboxes that load in real time photos
        //from bin file.
        private void label4_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            try
            {
                pictureBox1.Load("kou1.jpg");
                pictureBox2.Load("kou2.jpg");
                pictureBox3.Load("kou3.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in image loading");
            }
        }
        //Saves the textbox text on a txt file using a function from WriteTxt class.
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTxt wr = new WriteTxt();
                wr.WriteText(textBox3.Text);
                MessageBox.Show("Information saved! ", "Message");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while printing.");
            }
        }
    }
}
