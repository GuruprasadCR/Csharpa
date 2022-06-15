using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpa
{
    public class P17
    {
        //Out parameter-->used when you need to return more thsn one value
        public static void calculate(int FN, int LN, out int sum, out int product)
        {

            sum = FN + LN;
            product = FN * LN;

        }


        //parameter arrays

        public static void paramsMethod(params int[] Numbers)
        {

            Console.WriteLine("There are {0} elements",Numbers.Length);

            foreach(int n in Numbers)
            {
                Console.WriteLine(n);
            }


        }


       public static void Main()
        {

          int  sum;
          int  product;
            P17.calculate(10, 20, out sum,out product);
            Console.WriteLine("sum={0},product={1}",sum,product);



            //params

            int[] Numbers = new int[]  { 1, 2, 3, 4, 5 };
            paramsMethod(Numbers);
           //P17.paramsMethod(1,2,3,4);

        }
    }
}
