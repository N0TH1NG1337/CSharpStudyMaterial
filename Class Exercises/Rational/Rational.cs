using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalPro
{
    internal class Rational
    {
        private int x; // מונה
        private int y; // מכנה

        public Rational(int x, int y)
        {
            this.x = x;
            if (y == 0)
                throw new ArgumentException("error, y cant be 0");

            this.y = y;
        }

        // פעולות מאחזרות
        public int GetNumerator() { return this.x; }
        public int GetDenom() { return this.y; }

        // פעולות מציבות
        /*
        public void SetX(int x) { this.x = x; }
        public void SetY(int y) { this.y = y; }
        */

        // פעולה שבודקת האם שווה
        public bool IsEqual(Rational NewNumber)
        {
            int X1, Y1, X2, Y2;

            X1 = this.x;
            Y1 = this.y;

            X2 = NewNumber.GetNumerator();
            Y2 = NewNumber.GetDenom();

            if (X1 * Y2 == X2 * Y1)
                return true;

            return false;
        }

        // פעולה מכפילה
        public Rational Multiply(Rational NewNumber)
        {
            int X1, Y1, X2, Y2;

            X1 = this.x;
            Y1 = this.y;

            X2 = NewNumber.GetNumerator();
            Y2 = NewNumber.GetDenom();

            int NewX = X1 * X2;
            int NewY = Y1 * Y2;

            Rational ReturnMult = new Rational(NewX, NewY);

            return ReturnMult; 
        }

        // פעולה מחלקת
        public Rational Divide(Rational NewNumber)
        {
            int X1, Y1, X2, Y2;

            X1 = this.x;
            Y1 = this.y;

            X2 = NewNumber.GetNumerator();
            Y2 = NewNumber.GetDenom();

            int NewX = X1 * Y2;
            int NewY = Y1 * X2;

            if (NewY == 0)
                return null;

            Rational ReturnDiv = new Rational(NewX, NewY);

            return ReturnDiv;
        }

        // פעולה מדפיסה
        public override string ToString()
        {
            return String.Format("{0} / {1}", this.x, this.y);
        }
    }
}
