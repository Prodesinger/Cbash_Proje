using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denemeform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* */
        }
        public static void sendwebhook(string Url, string msg, string username)
        {
            http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
            {
                "username",
                username

            },
            {
                "content",
                    msg
            }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendwebhook(textBox1.Text, textBox3.Text, textBox2.Text);
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "<#>";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "<@>";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "@everyone";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "@here";           
        }
    }
}
