using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster
{
    public class CreateSectionMasterCommand : IRequest<Response<CreateSectionMasterDto>>
    {
        public string? Title { get; set; }
        //public IFormFile? ImageFile { get; set; }
        
        public string? FileName { get; set; }
        public string? ShortDescription { get; set; }
        public int? TotalViews { get; set; }    
        public string? KeyWords { get; set; }
        public string? CategoryType { get; set; }
        public string? LongDescription { get; set; }
        public string DynamicData { get; set; }
       
    }
}
