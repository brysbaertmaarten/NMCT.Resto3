using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Repositories
{
    public class ReviewRepository : BaseRepository, IReviewRepository
    {
        private const string _BASEURL = "https://restaurantfunction.azurewebsites.net/api/reviews";

        public Task<List<Review>> GetReviews(Guid restaurantId)
        {
            string url = String.Format("{0}?restaurantId={1}", _BASEURL, restaurantId);
            return GetAsync<List<Review>>(url);
        }

        public Task<Guid> PostReview(Guid restaurantId, Review review)
        {
            string url = String.Format("{0}?restaurantId={1}", _BASEURL, restaurantId);
            return PostAsync<Guid>(url, review);
        }
        

    }
}
