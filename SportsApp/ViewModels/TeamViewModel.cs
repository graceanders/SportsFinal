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
        PlayerRepo PlayerRepo;
        Team team = new Team();

        Player playerone;
        Player playertwo;
         
        public ICommand AddPlayerTeamOneCommand { get; set; }
        public ICommand RemovePlayerTeamOneCommand { get; set; }
        public ICommand AddPlayerTeamTwoCommand { get; set; }
        public ICommand RemovePlayerTeamTwoCommand { get; set; }



        public TeamViewModel(PlayerRepo pr)
        {
            this.PlayerRepo = pr;

            AddPlayerTeamOneCommand = new BasicCommand(ExecuteAddPlayerTeamOne, CanExecuteAddPlayerTeamOne);
            RemovePlayerTeamOneCommand = new BasicCommand(ExecuteRemovePlayerTeamOne, CanExecuteRemovePlayerTeamOne);

            AddPlayerTeamTwoCommand = new BasicCommand(ExecuteAddPlayerTeamTwo, CanExecuteAddPlayerTeamTwo);
            RemovePlayerTeamTwoCommand = new BasicCommand(ExecuteRemovePlayerTeamTwo, CanExecuteRemovePlayerTeamTwo);

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
            get { return this.team.TeamOne; }
            set
            {
                this.team.TeamOne = value;
                OnPropertyChanged();
            }
        }

        public List<Player> TeamTwo
        {
            get { return this.team.TeamTwo; }
            set
            {
                this.team.TeamTwo = value;
                OnPropertyChanged();
            }
        }

        private bool CanExecuteAddPlayerTeamOne(object paramater)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamOne(object paramater)
        {
            if (this.PlayerNameOne != "")
            {
                PlayerRepo.AddPlayer(TeamOne, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }

        private bool CanExecuteRemovePlayerTeamOne(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamOne(object paramater)
        {
            if (this.PlayerNameOne != "")
            {
                PlayerRepo.RemovePlayer(TeamOne, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }

        private bool CanExecuteAddPlayerTeamTwo(object paramater)
        {
            return true;
        }

        private void ExecuteAddPlayerTeamTwo(object paramater)
        {
            if (this.PlayerNameTwo != "")
            {
                PlayerRepo.AddPlayer(TeamTwo, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }

        private bool CanExecuteRemovePlayerTeamTwo(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamTwo(object paramater)
        {
            if (this.PlayerNameTwo != "")
            {
                PlayerRepo.RemovePlayer(TeamTwo, this.PlayerNameOne, this.PlayerNumberOne);
            }
        }
    }
}
