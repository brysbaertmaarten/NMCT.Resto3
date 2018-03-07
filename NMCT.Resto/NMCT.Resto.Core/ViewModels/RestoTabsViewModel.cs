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
    public class RestoTabsViewModel : MvxViewModel
    {
        private readonly Lazy<TabInfoViewModel> _tabInfoViewModel;
        public TabInfoViewModel TabInfoVM => _tabInfoViewModel.Value;

        private readonly Lazy<TabReviewViewModel> _tabReviewViewModel;
        public TabReviewViewModel TabReviewVM => _tabReviewViewModel.Value;

        protected readonly IRestoDataService _restoDataService;
        public RestoTabsViewModel(IRestoDataService restoDataService)
        {
            this._restoDataService = restoDataService;
            _tabInfoViewModel = new Lazy<TabInfoViewModel>(Mvx.IocConstruct<TabInfoViewModel>);
            _tabReviewViewModel = new Lazy<TabReviewViewModel>(Mvx.IocConstruct<TabReviewViewModel>);
            TabReviewVM.ParentViewModel = this;
            GetRestaurantData();
        }

        private Restaurant _restaurantContent;
        public Restaurant RestaurantContent
        {
            get { return _restaurantContent; }
            set {
                _restaurantContent = value;
                RaisePropertyChanged(() => RestaurantContent);
            }
        }

        public async void GetRestaurantData()
        {
            var restoList = await _restoDataService.GetRestaurants();
            RestaurantContent = restoList[3];
            RestaurantContent.Reviews = await _restoDataService.GetReviews(RestaurantContent.Id);
            RaisePropertyChanged(() => RestaurantContent);

            TabInfoVM.RestaurantContent = this.RestaurantContent;
        }
    }
}
