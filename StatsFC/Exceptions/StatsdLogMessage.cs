﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatsFC.Exceptions
{
    public class StatsdLogMessage
    {
        public string Message { get; set; }
        public EventType Weight { get; set; }
        public StatsdLogMessage(string message, EventType weight)
        {
            this.Message = message ?? string.Empty;
            Weight = weight;
        }
    }
}
