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

namespace Lesson5_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NewWindow newWindow;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openWindowButton_Click(object sender, RoutedEventArgs e)
        {
            newWindow = new NewWindow();
            newWindow.Show();
        }

        private void closeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            newWindow?.Close();
        }
    }
}