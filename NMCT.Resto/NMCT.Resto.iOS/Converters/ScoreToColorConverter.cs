using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Platform.Converters;
using UIKit;

namespace NMCT.Resto.iOS.Converters
{
    public class ScoreToColorConverter : MvxValueConverter<double, UIColor>
    {
        protected override UIColor Convert(double value, Type targetType, object parameter, CultureInfo culture)
        {
            return GetColor(value);
        }

        private UIColor GetColor(double value){
            if (value < 4) return UIColor.Red;
            if (value >= 4 && value < 6) return UIColor.Orange;
            else return UIColor.Green;
        }
    }
}