using AmanahTeknologTask.Domains;
using AmanahTeknologTask.Domains.Models;
using System.Collections.Generic;
using System.Linq;

namespace AmanahTeknologTask.Repositories
{
    public class ProductRepository: BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext _context):base(_context)
        {

        }
        public List<Product> GetAllBroducts()
        {
           
            return GetAll().ToList();
        }

        public void InsertBroduct(Product product)
        {
             Insert(product);
        }
        public void UpdateBroduct(Product product)
        {
            Update(product);
        }
        public void DeleteBroduct(int id)
        {
            Delete(id);
        }

        public bool CheckBroductExists(Product product)
        {
            return GetAny(b => b.Id == product.Id);
        }
        public Product GetBroductyId(int id)
        {
            return GetFirstOrDefault(b => b.Id == id);
        }

    }
}
