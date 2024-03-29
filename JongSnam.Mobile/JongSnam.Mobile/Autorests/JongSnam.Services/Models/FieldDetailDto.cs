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

    public partial class FieldDetailDto
    {
        /// <summary>
        /// Initializes a new instance of the FieldDetailDto class.
        /// </summary>
        public FieldDetailDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FieldDetailDto class.
        /// </summary>
        public FieldDetailDto(int? id = default(int?), string name = default(string), double? price = default(double?), string size = default(string), bool? isOpen = default(bool?), DiscountModel discountModel = default(DiscountModel), IList<ImageFieldModel> imageFieldModel = default(IList<ImageFieldModel>), bool? active = default(bool?))
        {
            Id = id;
            Name = name;
            Price = price;
            Size = size;
            IsOpen = isOpen;
            DiscountModel = discountModel;
            ImageFieldModel = imageFieldModel;
            Active = active;
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
        public double? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isOpen")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountModel")]
        public DiscountModel DiscountModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageFieldModel")]
        public IList<ImageFieldModel> ImageFieldModel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool? Active { get; set; }

    }
}
