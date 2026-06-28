using ECommerceShowcaseWeb.Models;

namespace ECommerceShowcaseWeb.Services
{
    public class CustomerService
    {
        private readonly List<Customer> _customers = new();
        private readonly IdManagerService _idManager;

        public CustomerService(IdManagerService idManager)
        {
            _idManager = idManager;
        }

        public string SaveCustomer(Customer customer)
        {
            customer.Id = _idManager.GenerateUniqueCustomerId();
            _customers.Add(customer);
            return customer.Id;
        }

        public Customer? GetCustomerById(string id) =>
            _customers.FirstOrDefault(c => c.Id == id);
    }
}
