using CharterCommunicationCore.Contracts.Repositories;
using CharterCommunicationCore.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationInfrastructure.Services
{
    public class CCTransactionServices : ICCTransactionServices
    {
        private readonly ICCTransactionRepository _cctransactionRepository;

        public CCTransactionServices(ICCTransactionRepository transactionRepository)
        {
            _cctransactionRepository = transactionRepository;
        }

        public decimal GetRewardPointsEachMonth(int CCcustomerId, int MonthsRecords)
        {
            var transactions = _cctransactionRepository.GetAllTransactions();
            var transactionsByCustomer = transactions.Where(t => t.CCCustomerId == CCcustomerId &&
                                                                 ((DateTime.Today.Year - t.CCTransactionDate.Year) * 12 +
                                                                     DateTime.Today.Month - t.CCTransactionDate.Month == MonthsRecords));
            decimal rewards = 0;
            foreach (var transaction in transactionsByCustomer)
            {
                rewards += GetRewards(transaction.CCTotalAmount);
            }

            return rewards;
        }

        public decimal GetThreeMonthsRewardPoints(int CCcustomerId)
        {
            var transactions = _cctransactionRepository.GetAllTransactions()
                .Where(t => t.CCCustomerId == CCcustomerId && ((DateTime.Today.Year - t.CCTransactionDate.Year) * 12 +
                    DateTime.Today.Month - t.CCTransactionDate.Month <= 3)); ;
            decimal rewards = 0;
            foreach (var transaction in transactions)
            {
                rewards += GetRewards(transaction.CCTotalAmount);
            }

            return rewards;
        }

        private decimal GetRewards(decimal totalAmount)
        {
            decimal rewards = 0;
            if (totalAmount > 100)
            {
                rewards += (totalAmount - 100) * 2;
            }

            if (totalAmount > 50)
            {
                rewards += Math.Min(totalAmount, 100) - 50;
            }

            return rewards;
        }
    }
}
