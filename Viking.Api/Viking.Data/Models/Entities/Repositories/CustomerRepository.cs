﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viking.Data.Models.Entities.Repositories
{
    interface ICustomerRepository
    {

    }
    class CustomerRepository : BaseRepository<tbl_Customer>, ICustomerRepository
    {

    }
}
