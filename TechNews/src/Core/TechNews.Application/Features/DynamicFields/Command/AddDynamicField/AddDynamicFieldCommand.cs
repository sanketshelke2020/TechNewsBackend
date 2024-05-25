﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.DynamicFields.Command.AddDynamicField
{
    public class AddDynamicFieldCommand : IRequest<Response<AddDynamicFieldCommandDto>>
    {
        public int DynamicFieldId { get; set; }
        public string CategoryType { get; set; }
        public string LabelText { get; set; }
        public string? Options { get; set; }
        public string? PlaceHolder { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public string FieldType { get; set; }
        public bool? IsNumber { get; set; }

        public string FieldCode { get; set; }
    }
}
