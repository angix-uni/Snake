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

namespace Snake
{
    public partial class Zapisz_Wynik : Form
    {
        public Zapisz_Wynik()
        {
            InitializeComponent();
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\highscore.txt";
            if (String.IsNullOrEmpty(textBox1.Text))
                {

                File.AppendAllText(path, Wyniklbl.Text + "      " + "UnnamedPlayer" + Environment.NewLine);
                Savebtn.Enabled = false;
            }
            else
            File.AppendAllText(path, Wyniklbl.Text + "      " + textBox1.Text + Environment.NewLine);
            var contents = File.ReadAllLines(path);
            Array.Sort(contents);
            Array.Reverse(contents);
            File.WriteAllLines(path, contents);
            Savebtn.Enabled = false;



        }
    }
}
