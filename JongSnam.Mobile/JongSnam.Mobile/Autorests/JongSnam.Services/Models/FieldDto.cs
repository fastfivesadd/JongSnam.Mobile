// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class FieldDto
    {
        /// <summary>
        /// Initializes a new instance of the FieldDto class.
        /// </summary>
        public FieldDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldDto class.
        /// </summary>
        public FieldDto(int? id = default(int?), string name = default(string), int? price = default(int?), string storeName = default(string), bool? isOpen = default(bool?), bool? active = default(bool?), IList<ImageFieldModel> imageFieldModel = default(IList<ImageFieldModel>))
        {
            Id = id;
            Name = name;
            Price = price;
            StoreName = storeName;
            IsOpen = isOpen;
            Active = active;
            ImageFieldModel = imageFieldModel;
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
        [JsonProperty(PropertyName = "price")]
        public int? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "storeName")]
        public string StoreName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isOpen")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageFieldModel")]
        public IList<ImageFieldModel> ImageFieldModel { get; set; }

    }
}
