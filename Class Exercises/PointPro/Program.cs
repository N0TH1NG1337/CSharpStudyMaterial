using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // בדיקת תקינות של המחלקה
            // יצירת 2 נקודות חדשות
            Point NewPoint = new Point(43, 7);
            Point SecondPoint = new Point(5, 5);

            // הדפסה שלהן
            Console.WriteLine(NewPoint.ToString());
            Console.WriteLine(SecondPoint.ToString());

            // חלק ב : חישוב מרחק
            double DistanceBetween2Points = NewPoint.Distance(SecondPoint);
            Console.WriteLine(DistanceBetween2Points);


            // החלפה של נקודות ה x
            double TempX = NewPoint.GetX();
            NewPoint.SetX(SecondPoint.GetX());
            SecondPoint.SetX(TempX);

            // הדפסה נוספת
            Console.WriteLine(NewPoint.ToString());
            Console.WriteLine(SecondPoint.ToString());

            // נקודת אמצע
            Point MiddlePoint = NewPoint.Middle(SecondPoint);
            Console.WriteLine(MiddlePoint.ToString());



        }
    }
}
