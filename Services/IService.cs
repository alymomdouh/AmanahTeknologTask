using System.Collections.Generic;

namespace AmanahTeknologTask.Services
{
    public interface IService<AddT, ListT> where AddT : class,new() where ListT : class, new()
        //,UpdateT,DetailsT   where UpdateT : class,new() where DetailsT : class,new() 
    {
        int Insert(AddT T);
       //void Update(UpdateT T);
       // DetailsT GetById(int Id);
        List<ListT> GetList();
       //void Delete(int Id);
    }
}
