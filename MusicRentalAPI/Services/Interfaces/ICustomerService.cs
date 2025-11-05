using MusicRentalAPI.Models;

namespace MusicRentalAPI.Services.Interfaces
{
    //additional customer interface
    public interface ICustomerService
    {
        Customer Add(Customer customer);
        List<Customer> GetAll();
        Customer? GetById(int customerId);
        bool Delete(int customerId);
    }
}
