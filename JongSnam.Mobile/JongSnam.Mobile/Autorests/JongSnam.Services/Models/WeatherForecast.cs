// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WeatherForecast
    {
        /// <summary>
        /// Initializes a new instance of the WeatherForecast class.
        /// </summary>
        public WeatherForecast()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WeatherForecast class.
        /// </summary>
        public WeatherForecast(System.DateTime? date = default(System.DateTime?), int? temperatureC = default(int?), int? temperatureF = default(int?), string summary = default(string))
        {
            Date = date;
            TemperatureC = temperatureC;
            TemperatureF = temperatureF;
            Summary = summary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime? Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "temperatureC")]
        public int? TemperatureC { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "temperatureF")]
        public int? TemperatureF { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }

    }
}
