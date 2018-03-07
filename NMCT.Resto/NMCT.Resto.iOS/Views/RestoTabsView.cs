using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using NMCT.Resto.Core.ViewModels;
using System;
using UIKit;

namespace NMCT.Resto.iOS
{
    public partial class RestoTabsView : MvxTabBarViewController<RestoTabsViewModel>
    {
        public RestoTabsView(IntPtr handle) : base(handle)
        {
        }

        private bool _constructed;
        public RestoTabsView()
        {
            _constructed = true;
            ViewDidLoad();
        }

        public override void ViewDidLoad()
        {
            if (!_constructed) return;
            base.ViewDidLoad();
            CreateTabs();

            //MvxFluentBindingDescriptionSet<RestoTabsView, RestoTabsViewModel> set = this.CreateBindingSet<RestoTabsView, RestoTabsViewModel>();
        }
        
        private void CreateTabs()
        {
            var viewControllers = new UIViewController[]
            {
                CreateSingleTab("Info", ViewModel.TabInfoVM),
                CreateSingleTab("Review", ViewModel.TabReviewVM)
            };

            ViewControllers = viewControllers;

            SelectedViewController = ViewControllers[0];

            NavigationItem.Title = SelectedViewController.Title;

            ViewControllerSelected += (o, e) =>
            {
                NavigationItem.Title = TabBar.SelectedItem.Title;
            };
        }

        private UIViewController CreateSingleTab(string tabName, MvxViewModel tabViewModel)
        {
            var viewController = this.CreateViewControllerFor(tabViewModel) as UIViewController;

            tabViewModel.Start();

            viewController.Title = tabName;
            viewController.TabBarItem = new UITabBarItem() { Title = tabName };

            return viewController;

        }
    }
}