using System;
using System.Collections.Generic;
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

namespace asd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public zxcEntities d = db.Instance;
        public MainWindow()
        {
            InitializeComponent();
            zxcGrid.ItemsSource = d.Products.ToList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if(zxcGrid.SelectedItem != null)
            {
                Products prod = zxcGrid.SelectedItem as Products;
                new Window1(prod).Show();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Products prod = ((sender as Button).DataContext as Products);
            d.Products.Remove(prod);
            d.ProductSale.RemoveRange(d.ProductSale.Where((ps) => ps.IDПродукции == prod.ID).ToList());
            d.SaveChanges();
            zxcGrid.ItemsSource = d.Products.ToList();

        }
    }
}
