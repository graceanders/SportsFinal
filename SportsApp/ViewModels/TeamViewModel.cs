using Caliburn.Micro;
using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SportsApp.ViewModels
{
    class TeamViewModel : BaseViewModel
    {
        Teams teams;
         
        public ICommand AddPlayerCommand { get; set; }
        public ICommand RemovePlayerCommand { get; set; }

        public BindableCollection<Player> TeamOne { get; set; }

        public TeamViewModel(Teams t)
        {
            this.teams = t;

            AddPlayerCommand = new BasicCommand(ExecuteAddPlayer, CanExecuteAddPlayer);
            RemovePlayerCommand = new BasicCommand(ExecuteRemovePlayer, CanExecuteRemovePlayer);

            //Populate DataGrid
            TeamOne = new BindableCollection<Player>(teams.TeamOne);

            
        }

        public void TestAddToList()
        {
            
        }

        private bool CanExecuteAddPlayer(object paramater)
        {
            return true;
        }

        private void ExecuteAddPlayer(object paramater)
        {
            
        }

        private bool CanExecuteRemovePlayer(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayer(object paramater)
        {

        }
    }
}
