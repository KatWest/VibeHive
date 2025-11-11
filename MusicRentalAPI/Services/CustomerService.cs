using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Services
{
    //additional customer service
    //what operations related to customers(add, get all, get by Id) 
    
    public class CustomerService : ICustomerService
    {
        private static readonly List<Customer> _customers = new();
        private static int nextCustomerId = 1; //Tracks the next available ID

        //add customer 
        public Customer Add(Customer customer)
        {
            customer.CustomerId = nextCustomerId++; ;
            _customers.Add(customer);
            return customer;
        }

        //get all customers 
        public List<Customer> GetAll() 
        {
            return _customers;
        }

        //get customer by id 
        public Customer? GetById(int customerId)
        {
            //Search the list of customers for a customer with the matching Id
            var customer = _customers.FirstOrDefault(c => c.CustomerId == customerId);

            // Return the customer if found, otherwise return null
            return customer;
        }

        //delete customer
        public bool Delete(int customerId)
        {
            var customer = GetById(customerId);
            if (customer == null) return false;
            _customers.Remove(customer);
            return true;
        }
    }
}
