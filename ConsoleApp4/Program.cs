using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        // this is a excercise 4.
        static void Main(string[] args)
        {
            // This asks the user for their legth of the rectangle amount. 
            Console.Write("enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());
            
            // This asks the user for their width of the rectangle amount.
            Console.Write("enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());
            //This solves the equation for perimeter by multpilying 2 to length and witdh.
            double perimeter = 2 * (length + width);
            //This solves the equation for area by multpilying the length and witdh.
            double area = length * width;
           
            //This one is for space between width of rectangle and Results.
            Console.WriteLine();
            
            //This prints out Results.
            Console.WriteLine("Results:");
            //this prints out Area of the rectangle.
            Console.WriteLine("Area of the rectangle: " + area);

            //this prints out Perimeter of the rectangle.
            Console.WriteLine("Perimeter of the rectangle: " + perimeter);
            Console.ReadLine();
            // I put Console.ReadLine(); because the build would not display for less than a second.
        }
    }
}
