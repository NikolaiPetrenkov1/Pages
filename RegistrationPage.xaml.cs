using Microsoft.Win32;
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

namespace Site_2
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        private MainWindow main;
        public RegistrationPage(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            main.Frame.Content = new MessagePage(Login.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Photo (*.png) |*.png";
            openFileDialog.ShowDialog();

        }
    }
}
