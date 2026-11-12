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
        static void Main(string[] args)
        {
            Bekeres();
        }
    }
}
