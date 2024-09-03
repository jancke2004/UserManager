using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManager.Repository.Entities;

namespace UserManager.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync(int skip, int take);
        // Additional methods like Add, Update, Delete, etc.
    }
}

