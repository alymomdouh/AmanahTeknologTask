using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmanahTeknologTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService service; 

        public PaymentController(IPaymentService service)
        {
            this.service = service;
        }

        [HttpPost("payByCard")]
        public ActionResult payByCard(PaymentVM paymentVM)
        { 
            return Ok(service.PaymentByCard(paymentVM));
        }

    }
}
