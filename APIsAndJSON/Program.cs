namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            RonVSKanyeAPI ronVSKanyeAPI = new RonVSKanyeAPI();

            //ronVSKanyeAPI.RonMethod();
            //ronVSKanyeAPI.KayneMethod();

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    ronVSKanyeAPI.RonMethod();
                }
                else { ronVSKanyeAPI.KayneMethod(); }
            }

            OpenWeatherMapAPI weatherApi = new OpenWeatherMapAPI();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            weatherApi.WeatherCheck();
        }
    }
}
