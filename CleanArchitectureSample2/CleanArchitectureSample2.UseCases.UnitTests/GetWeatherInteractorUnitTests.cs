using System;
using System.Diagnostics.CodeAnalysis;
using CleanArchitectureSample2.Entities;
using CleanArchitectureSample2.UseCases.Interactors;
using CleanArchitectureSample2.UseCases.Interfaces;
using Moq;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace CleanArchitectureSample2.UseCases.UnitTests
{
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class GetWeatherInteractorUnitTests
    {
        private readonly WeatherEntity _weather = new WeatherEntity
        {
            Description = "Cloudy",
            MaxTemperature = 25,
            MinTemperature = 12
        };

        private GetWeatherInteractor _interactor;

        [OneTimeSetUp]
        public void SetUp()
        {
            var mock = new Mock<IRepository>();
            mock.Setup(repo => repo.GetWeather("Barcelona")).Returns(_weather);
            _interactor = new GetWeatherInteractor(mock.Object);
        }

        [Test]
        public void Constructor_WithNullParameters_ThrowsException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new GetWeatherInteractor(null));
            Assert.That(exception.Message, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void Constructor_WithValidParameters_ReturnObject()
        {
            var mock = new Mock<IRepository>();
            var interactor = new GetWeatherInteractor(mock.Object);
            Assert.IsNotNull(interactor);
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void GetWeather_WithNullOrEmptyOrWhitespaceValue_ThrowsException(string value)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _interactor.Handle(value));
            Assert.That(exception.Message, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void GetWeather_WithAnExistingValue_ReturnWeatherEntity()
        {
            var result = _interactor.Handle("Barcelona");
            Assert.NotNull(result);
            Assert.AreEqual(result.MaxTemperature, _weather.MaxTemperature);
            Assert.AreEqual(result.MinTemperature, _weather.MinTemperature);
            Assert.AreEqual(result.Description, _weather.Description);
        }

        [Test]
        public void GetWeather_WithNonExistingValue_ReturnNullEntity()
        {
            var result = _interactor.Handle("Madrid");
            Assert.Null(result);
        }
    }
}
