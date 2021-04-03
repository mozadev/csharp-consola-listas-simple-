using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            string variable = "jose";
            string variable2 = "juan";

            nombres.Add("daniel");
            nombres.Add("maria");
            nombres.Add("gerardo");
            nombres.Add("juanita");
            nombres.Add(variable);
            nombres.Insert(0, variable2);
            nombres.Insert(1,"cesar");
            nombres.Remove ("gerardo");


            //String s1 = nombres[2];

            //foreach (string s1 in nombres)//solo para revisar todo el arreglo
            //{
            //    Console.WriteLine(nombres[1]);
            //}
            for (int i = nombres.Count/2; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);

            }


            Console.ReadKey();
           


        }
    }
}
