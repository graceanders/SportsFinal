using SportsApp.Views;
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

namespace SportsApp
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

        private void Adminbtn_Click(object sender, RoutedEventArgs e)
        {
            AdminView adminwindow = new AdminView();
            adminwindow.Show();
        }

        private void Teambtn_Click(object sender, RoutedEventArgs e)
        {
            TeamPlayerView teamwindow = new TeamPlayerView();
            teamwindow.Show();
        }
    }
}
