using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IDynamicFieldRepository : IAsyncRepository<DynamicField>
    {
        Task<List<DynamicField>> GetAllDynamicField();
        public Task<List<DynamicField>> DeleteDynamicField(int DynamicFieldId);
        public Task<List<DynamicField>> UpdateDynamicField(int DynamicFieldId);
        public Task<DynamicField> GetDynamicFieldById(int DynamicFieldId);




        Task<List<DynamicField>> GetDynamicFieldBycategory(string Category);
    }
}
