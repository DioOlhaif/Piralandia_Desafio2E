using System;
using System.Linq;

namespace Piralandia_Desafio2E
{
    class Program
    {
        static void Main(string[] args)
        {

            // METODO 1

            string n = Console.ReadLine();

            char[] arr = n.ToCharArray();

            Array.Reverse(arr);



            string v = new string(arr);

            Console.WriteLine(v);




            // METODO 2

            static void Main(string[] args) { 
            string n = Console.ReadLine();
            

            

            
            
            string v = new string(n.Reverse().ToArray());
            Console.WriteLine(v);


        


        }
    }
}
