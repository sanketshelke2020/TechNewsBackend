using TechNews.Application.Features.Events.Queries.GetEventsExport;
using System.Collections.Generic;

namespace TechNews.Application.Contracts.Infrastructure
{
    public interface ICsvExporter
    {
        byte[] ExportEventsToCsv(List<EventExportDto> eventExportDtos);
    }
}
