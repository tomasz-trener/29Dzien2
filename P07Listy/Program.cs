using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tablice maja stała długość
            string[] tablicaMiasta = new string[3] { "warszawa", "kraków", "gdańsk" };

            //listy mają zmienną długość 

            List<string> listaMiasta = new List<string>(); // lista posiada 0 elementów 

            if(listaMiasta == null)
            {
                // lista miast nie jest null
            }

            List<string> listaNull = null;
            //listaNull.Add("warszawa"); nie moge dodac elementu do obiektu, który nie istnieje 

            listaMiasta.Add("warszawa");
            listaMiasta.Add("gdańsk");
            listaMiasta.Insert(1, "Krakow"); // insert wstawia na konkretna pozycje a pozostale elementy przesuwaja sie w prawo 

            //listaMiasta.Insert(4, "Paryż"); wyjscie poza zakres 

            string miasto1= listaMiasta[0];
            string miastoOstatnie = listaMiasta[listaMiasta.Count-1];

            listaMiasta.RemoveAt(1); // usuwa drugi (liczymy od 0)
            listaMiasta.Remove("gdańsk"); // usuwa pierwszy napotkany element 

            //listaMiasta.RemoveAll() -- zostawimy na pozniej bo wymaga poznania delegatow 

            //listaMiasta.ToArray();
            // List<string> s= File.ReadAllLines("....").ToList();
        }
    }
}
