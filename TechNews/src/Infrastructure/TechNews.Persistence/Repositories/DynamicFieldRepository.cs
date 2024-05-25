using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class DynamicFieldRepository : BaseRepository<DynamicField>, IDynamicFieldRepository

    {
        private readonly ILogger _logger;
        public DynamicFieldRepository(ApplicationDbContext dbContext, ILogger<DynamicField> logger) : base(dbContext, logger)
        {
            _logger = logger;   
        }

        public Task<List<DynamicField>> DeleteDynamicField(int DynamicFieldId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DynamicField>> GetAllDynamicField()
        {
            List<DynamicField> dynamicFields = await _dbContext.DynamicFields.ToListAsync();
            return dynamicFields;   
        }

        public async Task<DynamicField> GetDynamicFieldById(int DynamicFieldId)
        {
            DynamicField dynamicField= await _dbContext.DynamicFields.Where(q=>q.DynamicFieldId==DynamicFieldId).FirstOrDefaultAsync();
            return dynamicField;
        }

       

        public Task<List<DynamicField>> UpdateDynamicField(int DynamicFieldId)
        {
            throw new NotImplementedException();
        }
        public  async Task<List<DynamicField>> GetDynamicFieldBycategory(string Category)
        {
           
            return await _dbContext.DynamicFields.Where(z => z.CategoryType == Category).ToListAsync();
            
        }

    }
}
