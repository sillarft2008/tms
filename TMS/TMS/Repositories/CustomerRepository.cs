using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TMS.Models;

namespace TMS.Repositories
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> All { get; }

        IQueryable<Customer> AllIncluding(
            params Expression<Func<Customer, object>>[] includeProperties);

        Customer Find(int? id);
        void InsertOrUpdate(Customer dude);
        void Delete(int id);

    }
    public class CustomerRepository : ICustomerRepository
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Customer> All
        {
            get { return context.Customers; }
        }

        IQueryable<Customer> ICustomerRepository.All
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IQueryable<Customer> AllIncluding(params Expression<Func<Customer, object>>[] includeProperties)
        {
            IQueryable<Customer> query = context.Customers;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Customer Find(int? id)
        {
            return context.Customers.Find(id);
        }

        public void InsertOrUpdate(Customer dude)
        {
            if (dude.Id == default(int)) //if it is default int(0) than it is a new movie
            {
                context.Customers.Add(dude);
            }
            else
            {
                context.Entry(dude).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Customer dude = context.Customers.Find(id);
            context.Customers.Remove(dude);
            context.SaveChanges();
        }
    }
}