using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.UserQueries.Query.GetUserQueryById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetUserQueryByIdCustomMapper: ITypeConverter<Querie, GetUserQueryByIdDto>
    {
    

        public GetUserQueryByIdDto Convert(Querie source, GetUserQueryByIdDto destination, ResolutionContext context)
        {
            GetUserQueryByIdDto dest = new GetUserQueryByIdDto
            {
               QuerieId = source.QuerieId,
               UserId = source.UserId,
                FullName= source.FullName,
                JobDesignation = source.JobDesignation,
                CompanyName = source.CompanyName,
                EmailAddress = source.EmailAddress,
                MobileNumber = source.MobileNumber,
                Subject= source.Subject,
                Description = source.Description,
                CountryName = source.Country.CountryName,
                CountryId = source.CountryId,
                CategoryType = source.CategoryType,


            };
            return dest;
        }
    }
}
