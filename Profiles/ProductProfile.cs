using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AutoMapper;

namespace AmanahTeknologTask.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProduct, Product>();
        }
    }
}
