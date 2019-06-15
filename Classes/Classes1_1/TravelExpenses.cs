using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1_1
{
    class TravelExpenses
    {
        public const decimal Rate = 2500;
        string account;
        decimal transport;
        int days;
        public TravelExpenses()
        {
            account = null;
            transport = 0;
            days = 0;
        }
        public TravelExpenses(string account,decimal transport,int days)
        {
            this.account = account;
            this.transport = transport;
            this.days = days;
        }
        public string Account
        {
            get => account;
            set => account = value;
        }
        public decimal Transport
        {
            get => transport;
            set => transport = value;
        }
        public int Days
        {
            get => days;
            set => days = value;
        }
        public decimal GetTotal()
        {
            return (transport + days * Rate);
        }
        public void Show()
        {
            Console.WriteLine(String.Format("rate={0}\nname={1}\ntransport={2}\ndays={3}\ntotal={4}", Rate, account, transport, days, GetTotal()));
        }
        public override string ToString()
        {
            return (String.Format("{0};{1};{2};{3};{4}",Rate,account,transport,days,GetTotal()));
        }
    }
}
