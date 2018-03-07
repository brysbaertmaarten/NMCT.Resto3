using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using NMCT.Resto.Core.Model;
using NMCT.Resto.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMCT.Resto.Core.ViewModels
{
    public class TabInfoViewModel : MvxViewModel
    {

        private string _name = "nmct";

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        Restaurant _restaurantContent;

        public Restaurant RestaurantContent
        {
            get { return _restaurantContent; }
            set
            {
                _restaurantContent = value;
                RaisePropertyChanged(() => RestaurantContent);
            }
        }

        protected readonly IRestoDataService _restoDataService;
        public TabInfoViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;
            //ChooseRandomRestaurant();
        }

        //private async void ChooseRandomRestaurant()
        //{
        //    RestaurantContent = await _restoDataService.GetRandomRestaurant();
        //    RestaurantContent.Reviews = await _restoDataService.GetReviews(RestaurantContent.Id);
        //    RaisePropertyChanged(() => RestaurantContent);
        //}

    }
}
