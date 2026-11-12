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
                Console.WriteLine(huto[i]);
           }
        }
        static void Takarit()
        {
            string[] tomb = new string[huto.Length];
            for (int i = 0;i < huto.Length;i++)
            {
                if (huto[i] != "")
                {
                    tomb[i] = huto[i];
                }
            }
            for (int i = 0; i < huto.Length ;i++)
            {
                huto[i] = tomb[i];
            }
        }
        static void Main(string[] args)
        {
            Bekeres();
        }
    }
}
