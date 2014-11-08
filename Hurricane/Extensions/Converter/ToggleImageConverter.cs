﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Hurricane.Extensions.Converter
{
    class ToggleImageConverter : IValueConverter
    {
        public string TrueImagePath { get; set; }
        public string FalseImagePath { get; set; }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
            {
                return new BitmapImage(new Uri(TrueImagePath, UriKind.Relative));
            }
            else
            {
                try
                {
                    return new BitmapImage(new Uri(FalseImagePath, UriKind.Relative));
                }
                catch (Exception)
                {

                    return null;
                }

            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }
}
