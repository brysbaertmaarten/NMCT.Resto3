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
    public class TabReviewViewModel : MvxViewModel
    {
        protected readonly IRestoDataService _restoDataService;
        public TabReviewViewModel(IRestoDataService restoDataService)
        {
            _restoDataService = restoDataService;
        }

        private RestoTabsViewModel _parentViewModel;
        public RestoTabsViewModel ParentViewModel
        {
            get { return _parentViewModel; }
            set {

                _parentViewModel = value;
                RaisePropertyChanged(() => ParentViewModel);
            }
        }

        private Review _newReview;
        public Review NewReview
        {
            get { return _newReview; }
            set {
                _newReview = value;
                RaisePropertyChanged(() => NewReview);
            }
        }

        public MvxCommand SaveReviewCommand
        {
            get{
                return new MvxCommand(() => SaveReview());
            }
        }

        private async void SaveReview()
        {
            bool succes = await _restoDataService.AddReview(ParentViewModel.RestaurantContent.Id, NewReview);
            if (succes) NewReview = new Review();
            ParentViewModel.GetRestaurantData();
        }


    }
}
