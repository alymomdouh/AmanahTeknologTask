using AmanahTeknologTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmanahTeknologTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            this.invoiceService = invoiceService;
        }
        [HttpGet("Get/{invoiceId}")]
        public IActionResult GetById(int invoiceId)
        {
            return Ok(invoiceService.GetById(invoiceId));
        }
    }
}
