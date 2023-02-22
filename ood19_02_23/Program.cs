using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //המחלקה אותה אנו יורשים נקראת מחלקת הבסיס (Base Class) והמחלקה החדשה שנוצרה ע"י מחלקת הבסיס נקראת מחלקה נגזרת (Derived Class). המחלקה הנגזרת יורשת את כל החברים (משתנים ופונקציות) של מחלקת הבסיס.
            Dog dog = new Dog("bonzo","kiara") {  age = 2 };
            Cat cat = new Cat("fish","tomi","miew") { age = 8, Name = "tomi", Food = "fish" };
            cat.Action();
            cat.Action();
            
            Console.WriteLine(cat.Food+cat.Name);
            Console.WriteLine(dog);

            // Usage example:
            MyDictionary myDictionary = new MyDictionary();

            // Add a new key-value pair using the indexer.
            myDictionary["hello"] = "world";

            // Get the value of an existing key using the indexer.
            string value = myDictionary["hello"]; // value = "world"

            // Get the value of a non-existing key using the indexer.
            string nullValue = myDictionary["goodbye"]; // nullValue = nul
        }
    }
}
