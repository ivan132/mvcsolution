﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Hosting;
using MvcSolution.Infrastructure.Logging;

namespace MvcSolution
{
    public class Logger
    {
        private static readonly ILogger _errorLogger;

        static Logger()
        {
            _errorLogger = new CommonLogger();
        }

        public static void Error(object message)
        {
            _errorLogger.Log(message);
        }
    }
}
