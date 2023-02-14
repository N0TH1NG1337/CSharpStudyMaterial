namespace __Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loops - לולאות עם תווך מוגדר

            /*
                 for loop strcut - מבנה לולאת 

                 for (int _Name_ = 0; _Name_ </<=/... SomeNumber; _Name_++) | (קפיצות ; מטרה ; ערך התחלתי ) | 
                 {
                     // code
                     הערה : שימוש ב ערך ההתחלתי ניתן רק להשתמש בתוך הבלוק הנל
                 }

                סוגים של קפיצות
                int Number = 0;

                1) Number++ / Number = Number + 1
                2) Number-- / Number = Number - 1
                3) Number = Number (type, +,- ...) OtherNumber / Number (type)= OtherNumber
             */


            // דוגמה של לולאה
            // ידפיס את הערכים מ 0 ל 9 
            // 10 פעמים בלולאה תרוץ כמו שקבנו
            int Number = 10;
            for (int Index = 0; Index < 10; Index--)
            {
                Console.WriteLine(Index);
            }

            // דוגמה של פעולות עם מיספרים . שמשתמשים בהם גם בתור קפיצות בלולאות
            // הדוגמה נלקחת רק בתנאי שכל שורה אינה קשורה לשורה שלפני
            Number = Number + 5; // Number = 10 + 5 = 15
            Number += 5; // Number = Number + 5 = 10 + 10 = 15 / אותו דבר כמו שורה שנכתבה לפני

            Number /= 5; // Number = Number / 5 = 10 / 5 = 2;
        }
    }
}
