using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllEventScheduleCustomMapper : ITypeConverter<SectionMaster, EventScheduleListVm>
    {
        private readonly IMapper _mapper;
        public GetAllEventScheduleCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public EventScheduleListVm Convert(SectionMaster source, EventScheduleListVm destination, ResolutionContext context)
        {
            Byte[] bytes;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var mv = new MemoryStream())
            {
                fileStream.CopyTo(mv)

;
                bytes = mv.ToArray();
            }
            EventScheduleListVm dest = new EventScheduleListVm()
            {
                Title = source.Title,
                //Image = source.Image,
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

            };
            return dest;
        }
    }
}
