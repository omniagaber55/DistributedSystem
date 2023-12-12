using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationaLibrary
{
    public class Operation:MarshalByRefObject
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
        public int mul(int x, int y)
        {
            return x * y;
        }
        public int div(int x, int y)
        {
            return x / y;
        }
        public int mod(int x, int y)
        {
            return x % y;
        }

    }
}
                                                                      