using AmanahTeknologTask.Domains.Models;
using AmanahTeknologTask.Dto;
using AmanahTeknologTask.Unit_Of_Work;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace AmanahTeknologTask.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper _mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = _mapper;
        }

        public List<ListProduct> GetList()
        {
            var data = unitOfWork.ProductRepository.GetAll().ToList();
            if (data.Count == 0)
            {
                return new List<ListProduct> { };
            }
            return mapper.Map<List<ListProduct>>(data);
        }
        public int Insert(AddProduct T)
        {
            var product = mapper.Map<Product>(T);
            unitOfWork.ProductRepository.Insert(product);
            return unitOfWork.SaveChanges();
        }
    }
}
