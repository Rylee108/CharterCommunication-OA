using CharterCommunicationCore.Contracts.Repositories;
using CharterCommunicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationInfrastructure.Repositories
{
    public class CCTransactionRepository : ICCTransactionRepository
    {
        public IEnumerable<Transaction> GetAllTransactions()
        {
            var transactions = new List<Transaction>();
            transactions.Add(new Transaction()
            {
                CCTransactionId = 1,
                CCTransactionDate = DateTime.Today.AddMonths(-1),
                CCCustomerId = 1,
                CCTotalAmount = 120
            });
            transactions.Add(new Transaction()
            {
                CCTransactionId = 2,
                CCTransactionDate = DateTime.Today.AddMonths(-2),
                CCCustomerId = 2,
                CCTotalAmount = 115
            });
            transactions.Add(new Transaction()
            {
                CCTransactionId = 3,
                CCTransactionDate = DateTime.Today.AddMonths(-4),
                CCCustomerId = 3,
                CCTotalAmount = 150
            });
            return transactions;
        }

        
    }
}
