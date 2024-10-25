using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieListy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPodstawowy = "https://www.google.com/search?q=pogoda ";
            string szukanyZnak = "°";
            string znakKoncowy = ">";
            string sciezka = @"C:\dane\miasta.txt";

            List<int> listaTemperatur = new List<int>();
            List<string> listaMiast = new List<string>();

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


                        // dodajemy opcje liczenia średniej temperatury 
                        listaMiast.Add(miasto);
                        listaTemperatur.Add(Convert.ToInt32(wynik.Substring(0, wynik.Length - 2)));// usuwania znaku °C

                        // teraz liczmy średnia temperature 
                        double sredniaTemp = 0;
                        foreach (var t in listaTemperatur)
                            sredniaTemp += t;

                        //sredniaTemp = sredniaTemp / listaMiasta.Count;
                        sredniaTemp /= listaTemperatur.Count;

                        string raport = string.Format("Srednia temepratura z lista ({0}) to {1} °C", 
                            string.Join(", ",listaMiast),sredniaTemp);
                        Console.WriteLine(raport);

                    }
                    catch (Exception ex)
                    {
                        File.AppendAllText(@"c:\dane\errors\errlog.txt", Environment.NewLine + DateTime.Now + " " + ex.Message);
                        Console.WriteLine("Nie udało się pobrać tempratury");
                    }

                }
            }

        }
    }
}
