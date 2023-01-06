using CharterCommunicationCore.Entities;
using CharterCommunicationCore.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharterCommunicationInfrastructure.HelpersFun
{
    public static class ModelWrap
    {
        public static TransactionRespModel ToTransactionRespModel(this Transaction transaction)
        {
            return new TransactionRespModel
            {
                CCTransactionId = transaction.CCTransactionId,
                CCTransactionDate = transaction.CCTransactionDate,
                CCCustomerId = transaction.CCCustomerId,
                CCTotalAmount = transaction.CCTotalAmount
            };
        }
    }
}
