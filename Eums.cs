using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyTracker
{
    public class Eums
    {
        public enum TransactionType
        {
            Debit=1 ,
            Credit=2,
            Debt=3
        }
        public enum CurrencyType
        {
            USD =1 ,
            NRP = 2
        }
    }
}
