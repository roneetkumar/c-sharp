using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCSATM.Bus
{
    public class clsAccount
    {
        //fields
        private string vNumber;
        private string vType;
        private string vStatus;
        private decimal vBalance;
        private DateTime vOpenDate;
        
        //public constructors
        public clsAccount(string Number, string Type, int Day, int Month, int Year, string Status, decimal Balance)
        {
            vNumber = Number;
            vType = Type;
            vOpenDate = new DateTime(Year, Month, Day);
            vStatus = Status;
            vBalance = Balance;
        }

        public clsAccount()
        {
            vNumber = vType = vStatus = "Not Defined";
            vBalance = 0;
        }

        //properties
        public string Number
        {
            get => vNumber;
        }

        public string Type
        {
            get => vType;
            set => vType = value;
        }

        public DateTime OpenDate
        {
            get => vOpenDate;
        }

        public string Status
        {
            get => vStatus;
            set => vStatus = value;
        }

        public decimal Balance
        {
            get => vBalance;
        }

        public void Open(string Number, string Type)
        {
            vNumber = Number;   // ReadOnly
            this.Type = Type;
            vOpenDate = DateTime.Today;
            this.Status = "active";
            vBalance = 0;
        }

        public Boolean Deposit(decimal Amount)
        {
            if(Amount <= 20000 && Amount >= 2)
            {
                vBalance = vBalance + Amount;
                return true;
            }   
            return false;
        }

        public int Withdraw(decimal Amount)
        {
            if (Amount < 20){return 2; }
            else if (Amount > 500) { return 1; }
            else if(Amount % 20 == 0) { return -1; }
            else if(Amount > vBalance) { return -2; }
            else
            {
                vBalance = vBalance - Amount;
                return 0;
            }
        }

        public string Consult()
        {
            string info;
            info = "Number : " + Number + 
                   "\nType : " + Type +
                   "\nOpenDate : " + vOpenDate.ToShortDateString() +
                   "\nStatus : " + Status + 
                   "\nBalance : " + vBalance + " $\n";
            return info;
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }
    }
}