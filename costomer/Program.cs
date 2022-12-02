Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace costomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Costomer c1 = new Costomer(101, "Ädam", true, 5000);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PropertiesExample
{
    class Customer
    {
        int _CustId;
        String _CName;
        bool _Status;
        int _Balance;
        public Customer(int CustId, String CName, bool Status, int
       Balance)
        {
            this._CustId = CustId;
            this._CName = CName;
            this._Status = Status;
            this._Balance = Balance;
        }
        public int CustId
        {
            get { return _CustId; }//getting property
            set { _CustId = value; }//setting
        }
        public String CName
        {
            get { return _CName; }//getting property

            set
            {
                if (_Status == true)
                    _CName = value;
            }
            //setting
        }
        public bool Status
        {
            get { return _Status; }//getting property
            set { _Status = value; }//setting
        }
        public int Balance
        {
            get { return _Balance; }//getting property
            set
            {
                if (_Status == true)
                    if (value > 500)
                        _Balance = value;
            }//setting
        }
    }
}