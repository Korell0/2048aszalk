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

<<<<<<< HEAD
             

        }
=======
            Console.WriteLine(tabla);
>>>>>>> 5e7915a901438a4015ca4bdc8bd30ee6cd65f1e5

        public void Move(int sor_honnan, int sor_hova, int oszlop_honnan, int oszlop_hova)
        {
            //balra gomb összadaás kizárólag (hiányzik az áthelyezés)
            for (int sor = 0; sor < 6; sor++)
            {
                for (int oszlop = 0; oszlop < 6; oszlop++)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        if (tabla[sor, oszlop] == tabla[sor, i])
                        {
                            tabla[sor, oszlop] *= 2;
                            tabla[sor, i] = 0;
                        }
                    }
                }
            }

            //jobbra gomb összeadás kizárólag (hiányzik az áthelyezés)
            for (int sor = 0; sor < 6; sor++)
            {
                for (int oszlop = 5; oszlop < -1; oszlop--)
                {
                    for (int i = 5; i < -1; i--)
                    {
                        if (tabla[sor, oszlop] == tabla[sor, i])
                        {
                            tabla[sor, oszlop] *= 2;
                            tabla[sor, i] = 0;
                        }
                    }
                }
            }
            
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
