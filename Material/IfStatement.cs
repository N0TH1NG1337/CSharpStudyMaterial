namespace __Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if Statement - תנאים

            /*
                מבנה תנאי : 
                
                if (bool value) // note : לא חובה לפתוח בלוק אם אנחנו נשתמש בשורה אחת של קוד
                {   
                    // אם התנאי נכון אז הקוד שכתוב פה ירוץ
                }
                else 
                {
                    // אם הבדיקה שעשינו לא נכונה אז הקוד שכתוב כאן ירוץ
                }


                    אפשרות נוספת לשימוש בתנאים
                if (bool value 1)
                {
                    // code if bool value 1 is true
                }
                else if (bool value 2)
                {
                    // code if bool value 2 is true
                } ...
                else 
                {
                    // code if everything is false
                }

             */

            // דוגמה
            int Number = 1337;
            if (Number == 0)
                // דוגמה לשימוש ללא בלוק
                Console.WriteLine("The number is 0");
            
            else if (Number == 1)
            {
                Console.WriteLine("The number is 1");
            }
            else
            {
                Console.WriteLine("The number is " + Number);
            }


            // Operators - אופרטורים
            /*
                נכון להיום למדנו רק על מספר אופרטירים

                a == b  שווה 
                a != b  לא שווה
                a > b  גדול יותר
                a >= b  גדול או שווה
                a < b  קטן יותר
                a <= b  קטן או שווה

                כמו כן ניתן להישתמש במספר תנאים בבדיקה אחת
                &&  גם 
                ||  או
             */

            // דוגמה לבדיקה של או. יש בדיקה אם המספר קטן או שווה ל 10 או שווה ל 1
            if (Number <= 10 || Number == 1) 
            {
                // nothing :P
            }


            // הערה אחת שלא דיברנו על זה בכיתה : אופרטורים מחזירין ערך אמת או שקר לכן ניתן לשמור אותם במשתנה של אמת  או שקר
            // דוגמה
            bool IsNumber10 = Number == 10;
            // ואז להתשתמש בצורה כזאת
            if (IsNumber10)
            {
                // code
            }
            
        }
    }
}
