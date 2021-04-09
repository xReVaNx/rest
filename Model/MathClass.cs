using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rest.Model
{
    public class MathClass
    {
        public int A { get; set; }
        public int B { get; set; }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
