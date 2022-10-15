using AmanahTeknologTask.Dto;

namespace AmanahTeknologTask.Services
{
    public interface IInvoiceService:IService<AddInvoice, ListInvoice>
    {
        DetailsInvoice GetById(int Id);
    }
}
