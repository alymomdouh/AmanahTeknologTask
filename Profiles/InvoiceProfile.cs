using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AutoMapper;

namespace AmanahTeknologTask.Profiles
{
    public class InvoiceProfile : Profile
    {
        public InvoiceProfile()
        {
            CreateMap<AddInvoice, Invoice>();
            CreateMap<Invoice, ListInvoice>();

            CreateMap<Tax, DetailsTax>();
            CreateMap<Payway, PaymentVM>()
                .ForMember(des => des.paymentBankVM, opt => opt.MapFrom(src => src.BankInformation))
                .ForMember(des => des.paymentCardVM, opt => opt.MapFrom(src => src.CardInformation))
                .ForMember(des => des.date, opt => opt.MapFrom(src => src.date))
                .ForMember(des => des.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<Product,ListProduct>();
            CreateMap<CompanyClient,ListCompanyClient>();
            CreateMap<IndividualClient,ListIndividualClient>();
            CreateMap<Invoice, DetailsInvoice>()
                .ForMember(des => des.IndividualClient, opt => opt.MapFrom(src => src.IndividualClient))
                .ForMember(des => des.Tax, opt => opt.MapFrom(src => src.Tax))
                .ForMember(des => des.Payway, opt => opt.MapFrom(src => src.Payway))
                .ForMember(des => des.product, opt => opt.MapFrom(src => src.product))
                .ForMember(des => des.CompanyClient, opt => opt.MapFrom(src => src.CompanyClient));

            CreateMap<CardInformation,PaymentCardVM >()
                .ForMember(des => des.expireDate, opt => opt.MapFrom(src => src.expireDate))
                .ForMember(des => des.CardNumber, opt => opt.MapFrom(src => src.CardNumber))
                .ForMember(des => des.CardHolderName, opt => opt.MapFrom(src => src.UserName))
                // here i put only one client for IndividualClient sorry for this 
                //.ForMember(des => des.IndividualClientId, opt => opt.MapFrom(src => (src.ClientType == ClientType.IndividualClient)? 1: (int?)null))
                //.ForMember(des => des.CompanyClientId, opt => opt.MapFrom(src => (src.ClientType == ClientType.CompanyClient)? 1: (int?)null))
                .ForMember(des => des.CardCVC, opt => opt.MapFrom(src => src.CVC));
            CreateMap<BankInformation,PaymentBankVM >();
        }
    }
}
