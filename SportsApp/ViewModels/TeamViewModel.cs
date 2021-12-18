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

        public List<Player> TeamOne
        {
            get { return team.TeamOne; }
            set
            {
                team.TeamOne = value;
                OnPropertyChanged();
            }
        }

        public List<Player> TeamTwo
        {
            get { return team.TeamTwo; }
            set
            {
                team.TeamTwo = value;
                OnPropertyChanged();
            }
        }

        private bool CanExecuteAddPlayerTeamOne(object parameter)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamOne(object parameter)
        {
            playerone.Name = PlayerNameOne;
            playerone.PlayerNumber = PlayerNumberOne;

            PlayerRepo.AddPlayer(TeamOne, playerone);
        }

        private bool CanExecuteRemovePlayerTeamOne(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamOne(object parameter)
        {
            playerone.Name = PlayerNameOne;
            playerone.PlayerNumber = PlayerNumberOne;

            PlayerRepo.RemovePlayer(TeamOne, playerone);
        }

        private bool CanExecuteAddPlayerTeamTwo(object parameter)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamTwo(object parameter)
        {
            playertwo.Name = PlayerNameTwo;
            playertwo.PlayerNumber = PlayerNumberTwo;

            PlayerRepo.AddPlayer(TeamOne, playertwo);
        }

        private bool CanExecuteRemovePlayerTeamTwo(object parameter)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamTwo(object parameter)
        {
            playertwo.Name = PlayerNameTwo;
            playertwo.PlayerNumber = PlayerNumberTwo;

            PlayerRepo.RemovePlayer(TeamOne, playertwo);
        }
    }
}
