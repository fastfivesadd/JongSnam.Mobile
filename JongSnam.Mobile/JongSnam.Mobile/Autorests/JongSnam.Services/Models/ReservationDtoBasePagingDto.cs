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

    public partial class ReservationDtoBasePagingDto
    {
        /// <summary>
        /// Initializes a new instance of the ReservationDtoBasePagingDto
        /// class.
        /// </summary>
        public ReservationDtoBasePagingDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationDtoBasePagingDto
        /// class.
        /// </summary>
        public ReservationDtoBasePagingDto(int? currentPage = default(int?), int? totalPage = default(int?), IList<ReservationDto> collection = default(IList<ReservationDto>))
        {
            CurrentPage = currentPage;
            TotalPage = totalPage;
            Collection = collection;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currentPage")]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalPage")]
        public int? TotalPage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "collection")]
        public IList<ReservationDto> Collection { get; set; }

    }
}
