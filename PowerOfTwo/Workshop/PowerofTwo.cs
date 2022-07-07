using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class PowerofTwo
    {
        public void poweroftwo()
        {
            Console.WriteLine("Enter the no : ");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num < 0 || num >= 31)
            {
                Console.WriteLine("Please enter the valid no ");
                num = Convert.ToInt32((Console.ReadLine()));
            }

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
