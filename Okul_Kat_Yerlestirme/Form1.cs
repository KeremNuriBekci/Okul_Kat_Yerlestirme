using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_Kat_Yerlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kat1, kat2, kat3;

            kat1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = (kat1.ToString());
            
            kat2 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = (kat2.ToString());

            kat3 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = (kat3.ToString());

            if (kat1 == 1)
            {
                kayıt_listbox.Items.Add("9/A Sınıfı");
                kayıt_listbox.Items.Add("9/H Sınıfı");
                kayıt_listbox.Items.Add("9/K Sınıfı");
                kayıt_listbox.Items.Add("9/BT Sınıfı");
            }
            else if (kat2 == 2)
            {
                kayıt_listbox.Items.Add("10/A Sınıfı");
                kayıt_listbox.Items.Add("10/H Sınıfı");
                kayıt_listbox.Items.Add("10/K Sınıfı");
                kayıt_listbox.Items.Add("10/BT Sınıfı");
            }
            else
                {
                kayıt_listbox.Items.Add("11/A Sınıfı");
                kayıt_listbox.Items.Add("11/H Sınıfı");
                kayıt_listbox.Items.Add("11/K Sınıfı");
                kayıt_listbox.Items.Add("11/BT Sınıfı");
            }
        }
    }
}
