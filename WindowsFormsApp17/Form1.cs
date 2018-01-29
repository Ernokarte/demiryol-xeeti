using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bakı");
            comboBox1.Items.Add("Sumqayıt");
            comboBox1.Items.Add("Gəncə");
            comboBox1.Items.Add("Mingəçevir");
            comboBox1.Items.Add("Ağdaş");
            comboBox1.Items.Add("Zaqatala");
            comboBox1.Items.Add("Lənkəran");
            comboBox2.Items.Add("Bakı");
            comboBox2.Items.Add("Sumqayıt");
            comboBox2.Items.Add("Gəncə");
            comboBox2.Items.Add("Mingəçevir");
            comboBox2.Items.Add("Ağdaş");
            comboBox2.Items.Add("Zaqatala");
            comboBox2.Items.Add("Lənkəran");
            comboBox3.Items.Add("0");
            comboBox3.Items.Add("1");
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");
            comboBox4.Items.Add("0");
            comboBox4.Items.Add("1");
            comboBox4.Items.Add("2");
            comboBox4.Items.Add("3");
            comboBox4.Items.Add("4");
            comboBox5.Items.Add("0");
            comboBox5.Items.Add("1");
            comboBox5.Items.Add("2");
            comboBox5.Items.Add("3");
            comboBox5.Items.Add("4");

        }

        

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;           
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar1.Visible = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            monthCalendar1.Visible = false;
            monthCalendar2.Visible = false;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar2.SelectionStart.ToShortDateString();
            monthCalendar2.Visible = false;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.ForeColor = Color.Red;
            if (comboBox1.Text == "Stansiya seçin")
            {
                comboBox1.ResetText();
               
            }
        }
    }
}
