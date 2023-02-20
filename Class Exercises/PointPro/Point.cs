using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointPro
{

    internal class Point
    {
        private double x; // מיקום על ציר x
        private double y; // מיקום על ציר y

        // פעולה בונה
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // פעולה בונה נוספת
        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        // פעולות מאחזרות
        public double GetX() { return x; }
        public double GetY() { return y; }

        // פעולות קובעות
        public void SetX(double x) { this.x = x; }
        public void SetY(double y) { this.y = y; }


        // פעולות נוספות
        public double Distance(Point NewPoint)
        {
            // Cache the xs and ys
            double X1, Y1, X2, Y2;

            X1 = this.x;
            Y1 = this.y;

            X2 = NewPoint.GetX();
            Y2 = NewPoint.GetY();

            // Distance Calc
            double DistanceCalc = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));

            return DistanceCalc;
        }

        public Point Middle(Point NewPoint)
        {
            // Cache the xs and ys
            double X1, Y1, X2, Y2;

            X1 = this.x;
            Y1 = this.y;

            X2 = NewPoint.GetX();
            Y2 = NewPoint.GetY();

            double MiddleX = (X1 + X2) / 2;
            double MiddleY = (Y1 + Y2) / 2;

            Point ReturnPoint = new Point(MiddleX, MiddleY);

            return ReturnPoint;
        }


        // פעולה מתארת
        public override string ToString()
        {
            return String.Format("({0}, {1})", this.x, this.y);
        }
    }
}
