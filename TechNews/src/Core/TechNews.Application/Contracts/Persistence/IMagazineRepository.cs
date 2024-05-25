using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IMagazineRepository:IAsyncRepository<Magazine>
    {
        Task<List<SectionMaster>> GetAllMagazine();
        Task<SectionMaster> GetMagazineById(int id);
    }
}
