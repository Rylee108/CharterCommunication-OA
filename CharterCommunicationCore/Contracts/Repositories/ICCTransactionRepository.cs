using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Transactions;
using CharterCommunicationCore.Entities;


namespace CharterCommunicationCore.Contracts.Repositories
{
    public interface ICCTransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions();
    }
}
