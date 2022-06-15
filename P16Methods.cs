using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpa
{
    public class P16
    {

        public void Evennumber()
        {
            int start = 0;

            while(start <= 20)
            {

                Console.WriteLine(start);
                start = start + 2;
            }

        }

        //static method
        public static void Evennumber2()
        {
            int start = 0;

            while (start <= 40)
            {

                Console.WriteLine(start);
                start = start + 2;
            }

        }

        // with return datatype

        public int Add(int x, int y)
        {
            return x + y;

        }
        public static void Main()
        {
           P16 obj1= new P16();
            obj1.Evennumber();

            P16.Evennumber2();

            P16 obj2=new P16();
            int sum = obj2.Add(10, 20);
            Console.WriteLine(sum);


            int a = 0;
            P16.simplemethod(a);
            Console.WriteLine(a);

            int x = 0;
            P16.simplemethod2(ref x);
            Console.WriteLine(x);

        }

        /* there are 4 type of method parameters
         * 1.value parameter
         * 2.reference parameter
         * 3.Out parameter
         * 4.parameter arrays*/

        //value parameter
         public static void simplemethod(int j)
        {
            j = 100;

        }
        //pass by ref
        public static void simplemethod2(ref int k)
        {
            k = 100;

        }


    }
}
