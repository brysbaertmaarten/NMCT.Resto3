using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Repositories
{
    public interface IRestaurantRepository
    {
        Task<List<Restaurant>> GetRestaurants();

        Task<Restaurant> GetRestaurantDetails(Guid id);
    }
}
