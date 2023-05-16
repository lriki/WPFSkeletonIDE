using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace WpfSkeletonApp.Views.DockingHelper
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class VisibilityBooleanConverter : IValueConverter
    {
        #region Private Fields
        private bool _not = false;
        private bool _inverted = false;
        #endregion Private Fields

        #region Properties
        public bool Inverted
        {
            get => _inverted;
            set => _inverted = value;
        }

        public bool Not
        {
            get => _not;
            set => _not = value;
        }
        #endregion Properties

        #region Private Methods
        private object VisibilityToBool(object value)
        {
            if (value is not Visibility)
                return DependencyProperty.UnsetValue;

            return (Visibility)value == Visibility.Visible ^ Not;
        }

        private object BoolToVisibility(object value)
        {
            if (value is not bool)
                return DependencyProperty.UnsetValue;

            return (bool)value ^ Not ? Visibility.Visible : Visibility.Hidden;
        }
        #endregion Private Methods

        #region IValueConverter
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Inverted ? BoolToVisibility(value) : VisibilityToBool(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Inverted ? VisibilityToBool(value) : BoolToVisibility(value);
        }
        #endregion IValueConverter
    }
}
