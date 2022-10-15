using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Dto.Shared;
using AmanahTeknologTask.Unit_Of_Work;
using AutoMapper;

namespace AmanahTeknologTask.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IInvoiceService invoiceService;
        private readonly IProductService productService;

        public PaymentService(IUnitOfWork unitOfWork,
            IMapper _mapper,
            IInvoiceService invoiceService,
            IProductService productService
            )
        {
            this.unitOfWork = unitOfWork;
            this.mapper = _mapper;
            this.invoiceService = invoiceService;
            this.productService = productService;
        }
        public int PaymentByCard(PaymentVM paymentVM)
        {
            var data = mapper.Map<Payway>(paymentVM);
            unitOfWork.PayWayRepository.AddPaymentByCard(data);
            // here create dynamic invoice from this data for save time 
            unitOfWork.SaveChanges();
            paymentVM.Id = data.Id;
            return createInvoice(paymentVM);
        }
        public int PaymentByBank(PaymentVM paymentVM)
        {
            throw new System.NotImplementedException();
        }
        private int createInvoice(PaymentVM payway)
        {
            // can get productDetails by product service or unitOfWork
            var productDetails = unitOfWork.ProductRepository.GetById(payway.ProductId);
            var taxprice = (payway.ClientType == ClientType.CompanyClient) ?
                unitOfWork.TaxRepository.GetById(1).Value : 0;
            // CAN make it by mapper 
            return invoiceService.Insert(
                new AddInvoice
                {
                    date = System.DateTime.Now.Date,
                    PaywayId = payway.Id,
                    ProductId = payway.ProductId,
                    /// this for save time i put in database one record for CompanyClient and IndividualClient
                    /// and not make repostory for them 
                    CompanyClientId = (payway.ClientType == ClientType.CompanyClient) ? 1 : null,
                    IndividualClientId = (payway.ClientType == ClientType.IndividualClient) ? 1 : null,
                    TaxId = (payway.ClientType == ClientType.CompanyClient) ? 1 : null,
                    Totalprice = productDetails.Price + taxprice,
                }
                );
        }


    }
}
