using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SynthesisClassLibrary.Classess;
using SynthesisClassLibrary.DAL;

namespace SynthesysAplication
{
    public partial class Form1 : Form
    {
        private TournamentManager tournamentManager;
        
        public Form1()
        {
            InitializeComponent();

            tournamentManager = new TournamentManager(new TournamentDataHelper());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            UpdateTournamentListBox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Tournament tournament = new Tournament(tbxInformation.Text, tbxName.Text,  dtpStartTime.Value, (int)nudMin.Value, (int)nudMax.Value, tbxAddress.Text, cbxSport.Text);
            tournamentManager.CreateTournament(tournament);

            UpdateTournamentListBox();
        }

        private void UpdateTournamentListBox()
        {
            lbxTournamentMatches.Items.Clear();
            lbxTournaments.Items.Clear();
            foreach(Tournament tournament in tournamentManager.GetTournaments())
            {
                lbxTournaments.Items.Add(tournament.ToString());
                lbxTournamentMatches.Items.Add(tournament.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tournamentManager.DeleteTournament(tournamentManager.GetTournaments().ElementAt(lbxTournaments.SelectedIndex).Id);
            UpdateTournamentListBox();
        }

        private void btnGenerateSchedule_Click(object sender, EventArgs e)
        {
           
            if(lbxTournamentMatches.SelectedIndex >= 0)
            {
                lbxSchedule.Items.Clear();
                Tournament t = tournamentManager.GetTournaments().ElementAt(lbxTournamentMatches.SelectedIndex);


                GameManager gameManager = new GameManager();
                List<string> schedule = gameManager.GenerateGames(t);
                foreach (string scheduleItem in schedule)
                {
                    lbxSchedule.Items.Add(scheduleItem);
                }
            }
            else
            {
                MessageBox.Show("Select a tournament");
            }


        }

        private void tbxSort_TextChanged(object sender, EventArgs e)
        {

            if (lbxTournamentMatches.SelectedIndex >= 0)
            {
                lbxSchedule.Items.Clear();
                Tournament t = tournamentManager.GetTournaments().ElementAt(lbxTournamentMatches.SelectedIndex);


                GameManager gameManager = new GameManager();
                List<string> schedule = gameManager.GenerateGames(t);
                List<string> result = new List<string>();
                foreach (string scheduleItem in schedule)
                {
                    if (!scheduleItem.Contains("Round"))
                    {
                        result.Add(scheduleItem);
                    }
                }

                foreach (string scheduleItem in result)
                {
                    if (!scheduleItem.Contains(tbxSort.Text))
                    {
                        lbxSchedule.Items.Add(scheduleItem);
                    }
                }

            }
            else
            {
                MessageBox.Show("Select a tournament");
            }
            

        }

        

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            Tournament tournament = tournamentManager.GetTournaments().ElementAt(lbxTournamentMatches.SelectedIndex);
            List<Match> matches = tournament.GetGameManager().GetGames();
            Match match = matches.ElementAt(lbxSchedule.SelectedIndex);
            Sport sport;
            if(tournament.Sport == "Badminton")
            {
                sport = new Badminton();
            }
            else
            {
                sport = new Karate();
            }
            tournament.GetGameManager().ScoreMatch(match.Id, (int)nudScore1.Value, (int)nudScore2.Value, sport);
        }
    }
}
