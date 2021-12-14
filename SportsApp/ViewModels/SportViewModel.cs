using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SportsApp.ViewModels
{
    public class SportViewModel : BaseViewModel
    {
        SportsRepo SportsRepo;

        public ICommand AddSportCommand { get; set; }
        public ICommand RemoveSportCommand { get; set; }

        public ICommand SaveSportsCommand { get; set; }
        public ICommand LoadSportsCommand { get; set; }

        public ICommand AddTeamCommand { get; set; }
        public ICommand RemoveTeamCommand { get; set; }
        //public ICommand AddTeamsToSportsCommand { get; set; }

        public ICommand SaveTeamsCommand { get; set; }
        public ICommand LoadTeamsCommand { get; set; }

        bool SportsLoadExecutable;
        bool TeamsLoadExecutable;

        public SportViewModel(SportsRepo sr)
        {
            this.SportsRepo = sr;
            AddSportCommand = new BasicCommand(ExecuteAddSport, CanExecuteAddSport);
            RemoveSportCommand = new BasicCommand(ExecuteRemoveSport, CanExecuteRemoveSport);
            SaveSportsCommand = new BasicCommand(ExecuteSaveSport, CanExecuteSaveSport);
            LoadSportsCommand = new BasicCommand(ExecuteLoadSport, CanExecuteLoadSport);

            AddTeamCommand = new BasicCommand(ExecuteAddTeam, CanExecuteAddTeam);
            RemoveTeamCommand = new BasicCommand(ExecuteRemoveTeam, CanExecuteRemoveTeam);
            //AddTeamsToSportsCommand = new BasicCommand(ExecuteAddTeamsToSports, CanExecuteAddTeamsToSports);
            SaveTeamsCommand = new BasicCommand(ExecuteSaveTeams, CanExecuteSaveTeams);
            LoadTeamsCommand = new BasicCommand(ExecuteLoadTeams, CanExecuteLoadTeams);

        }

        public string SportName
        {
            get { return this.SportsRepo.sports.SportName; }
            set
            {
                this.SportsRepo.sports.SportName = value;
                OnPropertyChanged();
            }
        }

        public string SportDescription
        {
            get { return this.SportsRepo.sports.SportDescription; }
            set
            {
                this.SportsRepo.sports.SportDescription = value;
                OnPropertyChanged();
            }
        }

        public List<Sports> SportsList
        {
            get { return this.SportsRepo.ListOfSports; }
            set
            {
                this.SportsRepo.ListOfSports = value;
                OnPropertyChanged();

            }
        }

        private bool CanExecuteAddSport(object parameter)
        {
            return true;
        }

        private void ExecuteAddSport(object parameter)
        {
            if (this.SportName == "" || this.SportDescription == "") { }
            else
            {
                SportsRepo.AddSport(this.SportName, this.SportDescription);
                OnPropertyChanged("SportsList");
            }
        }

        private bool CanExecuteRemoveSport(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveSport(object parameter)
        {
            if (this.SportName == "" || this.SportDescription == "") { }
            else
            {
                SportsRepo.RemoveSport(this.SportName, this.SportDescription);
                OnPropertyChanged("SportsList");
            }
        }

        //Sports Saving & Loading

        private bool CanExecuteSaveSport(object parameter)
        {
            return true;
        }

        private void ExecuteSaveSport(object parameter)
        {
            SportsRepo.SaveSport();
            SportsLoadExecutable = true;
        }

        private bool CanExecuteLoadSport(object parameter)
        {
            if(SportsLoadExecutable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

        private void ExecuteLoadSport(object parameter)
        {
            SportsRepo.LoadSport();

            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("SportsList");
        }

        //Teams

        public string TeamName
        {
            get { return this.SportsRepo.teams.TeamName; }
            set
            {
                this.SportsRepo.teams.TeamName = value;
                OnPropertyChanged();
            }
        }

        public int NumberOfPlayers
        {
            get { return this.SportsRepo.teams.NumberOfPlayers; }
            set
            {
                this.SportsRepo.teams.NumberOfPlayers = value;
                OnPropertyChanged();
            }
        }

        public string WhichSport
        {
            get { return this.SportsRepo.teams.WhichSport; }
            set
            {
                this.SportsRepo.teams.WhichSport = value;
            }
        }

        public List<Teams> TeamsList
        {
            get { return this.SportsRepo.ListOfTeams; }
            set
            {
                this.SportsRepo.ListOfTeams = value;
                OnPropertyChanged("TeamsList");

            }
        }

        private bool CanExecuteAddTeam(object parameter)
        {
            return true;
        }

        private void ExecuteAddTeam(object parameter)
        {
            if (this.TeamName == "" || this.NumberOfPlayers == 0 || this.WhichSport == "") { }
            else
            {
                SportsRepo.AddTeam(this.TeamName, this.NumberOfPlayers, this.WhichSport);
                OnPropertyChanged("TeamsList");
            }
        }

        private bool CanExecuteRemoveTeam(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveTeam(object parameter)
        {
            if (this.TeamName == "" || this.NumberOfPlayers == 0 || this.WhichSport == "") { }
            else
            {
                SportsRepo.RemoveTeam(this.TeamName, this.NumberOfPlayers, this.WhichSport);
                OnPropertyChanged("TeamsList");
            }
        }

        private bool CanExecuteSaveTeams(object parameter)
        {
            return true;
        }

        private void ExecuteSaveTeams(object parameter)
        {
            SportsRepo.SaveTeam();
            TeamsLoadExecutable = true;
        }

        private bool CanExecuteLoadTeams(object parameter)
        {
            if (TeamsLoadExecutable == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ExecuteLoadTeams(object parameter)
        {
            SportsRepo.LoadTeam();

            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("SportsList");
        }
    }
}