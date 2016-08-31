using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace praktika
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string[] files;
        string way=null;
        int index = 0;
        private void showButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                 way = folderBrowserDialog1.SelectedPath;
                 files = Directory.GetFiles(way);
                 pictureBox1.Image = new Bitmap(files[index]);
                 NextButton.Enabled = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {            
            pictureBox1.Image = new Bitmap(files[++index]);
            if (index != 0)
                PrevButton.Enabled = true;
            else
                PrevButton.Enabled = false;
            if (index == files.Length)
            {
                NextButton.Enabled = false;
            }
            else
                NextButton.Enabled = true;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(files[--index]);
            if (index != 0)
                PrevButton.Enabled = true;
            else
                PrevButton.Enabled = false;
            if (index == files.Length)
            {
                NextButton.Enabled = false;
            }
            else
                NextButton.Enabled = true;
            
        }
        
     


    }
}
