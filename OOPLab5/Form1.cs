using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Client> tmp = new List<Client>();
        List<Vklad> tmpV = new List<Vklad>();
        private void button1_Click(object sender, EventArgs e)
        {
            List<Client> C = new List<Client>();
            C.Add(new Client { Name = textBox1.Text, SurName = textBox2.Text, Passport = textBox3.Text });
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            var items = new[]
            {
                new { Text = C[0].SurName, Value = C[0] }
            };
            comboBox1.DataSource = items;
            tmp = C;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Vklad> V = new List<Vklad>();
            V.Add(new Vklad { Procent = Convert.ToDouble(textBox6.Text), Money = Convert.ToDouble(textBox5.Text), client = tmp[0] });
            comboBox2.DisplayMember = "Text";
            comboBox2.ValueMember = "Value";
            comboBox3.DisplayMember = "Text";
            comboBox3.ValueMember = "Value";
            var items = new[]
            {
                new { Text = V[0].client.SurName, Value = V[0] }
            };
            comboBox2.DataSource = items;
            comboBox3.DataSource = items;
            tmpV = V;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sum = Convert.ToDouble(textBox7.Text);
            tmpV[0].Money += sum;
            textBox5.Text = Convert.ToString(tmpV[0].Money);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = tmp[0].Name + " ";
            richTextBox1.Text += tmp[0].SurName + "\r\n";
            double all = tmpV[0].Money * ((tmpV[0].Procent / 100) + 1);
            richTextBox1.Text += "Через месяц: " + all; 
        }
    }
}
