﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JongSnam.Mobile.Services.Base;
using JongSnam.Mobile.Services.Interfaces;
using JongSnamService.Models;

namespace JongSnam.Mobile.Services.Implementations
{
    public class ReviewServices : BaseServices, IReviewServices
    {
        public async Task<IEnumerable<SumaryRatingDto>> GetReviewByStoreId(int storeId, int currentPage, int pageSize)
        {
            var response = await JongSnamServices.GetReviewByStoreIdWithHttpMessagesAsync(storeId, currentPage, pageSize);

            return await GetRespondDtoHandlerHttpStatus<IEnumerable<SumaryRatingDto>>(response);
        }

        public async Task<bool> AddReview(ReviewRequest reviewRequest)
        {
            try
            {
                var response = await JongSnamServices.AddReviewWithHttpMessagesAsync(reviewRequest);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        }
}
