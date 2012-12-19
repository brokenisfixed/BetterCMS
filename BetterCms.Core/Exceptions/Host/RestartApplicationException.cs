﻿using System;

namespace BetterCms.Core.Exceptions.Host
{
    public class RestartApplicationException : CmsException
    {
        public RestartApplicationException(string message)
            : base(message)
        {
        }

        public RestartApplicationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
