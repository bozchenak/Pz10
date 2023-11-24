using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Class1
    {
        int x;
        int y;
        public string show()
        {
            return $"{x} {y}";
        }
        public int mult()
        { 
            return x ^ y;
        }
    }
}
