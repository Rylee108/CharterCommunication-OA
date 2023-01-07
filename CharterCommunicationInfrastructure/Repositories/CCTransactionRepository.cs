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
                CCTransactionId = 001,
                CCTransactionDate = DateTime.Today.AddMonths(-3),
                CCCustomerId = 001,
                CCTotalAmount = 90
            });
            transactions.Add(new Transaction()
            {
                CCTransactionId = 002,
                CCTransactionDate = DateTime.Today.AddMonths(-1),
                CCCustomerId = 002,
                CCTotalAmount = 125
            });
            transactions.Add(new Transaction()
            {
                CCTransactionId = 003,
                CCTransactionDate = DateTime.Today.AddMonths(-5),
                CCCustomerId = 003,
                CCTotalAmount = 150
            });
            return transactions;
        }

        
    }
}
