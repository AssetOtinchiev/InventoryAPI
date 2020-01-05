using System;
using System.Collections.Generic;
using System.Text;
using InventoryAPI.Models;

namespace InventoryAPI.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        Customer GetByName(string name);
        int Insert2(Customer customer);
        int Update2(Customer customer);
        int Delete2(int id);
    }
}
