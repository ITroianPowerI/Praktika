using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracktika3
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x % y);
            }
            if (radioButton2.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(Math.Pow(x, y));
            }
            if (radioButton3.Checked)
            {
                string x = textBox1.Text;
                string y = textBox2.Text;
                textBox3.Text = x + y;
            }
            if (radioButton4.Checked)
            {
                double x = Convert.ToInt32(textBox1.Text);
                double y = Convert.ToInt32(textBox2.Text);
                textBox3.Text = Convert.ToString(x / y);
            }
        }
    }
}
