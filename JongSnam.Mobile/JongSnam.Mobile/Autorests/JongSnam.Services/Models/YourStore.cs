// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class YourStore
    {
        /// <summary>
        /// Initializes a new instance of the YourStore class.
        /// </summary>
        public YourStore()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the YourStore class.
        /// </summary>
        public YourStore(int? id = default(int?), string name = default(string), string image = default(string))
        {
            Id = id;
            Name = name;
            Image = image;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

    }
}
