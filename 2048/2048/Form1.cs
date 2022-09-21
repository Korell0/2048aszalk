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
        }

        private void fel_Click(object sender, EventArgs e)
        {
            Board.MoveVertical(0, Board.tabla.GetLength(1) + 1);
        }

        private void balra_Click(object sender, EventArgs e)
        {
            Board.MoveHorizontal(0, Board.tabla.GetLength(0) + 1);
        }

        private void jobbra_Click(object sender, EventArgs e)
        {
            Board.MoveHorizontal(Board.tabla.GetLength(0), -1);
        }

        private void le_Click(object sender, EventArgs e)
        {
            Board.MoveVertical(Board.tabla.GetLength(1), -1);
        }
    }
}
