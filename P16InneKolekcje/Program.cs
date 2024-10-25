using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16InneKolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Queue (kolejka)
            //Kolejka typu FIFO (First-In-Frist-Out) - oznacza, ze pierwsy element , ktroy zostanie 
            // dodany bedzie tez pierwszym elementem ktory zostanie usuniety 

            Queue<int> kolejka = new Queue<int>();
            kolejka.Enqueue(1);// dodaje na koniec kolejki 
            kolejka.Enqueue(2); 
            kolejka.Enqueue(3);

            int pierwszyElement = kolejka.Dequeue(); // usuwa i zwraca pierwszy element z koljeki 

            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------- stos -----");
            //2. Stack (stos) - kolejka typu LIFO (Last-In-Frist-Out) oznacza, ze ostatni
            // doadny do kolekcji element bedzie pierwszym , który zostanie usuniety 

            Stack<int> stack = new Stack<int>();
            stack.Push(1);// dodaje element na wierzch stosu 
            stack.Push(2);
            stack.Push(3);

            int ostatni = stack.Pop(); // usuwa i zwraca ostatni element 

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            

            // Stack<List<string>> s = new Stack<List<string>>();

            // zastosowanie: np: obsługa magaznu aby produkty nie lezaly w magazynie zbyt długo 

            // 3. HashSet (zbiór) 
            // zbiór to kolekcja, która przechowuje unikatowe elementy w nieuporządkowanej formie 

            Console.WriteLine("------ zbior ----");

            HashSet<int> zbior= new HashSet<int>();
            zbior.Add(1);
            zbior.Add(2);
            zbior.Add(2); // nie zostanie wykonana bo juz 2 istnieje 

            bool czyIstnieje =zbior.Contains(2);

            foreach (var item in zbior)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----- slownik -------");
            // 4. Dictionary (słownik)
            Dictionary<int, string> slownik = new Dictionary<int, string>();
            slownik.Add(1, "Kowalski");
            slownik.Add(4, "Ola");
            slownik.Add(2, "Tomasz");

            slownik[2] = "Jan";

            foreach (var item in slownik)
            {
                Console.WriteLine(item);
            }

            string osoba = slownik[2]; //Tomasz

            // 5. SortedDictionary  (słownik posortowany) 
            Console.WriteLine("----- (słownik posortowany)  -------");
            SortedDictionary<string,string> slownikPosorotwany = new SortedDictionary<string,string>();
            slownikPosorotwany.Add("Kowalski", "Adam");
            slownikPosorotwany.Add("Nowak", "Ola");
            slownikPosorotwany.Add("Anowacki", "Tomasz");

            foreach (var item in slownikPosorotwany)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
