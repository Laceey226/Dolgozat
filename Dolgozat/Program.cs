using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Dolgozat
{
    internal class Program
    {
        static Random random = new Random();
        static string[] huto = new string[10];
        static void Bekeres()
        {
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] != "")
                {
                    Console.Write("Kérem adja meg a tárgy nevét amit a hűtőszekrénybe szeretne helyezni: ");
                    huto[i] = Console.ReadLine();
                }
           }
        }
        static void Takarit()
        {
            int index = 0;
            string[] tomb = new string[huto.Length];
            for (int i = 0;i < huto.Length;i++)
            {
                if (huto[i] != "")
                {
                    tomb[index] = huto[i];
                    index++;
                }
            }
            for (int i = 0; i < huto.Length ;i++)
            {
                huto[i] = tomb[i];
            }
        }
        static int KeresEtel(string etelNeve)
        {
            int megoldas;
            for (int i = 0; i < huto.Length; i++)
            {
                if (huto[i] == etelNeve)
                {
                    megoldas = i + 1;
                    return megoldas;
                }
            }
            return 0;

        }
        static void F01()
        {
            Bekeres();
            Takarit();
            Console.Write("Mit keresel? ");
            string etelNeve = Console.ReadLine();
            Console.WriteLine("A keresett tárgy a " + KeresEtel(etelNeve) + ". helyen található");
        }
        static int[] szamok = new int[10];
        static void FeltoltEgyediekkel(int min, int max)
        {
            bool dupla = false;
            int seged;
            for (int i = 0;i < szamok.Length; i++)
            {
                do
                {
                    dupla = false;
                    seged = random.Next(min, max);
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        if (szamok[j] == seged)
                        {
                            dupla = true;
                        }
                    }
                } while (dupla == true);
                dupla = false;
                szamok[i] = seged;
                Console.WriteLine(szamok[i]);
            }
        }
        static int[] lnbb_novekvo = new int[szamok.Length];
        static void LeghosszabbNovekvo()
        {
            int seged = 0;
            int allas = 0;
            int allas_kezdo = 0;
            int lnbb_hossz = 0;
            int lnbb_kezdo = 0;
            int lnbb_veg = 0;

            for (int i = 1; i < szamok.Length; i++)
            {
                allas = i;
                allas_kezdo = i;
                while (allas != 0 && szamok[allas]! > szamok[allas - 1])
                {
                    if (allas != 0 && szamok[allas] > szamok[allas - 1])
                    {
                        allas++;
                        seged++;
                    }
                }
                if (seged > lnbb_hossz)
                {
                    lnbb_hossz = seged;
                    lnbb_kezdo = allas_kezdo;
                    lnbb_veg = allas_kezdo + seged;
                }
                allas = 0;
                seged = 0;
            }
            Console.WriteLine();
            Console.WriteLine("A leghosszabb növekvő sor: ");
            for (int i = 0; i < lnbb_hossz; i++)
            {
                lnbb_novekvo[i] = szamok[lnbb_kezdo];
                lnbb_kezdo++;
                Console.WriteLine(lnbb_novekvo[i]);
            }
        }
        static void F02()
        {
            Console.Write("Add meg a minimumot: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a maximumot: ");
            int max = Convert.ToInt32(Console.ReadLine());
            FeltoltEgyediekkel(min, max);
            LeghosszabbNovekvo();
        }
        static void Main(string[] args)
        {
            //F01();
            F02();
        }
    }
}
