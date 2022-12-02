using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace costomer
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