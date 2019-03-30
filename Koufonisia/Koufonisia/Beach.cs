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
    public partial class Beach : Form
    {
        public Beach()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.BackColor = Color.Transparent;
            radioButton3.BackColor = Color.Transparent;
        }

        private void Beach_Load(object sender, EventArgs e)
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("f1.jpg");
            pictureBox2.Load("f2.jpg");
            textBox1.Text = "Beautiful sandy beach, with blue-grenn water color and a tavern nearby.";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("am1.jpg");
            pictureBox2.Load("am2.jpg");
            textBox1.Text = "Ammos beach is the closest one to the village. A beautiful  sandy beach, with a crystal clear soft blue water color." +
                " This beach is protected from northern winds and is close to bars and restaurants.";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            textBox1.Visible = true;
            pictureBox1.Load("xk1.jpg");
            pictureBox2.Load("xk2.jpg");
            textBox1.Text = "A beautiful beach 850m. far from the main village. It is protected from north and west winds, and it is covered by small rocks. The" +
                "color of the water is a mix of green and blue! There is also a tavern near by, so can enjoy a delicious meal anytime in the day you like!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WriteTxt wr = new WriteTxt();
                wr.WriteText(textBox1.Text);
                MessageBox.Show("Text successfully saved!", "Message");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving the file!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
