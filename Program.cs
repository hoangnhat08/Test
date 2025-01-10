using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 10 / 2;
                Console.WriteLine("3");
                int value = 4 / 2;
                Console.WriteLine("2");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);



            }
            finally
            {
                Console.WriteLine("chay mac dinh ");
            }
            Console.ReadKey();

        }
    }
}
