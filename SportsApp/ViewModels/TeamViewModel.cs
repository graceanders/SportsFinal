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
        SportsRepo SportsRepo;
         
        public ICommand AddPlayerTeamOneCommand { get; set; }
        public ICommand RemovePlayerTeamOneCommand { get; set; }
        public ICommand AddPlayerTeamTwoCommand { get; set; }
        public ICommand RemovePlayerTeamTwoCommand { get; set; }



        public TeamViewModel(SportsRepo sr)
        {
            this.SportsRepo = sr;

            AddPlayerTeamOneCommand = new BasicCommand(ExecuteAddPlayerTeamOne, CanExecuteAddPlayerTeamOne);
            RemovePlayerTeamOneCommand = new BasicCommand(ExecuteRemovePlayerTeamOne, CanExecuteRemovePlayerTeamOne);

            AddPlayerTeamTwoCommand = new BasicCommand(ExecuteAddPlayerTeamTwo, CanExecuteAddPlayerTeamTwo);
            RemovePlayerTeamTwoCommand = new BasicCommand(ExecuteRemovePlayerTeamTwo, CanExecuteRemovePlayerTeamTwo);

        }

        public string PlayerNameOne
        {
            get { return this.SportsRepo.playerone.Name; }
            set
            {
                this.SportsRepo.playerone.Name = value;
                OnPropertyChanged();
            }
        }
         
        public int PlayerNumberOne
        {
            get { return this.SportsRepo.playerone.Number; }
            set
            {
                this.SportsRepo.playerone.Number = value;
                OnPropertyChanged();
            }
        }

        public string PlayerNameTwo
        {
            get { return this.SportsRepo.playertwo.Name; }
            set
            {
                this.SportsRepo.playertwo.Name = value;
                OnPropertyChanged();
            }
        }

        public int PlayerNumberTwo
        {
            get { return this.SportsRepo.playertwo.Number; }
            set
            {
                this.SportsRepo.playertwo.Number = value;
                OnPropertyChanged();
            }
        }

        public List<Player> TeamOne
        {
            get { return this.SportsRepo.TeamOne; }
            set
            {
                this.SportsRepo.TeamOne = value;
                OnPropertyChanged();
            }
        }

        public List<Player> TeamTwo
        {
            get { return this.SportsRepo.TeamTwo; }
            set
            {
                this.SportsRepo.TeamTwo = value;
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
                SportsRepo.AddPlayerTeamOne(this.PlayerNameOne, this.PlayerNumberOne);
            } 
            
        }

        private bool CanExecuteRemovePlayerTeamOne(object paramater)
        {
            return true;
        }

        private void ExecuteRemovePlayerTeamOne(object paramater)
        {
            if (this.PlayerNameOne != "") {

                SportsRepo.RemovePlayerTeamOne(this.PlayerNameOne, this.PlayerNumberOne);
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
                SportsRepo.AddPlayerTeamTwo(this.PlayerNameTwo, this.PlayerNumberTwo);
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
                SportsRepo.RemovePlayerTeamTwo(this.PlayerNameTwo, this.PlayerNumberTwo);
            }
        }
    }
}
