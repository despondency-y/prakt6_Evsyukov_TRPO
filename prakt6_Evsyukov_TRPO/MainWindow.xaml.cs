using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace prakt6_Evsyukov_TRPO
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

        private void ChangeThemeButton_Click(object sender, RoutedEventArgs e)
        {
            ThemeHelper.Toggle();
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            StartBtn.IsEnabled = false;
            StopBtn.IsEnabled = true;
            RestartBtn.IsEnabled = true;
            LoadBar.Value = 65;
            LogBox.AppendText("Сервер успешно запущен. Нагрузка: 65%\n");
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            StartBtn.IsEnabled = true;
            StopBtn.IsEnabled = false;
            RestartBtn.IsEnabled = false;
            LoadBar.Value = 0;
            LogBox.AppendText("Сервер остановлен\n");
        }

        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}