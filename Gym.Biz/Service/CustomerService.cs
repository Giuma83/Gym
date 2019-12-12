using Domain.DomainEntity;
using Gym.Dal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Biz.Service
{
    public class CustomerService
    {
        private CustomerRepository repo;

        public CustomerService()
        {
            repo = new CustomerRepository();
        }


        public void AddCustomer(Customer customer)
        {
            repo.AddCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            repo.DeleteCustomer(id);
        }

        public List<Customer> ReadCustomers(int currentPage)
        {
            var listCusteomer = repo.ReadCustomers(currentPage);
            return listCusteomer;
        }

        public Domain.DomainEntity.Customer ReadCustomerFromId(int id)
        {
            var customer = repo.ReadCustomerFromId(id);
            return customer;
        }

        public int GetPageCount()
        {
            return repo.GetPageCount();
        }
        public Domain.DomainEntity.Customer ReadCustomerFromName(string surname, string name)
        {
            var customer = repo.ReadCustomerFromName(surname, name);
            return customer;
        }



        public string EditCustomer(Customer customer)
        {
            return repo.UpdateCustomerTwo(customer);
        }

        public string UpdateCustomerTwo(Customer customer)
        {
           string AnswerCustomer = repo.UpdateCustomerTwo(customer);
            return AnswerCustomer;
        }
    }
}
