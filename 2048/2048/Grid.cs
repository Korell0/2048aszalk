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

        public void MoveHorizontal(int honnan, int hova)
        {
            //balra és jobbra gomb, összadaás kizárólag (hiányzik az áthelyezés)
            int leptek = new int[] { honnan, hova }.Max() == hova ? 1 : -1;

            for (int sor = honnan; leptek > 0 ? sor < hova : sor > -1; sor+=leptek)
            {
                for (int oszlop = honnan; leptek > 0 ? oszlop < hova : oszlop > -1; oszlop += leptek)
                {
                    for (int i = oszlop; leptek > 0 ? i < hova : i > -1; i += leptek)
                    {
                        if (tabla[sor, oszlop] == tabla[sor, i])
                        {
                            tabla[sor, oszlop] *= 2;
                            tabla[sor, i] = 0;
                            break;
                        }
                        if (tabla[sor, oszlop] != tabla[sor, i] && tabla[sor, i] != 0)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void MoveVertical(int honnan, int hova)
        {
            //fel és le gomb összeadás kizárólag (hiányzik az áthelyezés)
            int leptek = new int[] { honnan, hova }.Max() == hova ? 1 : -1;

            for (int oszlop = honnan; leptek > 0 ? oszlop < hova : oszlop > -1; oszlop+=leptek)
            {
                for (int sor = honnan; leptek > 0 ? sor < hova : sor > -1; sor+=leptek)
                {
                    for (int i = sor; leptek > 0 ? i < hova : i > -1 ; i+=leptek)
                    {
                        if (tabla[sor, oszlop] == tabla[i, oszlop])
                        {
                            tabla[sor, oszlop] *= 2;
                            tabla[i, oszlop] = 0;
                            break;
                        }
                        if (tabla[sor, oszlop] != tabla[i, oszlop] && tabla[i, oszlop] != 0)
                        {
                            break;
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
