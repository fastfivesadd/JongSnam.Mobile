// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReviewDto
    {
        /// <summary>
        /// Initializes a new instance of the ReviewDto class.
        /// </summary>
        public ReviewDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReviewDto class.
        /// </summary>
        public ReviewDto(string name = default(string), string message = default(string), double? rating = default(double?))
        {
            Name = name;
            Message = message;
            Rating = rating;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rating")]
        public double? Rating { get; set; }

    }
}
