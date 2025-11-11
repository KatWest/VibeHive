using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Controllers
{
    //additional controller: Customers/Users to handle customer management
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        //customer service used for handling biz logic
        private readonly ICustomerService _customerService;


        // Constructor injection: ASP.NET Core provides the service automatically
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //get list of all customers
        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerService.GetAll();
            return Ok(customers); // Return 200 OK with the list of customers
        }

        //get customer by ID
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            // Try to find the customer by ID
            var customer = _customerService.GetById(id);

            // If not found, return 404 Not Found
            if (customer == null)
                return NotFound("Customer not found.");

            //  return 200 OK with the customer details if found
            return Ok(customer);
        }

        //add new customer to system
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            // Validate input for emual and name
            if (string.IsNullOrWhiteSpace(customer.Name) || string.IsNullOrWhiteSpace(customer.Email))
                return BadRequest("Name and Email are required.");

            // Pass new customer to the service layer to add it
            var addedCustomer = _customerService.Add(customer);

            // Return a success message
            return Ok($"{addedCustomer.Name} has been added successfully.");
        }

       //delete custoemr by Id 
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            // Call the customerservice to delete the customer
            var success = _customerService.Delete(id);

            // Check if the deletion was successful
            if (success)
            {
                // If the customer was found and deleted
                return Ok("Customer was deleted successfully.");
            }
            else
            {
                // If no matching customer was found
                return NotFound("Customer not found.");
            }
        }
    }
}

