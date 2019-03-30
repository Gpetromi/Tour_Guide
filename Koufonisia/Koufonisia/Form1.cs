using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koufonisia
{
    public partial class Form1 : Form
    {
        //Connecton String
        String connectionDb = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Registered.mdb";
        OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            label1.Visible = true;
            button2.Visible = false;
            button5.Visible = true;

        }
        //Creates the connection to the database.
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionDb);
        }
        //Shows up another form(window).
        private void button1_Click(object sender, EventArgs e)
        {
            Guest gst = new Guest();
            this.Hide();
            gst.Show();
        }
        //Reference to creator.
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gregory Petromichelakis", "Created By");
        }
        //Kills the application.
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try-catch a connection to the access database to check if text on textbox exists on database.(login form)
            try
            {
                connection.Open();
                //   String query = "Select * from Table1";
                String query = "Select * from Table1 where Email ='" + textBox1.Text.Trim() + "'";
                OleDbCommand command = new OleDbCommand(query, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    Menu mn = new Menu();
                    this.Hide();
                    mn.Show();
                }
                else
                {
                    MessageBox.Show("User not found", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load database", "Error");
            }
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Type 'gregory@gmail.com' for login!", "Hint");
        }
    }
}
