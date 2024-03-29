// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ImageFieldModel
    {
        /// <summary>
        /// Initializes a new instance of the ImageFieldModel class.
        /// </summary>
        public ImageFieldModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImageFieldModel class.
        /// </summary>
        public ImageFieldModel(int? id = default(int?), System.DateTime? createdDate = default(System.DateTime?), System.DateTime? updatedDate = default(System.DateTime?), int? fieldId = default(int?), string image = default(string))
        {
            Id = id;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            FieldId = fieldId;
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
        [JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "updatedDate")]
        public System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fieldId")]
        public int? FieldId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

    }
}
