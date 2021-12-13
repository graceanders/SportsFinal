using SportsApp.ViewModels;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SportsApp.Views
{
    /// <summary>
    /// Interaction logic for TeamView.xaml
    /// </summary>
    public partial class TeamView : Window
    {
        Teams teams;
        TeamViewModel vm;

        public TeamView()
        {
            InitializeComponent();
            teams = new Teams();
            vm = new TeamViewModel(teams);

            this.DataContext = vm;
        }
    }
}
