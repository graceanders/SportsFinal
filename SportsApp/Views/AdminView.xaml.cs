﻿using SportsApp.ViewModels;
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
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {
        Sports sports;
        Teams teams;
        SportViewModel vm;

        public AdminView()
        {
            InitializeComponent();
            sports = new Sports();
            teams = new Teams();
            vm = new SportViewModel(sports, teams);

        }
    }
}
