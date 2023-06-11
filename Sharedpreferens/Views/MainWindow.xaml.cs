using SharedPreferens.Views;
using System.Windows;

namespace SharedPreferens
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToGeometricShapesWindow(object sender, RoutedEventArgs e)
        {
            GeometricShapes nextWindow = new();
            MySharedPreferens sharedPreferens = new();
            if (loginTB.Text.Trim() != string.Empty && passwordTB.Text.Trim() != string.Empty)
            {
                //Preferences.Set("login", loginTB.Text);
                //Preferences.Set("password", passwordTB.Text);
                sharedPreferens.Login = loginTB.Text;
                sharedPreferens.Password = passwordTB.Text;
                nextWindow.Show();
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }
    }
}
