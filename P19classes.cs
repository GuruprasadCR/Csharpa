using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19
{
    public class Customer
    {
        string _firstname;
        string _lastname;

        //public Customer()  
        //     : this ("Please enter the values","Please enter the values");
        // {

        // }


        public Customer(string FirstName, string LastName)
        {

            this._firstname = FirstName;
            this._lastname = LastName;
        }

        public void print()
        {
            Console.WriteLine("{0}{1}", _firstname, _lastname);
        }

    }

    public class main
    {
        static void Main()
        {
            Customer c1 = new Customer("Guru", "prasad");
            c1.print();
            //Customer c2 = new Customer();
            //c2.print();


        }


    }
}


