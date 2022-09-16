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

namespace _2048
{
    public partial class Form1 : Form
    {
        static Grid Board = new Grid(5);
        public Form1()
        {
            InitializeComponent();
            TablaKiiratas();
        }

        private void TablaKiiratas()
        {
            for (int i = 1; i <5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    string name = $"N{i}{j}";
                    this.N11.Image = Image.FromFile($"{Board.Display(i,j)}.png");
                }
            }
        }

        private void fel_Click(object sender, EventArgs e)
        {
        


        }
    }
}
