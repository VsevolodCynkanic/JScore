using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCounter
{
    public partial class Counter3Players2Round : Form
    {
        public Counter3Players2Round(string team1name, string team2name, string team3name,
            string team1Score, string team2Score, string team3Score, int[] points)
        {
            InitializeComponent();
            team1Counter.Text = team1name;
            team2Counter.Text = team2name;
            team3Counter.Text = team3name;
            team1ScoreR2.Text = team1Score;
            team2ScoreR2.Text = team2Score;
            team3ScoreR2.Text = team3Score;
            this.points = points;
        }
        int point200 = 200;
        int point400 = 400;
        int point600 = 600;
        int point800 = 800;
        int point1000 = 1000;

        int[] points = new int[4];

        private void plusTeam1_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[0] += point200;
                team1ScoreR2.Text = points[0].ToString();
                points200R2.Checked = false;
                points400R2.Checked = true;
            }
            else if (points400R2.Checked)
            {
                points[0] += point400;
                team1ScoreR2.Text = points[0].ToString();
                points400R2.Checked = false;
                points600R2.Checked = true;
            }
            else if (points600R2.Checked)
            {
                points[0] += point600;
                team1ScoreR2.Text = points[0].ToString();
                points600R2.Checked = false;
                points800R2.Checked = true;
            }
            else if (points800R2.Checked)
            {
                points[0] += point800;
                team1ScoreR2.Text = points[0].ToString();
                points800R2.Checked = false;
                points1000R2.Checked = true;
            }
            else if (points1000R2.Checked)
            {
                points[0] += point1000;
                team1ScoreR2.Text = points[0].ToString();
                points1000R2.Checked = false;
                points200R2.Checked = true;
            }
        }

        private void plusTeam2_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[1] += point200;
                team2ScoreR2.Text = points[1].ToString();
                points200R2.Checked = false;
                points400R2.Checked = true;
            }
            else if (points400R2.Checked)
            {
                points[1] += point400;
                team2ScoreR2.Text = points[1].ToString();
                points400R2.Checked = false;
                points600R2.Checked = true;
            }
            else if (points600R2.Checked)
            {
                points[1] += point600;
                team2ScoreR2.Text = points[1].ToString();
                points600R2.Checked = false;
                points800R2.Checked = true;
            }
            else if (points800R2.Checked)
            {
                points[1] += point800;
                team2ScoreR2.Text = points[1].ToString();
                points800R2.Checked = false;
                points1000R2.Checked = true;
            }
            else if (points1000R2.Checked)
            {
                points[1] += point1000;
                team2ScoreR2.Text = points[1].ToString();
                points1000R2.Checked = false;
                points200R2.Checked = true;
            }
        }

        private void plusTeam3_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[2] += point200;
                team3ScoreR2.Text = points[2].ToString();
                points200R2.Checked = false;
                points400R2.Checked = true;
            }
            else if (points400R2.Checked)
            {
                points[2] += point400;
                team3ScoreR2.Text = points[2].ToString();
                points400R2.Checked = false;
                points600R2.Checked = true;
            }
            else if (points600R2.Checked)
            {
                points[2] += point600;
                team3ScoreR2.Text = points[2].ToString();
                points600R2.Checked = false;
                points800R2.Checked = true;
            }
            else if (points800R2.Checked)
            {
                points[2] += point800;
                team3ScoreR2.Text = points[2].ToString();
                points800R2.Checked = false;
                points1000R2.Checked = true;
            }
            else if (points1000R2.Checked)
            {
                points[2] += point1000;
                team3ScoreR2.Text = points[2].ToString();
                points1000R2.Checked = false;
                points200R2.Checked = true;
            }
        }

        private void minusTeam1_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[0] -= point200;
                team1ScoreR2.Text = points[0].ToString();
            }
            else if (points400R2.Checked)
            {
                points[0] -= point400;
                team1ScoreR2.Text = points[0].ToString();
            }
            else if (points600R2.Checked)
            {
                points[0] -= point600;
                team1ScoreR2.Text = points[0].ToString();
            }
            else if (points800R2.Checked)
            {
                points[0] -= point800;
                team1ScoreR2.Text = points[0].ToString();
            }
            else if (points1000R2.Checked)
            {
                points[0] -= point1000;
                team1ScoreR2.Text = points[0].ToString();
            }
        }

        private void minusTeam2_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[1] -= point200;
                team2ScoreR2.Text = points[1].ToString();
            }
            else if (points400R2.Checked)
            {
                points[1] -= point400;
                team2ScoreR2.Text = points[1].ToString();
            }
            else if (points600R2.Checked)
            {
                points[1] -= point600;
                team2ScoreR2.Text = points[1].ToString();
            }
            else if (points800R2.Checked)
            {
                points[1] -= point800;
                team2ScoreR2.Text = points[1].ToString();
            }
            else if (points1000R2.Checked)
            {
                points[1] -= point1000;
                team2ScoreR2.Text = points[1].ToString();
            }
        }

        private void minusTeam3_Click(object sender, EventArgs e)
        {
            if (points200R2.Checked)
            {
                points[2] -= point200;
                team3ScoreR2.Text = points[2].ToString();
            }
            else if (points400R2.Checked)
            {
                points[2] -= point400;
                team3ScoreR2.Text = points[2].ToString();
            }
            else if (points600R2.Checked)
            {
                points[2] -= point600;
                team3ScoreR2.Text = points[2].ToString();
            }
            else if (points800R2.Checked)
            {
                points[2] -= point800;
                team3ScoreR2.Text = points[2].ToString();
            }
            else if (points1000R2.Checked)
            {
                points[2] -= point1000;
                team3ScoreR2.Text = points[2].ToString();
            }
        }

        private void homePicture3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Hide();
                StartPage startPage = new StartPage();
                startPage.Show();
            }
        }

        private void unlockPicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && pointsPanel.Enabled == true)
            {
                pointsPanel.Enabled = false;
            }
            else if (pointsPanel.Enabled == false)
            {
                pointsPanel.Enabled = true;
            }
        }

        private void Counter3Players2Round_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show("Are you sure you want to close JScore?", "Confirms", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void round3Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Counter3Players3Round counter4Players3Round = new Counter3Players3Round(team1Counter.Text, team2Counter.Text, team3Counter.Text,
                team1ScoreR2.Text, team2ScoreR2.Text, team3ScoreR2.Text, points);
            counter4Players3Round.Show();
        }
    }
}
