using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Card card1 = new Card("Black", 1337);
            Card card2 = new Card("White", 228);
            
            Console.WriteLine(card1);
            Console.WriteLine(card2);
            
        }
    }
}
