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
        public bool teljes;

        public Grid(int meret)
        {

            tabla = new int[meret, meret];
            teljes = false;
            TablaFeltoltes();
            SzamGeneralas(new Random());
            SzamGeneralas(new Random());

        }

        public void SzamGeneralas(Random rand)
        {
            int[] poz = new int[] { rand.Next(0, tabla.GetLength(0)), rand.Next(0, tabla.GetLength(1)) };
            for (int sor = 0; sor < tabla.GetLength(1); sor++)
			{
                for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
			    {
                    if ()
	                {

	                }
			    }
			}
            if (tabla[poz[0], poz[1]] == 0)
            {
                tabla[poz[0], poz[1]] = rand.Next(1, 3) * 2;
            }
            else
            {
                SzamGeneralas(rand);
            }
        }

        public void TablaFeltoltes()
        {
            for (int sor = 0; sor < tabla.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < tabla.GetLength(1); oszlop++)
                {
                    tabla[sor, oszlop] = 0;
                }
            }
        }


        public void VizszintesMozgas(int honnan, int hova)
        {
            int leptek = honnan < hova ? 1 : -1;
            for (int sor = 0; sor < tabla.GetLength(1); sor++)
            {
                for (int oszlop = honnan < hova ? 0 : honnan - 1; honnan < hova ? oszlop < hova : oszlop > hova - 1; oszlop+=leptek)
                {
                    if (tabla[sor, oszlop] > 0)
                    {
                        for (int i = oszlop; honnan < hova ? i < hova : i > hova - 1; i += leptek)
                        {
                            if (tabla[sor, oszlop] == tabla[sor, i] && oszlop != i)
                            {
                                tabla[sor, oszlop] *=2;
                                tabla[sor, i] = 0;
                                break;
                            }
                            else if (tabla[sor, i] > 0 && oszlop != i)
                            {
                                break;
                            }
                        }
                    }
                    
                }
            }
            VizszintesRendezes(honnan, hova, leptek);
            SzamGeneralas(new Random());
            SzamGeneralas(new Random());

        }

        private void VizszintesRendezes(int honnan, int hova, int leptek)
        {
            for (int sor = 0; sor < tabla.GetLength(1); sor++)
            {
                for (int oszlop = honnan < hova ? 0 : honnan - 1; honnan < hova ? oszlop < hova : oszlop > hova - 1; oszlop += leptek)
                {
                    if (tabla[sor, oszlop] == 0)
                    {
                        for (int i = oszlop; honnan < hova ? i < hova : i > hova - 1; i += leptek)
                        {
                            if (tabla[sor, i] > 0)
                            {
                                tabla[sor, oszlop] = tabla[sor, i];
                                tabla[sor, i] = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }


        public void FuggolegesMozgas(int honnan, int hova)
        {
            int leptek = honnan < hova ? 1 : -1;
            for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
            {
                for (int sor = honnan < hova ? 0 : honnan - 1; honnan < hova ? sor < hova : sor > hova - 1; sor+=leptek)
                {
                    if (tabla[sor, oszlop] > 0)
                    {
                        for (int i = sor; honnan < hova ? i < hova : i > hova - 1; i+=leptek)
                        {
                            if (tabla[sor, oszlop] == tabla[i, oszlop] && sor != i)
                            {
                                tabla[sor, oszlop] *= 2;
                                tabla[i, oszlop] = 0;
                                break;
                            }
                            else if (tabla[i, oszlop] > 0 && sor != i)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            FuggolegesRendezes(honnan, hova, leptek);
            SzamGeneralas(new Random());
            SzamGeneralas(new Random());


        }

        private void FuggolegesRendezes(int honnan, int hova, int leptek)
        {
            for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
            {
                for (int sor = honnan < hova ? 0 : honnan - 1; honnan < hova ? sor < hova : sor > hova - 1; sor += leptek)
                {
                    if (tabla[sor, oszlop] == 0)
                    {
                        for (int i = sor; honnan < hova ? i < hova : i > hova - 1; i += leptek)
                        {
                            if (tabla[i, oszlop] > 0)
                            {
                                tabla[sor, oszlop] = tabla[i, oszlop];
                                tabla[i, oszlop] = 0;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public int Display(int sor,int oszlop) 
        {
            int collum = tabla.GetLength(0);
            int row = tabla.GetLength(1);


          // Tabla beolvasása
            for (int i = 0; i < row; i++)
            {
                for (int j= 0; j < collum; j++)
                {
                    if (i == sor )
                    {
                        if (j==oszlop)
                        {
                            return tabla[i, j];
                        }

                    }
                }
            }
            return 0;
        }
    }
}
