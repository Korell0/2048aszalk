using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    class Grid
    {
        public int[,] tabla;
        public int pontszam;
        public Grid(int meret)
        {

            tabla = new int[meret, meret];
            pontszam = 0;
            TablaFeltoltes();
            SzamGeneralas(new Random());
            SzamGeneralas(new Random());

        }



        public void Del2048()
        {

            for (int sor = 0; sor < tabla.GetLength(1); sor++)
            {
                for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
                {
                    if (tabla[sor, oszlop] == 2048)
                    {
                        tabla[sor, oszlop] = 0;
                    }
                }
            }

        }

        public int MaxPont()
        {
            int max = 0;
            for (int sor = 0; sor < tabla.GetLength(1); sor++)
            {
                for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
                {
                    if (max <= tabla[sor, oszlop])
                    {
                        max = tabla[sor, oszlop];
                    }
                }
            }
            return max;
        }

        public bool EllenorzesVereseg()
        {
            for (int sor = 0; sor < tabla.GetLength(1); sor++)
            {
                for (int oszlop = 0; oszlop < tabla.GetLength(0); oszlop++)
                {
                    if (tabla[sor, oszlop] == 0)
                    {

                        // itt kell történjenek a vereség eseményei
                        return false;

                    }
                }
            }
            MessageBox.Show($"Játék Vége!\nElért pontszámod: {pontszam}");
            Application.Restart();
            return true; // Ez itt egy picit érdekes 🤔
        }

        public void EllenorzesPont(int sor, int oszlop)
        {
            if (tabla[sor, oszlop] == 2048)
            {
                pontszam++;
            }
        }

         
        public void SzamGeneralas(Random rand)
        {
            if (!EllenorzesVereseg())
            {
                int[] poz = new int[] { rand.Next(0, tabla.GetLength(0)), rand.Next(0, tabla.GetLength(1)) };
                if (tabla[poz[0], poz[1]] == 0)
                {
                    tabla[poz[0], poz[1]] = rand.Next(1, 3) * 2;
                }
                else
                {
                    SzamGeneralas(rand);
                }
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
                                EllenorzesPont(sor, oszlop);
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
            MaxPont();

        }

        public void VizszintesRendezes(int honnan, int hova, int leptek)
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
                                EllenorzesPont(sor, oszlop);
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
            MaxPont();

        }

        public void FuggolegesRendezes(int honnan, int hova, int leptek)
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
    }
}
