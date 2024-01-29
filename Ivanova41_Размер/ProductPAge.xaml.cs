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

namespace Ivanova41_Размер
{
    /// <summary>
    /// Логика взаимодействия для ProductPAge.xaml
    /// </summary>
    public partial class ProductPAge : Page
    {
       
        public ProductPAge()
        {
            InitializeComponent();
            var currentProduct = Ivanova41Entities.GetContext().Product.ToList();
            ProductListView.ItemsSource = currentProduct;
           
        }

    }
}
