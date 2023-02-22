using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
    public class Cat:Animal
    {
        public Cat(string food, string name) : base(food, name) { }
        public Cat(string food, string name, string voice) : this(food, name) { }
            //{ this.Voice = voice; }
        public string Voice { get; set; }

        public new void  Action()
        {
            base.Action();
            Console.WriteLine("run");
        }
        // ב- C# ניתן לדרוס פונקציה שקיבלנו ממחלקת הבסיס ואם נרצה (לא חובה) נוכל להשתמש בתוך המחלקה היורשת גם בפונקציה שקיבלנו ממחלקת הבסיס. השימוש יתבצע באמצעות המילה השמורה base ולאחריה נקודה וקריאה לפונקציה.

    }
}
