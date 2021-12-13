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

        //Player player1 = new Player("Gage", 32);
        //Player player2 = new Player("Weaton", 54);
        //Player player3 = new Player("Jamison", 10);

        //public BindableCollection<Player> TeamOne { get; set; }

        public TeamViewModel(Teams t)
        {
            this.teams = t;

            AddPlayerCommand = new BasicCommand(ExecuteAddPlayer, CanExecuteAddPlayer);
            RemovePlayerCommand = new BasicCommand(ExecuteRemovePlayer, CanExecuteRemovePlayer);

            //Populate DataGrid
            //TeamOne = new BindableCollection<Player>(teams.Player());


        }

        public void TestAddToList()
        {
            //teams.TeamOne.Add(player1);
            //teams.TeamOne.Add(player2);
            //teams.TeamOne.Add(player3);
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
