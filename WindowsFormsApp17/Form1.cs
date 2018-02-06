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
        public static string from;
        public static string from1;
        public static string from2;
        public static string to;


        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            var Siyahi = list1.list;
            foreach (var item in Siyahi)
                comboBox1.Items.Add(item.NameOfCountry);
            comboBox2.Items.Clear();
            var Siyahi2 = list1.list;
            foreach (var item in Siyahi2)
                comboBox2.Items.Add(item.NameOfCountry);
        }
        ListOfCountry list1 = new ListOfCountry();

        private void Form1_Load(object sender, EventArgs e)
        {
        
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
            
            
                var a = Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString()).ToString("MMMM dd, yyyy");
                textBox1.Text = a;
                monthCalendar1.Visible = false;
            
           
            
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (textBox1.Text== Convert.ToDateTime(monthCalendar1.SelectionStart.ToShortDateString()).ToString("MMMM dd, yyyy"))
            {
                var b = Convert.ToDateTime(monthCalendar2.SelectionStart.ToShortDateString()).ToString("MMMM dd, yyyy");
                textBox2.Text = b;
                monthCalendar2.Visible = false;
            }
            else
            {
                
                MessageBox.Show("Gediş tarixi seçilməyib!!!");
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
            comboBox1.ForeColor = Color.Black;
            if (comboBox1.Text == "Stansiya seçin")
            {
                comboBox1.ResetText();
                
            }
            comboBox1.DroppedDown = true;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.Black;
            if (comboBox2.Text == "Stansiya seçin")
            {
                comboBox2.ResetText();
                
            }
            comboBox2.DroppedDown = true;
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
            monthCalendar2.MinDate = monthCalendar1.SelectionStart.AddDays(1);
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
            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || comboBox3.SelectedIndex <= 0||textBox1.Text== "AY/GÜN/İL"||
                comboBox1.SelectedItem==comboBox2.SelectedItem)
            {
                label1.ForeColor =Color.Red;
                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
            }
            else
            {
                Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            
                       
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            from = comboBox1.SelectedItem.ToString();
        }

       

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            from1 = comboBox2.SelectedItem.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            from2 = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
    class Country
    {
        public string NameOfCountry { get; set; }
        public Country(string NameOf)
        {
            NameOfCountry = NameOf;
        }

    }
    class ListOfCountry
    {
        public List<Country> list = new List<Country>()
        {
            new Country("Bakı"),
             new Country("Sumqayıt"),
             new Country("Gəncə"),
             new Country("Mingəçevir"),
             new Country("Ağdaş"),
             new Country("Zaqatala"),
             new Country("Lənkəran")
        };
    }
    class Sernisinler
    {
        public string CountOfPas { get; set; }

    }
    class Trains
    {
        public string VaqonunTipi { get; set; }
        public string VaqonunSayi { get; set; }
        public string YerlerinSayi { get; set; }

    }
    class Tarifler
    {
        public decimal BoyuklerUcun { get; set; }
        public decimal UsaqlarUcun { get; set; }
    }
}
