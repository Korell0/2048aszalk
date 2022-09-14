using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    class Grid
    {
        public int[,] tabla;

        public Grid(int meret)
        {
            tabla = new int[meret, meret];
            for (int sor = 0; sor < meret; sor++)
            {
                for (int oszlop = 0; oszlop < meret; oszlop++)
                {
                    tabla[sor, oszlop] = 0;
                }
            }

            Random rand = new Random();

            int[] poz1 = new int[] { rand.Next(0, meret) , rand.Next(0, meret) };
            int[] poz2 = new int[] { poz1[0], poz1[1] };
            while (poz1[0] == poz2[0] && poz1[1] == poz2[1])
            {
                poz2 = new int[] {rand.Next(0, meret) , rand.Next(0, meret) };
            }

            tabla[poz1[0], poz1[1]] = rand.Next(1, 3) * 2;
            tabla[poz2[0], poz2[1]] = rand.Next(1, 3) * 2;

            Console.WriteLine(tabla);

        }

        public void Display() 
        {
            int collum = tabla.GetLength(0);
            int row = tabla.GetLength(1);

          // Tabla beolvasása
            for (int i = 0; i < row; i++)
            {
                for (int j= 0; j < collum; j++)
                {
                   
                }
            }
        }
    }
}
