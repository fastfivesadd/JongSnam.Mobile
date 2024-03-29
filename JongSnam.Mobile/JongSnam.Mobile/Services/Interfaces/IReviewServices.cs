﻿using System.Threading.Tasks;
using JongSnamService.Models;

namespace JongSnam.Mobile.Services.Interfaces
{
    public interface IReviewServices
    {
        Task<SumaryRatingDto> GetReviewByStoreId(int storeId, int currentPage, int pageSize);

        Task<bool> AddReview(ReviewRequest reviewRequest);
    }
}
