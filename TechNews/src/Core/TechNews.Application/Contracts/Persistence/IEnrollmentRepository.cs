using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IEnrollmentRepository : IAsyncRepository<Enrollment>
    {
        Task<bool> EnrollmentDone(int userId, int webinarId);
        public Task<Enrollment> GetEnrollmentByUserAndWebinarId(int userId, int webinarId);
        Task<List<Enrollment>> GetAllEnrolledUser(int WebinarId);

    }
}
