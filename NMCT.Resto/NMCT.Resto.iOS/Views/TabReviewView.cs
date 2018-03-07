using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using NMCT.Resto.Core.ViewModels;
using System;
using UIKit;

namespace NMCT.Resto.iOS
{
    [MvxFromStoryboard(StoryboardName = "Main")]
    public partial class TabReviewView : MvxViewController
    {
        public TabReviewView (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MvxFluentBindingDescriptionSet<TabReviewView, TabReviewViewModel> set = this.CreateBindingSet<TabReviewView, TabReviewViewModel>();

            set.Bind(txtName).To(vm => vm.NewReview.UserName);
            set.Bind(txtScore).To(vm => vm.NewReview.Score);
            set.Bind(txtDate).To(vm => vm.NewReview.TimeStampOfVisit);
            set.Bind(txtComment).To(vm => vm.NewReview.Comment);
            set.Bind(btnSave).To(vm => vm.SaveReviewCommand);

            set.Apply();
        }
    }
}