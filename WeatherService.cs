namespace WeatherConnects;

public class WeatherService
{
    private readonly OpenMeteo.OpenMeteoClient _client;

    public WeatherService()
    {
        _client = OpenMeteoClient.Instance.Client;
    }

    public async Task<WeatherForecast?> GetWeatherAsync(string location)
    {
        return await _client.QueryAsync(location);
    }
}