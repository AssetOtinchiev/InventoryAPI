using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using InventoryAPI.Interfaces;
using InventoryAPI.Models;
using RepoDb;

namespace InventoryAPI.Repositories
{
    public class CustomerRepository : BaseRepository<Customer, SqlConnection>, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
            : base(connectionString)
        { }

        public Customer GetById(int id)
        {
            return Query(id).FirstOrDefault();
        }

        public Customer GetByName(string name)
        {
            return Query(e => e.Name == name).FirstOrDefault();
        }
        public int Insert2(Customer customer)
        {
            return Insert<int>(customer);
        }

        public int Update2(Customer customer)
        {
            return Update(customer);
        }

        public int Delete2(int id)
        {
            return Delete(id);
        }
    }
}
