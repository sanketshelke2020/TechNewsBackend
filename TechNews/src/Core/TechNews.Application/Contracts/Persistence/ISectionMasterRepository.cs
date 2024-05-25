using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface ISectionMasterRepository : IAsyncRepository<SectionMaster>
    {
        Task<bool> DeleteByIdAsync(int sectionMasterId);
        Task<SectionMaster> GetSectionByIdAsync(int sectionMasterId);
        Task<List<SectionMaster>> GetSectionMasterByCategory(string category);
        bool UpdateSection(SectionMaster section);
    }
}
