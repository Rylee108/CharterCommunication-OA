using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationCore.Models.ResponseModels
{
    public class TransactionRespModel
    {
        public int CCTransactionId { get; set; }
        public DateTime CCTransactionDate { get; set; }
        public decimal CCTotalAmount { get; set; }
        public int CCCustomerId { get; set; }
    }
}
