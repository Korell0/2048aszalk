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

        public void EventClick()
        {
            TablaKiiratas();
            pont.Text = $"{Board.pontszam}";
            progressBar.Value = Convert.ToInt32(Math.Log2(Board.MaxPont() / 2) * 10);
            Board.Del2048();
        }


        private void X6_Click(object sender, EventArgs e)
        {
            Palyageneralas(6);
        }

        private void X5_Click(object sender, EventArgs e)
        {
            Palyageneralas(5);
        }

        private void X4_Click(object sender, EventArgs e)
        {
            Palyageneralas(4);
        }
        private void reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void VisibleChange()
        {
            fel.Visible = !fel.Visible;
            le.Visible = !le.Visible;
            balra.Visible = !balra.Visible;
            jobbra.Visible = !jobbra.Visible;
            wasd.Visible = !wasd.Visible;
            pont.Visible = !pont.Visible;
            progressBar.Visible = !progressBar.Visible;
            Progressus.Visible = !Progressus.Visible;
            reset.Visible = !reset.Visible;

            size.Visible = !size.Visible;
            X6.Visible = !X6.Visible;
            X5.Visible = !X5.Visible;
            X4.Visible = !X4.Visible;
        }

        private void Palyageneralas(int meret)
        {
            int fullsize = 375; //(px)
            int gap = 5; //(px)
            int border = 15; //(px)
            Board = new Grid(meret);
            pictures = new PictureBox[Board.tabla.GetLength(1), Board.tabla.GetLength(0)];
            for (int sor = 0; sor < Board.tabla.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < Board.tabla.GetLength(1); oszlop++)
                {
                    PictureBox uj = new PictureBox();
                    uj.Name = "pictureBox_" + (sor * Board.tabla.GetLength(1) + oszlop).ToString();
                    uj.Location = new Point(border + (Convert.ToInt32(uj.Name.Split('_')[1]) % Board.tabla.GetLength(1)) * (fullsize / Board.tabla.GetLength(1) + gap), border + (Convert.ToInt32(uj.Name.Split('_')[1]) / Board.tabla.GetLength(0)) * (fullsize / Board.tabla.GetLength(1) + gap));
                    uj.Size = new Size(fullsize / Board.tabla.GetLength(0), fullsize / Board.tabla.GetLength(1));
                    uj.BackColor = Color.FromArgb(0, 0, 0);
                    uj.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictures[sor, oszlop] = uj;
                    this.Controls.Add(uj);
                }
            }
            TablaKiiratas();
            VisibleChange();
        }

        private void TablaKiiratas()
        {
            for (int sor = 0; sor < Board.tabla.GetLength(1); sor++)
            {
                for (int oszlop = 0; oszlop < Board.tabla.GetLength(0); oszlop++)
                {
                    pictures[sor, oszlop].Image = null;
                    pictures[sor, oszlop].Image = Image.FromFile($"{Board.Display(sor, oszlop)}.png");
                }
            }
        }

        private void wasd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A or Keys.Left:
                    Board.VizszintesMozgas(0, Board.tabla.GetLength(0));
                    EventClick();
                    break;
                case Keys.D or Keys.Right:
                    Board.VizszintesMozgas(Board.tabla.GetLength(0), 0);
                    EventClick();
                    break;
                case Keys.W or Keys.Up:
                    Board.FuggolegesMozgas(0, Board.tabla.GetLength(1));
                    EventClick();
                    break;
                case Keys.S or Keys.Down:
                    Board.FuggolegesMozgas(Board.tabla.GetLength(1), 0);
                    EventClick();
                    break;
                default:
                    break;
            }
        }

    }
}
