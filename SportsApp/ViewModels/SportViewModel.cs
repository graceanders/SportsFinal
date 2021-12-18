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

        TeamsRepo TeamsRepo;

        public ICommand AddSport { get; set; }
        public ICommand RemoveSport { get; set; }

        public ICommand SaveSports { get; set; }
        public ICommand LoadSports { get; set; }

        public ICommand AddTeam { get; set; }
        public ICommand RemoveTeam { get; set; }

        public ICommand AddTeamToSport { get; set; }

        public ICommand SaveTeams { get; set; }
        public ICommand LoadTeams { get; set; }

        bool SportsLoadExecutable;
        bool TeamsLoadExecutable;

        public SportViewModel(SportsRepo sr, TeamsRepo tr)
        {
            this.SportsRepo = sr;
            AddSport = new BasicCommand(ExecuteAddSport, CanExecuteAddSport);
            RemoveSport = new BasicCommand(ExecuteRemoveSport, CanExecuteRemoveSport);
            SaveSports = new BasicCommand(ExecuteSaveSport, CanExecuteSaveSport);
            LoadSports = new BasicCommand(ExecuteLoadSport, CanExecuteLoadSport);

            this.TeamsRepo = tr;
            AddTeam = new BasicCommand(ExecuteAddTeam, CanExecuteAddTeam);
            RemoveTeam = new BasicCommand(ExecuteRemoveTeam, CanExecuteRemoveTeam);
            AddTeamToSport = new BasicCommand(ExecuteAddTeamsToSports, CanExecuteAddTeamsToSports);
            SaveTeams = new BasicCommand(ExecuteSaveTeams, CanExecuteSaveTeams);
            LoadTeams = new BasicCommand(ExecuteLoadTeams, CanExecuteLoadTeams);

        }

        public string SportName
        {
            get { return this.SportsRepo.sports.SportName; }
            set
            {
                this.SportsRepo.sports.SportName = value;
                OnPropertyChanged();
                OnPropertyChanged("CurrentSportItem");
            }
        }

        public string SportDescription
        {
            get { return this.SportsRepo.sports.SportDescription; }
            set
            {
                this.SportsRepo.sports.SportDescription = value;
                OnPropertyChanged();
                OnPropertyChanged("CurrentSportItem");
            }
        }

        public List<Sport> ListOfSports
        {
            get { return SportsRepo.ListOfSports; }
            set
            {
                SportsRepo.ListOfSports = value;
                OnPropertyChanged();

            }
        }

        public Sport CurrentSportItem
        {
            get { return this.SportsRepo.CurrentSportItem; }
            set
            {
                this.SportsRepo.CurrentSportItem.SportName = SportName;
                this.SportsRepo.CurrentSportItem.SportDescription = SportDescription;
                OnPropertyChanged();
            }
        }

        private bool CanExecuteAddSport(object parameter)
        {
            return true;
        }

        private void ExecuteAddSport(object parameter)
        {
            SportsRepo.AddSport(SportName, SportDescription);
            OnPropertyChanged("ListOfSports");
        }

        private bool CanExecuteRemoveSport(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveSport(object parameter)
        {
            SportsRepo.RemoveSport(SportName, SportDescription);

            OnPropertyChanged("ListOfSports");
        }

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
            if (SportsLoadExecutable == true)
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

        public string TeamName
        {
            get { return this.TeamsRepo.teams.TeamName; }
            set
            {
                this.TeamsRepo.teams.TeamName = value;
                OnPropertyChanged();
                OnPropertyChanged("CurrentTeamItem");
            }
        }

        public int NumberOfPlayers
        {
            get { return this.TeamsRepo.teams.NumberOfPlayers; }
            set
            {
                this.TeamsRepo.teams.NumberOfPlayers = value;
                OnPropertyChanged();
                OnPropertyChanged("CurrentTeamItem");
            }
        }

        public Sport WhichSport
        {
            get { return this.TeamsRepo.teams.TeamsSport; }
            set
            {
                this.TeamsRepo.teams.TeamsSport = value;
                OnPropertyChanged();
                OnPropertyChanged("CurrentTeamItem");
            }
        }

        public List<Team> ListOfTeams
        {
            get { return TeamsRepo.ListOfTeams; }
            set
            {
                TeamsRepo.ListOfTeams = value;
                OnPropertyChanged();

            }
        }

        public Team CurrentTeamItem
        {
            get { return this.TeamsRepo.CurrentTeamItem; }
            set
            {
                this.TeamsRepo.CurrentTeamItem.TeamName = TeamName;
                this.TeamsRepo.CurrentTeamItem.NumberOfPlayers = NumberOfPlayers;
                OnPropertyChanged();
            }
        }

        private bool CanExecuteAddTeam(object parameter)
        {
            return true;
        }

        private void ExecuteAddTeam(object parameter)
        {
            TeamsRepo.AddTeam(TeamName, NumberOfPlayers);

            OnPropertyChanged("ListOfTeams");
        }

        private bool CanExecuteRemoveTeam(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveTeam(object parameter)
        {
            TeamsRepo.RemoveTeam(TeamName, NumberOfPlayers);
            OnPropertyChanged("ListOfTeams");
        }

        private bool CanExecuteAddTeamsToSports(object parameter)
        {
            return true;
        }

        private void ExecuteAddTeamsToSports(object parameter)
        {
            CurrentTeamItem.TeamName = this.TeamName;
            CurrentTeamItem.NumberOfPlayers = this.NumberOfPlayers;

            TeamsRepo.AddTeamToSport(CurrentTeamItem, this.WhichSport);
        }

        private bool CanExecuteSaveTeams(object parameter)
        {
            return true;
        }

        private void ExecuteSaveTeams(object parameter)
        {
            TeamsRepo.SaveTeam();
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
            TeamsRepo.LoadTeam();

            OnPropertyChanged("Name");
            OnPropertyChanged("Description");
            OnPropertyChanged("SportsList");
        }
    }
}