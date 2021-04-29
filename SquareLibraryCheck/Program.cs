using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareLib;

namespace SquareLibraryCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareCalculation objSquare = new SquareCalculation();
            Console.WriteLine(objSquare.Square(5.0, 6.0));
            Console.WriteLine(objSquare.Square(5.0, 6.0, 4.0));
            Console.WriteLine(objSquare.Square(6.0));
            Console.WriteLine(objSquare.CheckTypeTriangle(5.0, 4.0, 3.0));
            Console.WriteLine(objSquare.CheckTypeTriangle(5.0, 4.0, 2.0));
        }
    }
}
