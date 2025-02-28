﻿using Contracts.Common.Interfaces;
using Customer.API.Persistence;
using System.Collections.Generic;

namespace Customer.API.Repositories.Interfaces
{
    public interface ICustomerRepository:IRepositoryQueryBase<Customer.API.Entities.Customer,int, CustomerContext>
    {
        Task<Entities.Customer> GetCustomerByUserNameAsync(string username);
        Task<IEnumerable<Entities.Customer>> GetCustomersAsync();
    }
}
