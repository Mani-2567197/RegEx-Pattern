using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEx
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the text (or) paragaph : ");
            string text = Console.ReadLine();
            RegEx regEx = new RegEx();
            regEx.Results(text);

        }
    }
}
