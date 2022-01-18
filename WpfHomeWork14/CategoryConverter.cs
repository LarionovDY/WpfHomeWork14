using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WpfHomeWork14
{
    class CategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)     //конвертанция категории товаров из enum в string
        {
            switch ((ProductCategory)value)
            {
                case ProductCategory.Appliance:
                    return "Бытовая техника";
                case ProductCategory.Food:
                    return "Еда";
                case ProductCategory.Meds:
                    return "Медикаменты";
                default:
                    return "Неизвестна";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
