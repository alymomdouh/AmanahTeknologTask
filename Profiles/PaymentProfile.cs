using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Dto.Shared;
using AutoMapper;
using System;

namespace AmanahTeknologTask.Profiles
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<PaymentVM, Payway>()
                .ForMember(des=>des.date, opt => opt.MapFrom(src => DateTime.Now.Date))
                .ForMember(des=>des.CardInformation, opt => opt.MapFrom(src => (src.PaymentType== PaymentWay.Card) ? src.paymentCardVM:null))
                .ForMember(des=>des.BankInformation, opt => opt.MapFrom(src => (src.PaymentType== PaymentWay.Bank) ? src.paymentBankVM:null))
                ;
            CreateMap<PaymentCardVM, CardInformation>()
                .ForMember(des => des.expireDate, opt => opt.MapFrom(src => src.expireDate))
                .ForMember(des => des.CardNumber, opt => opt.MapFrom(src => src.CardNumber))
                .ForMember(des => des.UserName, opt => opt.MapFrom(src => src.CardHolderName))
                // here i put only one client for IndividualClient sorry for this 
                //.ForMember(des => des.IndividualClientId, opt => opt.MapFrom(src => (src.ClientType == ClientType.IndividualClient)? 1: (int?)null))
                //.ForMember(des => des.CompanyClientId, opt => opt.MapFrom(src => (src.ClientType == ClientType.CompanyClient)? 1: (int?)null))
                .ForMember(des => des.CVC, opt => opt.MapFrom(src => src.CardCVC));
            CreateMap<PaymentBankVM, BankInformation>(); 
        }
    }
}
