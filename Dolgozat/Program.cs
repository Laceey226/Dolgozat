namespace Dolgozat
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            F01();
        }
    }
}
