using TechNews.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace TechNews.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
