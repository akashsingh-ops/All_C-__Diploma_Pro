using costomer;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101, "Ädam", true, 5000);
            Console.WriteLine("The Customer Id is : " + c1.CustId);
            c1.CustId = 102;
            Console.WriteLine("The Modified Customer Id is : " +
           c1.CustId);
            Console.WriteLine("The Customer Name is : " + c1.CName);
            c1.CName += " Smith";
            Console.WriteLine("The Modified Customer Name is : " +
           c1.CName);
            Console.WriteLine("The Customer Balance is : " +
           c1.Balance);
            c1.Balance -= 5000;
            Console.WriteLine("The Customer Modified Balance is : " +
           c1.Balance);
        }
    }
}
