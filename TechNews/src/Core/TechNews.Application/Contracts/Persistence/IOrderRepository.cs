﻿using TechNews.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IOrderRepository: IAsyncRepository<Order>
    {
        Task<List<Order>> GetPagedOrdersForMonth(DateTime date, int page, int size);
        Task<int> GetTotalCountOfOrdersForMonth(DateTime date);
    }
}
