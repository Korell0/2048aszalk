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
            Palyageneralas(5);
        }

        private void Palyageneralas(int meret)
        {
            int[,] GameSpace = new int[meret, meret];
            int sor = 0;
            int oszlop = 0;

            for (int i = 0; i < meret*meret; i++)
            {
                oszlop = i % meret;
                
                PictureBox uj = new PictureBox();
                uj.Name = i.ToString();

                uj.Location = new Point(20 + oszlop*78 +3, 20 + sor*78);
                uj.Size = new Size(75, 75);
                uj.BackColor = Color.FromArgb(0,0,0);
                if (oszlop == meret - 1)
                {
                    sor++;
                }
                this.Controls.Add(uj);
                for (int j = 0; j < sor; j++)
                {
                    for (int k = 0; k < oszlop; k++)
                    {

                    }
                }
            }
        }

        private void fel_Click(object sender, EventArgs e)
        {
            
            TablaKiiratas();
        }

        private void TablaKiiratas()
        {
            for (int i = 1; i <5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    string name = $"N{i}{j}";
                    //this..Image = Image.FromFile($"{Board.Display(i,j)}.png");
                }
            }
        }

    }
}
