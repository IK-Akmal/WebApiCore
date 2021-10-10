using System;
using System.Collections.Generic;
using System.Linq;
using WebApiCore.Data.Context;
using WebApiCore.Data.Models;

namespace WebApiCore.Data.Repository
{
    public class CustomersRepository : IRepository<Customer>
    {
        private readonly WebApiCoreContext context;

        public CustomersRepository(WebApiCoreContext context)
        {
            this.context = context;
        }
        public IEnumerable<Customer> All => context.Customers.ToList();

        public void Add(Customer entity)
        {
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            context.Customers.Remove(entity);
            context.SaveChanges();
        }

        public Customer FindById(Guid id)
        {
            return context.Customers.FirstOrDefault(item => item.Id == id);
        }

        public void Update(Customer entity)
        {
            context.Customers.Update(entity);
            context.SaveChanges();
        }
    }
}