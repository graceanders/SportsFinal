using SportsLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SportsApp.ViewModels
{
    class SportViewModel : BaseViewModel
    {
        SportsRepo SportsRepo;

        TeamsRepo TeamsRepo;

        //List<Sports> SportsList { get => SportsRepo.ListOfSports;}

        public ICommand AddSportCommand { get; set; }
        public ICommand RemoveSportCommand { get; set; }

        public ICommand SaveSportsCommand { get; set; }
        public ICommand LoadSportsCommand { get; set; }

        public ICommand AddTeamCommand { get; set; }
        public ICommand RemoveTeamCommand { get; set; }

        public ICommand SaveTeamsCommand { get; set; }
        public ICommand LoadTeamsCommand { get; set; }

        bool SportsLoadExecutable;
        bool TeamsLoadExecutable;

        public SportViewModel(SportsRepo sr, TeamsRepo tr)
        {
            this.SportsRepo = sr;
            AddSportCommand = new BasicCommand(ExecuteAddSport, CanExecuteAddSport);
            RemoveSportCommand = new BasicCommand(ExecuteRemoveSport, CanExecuteRemoveSport);
            SaveSportsCommand = new BasicCommand(ExecuteSaveSport, CanExecuteSaveSport);
            LoadSportsCommand = new BasicCommand(ExecuteLoadSport, CanExecuteLoadSport);

            this.TeamsRepo = tr; 
            //AddTeamCommand = new BasicCommand(ExecuteAddTeam, CanExecuteAddTeam);
            //RemoveTeamCommand = new BasicCommand(ExecuteRemoveTeam, CanExecuteRemoveTeam);
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
            get { return this.SportsRepo.ListOfSports; }
            set
            {
                this.SportsRepo.ListOfSports = value;
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
            if (SportName != "" || SportDescription != "") 
            {
                SportsRepo.AddSport(SportName, SportDescription);
                //SportsRepo.RemakeSportsList();
                OnPropertyChanged("ListOfSports");
            }
        }

        private bool CanExecuteRemoveSport(object parameter)
        {
            return true;
        }

        private void ExecuteRemoveSport(object parameter)
        {
            if (SportName != "" || SportDescription != "") 
            {
                SportsRepo.RemoveSport(SportName, SportDescription);
                //SportsRepo.RemakeSportsList();
                OnPropertyChanged("ListOfSports");
            }
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

        //public string WhichSport
        //{
        //    get { return this.TeamsRepo.teams.WhichSport; }
        //    set
        //    {
        //        this.TeamsRepo.teams.WhichSport = value;
        //        OnPropertyChanged();
        //        OnPropertyChanged("CurrentTeamItem");
        //    }
        //}

        public List<Team> ListOfTeams
        {
            get { return this.TeamsRepo.ListOfTeams; }
            set
            {
                this.TeamsRepo.ListOfTeams = value;
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

        //private void ExecuteAddTeam(object parameter)
        //{
        //    if (TeamName != "" || WhichSport != "")
        //    {
        //        TeamsRepo.AddTeam(TeamName, NumberOfPlayers, WhichSport);
        //        TeamsRepo.RemakeTeamsList();
        //        OnPropertyChanged("ListOfTeams");
        //    }
        //}

        private bool CanExecuteRemoveTeam(object parameter)
        {
            return true;
        }

        //private void ExecuteRemoveTeam(object parameter)
        //{
        //    if (TeamName != "" || WhichSport != "")
        //    {
        //        TeamsRepo.RemoveTeam(TeamName, NumberOfPlayers, WhichSport);
        //        TeamsRepo.RemakeTeamsList();
        //        OnPropertyChanged("ListOfTeams");
        //    }
        //}

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