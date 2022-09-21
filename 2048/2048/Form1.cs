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
        static Grid Board;
        static PictureBox[,] pictures;
        static int meret = 0;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        private void fel_Click(object sender, EventArgs e)
        {
            Board.FuggolegesMozgas(0, Board.tabla.GetLength(1));
            EventClick();
        }

        private void balra_Click(object sender, EventArgs e)
        {
            Board.VizszintesMozgas(0, Board.tabla.GetLength(0));
            EventClick();

        }

        private void jobbra_Click(object sender, EventArgs e)
        {
            Board.VizszintesMozgas(Board.tabla.GetLength(0), 0);
            EventClick();

        }

        private void le_Click(object sender, EventArgs e)
        {
            Board.FuggolegesMozgas(Board.tabla.GetLength(1), 0);
            EventClick();
        }

        private void EventClick()
        {
            TablaKiiratas();
            pont.Text = $"{Board.pontszam}";
            progressBar.Value = Convert.ToInt32(Math.Log2(Board.MaxPont() / 2) * 10);
            Board.Del2048();
        }
        private void Palyageneralas()
        {
            Board = new Grid(meret);
            pictures = new PictureBox[meret, meret];
            int sor = 0;
            int oszlop = 0;

            for (int i = 0; i < meret*meret; i++)
            {
                oszlop = i % meret;
                
                PictureBox uj = new PictureBox();
                uj.Name = i.ToString();
                this.Controls.Add(uj);

                uj.Location = new Point(20 + oszlop*78 +3, 20 + sor*78);
                uj.Size = new Size(75, 75);
                uj.BackColor = Color.FromArgb(0,0,0);
                uj.SizeMode = PictureBoxSizeMode.StretchImage;
                pictures[sor, oszlop] = uj;
                pictures[sor, oszlop] = uj;
                this.Controls.Add(uj);
                if (oszlop == meret - 1)
                {
                    sor++;
                }
            }

        }


        
        private void TablaKiiratas()
        {
            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    pictures[i, j].Image = null;
                    pictures[i,j].Image = Image.FromFile($"{Board.Display(i,j)}.png");

                }
            }
        }

        private void X5_Click(object sender, EventArgs e)
        {
            meret = 5;
            Palyageneralas();
            TablaKiiratas();

            fel.Visible = true;
            le.Visible = true;
            balra.Visible = true;
            jobbra.Visible = true;
            wasd.Visible = true;
            pont.Visible = true;
            progressBar.Visible = true;
            Progressus.Visible = true;

            size.Visible = false;
            X5.Visible = false;
            X4.Visible = false;
        }

        private void X4_Click(object sender, EventArgs e)
        {
            meret = 4;
            Palyageneralas();
            TablaKiiratas();

            fel.Visible = true;
            le.Visible = true;
            balra.Visible = true;
            jobbra.Visible = true;
            wasd.Visible = true;
            pont.Visible = true;
            progressBar.Visible = true;
            Progressus.Visible = true;

            size.Visible = false;
            X5.Visible = false;
            X4.Visible = false;
        }

    }
}
