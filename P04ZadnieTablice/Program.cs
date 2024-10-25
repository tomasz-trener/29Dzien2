using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadnieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";
            string sciezka = @"C:\dane\miasta.txt";

            string[] miastaZPliku = null;
            try
            {
                miastaZPliku = File.ReadAllLines(sciezka);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nie udało się wczytac pliku");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
              //  throw ex;
            }

            if (miastaZPliku != null)
            {

                Console.WriteLine("Dostepne miasta:");
                for (int i = 0; i < miastaZPliku.Length; i++)
                    Console.WriteLine($"[{i + 1}] {miastaZPliku[i]}");

                while (true)
                {
                    try
                    {
                        int nrMiasta = Convert.ToInt32(Console.ReadLine());
                        string miasto = miastaZPliku[nrMiasta - 1];

                        string adres = adresPodstawowy + miasto;

                        WebClient wc = new WebClient();
                        string dane = wc.DownloadString(adres);

                        int indx = dane.IndexOf(szukanyZnak);
                        int aktualnaPozycja = indx;

                        while (dane.Substring(aktualnaPozycja, 1) != znakKoncowy)
                            aktualnaPozycja--;

                        string wynik = dane.Substring(aktualnaPozycja + 1, indx - aktualnaPozycja + 1);

                        Console.WriteLine($"Temeratura dla miasta {miasto} wynosi {wynik}");
                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(@"c:\dane\errors\errlog.txt", Environment.NewLine+DateTime.Now + " " + ex.Message);
                        Console.WriteLine("Nie udało się pobrać tempratury");
                    }
                   
                }
            }

        }
    }
}
