using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class P6
    {
        static void Main()
        {
            Console.WriteLine("Nullable");
            //To make value type to null use "?" symbol

            //bool? a = true;

            //if (a == null)
            //{

            //    Console.WriteLine(a.Value);
            //}

            Console.WriteLine("NullCoalescing operator");

            int? Ticketsonsale = 100;
            var availabletickets = Ticketsonsale ??0;
            Console.WriteLine(availabletickets);

        }

    }

