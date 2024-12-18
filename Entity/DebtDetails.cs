using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMoneyTracker.Entity
{
    public class DebtDetails
    {
        public Guid Id { get; set; }
        public  int DebtAmount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [ForeignKey("Transaction")]
        public Guid TransactionId { get; set; }
        public Transaction Transactions { get; set; }
    }
}
