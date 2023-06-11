using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SharedPreferens.Views
{
    /// <summary>
    /// Логика взаимодействия для ChooseShape.xaml
    /// </summary>
    public partial class ChooseShape : Window
    {
        public ChooseShape()
        {
            InitializeComponent();
        }

        private void NavigateToGeometricCalculator(object sender, RoutedEventArgs e)
        {
            if (choose.SelectedIndex == 0)
            {
                GeometricCalculator nextWindow = new("Треугольник", Calculate());
                nextWindow.Show();
            }
            else if (choose.SelectedIndex == 1)
            {
                GeometricCalculator nextWindow = new("Круг", Calculate());
                nextWindow.Show();
            }
        }

        private void ChangeImage(object sender, SelectionChangedEventArgs e)
        {
            if (choose.SelectedIndex == 0)
            {
                image.Source = new BitmapImage(new Uri(@"../Images/triangle.png", UriKind.Relative));
            }
            else if (choose.SelectedIndex == 1)
            {
                image.Source = new BitmapImage(new Uri(@"../Images/circle.png", UriKind.Relative));
            }
        }

        private double Calculate() 
        {
            string[] numbers = dataForCalculate.Text.Split(" ");
            double result = 0;
            if (choose.SelectedIndex == 0)
            {
                result = Convert.ToInt32(numbers[0]) * 2 + Convert.ToInt32(numbers[1]);
            }
            else if (choose.SelectedIndex == 1)
            {
                result = Convert.ToInt32(numbers[0]) / (2 * Math.PI);
            }
            return result;
        }
    }
}
