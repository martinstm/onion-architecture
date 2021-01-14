using System;
using System.Collections.Generic;
using System.Text;

namespace Example.StrategyPattern.Models
{
    public class Route
    {
        public string Path { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
