using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class UserControl1 : UserControl
    {
       
        public UserControl1()
        {
            InitializeComponent();
            
            label10.Text = Form1.from;
            label12.Text = Form1.from1;
        }
        
        private static UserControl1 instance;
        public static UserControl1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserControl1();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
           

        }
    }
}
