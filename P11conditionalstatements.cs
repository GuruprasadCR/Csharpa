using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpa
{
    public class P11
    {
        static void Main()
        {
            int Num = 10;
            int Numb = 20;

            //if condition
            if(Num==10 && Numb==20)
            {

                Console.WriteLine("valid nums");
            }


            //Switch statement

            Console.WriteLine("enter any number");

           int  UserNumber = int.Parse(Console.ReadLine());

            switch(UserNumber)
            {
                case 10:
                    Console.WriteLine("Entered number is 10");
                    break;

                case 20:
                    Console.WriteLine("Entered number is 20");
                    break;

                case 30:
                    Console.WriteLine("Entered number is 30");
                    break;

                 default:
                    Console.WriteLine("entered number is not 10 or 20 or 30");
                    break ;

            }

            //also we can writr

            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Entered number is {0}",UserNumber);
                    break;

                default:
                    Console.WriteLine("entered number is not 10 or 20 or 30");
                    break;

            }






        }

    }
}
