using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            generics obj = new generics();
            obj.MUL<int>(5, 6);
            obj.DIV<float>(10.5f, 2.5f);

        }
    }
}
