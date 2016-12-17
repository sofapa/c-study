using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EqualsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			var numbers = new int[]{0,1,2,3,4,5,6,7}; 
			var numQuery = from num in numbers where (num % 2) ==0 select num;  
			foreach(int num in numQuery)
			{
				Console.WriteLine("{0}", num);
			}
        }
    }
}