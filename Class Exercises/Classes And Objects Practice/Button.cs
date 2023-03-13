using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    internal class Button
    {
        private int Num; // מספר הכפתור
        private int Size; // גודל הכפתור
        private string Color; // צבע הכפתור

        // פעולה בונה ראשונה
        public Button(int Num)
        {
            this.Num = Num;
            this.Size = 5;
            this.Color = "black";
        }

        // פעולה בונה שנייה
        public Button(int Num, int Size, string Color) 
        { 
            this.Num = Num;
            this.Size = Size;
            this.Color = Color;
        }

        // פעולה המחזירה גודל
        public int GetSize() { return this.Size; }

        // פעולה שמוסיפה לגודל
        public void AddToSize(int X) { this.Size += X; }

        // פעולה שבודקת אם הגדלים שווים
        public bool IsSameSize(Button other) { return this.Size == other.Size; }
    
    }
}
