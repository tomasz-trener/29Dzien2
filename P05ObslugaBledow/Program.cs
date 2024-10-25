using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ObslugaBledow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            string s = "ala";


            try
            {
                int c = a / b;
                string s1 = s.Substring(3,1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Podales bledny index");
                File.AppendAllText(@"c:\dane\erros\errorlog.txt", Environment.NewLine + DateTime.Now + " " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Nie mozesz dzielić przez zero");
                File.AppendAllText(@"c:\dane\erros\errorlog.txt", Environment.NewLine + DateTime.Now + " " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coś poszło nie tak");
                File.AppendAllText(@"c:\dane\erros\errorlog.txt", Environment.NewLine + DateTime.Now + " " + ex.Message);
            }
           
            Console.ReadKey (); 

        }
    }
}
