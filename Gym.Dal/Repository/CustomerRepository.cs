using AutoMapper;
using Gym.Dal.AutoMapper;
using Gym.Dal.Dao;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym.Dal.Repository
{
    public class CustomerRepository
    {
        private readonly Context _context;
        private readonly DalProfile _dalProfile;
        private readonly MapperConfiguration config;
        private readonly Mapper mapper;

        public CustomerRepository()
        {
            _context = new Context();
            _dalProfile = new DalProfile();
            config = new MapperConfiguration(c =>
            {
                c.AddProfile(_dalProfile);
            });
            mapper = new Mapper(config);
        }
        public void AddCustomer(Domain.DomainEntity.Customer customer)
        {
            var definitiveCustomer = mapper.Map<Customer>(customer);
            _context.Customers.Add(definitiveCustomer);
            _context.SaveChanges();
            
        }

        public void DeleteCustomer(int id)
        {
            var del = _context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            _context.Customers.Remove(del);
            _context.SaveChanges();
        }

        int maxRows = 5;
        public List<Domain.DomainEntity.Customer> ReadCustomers(int currentPage)
        {
            var lCustomers = _context.Customers.OrderBy(x => x.NameCustomer).Skip((currentPage - 1) * maxRows).Take(maxRows).ToList();
            var definitiveCustomer = mapper.Map<List<Domain.DomainEntity.Customer>>(lCustomers);
            return definitiveCustomer;
        }

        public int GetPageCount()
        {
            double pageCount = (double)((decimal)_context.Customers.Count() / Convert.ToDecimal(maxRows));
            return (int)Math.Ceiling(pageCount);
        }

        public Domain.DomainEntity.Customer ReadCustomerFromId(int id)
        {
            var lCustomer = _context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            var definitiveCustomer = mapper.Map<Domain.DomainEntity.Customer>(lCustomer);
            return definitiveCustomer;
        }

        public Domain.DomainEntity.Customer ReadCustomerFromName(string surname, string name)
        {
            var lCustomer = _context.Customers.Where(x => x.SurnameCustomer == surname && x.NameCustomer == name).FirstOrDefault();
            var definitiveCustomer = mapper.Map<Domain.DomainEntity.Customer>(lCustomer);
            return definitiveCustomer;
        }

    

        public string EditCustomer(Domain.DomainEntity.Customer customer)
        {
            var definitiveCustomer = mapper.Map<Gym.Dal.Dao.Customer>(customer);
            var lCustomer = _context.Customers.Where(x => x.CustomerId == definitiveCustomer.CustomerId).FirstOrDefault();
            if (lCustomer!=null)
            {
                _context.Customers.Attach(lCustomer);
                _context.Entry(lCustomer).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return "customer updated";
            }
            return "error customer not found";

        }

        public string UpdateCustomerTwo(Domain.DomainEntity.Customer customer)
        {
            var definitiveCustomer = mapper.Map<Gym.Dal.Dao.Customer>(customer);

            var lCustomer = _context.Customers.Where(x => x.CustomerId == definitiveCustomer.CustomerId).FirstOrDefault();
            if (lCustomer != null)
            {
                _context.Customers.AddOrUpdate(definitiveCustomer);
                _context.SaveChanges();
                return "customer updated";
            }
            return "error customer not found";

        }
    }

}
