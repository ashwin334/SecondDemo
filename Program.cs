using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a =Convert.ToInt32(Console.ReadLine()); // if input is null,then it will assign 0
            //int b =int.Parse(Console.Readline(); //if input is null,then shows error
            int b =Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine(sum); 
            int sub = a - b;
            Console.WriteLine(sub);
            int m = a * b;
            Console.WriteLine(m);   
            
            int div = a / b;    
            Console.WriteLine(div); 

            int mod = a % b;    
            Console.WriteLine(mod); 

        }
    }
}
