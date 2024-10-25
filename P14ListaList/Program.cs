using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14ListaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<List<string>> listaList = new List<List<string>>();

            var listaListList = new List<List<List<string>>>();

            //skupmy sie na liscie dwuwymiarowej
            listaList.Add(new List<string>());
            listaList[0].Add("A");
            listaList[0].Add("B");

            listaList.Add(new List<string>() { "C", "D", "E" });

            // zapis klamerkowy 
            List<string> lista0 = new List<string>()
            {
                "A", "B", "C",
            };

            var listaListNapisow = new List<List<string>>()
            {
                new List<string>() {"A","B"},
                new List<string>() {"C","D"},
                new List<string>() {"E","F"},
            };

            listaListNapisow.Add(new List<string> {"X","Y", "Z"});  


            foreach (var lw in listaListNapisow)
            {
                Console.WriteLine(string.Join(" ", lw));
            }


            foreach (var s in listaListNapisow[0])
                Console.WriteLine(s);

            Console.ReadKey();


        }
    }
}
