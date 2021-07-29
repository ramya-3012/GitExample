using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitExample
{
    public class Emp
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public string Message(string s)
        {
            return "Hello " + s;
        }

        public bool Check(int a,int b)
        {
            if (a == 42)
                return CheckTestPass();
            else
                return CheckTestFail();

        }
    }
}
