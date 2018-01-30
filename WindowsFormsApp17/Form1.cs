﻿using System;
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
            


        }
             
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.ForeColor = Color.Black;
            if (textBox2.Text == "GÜN/AY/İL")
            {
                textBox2.Clear();
            }
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
            comboBox1.ForeColor = Color.Black;
            if (comboBox1.Text == "Stansiya seçin")
            {
                comboBox1.ResetText();
                comboBox1.DroppedDown = true;
            }
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
            if (comboBox2.Text == "Stansiya seçin")
            {
                comboBox2.ResetText();
                comboBox2.DroppedDown = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            if (textBox1.Text == "GÜN/AY/İL")
            {
                textBox1.Clear();
            }
            monthCalendar1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
                                          
           textBox2.Visible = true;
           label5.Visible = true;
           pictureBox5.Visible = true;
                            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
           textBox2.Visible = false;
           label5.Visible = false;
           pictureBox5.Visible = false;
            monthCalendar2.Visible = false;
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.MinDate = monthCalendar1.SelectionEnd.AddDays(1);
            monthCalendar2.MaxDate = monthCalendar1.SelectionStart.AddMonths(1);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
            comboBox4.Items.Clear();
            for (int i = 0; i <= comboBox3.SelectedIndex; i++)
            {
                comboBox5.Items.Add(i);
            }

            if (comboBox3.SelectedIndex == 4)
            {
                comboBox4.Enabled = false;
                comboBox4.ResetText();
            }
            for (int i = 0; i <=4-comboBox3.SelectedIndex; i++)
            {
                comboBox4.Enabled = true;
                comboBox4.Items.Add(i);
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.DroppedDown = true;
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.DroppedDown = true;
        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
            comboBox5.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            Controls.Add(UserControl1.Instance);
            UserControl1.Instance.Dock = DockStyle.Fill;
            UserControl1.Instance.BringToFront();
        }
    }
    class Country
    {
        public string NameOfCountry { get; set; }

    }
    class ListOfCountry
    {
        public List<Country> list = new List<Country>();
    }
}
