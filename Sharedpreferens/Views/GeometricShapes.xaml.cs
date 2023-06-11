using System.Windows;

namespace SharedPreferens.Views
{
    /// <summary>
    /// Логика взаимодействия для GeometricShapes.xaml
    /// </summary>
    public partial class GeometricShapes : Window
    {
        public GeometricShapes()
        {
            InitializeComponent();
        }

        private void NavigateToChooseShape(object sender, RoutedEventArgs e)
        {
            ChooseShape nextWindow = new();
            nextWindow.Show();
        }
    }
}
