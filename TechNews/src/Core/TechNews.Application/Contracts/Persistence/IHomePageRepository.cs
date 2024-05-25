using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IHomePageRepository:IAsyncRepository<SectionMaster>
    {
        List<SectionMaster> GetBreakingNews();

        Task<List<SectionMaster>> GettreandingVideo();


    }
    
}
