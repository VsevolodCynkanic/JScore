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
    public partial class Counter4Players3Round : Form
    {
        public Counter4Players3Round(string team1name, string team2name, string team3name, string team4name,
            string team1ScoreR2, string team2ScoreR2, string team3ScoreR2, string team4ScoreR2, int[] points)
        {
            InitializeComponent();
            team1Counter.Text = team1name;
            team2Counter.Text = team2name;
            team3Counter.Text = team3name;
            team4Counter.Text = team4name;
            team1ScoreR3.Text = team1ScoreR2;
            team2ScoreR3.Text = team2ScoreR2;
            team3ScoreR3.Text = team3ScoreR2;
            team4ScoreR3.Text = team4ScoreR2;
            this.points = points;
        }
        int point300 = 300;
        int point600 = 600;
        int point900 = 900;
        int point1200 = 1200;
        int point1500 = 1500;
        int[] points = new int[4];

        private void plusTeam1_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[0] += point300;
                team1ScoreR3.Text = points[0].ToString();
                points300R3.Checked = false;
                points600R3.Checked = true;
            }
            else if (points600R3.Checked)
            {
                points[0] += point600;
                team1ScoreR3.Text = points[0].ToString();
                points600R3.Checked = false;
                points900R3.Checked = true;
            }
            else if (points900R3.Checked)
            {
                points[0] += point900;
                team1ScoreR3.Text = points[0].ToString();
                points900R3.Checked = false;
                points1200R3.Checked = true;
            }
            else if (points1200R3.Checked)
            {
                points[0] += point1200;
                team1ScoreR3.Text = points[0].ToString();
                points1200R3.Checked = false;
                points1500R3.Checked = true;
            }
            else if (points1500R3.Checked)
            {
                points[0] += point1500;
                team1ScoreR3.Text = points[0].ToString();
                points1500R3.Checked = false;
                points300R3.Checked = true;
            }
        }

        private void plusTeam2_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[1] += point300;
                team2ScoreR3.Text = points[1].ToString();
                points300R3.Checked = false;
                points600R3.Checked = true;
            }
            else if (points600R3.Checked)
            {
                points[1] += point600;
                team2ScoreR3.Text = points[1].ToString();
                points600R3.Checked = false;
                points900R3.Checked = true;
            }
            else if (points900R3.Checked)
            {
                points[1] += point900;
                team2ScoreR3.Text = points[1].ToString();
                points900R3.Checked = false;
                points1200R3.Checked = true;
            }
            else if (points1200R3.Checked)
            {
                points[1] += point1200;
                team2ScoreR3.Text = points[1].ToString();
                points1200R3.Checked = false;
                points1500R3.Checked = true;
            }
            else if (points1500R3.Checked)
            {
                points[1] += point1500;
                team2ScoreR3.Text = points[1].ToString();
                points1500R3.Checked = false;
                points300R3.Checked = true;
            }
        }

        private void plusTeam3_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[2] += point300;
                team3ScoreR3.Text = points[2].ToString();
                points300R3.Checked = false;
                points600R3.Checked = true;
            }
            else if (points600R3.Checked)
            {
                points[2] += point600;
                team3ScoreR3.Text = points[2].ToString();
                points600R3.Checked = false;
                points900R3.Checked = true;
            }
            else if (points900R3.Checked)
            {
                points[2] += point900;
                team3ScoreR3.Text = points[2].ToString();
                points900R3.Checked = false;
                points1200R3.Checked = true;
            }
            else if (points1200R3.Checked)
            {
                points[2] += point1200;
                team3ScoreR3.Text = points[2].ToString();
                points1200R3.Checked = false;
                points1500R3.Checked = true;
            }
            else if (points1500R3.Checked)
            {
                points[2] += point1500;
                team3ScoreR3.Text = points[2].ToString();
                points1500R3.Checked = false;
                points300R3.Checked = true;
            }
        }

        private void plusTeam4_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[3] += point300;
                team4ScoreR3.Text = points[3].ToString();
                points300R3.Checked = false;
                points600R3.Checked = true;
            }
            else if (points600R3.Checked)
            {
                points[3] += point600;
                team4ScoreR3.Text = points[3].ToString();
                points600R3.Checked = false;
                points900R3.Checked = true;
            }
            else if (points900R3.Checked)
            {
                points[3] += point900;
                team4ScoreR3.Text = points[3].ToString();
                points900R3.Checked = false;
                points1200R3.Checked = true;
            }
            else if (points1200R3.Checked)
            {
                points[3] += point1200;
                team4ScoreR3.Text = points[3].ToString();
                points1200R3.Checked = false;
                points1500R3.Checked = true;
            }
            else if (points1500R3.Checked)
            {
                points[3] += point1500;
                team4ScoreR3.Text = points[3].ToString();
                points1500R3.Checked = false;
                points300R3.Checked = true;
            }
        }

        private void minusTeam1_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[0] -= point300;
                team1ScoreR3.Text = points[0].ToString();
            }
            else if (points600R3.Checked)
            {
                points[0] -= point600;
                team1ScoreR3.Text = points[0].ToString();
            }
            else if (points900R3.Checked)
            {
                points[0] -= point900;
                team1ScoreR3.Text = points[0].ToString();
            }
            else if (points1200R3.Checked)
            {
                points[0] -= point1200;
                team1ScoreR3.Text = points[0].ToString();
            }
            else if (points1500R3.Checked)
            {
                points[0] -= point1500;
                team1ScoreR3.Text = points[0].ToString();
            }
        }

        private void minusTeam2_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[1] -= point300;
                team2ScoreR3.Text = points[1].ToString();
            }
            else if (points600R3.Checked)
            {
                points[1] -= point600;
                team2ScoreR3.Text = points[1].ToString();
            }
            else if (points900R3.Checked)
            {
                points[1] -= point900;
                team2ScoreR3.Text = points[1].ToString();
            }
            else if (points1200R3.Checked)
            {
                points[1] -= point1200;
                team2ScoreR3.Text = points[1].ToString();
            }
            else if (points1500R3.Checked)
            {
                points[1] -= point1500;
                team2ScoreR3.Text = points[1].ToString();
            }
        }
        private void minusTeam3_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[2] -= point300;
                team3ScoreR3.Text = points[2].ToString();
            }
            else if (points600R3.Checked)
            {
                points[2] -= point600;
                team3ScoreR3.Text = points[2].ToString();
            }
            else if (points900R3.Checked)
            {
                points[2] -= point900;
                team3ScoreR3.Text = points[2].ToString();
            }
            else if (points1200R3.Checked)
            {
                points[2] -= point900;
                team3ScoreR3.Text = points[2].ToString();
            }
            else if (points1500R3.Checked)
            {
                points[2] -= point1500;
                team3ScoreR3.Text = points[2].ToString();
            }
        }

        private void minusTeam4_Click(object sender, EventArgs e)
        {
            if (points300R3.Checked)
            {
                points[3] -= point300;
                team4ScoreR3.Text = points[3].ToString();
            }
            else if (points600R3.Checked)
            {
                points[3] -= point600;
                team4ScoreR3.Text = points[3].ToString();
            }
            else if (points900R3.Checked)
            {
                points[3] -= point900;
                team4ScoreR3.Text = points[3].ToString();
            }
            else if (points1200R3.Checked)
            {
                points[3] -= point1200;
                team4ScoreR3.Text = points[3].ToString();
            }
            else if (points1500R3.Checked)
            {
                points[3] -= point1500;
                team4ScoreR3.Text = points[3].ToString();
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

        private void Counter4Players3Round_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialog = MessageBox.Show("Do you want to close the JCounter?", "Confirms", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void resetButton_Click(object sender, EventArgs e)
        {
            points[0] = 0;
            team1ScoreR3.Text = points[0].ToString();
            points[1] = 0;
            team2ScoreR3.Text = points[1].ToString();
            points[2] = 0;
            team3ScoreR3.Text = points[2].ToString();
            points[3] = 0;
            team4ScoreR3.Text = points[3].ToString();
            points300R3.Checked = true;
        }
    }
}
