using CleanArchitectureSample2.Entities;
using CleanArchitectureSample2.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample2.Repository
{
    public class WeatherRepository : IRepository
    {
        //private readonly IApi _api;
        //private readonly IMapper<WeatherData, WeatherEntity> _mapper;

        //public WeatherRepository(IApi api, IMapper<WeatherData, WeatherEntity> mapper)
        //{
        //    _api = api ?? throw new System.ArgumentNullException(nameof(api));
        //    _mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
        //}


        public WeatherEntity GetWeather(string cityName)
        {
            //    if (string.IsNullOrEmpty(cityName))
            //    {
            //        throw new System.ArgumentNullException(nameof(cityName));
            //    }

            //    return _mapper.MapFrom(_api.GetWeatherData(cityName));
            return null;
        }
    }
}
