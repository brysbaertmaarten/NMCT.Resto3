// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace NMCT.Resto.iOS
{
    [Register ("TabInfoView")]
    partial class TabInfoView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgRestaurant { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCuisines { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPriceRange { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblScore { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgRestaurant != null) {
                imgRestaurant.Dispose ();
                imgRestaurant = null;
            }

            if (lblAddress != null) {
                lblAddress.Dispose ();
                lblAddress = null;
            }

            if (lblCuisines != null) {
                lblCuisines.Dispose ();
                lblCuisines = null;
            }

            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }

            if (lblPriceRange != null) {
                lblPriceRange.Dispose ();
                lblPriceRange = null;
            }

            if (lblScore != null) {
                lblScore.Dispose ();
                lblScore = null;
            }
        }
    }
}