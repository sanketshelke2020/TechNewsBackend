using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetEventSheduleByIdCustomMapper : ITypeConverter<SectionMaster, GetEventSheduleByIdDto>
    {

        private readonly IMapper _mapper;
        public GetEventSheduleByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetEventSheduleByIdDto Convert(SectionMaster source, GetEventSheduleByIdDto destination, ResolutionContext context)
        {
            Byte[] bytes;
           

            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)

;
                bytes = ms.ToArray();
            }

           
           

            GetEventSheduleByIdDto dest = new GetEventSheduleByIdDto()
            {
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                EventScheduleID = source.EventSchedule.EventScheduleId,
                EventTopic = source.EventSchedule.EventTopic,
                EventDate = source.EventSchedule.EventDate,
                SpeakerName = source.EventSchedule.SpeakerName,
                YoutubeVideoLink = source.EventSchedule.YoutubeVideoLink,
                LongDescription = source.EventSchedule.LongDescription,
                CreatedDate = source.CreatedDate,
                
                Comments = _mapper.Map<ICollection<GetEventSheduleByIdCommentDto>>(source.Comments),


            };
            return dest;
        }
    }
}
