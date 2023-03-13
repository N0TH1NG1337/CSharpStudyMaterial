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
            // Card Q
            Card card1 = new Card("Black", 1337); // ניצור כרטיס 1
            Card card2 = new Card("White", 228); // ניצור כרטיס 2
            
            // נדפיס כל אחד 
            Console.WriteLine(card1); 
            Console.WriteLine(card2);
            
            // Button Q
            Button B1 = new Button(228); // ניצור אובייקט חדש

            B1.AddToSize(5); // נוסיף לאובייקט 5
            Console.WriteLine(B1.GetSize()); // אין לנו פעולה מדפיסה ולכן נדפיס לבדוק רק את הגודל

            Button B2 = new Button(2, 10, "white"); // ניצור עוד אובייקט
            Console.WriteLine(B1.IsSameSize(B2)); // נדפיס את התוצאה
            
        }
    }
}
