using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample2.Entities
{
    public class WeatherEntity
    {
        public string Description { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
    }
}
