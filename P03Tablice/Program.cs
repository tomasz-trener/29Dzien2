using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1 = "warszwa";
            string miasto2 = "kraków";
            string miasta3 = "wrocław";

            string[] miasta = new string[4];

            miasta[0] = miasto1;
            miasta[1] = miasto2;
            //...
            miasta[3] = "gdańsk";     

            //miasta[4] = "gdynia" // bład wyjscie poza zakres tablicy 

            int dlugoscTablicy = miasta.Length; // 4 

            Console.WriteLine(miasta[0]); //warszawa 
            Console.WriteLine(miasta[2]); // ? mozemy sprawdzic w trybie debugoawanie 

            int[] temperatury = new int[2];

            // string s = null;
            // int x = null;

            // inne sposoby tworzenia tablic : 
            int[] liczby = new int[3] { 4, 6, 3 }; // tablica z odrazu uzupelnionymi wartosciami 
            int[] liczby2 = new int[] { 4, 6, 3,6,7,9 }; // inny sposob tworzenia tablicy 

            int x = Convert.ToInt32(Console.ReadLine());
            int[] liczby3 = new int[x];  // nie znamy dlugosci tablicy przed uruchomieniem programu 

            int[] liczby4 = { 4, 5, 7, 33, 23, 3 }; // jeszcze inny sposob na utworzenie tablicy 


            liczby2[1] = 8; // w tablicy moge podmienic wartosci 
            // tablice maja ustaloną, niezmienną dlugość 

            //talice moga być dowolnego typu 
            bool[] tablicaWartosciLogicznych = { true, false, true };
            char[] znakow = { 'a', 'g', 'x' };


            Console.ReadKey();
        }
    }
}
