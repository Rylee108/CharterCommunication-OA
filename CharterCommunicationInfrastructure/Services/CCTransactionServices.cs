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
            var cctransactions = _cctransactionRepository.GetAllTransactions();
            var transactionsByCustomer = cctransactions.Where(t => t.CCCustomerId == CCcustomerId &&
                                                                 ((DateTime.Today.Year - t.CCTransactionDate.Year) * 12 +
                                                                     DateTime.Today.Month - t.CCTransactionDate.Month == MonthsRecords));
            decimal rewardpoints = 0;
            foreach (var transaction in transactionsByCustomer)
            {
                rewardpoints += GetRewards(transaction.CCTotalAmount);
            }

            return rewardpoints;
        }

        public decimal GetThreeMonthsRewardPoints(int CCcustomerId)
        {
            var cctransactions = _cctransactionRepository.GetAllTransactions()
                .Where(t => t.CCCustomerId == CCcustomerId && ((DateTime.Today.Year - t.CCTransactionDate.Year) * 12 +
                    DateTime.Today.Month - t.CCTransactionDate.Month <= 3)); ;
            decimal rewardpoints = 0;
            foreach (var transactions in cctransactions)
            {
                rewardpoints += GetRewards(transactions.CCTotalAmount);
            }

            return rewardpoints;
        }

        private decimal GetRewards(decimal totalAmount)
        {
            decimal rewardpoints = 0;
            if (totalAmount > 100)
            {
                rewardpoints += (totalAmount - 100) * 2;
            }

            if (totalAmount > 50)
            {
                rewardpoints += Math.Min(totalAmount, 100) - 50;
            }

            return rewardpoints;
        }
    }
}
