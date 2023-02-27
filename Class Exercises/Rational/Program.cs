using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalPro
{
    internal class Program
    {
        // פעולה של חיבור שני מספר רציונלים
        // תנאי כניסה : שני מספרים רציונלים
        // תנאי יציאה : חיבור שני מספרים רציונלים והחזרה של מספר חדש
        public static Rational Add(Rational FirstNumber, Rational SecondNumber)
        {
            // add logic
            int X1, Y1; // 
            int X2, Y2; //

            X1 = FirstNumber.GetNumerator();
            Y1 = FirstNumber.GetDenom();

            X2 = SecondNumber.GetNumerator();
            Y2 = SecondNumber.GetDenom();

            int NewX, NewY; // Cache the new values for x and y
            Rational ReturnPoint; // Cache the return value

            if (Y1 == Y2) // אם המכנה שווה אז לא חובה ליצור מכנה מחדש
            {
                NewX = X1 + X2;
                NewY = Y1;

                ReturnPoint = new Rational(NewX, NewY);

                return ReturnPoint;
            }

            // if not 
            NewX = X1 * Y2 + X2 * Y1;
            NewY = Y1 * Y2;

            ReturnPoint = new Rational(NewX, NewY);

            return ReturnPoint;
        }

        // פעולה של חיסור שני מספר רציונלים
        // תנאי כניסה : שני מספרים רציונלים
        // תנאי יציאה : חיסור שני מספרים רציונלים והחזרה של מספר חדש
        public static Rational Remove(Rational FirstNumber, Rational SecondNumber)
        {
            // add logic
            int X1, Y1; // 
            int X2, Y2; //

            X1 = FirstNumber.GetNumerator();
            Y1 = FirstNumber.GetDenom();

            X2 = SecondNumber.GetNumerator();
            Y2 = SecondNumber.GetDenom();

            int NewX, NewY; // Cache the new values for x and y
            Rational ReturnPoint; // Cache the return value

            if (Y1 == Y2) // אם המכנה שווה אז לא חובה ליצור מכנה מחדש
            {
                NewX = X1 - X2;
                NewY = Y1;

                ReturnPoint = new Rational(NewX, NewY);

                return ReturnPoint;
            }

            // if not 
            NewX = X1 * Y2 - X2 * Y1;
            NewY = Y1 * Y2;

            ReturnPoint = new Rational(NewX, NewY);

            return ReturnPoint;
        }

        static void Main(string[] args)
        {
            
            Rational NewRat = new Rational(5, 7);
            Rational SecondRat = new Rational(5, 6);

            Console.WriteLine(NewRat);

            // check everything
            Console.WriteLine(NewRat.IsEqual(SecondRat));
            Console.WriteLine(NewRat.Multiply(SecondRat));
            Console.WriteLine(NewRat.Divide(SecondRat));
            Console.WriteLine(Add(NewRat, SecondRat));
        }
    }
}
