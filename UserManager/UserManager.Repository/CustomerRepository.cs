using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using UserManager.Repository.Interfaces;
using UserManager.Repository.Entities;

namespace UserManager.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync(int skip, int take)
        {
            return await _context.Customers.Skip(skip).Take(take).ToListAsync();
        }
    }
}

