using System.Net.NetworkInformation;

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
            }
        }
        static void F02()
        {
            Console.Write("Add meg a minimumot: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg a maximumot: ");
            int max = Convert.ToInt32(Console.ReadLine());
            FeltoltEgyediekkel(min, max);
        }
        static void Main(string[] args)
        {
            //F01();
            F02();
        }
    }
}
