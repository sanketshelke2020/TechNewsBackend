﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByDate
{
    public class GetSectionMasterByDateQuery : IRequest<Response<List<GetSectionMasterByDateDto>>>
    {

    }
}