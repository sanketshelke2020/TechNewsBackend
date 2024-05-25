using MediatR;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Commands.DeleteSectionMaster
{
    public class DeleteSectionMasterCommandHandler : IRequestHandler<DeleteSectionMasterCommand, Response<bool>>
    {
        private readonly ISectionMasterRepository _sectionMasterRepository;

        public DeleteSectionMasterCommandHandler(ISectionMasterRepository sectionMasterRepository)
        {
            this._sectionMasterRepository = sectionMasterRepository;
        }

        async Task<Response<bool>> IRequestHandler<DeleteSectionMasterCommand, Response<bool>>.Handle(DeleteSectionMasterCommand request, CancellationToken cancellationToken)
        {
            bool isDeleted = await _sectionMasterRepository.DeleteByIdAsync(request.SectionMasterId);
            return new Response<bool>(isDeleted);
        }
    }
}
