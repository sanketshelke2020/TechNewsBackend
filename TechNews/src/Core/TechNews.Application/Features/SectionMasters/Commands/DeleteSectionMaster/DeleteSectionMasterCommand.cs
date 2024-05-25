using MediatR;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Commands.DeleteSectionMaster
{
    public class DeleteSectionMasterCommand : IRequest<Response<bool>>
    {
        public int SectionMasterId { get; set; }
    }
}
