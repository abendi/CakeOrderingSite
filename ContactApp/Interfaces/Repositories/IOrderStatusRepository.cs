﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Interfaces.Repositories
{
    public interface IOrderStatusRepository : IBaseRepository<OrderStatus>
    {
        OrderStatus GetNextLogicalStatusFor(int logicalOrder);
        OrderStatus GetFirstLogicalStatus();
    }
}
