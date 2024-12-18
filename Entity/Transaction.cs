using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalMoneyTracker.Eums;

namespace PersonalMoneyTracker.Entity
{
    public class Transaction
    {
        public Guid Id { get; set; }
        [ForeignKey("User")]
        public Guid UserId { get; set; }
        [ForeignKey("Tags")]
        public Guid TagId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TrasactionType { get; set; }
        public User Users { get; set; }
        public Tags Tags { get; set; }

    }
}
