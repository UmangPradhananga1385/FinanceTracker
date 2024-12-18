using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PersonalMoneyTracker.Eums;

namespace PersonalMoneyTracker.Dto
{
    public class CreateTrasactionDto
    {
        public string TagName { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public TransactionType TrasactionType { get; set; }
    }
}
