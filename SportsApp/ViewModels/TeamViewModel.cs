using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SportsApp.ViewModels
{
    public class TeamViewModel : BaseViewModel
    {
        PlayerRepo PlayerRepo;
        public Team team;

        public Player playerone;
        public Player playertwo;
         
        public ICommand AddPlayerTeamOne { get; set; }
        public ICommand RemovePlayerTeamOne { get; set; }
        public ICommand AddPlayerTeamTwo { get; set; }
        public ICommand RemovePlayerTeamTwo { get; set; }



        public TeamViewModel(PlayerRepo pr)
        {
            this.PlayerRepo = pr;
            team = new Team();

            AddPlayerTeamOne = new BasicCommand(ExecuteAddPlayerTeamOne, CanExecuteAddPlayerTeamOne);
            RemovePlayerTeamOne = new BasicCommand(ExecuteRemovePlayerTeamOne, CanExecuteRemovePlayerTeamOne);

            AddPlayerTeamTwo = new BasicCommand(ExecuteAddPlayerTeamTwo, CanExecuteAddPlayerTeamTwo);
            RemovePlayerTeamTwo = new BasicCommand(ExecuteRemovePlayerTeamTwo, CanExecuteRemovePlayerTeamTwo);

            playerone = new Player("", 0);
            playertwo = new Player("", 0);

        }

        public string PlayerNameOne
        {
            get { return this.playerone.Name; }
            set
            {
                this.playerone.Name = value;
                OnPropertyChanged();
            }
        }

        public int PlayerNumberOne
        {
            get { return this.playerone.PlayerNumber; }
            set
            {
                this.playerone.PlayerNumber = value;
                OnPropertyChanged();
            }
        }

        public string PlayerNameTwo
        {
            get { return this.playertwo.Name; }
            set
            {
                this.playertwo.Name = value;
                OnPropertyChanged();
            }
        }

        public int PlayerNumberTwo
        {
            get { return this.playertwo.PlayerNumber; }
            set
            {
                this.playertwo.PlayerNumber = value;
                OnPropertyChanged();
            }
        }

        //public List<Player> TeamOne
        //{
        //    get { return this.team.TeamOne; }
        //    set
        //    {
        //        this.team.TeamOne = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public List<Player> TeamTwo
        //{
        //    get { return this.team.TeamTwo; }
        //    set
        //    {
        //        this.team.TeamTwo = value;
        //        OnPropertyChanged();
        //    }
        //}

        private bool CanExecuteAddPlayerTeamOne(object parameter)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamOne(object parameter)
        {
            playerone.Name = PlayerNameOne;
            playerone.PlayerNumber = PlayerNumberOne;

            PlayerRepo.AddPlayer(team.TeamOne, playerone);
        }

        private bool CanExecuteRemovePlayerTeamOne(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamOne(object parameter)
        {
            if (this.PlayerNameOne != "")
            {
                PlayerRepo.RemovePlayer(team.TeamOne, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }

        private bool CanExecuteAddPlayerTeamTwo(object parameter)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamTwo(object parameter)
        {
            if (this.PlayerNameTwo != "")
            {
                PlayerRepo.AddPlayer(team.TeamTwo, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }

        private bool CanExecuteRemovePlayerTeamTwo(object parameter)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamTwo(object parameter)
        {
            if (this.PlayerNameTwo != "")
            {
                PlayerRepo.RemovePlayer(team.TeamTwo, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }


        private bool CanExecuteTest(object parameter)
        {
            return true;
        }

        private void ExecuteTest(object parameter)
        {

        }
    }
}
