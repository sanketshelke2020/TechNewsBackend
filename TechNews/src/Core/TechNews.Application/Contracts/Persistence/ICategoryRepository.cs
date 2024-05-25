﻿using TechNews.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TechNews.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
        Task<Category> AddCategory(Category category);
    }
}
