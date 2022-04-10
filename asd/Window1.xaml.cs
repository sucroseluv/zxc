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
using System.Windows.Shapes;

namespace asd
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        zxcEntities d = db.Instance;
        Products prod = new Products();
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(Products prod)
        {
            InitializeComponent();
            this.prod = prod;
            g.DataContext = this.prod;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(prod.ID);
            //d.Products.Add(prod);
            d.SaveChanges();
            Close();
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
