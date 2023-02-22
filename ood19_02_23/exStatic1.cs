using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ood19_02_23
{
    public static class exStatic1
    {
        //מאפיין סטטי בתוך מחלקה סטטית
        private static int counter;

        public static int Counter
        {
            get { return counter; }
        }

      
    }
    class Grade
    {
        //Static Data members:
        static int counter;
        static int sum;

        //Static Method:
        public static double Average()
        {
            return (double)sum / counter;
        }
    }
}
