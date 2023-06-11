using System.Windows;

namespace SharedPreferens.Views
{
    /// <summary>
    /// Логика взаимодействия для GeometricCalculator.xaml
    /// </summary>
    public partial class GeometricCalculator : Window
    {
        public GeometricCalculator(string shape, double result)
        {
            InitializeComponent();
            shapeTitle.Text = shape;
            resultTextBox.Text = result.ToString();
        }
    }
}
