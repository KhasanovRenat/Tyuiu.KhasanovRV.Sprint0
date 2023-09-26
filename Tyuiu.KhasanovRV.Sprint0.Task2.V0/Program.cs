using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhasanovRV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Ренат"));

            Console.ReadKey();
        }
    }
}
