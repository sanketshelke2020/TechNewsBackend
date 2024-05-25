using AutoMapper;
using TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategoryQuery;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetDynamicFieldByCategoryCustomMapper : ITypeConverter<DynamicField, GetDynamicFieldByCategoryDto>
    {
        private readonly IMapper _mapper;
        public GetDynamicFieldByCategoryCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public GetDynamicFieldByCategoryDto Convert(DynamicField source, GetDynamicFieldByCategoryDto destination, ResolutionContext context)
        {
            GetDynamicFieldByCategoryDto dest = new GetDynamicFieldByCategoryDto
            {
                DynamicFieldId = source.DynamicFieldId,
                CategoryType = source.CategoryType,
                LabelText = source.LabelText,
                Options = source.Options,
                PlaceHolder = source.PlaceHolder,
                MaxLength = source.MaxLength,
                MinLength = source.MinLength,
                FieldCode = source.FieldCode,
                FieldType = source.FieldType,
                IsNumber = source.IsNumber,
                DynamicFormMultipleOptions = _mapper.Map<ICollection<MultipleOptionDto>>(source.DynamicFormMultipleOptions),
            };
            return dest;
        }
    }
}
