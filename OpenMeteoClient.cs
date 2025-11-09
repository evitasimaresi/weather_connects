using OpenMeteo;

namespace WeatherConnects;

        // Before using the library you have to create a new client. 
        // Once created you can reuse it for every other api call you are going to make. 
        // There is no need to create multiple clients.

public class OpenMeteoClient
{
    private static OpenMeteoClient? _instance;
    private static readonly object _lock = new object();
    private OpenMeteo.OpenMeteoClient _client;

    private OpenMeteoClient()
    {
        _client = new OpenMeteo.OpenMeteoClient();
    }

    public static OpenMeteoClient Instance
    {
        get
        {
            if (_instance == null)
            {
                lock(_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new OpenMeteoClient();
                    }
                }
            }
            return _instance;
        }
    }

    public OpenMeteo.OpenMeteoClient Client
    {
        get {return _client;}
    }
}