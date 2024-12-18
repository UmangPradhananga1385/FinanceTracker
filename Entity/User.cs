using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalMoneyTracker.Eums;

namespace PersonalMoneyTracker.Entity
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public int ContactNumber { get; set; }
        public string  Email { get; set; }
        public string Address { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public string Password { get; set; }
    }
}
