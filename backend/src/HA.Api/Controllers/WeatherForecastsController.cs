using HA.Application.UseCases.WeatherForecasts.GetWeatherForecasts;
using Microsoft.AspNetCore.Mvc;
using HA.Domain.Entities;

namespace HA.Api.Controllers;

[ApiController]
[Route("weather-forecasts")]
public class WeatherForecastsController : ApiControllerBase
{
    [HttpGet]
    public Task<WeatherForecast[]> Get()
        => Sender.Send(new GetWeatherForecastsQuery());
}
