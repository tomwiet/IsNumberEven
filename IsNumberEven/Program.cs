using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            try 
            { 
                if(!int.TryParse(Console.ReadLine(), out var number))
                    throw new Exception("Podałes wartośc która nie jest liczbą");
                
                if (number % 2 == 0)
                {
                    Console.WriteLine("Liczpa parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta");
                }
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                Console.ReadLine(); 
            }
        }
    }
}
