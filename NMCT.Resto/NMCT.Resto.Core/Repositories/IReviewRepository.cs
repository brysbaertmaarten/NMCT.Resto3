using NMCT.Resto.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.Repositories
{
    public interface IReviewRepository
    {
        Task<List<Review>> GetReviews(Guid restaurantId);
        Task<Guid> PostReview(Guid restaurantId, Review review);
        
    }
}
