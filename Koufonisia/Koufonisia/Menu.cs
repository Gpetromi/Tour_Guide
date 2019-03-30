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
    public partial class Menu : Form
    {
        public Boolean wasVisited = false;
        //Creating a media player.
        WMPLib.WindowsMediaPlayer sp = new WMPLib.WindowsMediaPlayer();
        public Menu()
        {
            InitializeComponent();
            label4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label3.BackColor = Color.Red;
            label11.BackColor = Color.Red;
            label13.BackColor = Color.Red;
            label14.BackColor = Color.Red;
            label15.BackColor = Color.Red;
            label16.BackColor = Color.Red;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Shows up another class(window).
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Diamoni dm = new Diamoni();
            dm.Show();
            label3.BackColor = Color.Green;
        }
        //Reference to creator.
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Shows up another class(window).
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Beach bc = new Beach();
            bc.Show();
            label13.BackColor = Color.Green;
        }
        //Shows up another class(window).
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Food fd = new Food();
            fd.Show();
            label16.BackColor = Color.Green;
        }
        //Shows up another class(window).
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Info nf = new Info();
            nf.Show();
            label11.BackColor = Color.Green;

        }
        //Starts the music player after finding file's position.
        private void button3_Click(object sender, EventArgs e)
        {
            sp.URL = "2.mp3";
            sp.controls.play();
        }
        //Stops the music player.
        private void button4_Click(object sender, EventArgs e)
        {
            sp.controls.stop();
        }
        //Shows up another class(window).
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bar br = new Bar();
            br.Show();
            label14.BackColor = Color.Green;
        }
        //Shows up another class(window).
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Apps ap = new Apps();
            ap.Show();
            label15.BackColor = Color.Green;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
            label11.BackColor = Color.Red;
            label13.BackColor = Color.Red;
            label14.BackColor = Color.Red;
            label15.BackColor = Color.Red;
            label16.BackColor = Color.Red;
        }
    }
}
