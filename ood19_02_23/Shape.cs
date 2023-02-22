using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
    public abstract class Shape
    {
        protected Shape(int x) { X = x; }
        protected  Shape() {  }
        
        public void print(string draw)
        {
            Console.WriteLine(draw);
        }

        public abstract void Name(string name);

        public int X { get; set; }
        public abstract int y { get; set; }
    }
    // abstractפונקציות ופרופ שהם לא 
    //לא ניתן להשתמש בהן מחוץ לפונצקיות
    //https://webmaster.org.il/articles/csharp-oop-abstract/
    public class circle:Shape
    {
        public override void Name(string name)
        {
            Console.WriteLine(name+ " its me");    
            base.print(name);
        }
        public override int y { get; set; }
        
    }
}
