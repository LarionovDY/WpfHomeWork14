using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHomeWork14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                Title = "Хлеб",
                Price = (decimal)34.5,
                Category = ProductCategory.Food,
                ImageSource = "Data/food.png"
            });
            products.Add(new Product()
            {
                Title = "Телевизор",
                Price = (decimal)35200.95,
                Category = ProductCategory.Appliance,
                ImageSource = "Data/appliance.png"
            });
            products.Add(new Product()
            {
                Title = "Молоко",
                Price = (decimal)55.30,
                Category = ProductCategory.Food,
                ImageSource = "Data/food.png"
            });
            products.Add(new Product()
            {
                Title = "Парацетамол",
                Price = (decimal)110,
                Category = ProductCategory.Meds,
                ImageSource = "Data/meds.png"
            });
            products.Add(new Product()
            {
                Title = "Микроволновка",
                Price = (decimal)15700.555,
                Category = ProductCategory.Appliance,
                ImageSource = "Data/appliance.png"
            });
            lstBox.ItemsSource = products;
        }
    }
}
