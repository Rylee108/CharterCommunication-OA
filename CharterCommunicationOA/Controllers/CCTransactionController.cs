using CharterCommunicationCore.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharterCommunicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CCTransactionController : ControllerBase
    {
        private readonly ICCTransactionServices _transactionService;

        public CCTransactionController(ICCTransactionServices transactionService)
        {
            _transactionService = transactionService;
        }


        [HttpGet]
        [Route("{customerId:int}")]
        public ActionResult<decimal> GetThreeMonthsRewardPoints(int customerId)
        {
            var rewards = _transactionService.GetThreeMonthsRewardPoints(customerId);
            return Ok(rewards);
        }

        [HttpGet]
        [Route("{customerId:int}/{MonthsRecords:int}")]
        public ActionResult<decimal> GetRewardPointsEachMonth(int customerId, int monthsFromNow)
        {
            var rewards = _transactionService.GetRewardPointsEachMonth(customerId, monthsFromNow);
            return Ok(rewards);
        }
    }
}
