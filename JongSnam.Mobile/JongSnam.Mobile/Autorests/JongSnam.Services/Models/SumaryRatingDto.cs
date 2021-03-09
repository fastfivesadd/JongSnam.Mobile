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

    public partial class SumaryRatingDto
    {
        /// <summary>
        /// Initializes a new instance of the SumaryRatingDto class.
        /// </summary>
        public SumaryRatingDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SumaryRatingDto class.
        /// </summary>
        public SumaryRatingDto(int? currentPage = default(int?), int? totalPage = default(int?), IList<ReviewDto> collection = default(IList<ReviewDto>), int? totalFive = default(int?), int? totalFour = default(int?), int? totalThree = default(int?), int? totalTwo = default(int?), int? totalOne = default(int?), double? summaryRating = default(double?))
        {
            CurrentPage = currentPage;
            TotalPage = totalPage;
            Collection = collection;
            TotalFive = totalFive;
            TotalFour = totalFour;
            TotalThree = totalThree;
            TotalTwo = totalTwo;
            TotalOne = totalOne;
            SummaryRating = summaryRating;
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
        public IList<ReviewDto> Collection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalFive")]
        public int? TotalFive { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalFour")]
        public int? TotalFour { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalThree")]
        public int? TotalThree { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalTwo")]
        public int? TotalTwo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalOne")]
        public int? TotalOne { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summaryRating")]
        public double? SummaryRating { get; set; }

    }
}