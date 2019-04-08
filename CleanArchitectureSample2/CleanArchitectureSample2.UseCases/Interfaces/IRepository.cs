using CleanArchitectureSample2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample2.UseCases.Interfaces
{
    public interface IRepository
    {
        WeatherEntity GetWeather(string cityName);
    }
}
