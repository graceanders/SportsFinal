using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SportsApp.ViewModels
{
    class SportViewModel : BaseViewModel
    {
        //public Sports thissport = new Sports("", "");
        //public Teams thisteams = new Teams("", 0, "");

        Sports sport;

        public ICommand AddSportCommand { get; set; }
        public ICommand RemoveSportCommand { get; set; }

        public ICommand SaveSportsCommand { get; set; }
        public ICommand LoadSportsCommand { get; set; }

        Teams teams;

        public ICommand AddTeamCommand { get; set; }
        public ICommand RemoveTeamCommand { get; set; }
        //public ICommand AddTeamsToSportsCommand { get; set; }

        public ICommand SaveTeamsCommand { get; set; }
        public ICommand LoadTeamsCommand { get; set; }

        bool SportsLoadExecutable;
        bool TeamsLoadExecutable;

        public SportViewModel(Sports s, Teams t)
        {
            this.sport = s;

            AddSportCommand = new BasicCommand(ExecuteAddSport, CanExecuteAddSport);
            RemoveSportCommand = new BasicCommand(ExecuteRemoveSport, CanExecuteRemoveSport);
            SaveSportsCommand = new BasicCommand(ExecuteSaveSport, CanExecuteSaveSport);
            LoadSportsCommand = new BasicCommand(ExecuteLoadSport, CanExecuteLoadSport);

            this.teams = t;
            AddTeamCommand = new BasicCommand(ExecuteAddTeam, CanExecuteAddTeam);
            RemoveTeamCommand = new BasicCommand(ExecuteRemoveTeam, CanExecuteRemoveTeam);
            //AddTeamsToSportsCommand = new BasicCommand(ExecuteAddTeamsToSports, CanExecuteAddTeamsToSports);
            SaveTeamsCommand = new BasicCommand(ExecuteSaveTeams, CanExecuteSaveTeams);
            LoadTeamsCommand = new BasicCommand(ExecuteLoadTeams, CanExecuteLoadTeams);

            

        }

        //Sports

        public string SportName
        {
            get { return this.sport.SportName; }
            set
            {
                this.sport.SportName = value;
                OnPropertyChanged();
            }
        }

        public string SportDescription
        {
            get { return this.sport.SportDescription; }
            set
            {
                this.sport.SportDescription = value;
                OnPropertyChanged();
            }
        }

        public List<Sports> SportsList
        {
            get { return this.sport.SportsList; }
            set
            {
                this.sport.SportsList = value;
                OnPropertyChanged();

            }
        }

        private bool CanExecuteAddSport(object parameter)
        {
            return true;
        }

        private void ExecuteAddSport(object parameter)
        {
            //thissport.SportName = SportName;
            //thissport.SportDescription = SportDescription;
            SportsList.Add(this.sport);
            OnPropertyChanged("SportsList");
        }

        private bool CanExecuteRemoveSport(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveSport(object parameter)
        {

        }

        //Sports Saving & Loading

        private bool CanExecuteSaveSport(object parameter)
        {
            return true;
        }

        private void ExecuteSaveSport(object parameter)
        {
            sport.SaveSports(sport);
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
            sport.LoadSports();

            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("SportsList");
        }

        //Teams

        public string TeamName
        {
            get { return this.teams.TeamName; }
            set
            {
                this.teams.TeamName = value;
                OnPropertyChanged();
            }
        }

        public int NumberOfPlayers
        {
            get { return this.teams.NumberOfPlayers; }
            set
            {
                this.teams.NumberOfPlayers = value;
                OnPropertyChanged();
            }
        }

        public string WhichSport
        {
            get { return this.teams.WhichSport; }
            set
            {
                this.teams.WhichSport = value;
            }
        }

        public List<Teams> TeamsList
        {
            get { return this.teams.TeamsList; }
            set
            {
                this.teams.TeamsList = value;
                OnPropertyChanged("TeamsList");

            }
        }

        private bool CanExecuteAddTeam(object parameter)
        {
            return true;
        }

        private void ExecuteAddTeam(object parameter)
        {
            //thisteams.TeamName = this.TeamName;
            //thisteams.NumberOfPlayers = this.NumberOfPlayers;
            //thisteams.WhichSport = this.WhichSport;
            
            TeamsList.Add(this.teams);
            OnPropertyChanged("TeamsList");
        }

        private bool CanExecuteRemoveTeam(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveTeam(object parameter)
        {

        }

        //private bool CanExecuteAddTeamsToSports(object parameter)
        //{
        //    return true;
        //}

        //private void ExecuteAddTeamsToSports(object parameter)
        //{

        //}

        //Teams Saving & Loading

        private bool CanExecuteSaveTeams(object parameter)
        {
            return true;
        }

        private void ExecuteSaveTeams(object parameter)
        {
            teams.SaveTeams(teams);
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
            teams.LoadTeams();

            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("SportsList");
        }
    }
}