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

        private void CMSportbtn_Click(object sender, RoutedEventArgs e)
        {
            WPFSport sportwindow = new WPFSport();
            sportwindow.Show();
        }

        private void CMPlayerbtn_Click(object sender, RoutedEventArgs e)
        {
            WPFPlayer sportwindow = new WPFPlayer();
            sportwindow.Show();
        }

        private void CMTeambtn_Click(object sender, RoutedEventArgs e)
        {
            WPFTeam teamwindow = new WPFTeam();
            teamwindow.Show();
        }
    }
}
