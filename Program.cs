namespace WeatherConnects;

// using OpenMeteo;


// class Program
// {
//     static void Main(string[] args)
//     {
//         RunAsync(args[0]).GetAwaiter().GetResult();
        
//     }


//     static async Task RunAsync(string location)
//     {
//         // Before using the library you have to create a new client. 
//         // Once created you can reuse it for every other api call you are going to make. 
//         // There is no need to create multiple clients.
//         OpenMeteo.OpenMeteoClient client = new OpenMeteo.OpenMeteoClient();

//         // Make a new api call to get the current weather in "location"
//         WeatherForecast? weatherData = await client.QueryAsync(location);
//         try
//         {
//             if (weatherData != null && weatherData.Current.Temperature != null && weatherData.CurrentUnits.Temperature != null)
//             {
//                 // Output the current weather to console
//                 Console.WriteLine($@"
//     Weather in {location}
//         Temperature: {weatherData.Current.Temperature} {weatherData.CurrentUnits.Temperature}
//         Humidity: {weatherData.Current.Relativehumidity_2m} {weatherData.CurrentUnits.Relativehumidity_2m}
//         Rain: {weatherData.Current.Rain} {weatherData.CurrentUnits.Rain} 
//         ");
//             }
//         }
//         catch (Exception e)
//         {
//             Console.WriteLine($"An error occured: {e.Message}");
//         }
//     }
// }

class Program
{
    static void Main(string[] args)
    {
        if(arg.Length == 0)
        {
            throw new  ArgumentNullException(nameof (args), "Provide valid location.");
        }

        RunAsync(args[0]).GetAwaiter().GetResult();
    }

    static async Task RunAsync(string location)
    {
        var weatherService = new WeatherService();
        WeatherForecast? weatherData = await weatherService.GetWeatherAsync(location);
        try
        {
         if (weatherData != null && weatherData.Current.Temperature != null && weatherData.CurrentUnits.Temperature != null)
            {
                // Output the current weather to console
                Console.WriteLine($@"
    Weather in {location}
        Temperature: {weatherData.Current.Temperature} {weatherData.CurrentUnits.Temperature}
        Humidity: {weatherData.Current.Relativehumidity_2m} {weatherData.CurrentUnits.Relativehumidity_2m}
        Rain: {weatherData.Current.Rain} {weatherData.CurrentUnits.Rain} 
        ");
            }
        }
        catch (Exception e)
        {
                        Console.WriteLine($"An error occured: {e.Message}");
        }
    }
}
