using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Services
{
    public class RestoDataService : IRestoDataService
    {
        private readonly IRestaurantRepository _restauarantRepository;
        private readonly IReviewRepository _reviewRepository;

        public RestoDataService(IRestaurantRepository restaurantRepository, IReviewRepository reviewRepository)
        {
            this._restauarantRepository = restaurantRepository;
            this._reviewRepository = reviewRepository;
        } 

        public async Task<List<Restaurant>> GetRestaurants()
        {
            return await _restauarantRepository.GetRestaurants();
        }

        public async Task<Restaurant> GetRandomRestaurant()
        {
            List<Restaurant> restaurants = await GetRestaurants();

            Random rnd = new Random();
            int r = rnd.Next(restaurants.Count);

            return restaurants[r];
        }

        public async Task<List<Review>> GetReviews(Guid restoId)
        {
            return await _reviewRepository.GetReviews(restoId);
        }

        public async Task<bool> AddReview(Guid restoId, Review review)
        {
            Guid id = await _reviewRepository.PostReview(restoId, review);

            if (id != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
