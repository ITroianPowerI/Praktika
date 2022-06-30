using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracktika1
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
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                string path = @"C:\Users\user\Desktop\iop123\folder_";
                for (int i = 0; i <= a; i++)
                {
                    string pathNew = path + Convert.ToString(i);
                    Directory.CreateDirectory(pathNew);
                }
                label1.Text = "Папки успешно созданы!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                string path = @"C:\Users\user\Desktop\iop123\folder_";
                for (int i = 0; i <= a; i++)
                {
                    string pathNew = path + Convert.ToString(i);
                    Directory.Delete(pathNew);
                }
                label1.Text = "Папки успешно удалены!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
