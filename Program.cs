using OpenMeteo;

class Program
{
    static void Main()
    {
        RunAsync().GetAwaiter().GetResult();
    }

    static async Task RunAsync()
    {
        // Before using the library you have to create a new client. 
        // Once created you can reuse it for every other api call you are going to make. 
        // There is no need to create multiple clients.
        OpenMeteo.OpenMeteoClient client = new OpenMeteo.OpenMeteoClient();

        // Make a new api call to get the current weather in tokyo
        WeatherForecast? weatherData = await client.QueryAsync("Tokyo");
        try
        {
            if (weatherData != null && weatherData.Current.Temperature != null && weatherData.CurrentUnits.Temperature != null)
            {
                // Output the current weather to console
                Console.WriteLine("Weather in Tokyo: " + weatherData.Current.Temperature + weatherData.CurrentUnits.Temperature);
                // Output: "Weather in Tokyo: 28.1°C
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured: {e.Message}");
        }
    }
}