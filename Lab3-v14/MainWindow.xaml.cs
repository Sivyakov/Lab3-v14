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

namespace Lab3_v14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BookPrice bookPrice = new BookPrice();
            bookPrice.Name= BoxName.Text;
            bookPrice.Avtor=BoxAvtor.Text;
            bookPrice.Year= Convert.ToInt32(BoxYear.Text);
            bookPrice.Salary= Convert.ToInt32(BoxSalary.Text);
            Result.Text = ($" {bookPrice.Discount(bookPrice.Salary,bookPrice.Year)}");
        }
    }
}
