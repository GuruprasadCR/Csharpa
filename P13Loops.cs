using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpa
{
    public class P13
    {
        static void Main()
        {
            //While loop
          //  Console.WriteLine("Enter a value");
          //  int a = int.Parse (Console.ReadLine());

          //int  start = 0;
          //  while (start<=a)
          //  {
          //      Console.Write(start+" ");
          //      start=start+2;

          //  }

            //For loop

            int[] vs = new int[] {1,2,3,4};

            for(int i=0; i<vs.Length; i++)
            {

                Console.WriteLine(vs[i]);
            }


            //Foreach loop-- for each loop is used to iterate over the collections
            //helps out of range exceptions

            foreach(int i in vs)
            {

                Console.WriteLine(i);
            }

        }


    }
}
