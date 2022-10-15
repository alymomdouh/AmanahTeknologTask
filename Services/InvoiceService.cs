using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Unit_Of_Work;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AmanahTeknologTask.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public InvoiceService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = _mapper;
        }
        public int Insert(AddInvoice T)
        {
            var invoice = mapper.Map<Invoice>(T);
            unitOfWork.InvoiceRepository.Insert(invoice);
            unitOfWork.SaveChanges();
            return invoice.Id;
        }
        public List<ListInvoice> GetList()
        {
            throw new System.NotImplementedException();
        }

        public DetailsInvoice GetById(int Id)
        {
            // other are multi way to   include navagtion Properties
            // not use this beacase not config it 
            //var data= unitOfWork.InvoiceRepository.GetWhere(x=>x.Id==Id)
            //     .Include(x=>x.Tax)
            //     .Include(x=>x.CompanyClient)
            //     .Include(x=>x.IndividualClient)
            //     .Include(x=>x.Payway)
            //     .Include(x=>x.product);
            var data = unitOfWork.InvoiceRepository.GetWhere(x => x.Id == Id, "Tax,CompanyClient,IndividualClient,Payway,product,Payway.CardInformation,Payway.BankInformation").ToList().FirstOrDefault();
               var invoiceDetails = mapper.Map<DetailsInvoice>(data);
            return invoiceDetails;
        } 
    }
}
