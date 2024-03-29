﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerServices 
    {
        List<Customer> GetAll();
        Customer GetById(int customerId);
    }
}
