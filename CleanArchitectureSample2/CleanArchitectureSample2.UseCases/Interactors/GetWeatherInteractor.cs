using CleanArchitectureSample2.Entities;
using CleanArchitectureSample2.UseCases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureSample2.UseCases.Interactors
{
    public class GetWeatherInteractor : IRequestHandler<string, WeatherEntity>
    {
        private readonly IRepository _repository;

        public GetWeatherInteractor(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }


        public WeatherEntity Handle(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            return _repository.GetWeather(data);
        }
    }
}
