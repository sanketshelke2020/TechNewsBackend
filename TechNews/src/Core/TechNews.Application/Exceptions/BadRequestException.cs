﻿using System;
using System.Runtime.Serialization;

namespace TechNews.Application.Exceptions
{
    [Serializable]
    public class BadRequestException: ApplicationException
    {
        public BadRequestException(string message): base(message)
        {
        }

        protected BadRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
