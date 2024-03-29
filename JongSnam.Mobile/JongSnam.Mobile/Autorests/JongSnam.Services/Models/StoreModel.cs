// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace JongSnamService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StoreModel
    {
        /// <summary>
        /// Initializes a new instance of the StoreModel class.
        /// </summary>
        public StoreModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoreModel class.
        /// </summary>
        public StoreModel(int? id = default(int?), System.DateTime? createdDate = default(System.DateTime?), System.DateTime? updatedDate = default(System.DateTime?), int? ownerId = default(int?), string name = default(string), string address = default(string), int? subDistrictId = default(int?), int? districtId = default(int?), int? provinceId = default(int?), string contactMobile = default(string), double? latitude = default(double?), double? longtitude = default(double?), string rules = default(string), string image = default(string), bool? isOpen = default(bool?), string officeHours = default(string))
        {
            Id = id;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
            OwnerId = ownerId;
            Name = name;
            Address = address;
            SubDistrictId = subDistrictId;
            DistrictId = districtId;
            ProvinceId = provinceId;
            ContactMobile = contactMobile;
            Latitude = latitude;
            Longtitude = longtitude;
            Rules = rules;
            Image = image;
            IsOpen = isOpen;
            OfficeHours = officeHours;
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
        [JsonProperty(PropertyName = "ownerId")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subDistrictId")]
        public int? SubDistrictId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "districtId")]
        public int? DistrictId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provinceId")]
        public int? ProvinceId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactMobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "longtitude")]
        public double? Longtitude { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public string Rules { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isOpen")]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "officeHours")]
        public string OfficeHours { get; set; }

    }
}
