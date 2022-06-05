using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class P7
    {
        static void Main()
        {
        //Implicit conversion
        Console.WriteLine("Implicit conversion");

        int a = 20;
        float b = (int)a;
        Console.WriteLine(b);

        Console.WriteLine("\nExplicit conversion");

        //typecasting method

        float G = 20.5467F;

        int h=(int)G;
        Console.WriteLine(h);

        //using convert class

        float i = 20.5467F;
        int j = Convert.ToInt32(i);
        Console.WriteLine(j);

        //Convert string to int

        Console.WriteLine("\n string conversion");

        string str = "100";

        int strnum = int.Parse(str);
        Console.WriteLine(strnum);

        string strn = "120k";
        int res;
       bool isconversionissuccess =  int.TryParse(strn,out res);

        if (isconversionissuccess)
        {

            Console.WriteLine(res);
        }
        else
        {


            Console.WriteLine("please enter a valid num");
        }
        

    }




    }

