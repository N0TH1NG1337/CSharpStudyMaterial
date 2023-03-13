using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Card
    {
        private string Color; // צבע הקלף
        private int Num; // מספר הקלף

        // פעולה בונה
        public Card(string Color, int Num) 
        {
            this.Color = Color;
            this.Num = Num;
        }

        // פעולות מאחזרות
        public string GetColor() { return this.Color; }
        public int GetNum() { return this.Num; }

        // פעולה מדפיסה
        public override string ToString()
        {
            return String.Format("Card - Color : {0}, Number : {1}", this.Color, this.Num);
        }
        
    }
}
