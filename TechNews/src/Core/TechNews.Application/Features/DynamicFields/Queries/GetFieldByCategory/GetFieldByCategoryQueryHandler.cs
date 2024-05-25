//using AutoMapper;
//using MediatR;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechNews.Application.Contracts.Persistence;
//using TechNews.Application.Features.Articles.Queries.GetArticleById;
//using TechNews.Application.Responses;
//using TechNews.Domain.Entities;

//namespace TechNews.Application.Features.DynamicFields.Queries.GetFieldByCategory
//{
//    public class GetFieldByCategoryQueryHandler : IRequestHandler<GetFieldByCategoryQuery, Response<List<DynamicField>>>
//    {
//        private readonly IMapper _mapper;
//        private readonly IDynamicFieldRepository _dynamicFieldRepository;
//        private readonly ILogger<GetFieldByCategoryQueryHandler> _logger;
//        public GetFieldByCategoryQueryHandler(IMapper mapper, IDynamicFieldRepository dynamicFieldRepository, ILogger<GetFieldByCategoryQueryHandler> logger)
//        {
//            _mapper = mapper;
//            _dynamicFieldRepository = dynamicFieldRepository;
//            _logger = logger;
//        }

//        async Task<Response<List<DynamicField>>> IRequestHandler<GetFieldByCategoryQuery, Response<List<DynamicField>>>.Handle(GetFieldByCategoryQuery request, CancellationToken cancellationToken)
//        {
//            _logger.LogInformation(" GetFieldByCategoryQueryHandler Initaiated");
//            List<DynamicField> dynamicField =await  _dynamicFieldRepository.GetFieldByCategory(request.CategoryType);
//            var result = _mapper.Map<List<DynamicField>>(dynamicField);
//            return new Response<List<DynamicField>>(result);
//        }
//    }
//}
