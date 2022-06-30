using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fog = new OpenFileDialog();
                openFileDialog1.Filter = "txt files (*.txt)|*.txt"; // it will show but files with .txt extension
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != string.Empty)
                    using (StreamReader read = File.OpenText(openFileDialog1.FileName))
                    {
                        textBox1.Text = read.ReadToEnd();
                    }
            }
            catch
            {
                MessageBox.Show("Файл не был найден!", "System messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog tog = new SaveFileDialog();
                tog.Filter = "txt files (*.txt)|*.txt"; // it will show but files with .txt extension
                tog.ShowDialog();
                if (tog.FileName != string.Empty)
                {
                    using (StreamWriter write = File.CreateText(tog.FileName))
                    {
                        write.Write(textBox1.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не был найден!", "System messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void папкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                MessageBox.Show("Путь к файлу записан!", "System messege", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
