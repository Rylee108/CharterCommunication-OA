using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationCore.Contracts.Services
{
    public interface ICCTransactionServices
    {
        decimal GetRewardPointsEachMonth(int CCcustomerId, int MonthsRecords);
        decimal GetThreeMonthsRewardPoints(int CCcustomerId);
    }
}
