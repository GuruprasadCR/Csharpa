using Csharpasm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamA;
using TB=TeamB; // it called as allias directive

public static class P18Namespaces
    {

        public static void Main()
        {

        Teamx.Printa();
        TB.Teamx.Printa();
        P18asm.printassembly();

    }
   
    }

namespace TeamA
{
    public class Teamx
    {
        public static void Printa()
        {
            Console.WriteLine("Team A");
        }
    }
}

namespace TeamB
{
    public  class Teamx
    {
        public static void Printa()
        {
            Console.WriteLine("Team B");
        }
    }
}



