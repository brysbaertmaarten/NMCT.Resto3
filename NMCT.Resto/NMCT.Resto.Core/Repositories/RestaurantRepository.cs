using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Repositories
{
    public class RestaurantRepository : BaseRepository, IRestaurantRepository
    {
        private const string _BASEURL = "https://restaurantfunction.azurewebsites.net/api/restaurants";
        private List<Restaurant> _restaurants;

        public async Task<List<Restaurant>> GetRestaurants()
        {
            string url = _BASEURL;
            if( _restaurants == null)
                _restaurants = await GetAsync<List<Restaurant>>(url);

            return _restaurants;
        }

        public async Task<Restaurant> GetRestaurantDetails(Guid id)
        {
            if (_restaurants == null) await GetRestaurants();
            return _restaurants.Where(resto => resto.Id == id)?.First();
        }
    }
}
