using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
    public class Animal
    {
        public Animal(string Food,string Name) { }
        
        public string Food { get; set; }
        public string Name { get; set; }
        public int age { get; set; }

      public void Action ()
        {
           Console.WriteLine(string.Format("\nName: {0} {1}", Name, "jump"));
        }

    }


}
