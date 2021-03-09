// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdatePictureFieldRequest
    {
        /// <summary>
        /// Initializes a new instance of the UpdatePictureFieldRequest class.
        /// </summary>
        public UpdatePictureFieldRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdatePictureFieldRequest class.
        /// </summary>
        public UpdatePictureFieldRequest(string image, int? id = default(int?))
        {
            Image = image;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
        }
    }
}
