using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGroup
{
    public partial class Form1 : Form
    {

        List<Team> seed1 = new List<Team>();
        List<Team> seed2 = new List<Team>();
        List<Team> seed3 = new List<Team>();
        List<Team> seed4 = new List<Team>();
        List<Team> groupA = new List<Team>();
        List<Team> groupB = new List<Team>();
        List<Team> groupC = new List<Team>();
        List<Team> groupD = new List<Team>();
        List<int> listNumbers = new List<int>();
        public Form1()
        {
            InitializeComponent();
            seed1.Add(new Team("G2", "LEC"));
            seed1.Add(new Team("DWG", "LCK"));
            seed1.Add(new Team("TSM", "LCS"));
            seed1.Add(new Team("TES", "LPL"));
            seed2.Add(new Team("FNC", "LEC"));
            seed2.Add(new Team("JDG", "LPL"));
            seed2.Add(new Team("SN", "LPL"));
            seed2.Add(new Team("DRX", "LCK"));
            seed3.Add(new Team("RGE", "LEC"));
            seed3.Add(new Team("FLY", "LCS"));
            seed3.Add(new Team("GENG", "LCK"));
            seed3.Add(new Team("MCX", "PCS"));
            seed4.Add(new Team("UOL", "CBL"));
            seed4.Add(new Team("TLN", "PCS"));
            seed4.Add(new Team("LGD", "LPL"));
            seed4.Add(new Team("TL", "LCS"));
            addTeam();
            displayA.DataSource = groupA;
            displayB.DataSource = groupB;
            displayC.DataSource = groupC;
            displayD.DataSource = groupD;
            displayA.Columns[1].Visible = false;
            displayB.Columns[1].Visible = false;
            displayC.Columns[1].Visible = false;
            displayD.Columns[1].Visible = false;
        }

        public void addTeam()
        {

            int number;
            var random1 = new Random();
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = random1.Next(0, 4);
                } while (listNumbers.Contains(number));
                listNumbers.Add(number);
            }

            drawTeam(seed1, listNumbers, groupA, groupB, groupC, groupD, 1);
            drawTeam(seed2, listNumbers, groupA, groupB, groupC, groupD, 2);
            checkSwap(groupD, groupC, groupB, groupA, 1);
            drawTeam(seed3, listNumbers, groupA, groupB, groupC, groupD, 3);
            checkSwap(groupD, groupB, groupC, groupA, 2);
            drawTeam(seed4, listNumbers, groupA, groupB, groupC, groupD, 4);
            checkSwap(groupD, groupB, groupC, groupA, 3);
            checkSwap(groupC, groupB, groupA, groupD, 3);
            checkSwap(groupB, groupA, groupC, groupD, 3);
            checkSwap(groupA, groupB, groupC, groupD, 3);
        }
        private bool checkTeam(List<Team> team, String region, int b)
        {
            for (int i = 0; i < team.Count - b; i++)
            {
                if (region.Equals(team[i].Region))
                {
                    return false;
                }
            }
            return true;
        }
        private void swap(List<Team> team1, List<Team> team2, int position)
        {
            team1.Add(team2[position]);
            team2.Add(team1[position]);
            team1.RemoveAt(position);
            team2.RemoveAt(position);
        }
        private void checkSwap(List<Team> team1, List<Team> team2, List<Team> team3, List<Team> team4, int position)
        {
            if (!checkTeam(team1, team1[position].Region, 1))
            {
                if (checkTeam(team1, team2[position].Region, 0)
                        && checkTeam(team2, team1[position].Region, 0))
                {

                    swap(team1, team2, position);
                }
                else if (checkTeam(team1, team4[position].Region, 0)
                      && checkTeam(team4, team1[position].Region, 0))
                {

                    swap(team1, team4, position);
                }
                else if (checkTeam(team1, team3[position].Region, 0)
                      && checkTeam(team3, team1[position].Region, 0))
                {

                    swap(team1, team3, position);
                }
            }
        }
        private void drawTeam(List<Team> seed, List<int> ran, List<Team> teamA,
            List<Team> teamB, List<Team> teamC, List<Team> teamD, int size)
        {

            for (int j = 0; j < seed.Count; j++)
            {
                if (checkTeam(teamA, seed[ran[j]].Region, 0)
                        && teamA.Count != size)
                {
                    teamA.Add(seed[ran[j]]);
                }
                else if (checkTeam(teamB, seed[ran[j]].Region, 0)
                      && teamB.Count != size)
                {
                    teamB.Add(seed[ran[j]]);
                }
                else if (checkTeam(teamC, seed[ran[j]].Region, 0)
                      && teamC.Count != size)
                {
                    teamC.Add(seed[ran[j]]);
                }
                else if (teamD.Count != size)
                {
                    teamD.Add(seed[ran[j]]);
                }
                else
                {
                    teamC.Add(seed[ran[j]]);
                }
            }
        }
    }
}
