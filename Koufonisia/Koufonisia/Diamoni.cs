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
    public partial class Diamoni : Form
    {
        private void VisitLink(String s)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(s);
        }
        public Diamoni()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            label2.Text = "Rating: 9,2!";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("mh1.jpg");
            pictureBox2.Load("mh2.jpg");
            textBox1.Text = "This hotel is 1 minute away from the beach. Myrto Hotel is located at Koufonisia,only just 150m " +
                "from the port and 40m from the beach. It offers rooms, a beautiful bar and transportation from/to the port. There is also a gift shop. " +
                "Every room has a private bathroom. Each room also has a balcony with an amazing view. Daily breakfast also included for free, " +
                "and moreover, you can  enjoy a cup of coffee or a delicious cocktail in the bar with the best view in the island! " +
                "Myrto Hotel is 1km away from Foikikas beach . Free parking icnluded.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            label2.Text = "Rating: 9,6!";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("oc1.jpg");
            pictureBox2.Load("oc2.jpg");
            textBox1.Text = "This accommodation is an 18-minute walk from the beach. Oceanides Residence Koufonisia offers pet-friendly rooms in Koufonisia. " +
                "Platia Punta beach is 1.2 km from the accommodation. Free private parking is available on site. All rooms are equipped with satellite TV." +
                "Some have a terrace and / or a balcony with sea view. There is also a kitchenette with toaster, fridge, mini bar and coffee maker. " +
                "Each unit includes private bathroom with shower. Towels are provided. Oceanides Residence Koufonisia offers barbecue facilities and guests" +
                " can also take advantage of  the grocery delivery service.  Free bicycles are provided and the area is suitable for snorkeling."+
                "You can also enjoy activities such as windsurfing, scuba diving and cycling. Harokopou Beach is 500 meters from Oceanides Residence Koufonisia.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button6.Visible = true;
            label2.Text = "Rating: 8,2!";
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("p1.jpg");
            pictureBox2.Load("p2.jpg");
            textBox1.Text = "This accommodation is a 5-minute walk from the beach. The traditionally built Paradise Resort Hotel is just 200 meters away from the port of Koufonisi. " +
                                            "It offers an outdoor pool with sun loungers and a café-bar. The rooms offer a balcony with unlimited view to the Aegean Sea. All rooms include air conditioning, satellite " +
                                            "TV, safe, fridge and coffee-tea facilities. The private bathroom is equipped with a hydromassage shower and free toiletries."+
                                            "Visitors can enjoy a swim in the pool or order a refreshing drink from the coffee bar on the hotel premises."+
                                            "Free Wi-Fi included. You will find various fish taverns, bars and shops just a short walk from Paradise Resot Hotel. Foinikas Beach is 600 meters away, and Italida Beach 800 meters." +
                                            "Pori beach is 1 km away.";
        }

        private void Diamoni_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink("http://www.koufonisia.gr/?page_id=60&lang=en");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in search", "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTxt wr = new WriteTxt();
                wr.WriteText(textBox1.Text);
                MessageBox.Show("Info saved!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ");
            }
        }
    }
}
