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
using Lib13;

namespace Practice_1
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

        private void GenerationAndCalculating_Click(object sender, RoutedEventArgs e)
        {
            var results = Practice.CalculatingNumbers();
            result.Text = results.ToString();
            var numbers = Practice.CalculatingNumbers();
            number.Text = numbers.ToString();


        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void number_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
