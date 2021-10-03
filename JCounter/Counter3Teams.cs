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
    public partial class Counter3Teams : Form
    {
        public Counter3Teams(string team1name, string team2name, string team3name)
        {
            InitializeComponent();
            team1Counter.Text = team1name;
            team2Counter.Text = team2name;
            team3Counter.Text = team3name;
        }
        int point100 = 100;
        int point200 = 200;
        int point300 = 300;
        int point400 = 400;
        int point500 = 500;
        int[] points = new int[4];

        private void plusTeam1_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[0] += point100;
                team1Score.Text = points[0].ToString();
                points100.Checked = false;
                points200.Checked = true;
            }
            else if (points200.Checked)
            {
                points[0] += point200;
                team1Score.Text = points[0].ToString();
                points200.Checked = false;
                points300.Checked = true;
            }
            else if (points300.Checked)
            {
                points[0] += point300;
                team1Score.Text = points[0].ToString();
                points300.Checked = false;
                points400.Checked = true;
            }
            else if (points400.Checked)
            {
                points[0] += point400;
                team1Score.Text = points[0].ToString();
                points400.Checked = false;
                points500.Checked = true;
            }
            else if (points500.Checked)
            {
                points[0] += point500;
                team1Score.Text = points[0].ToString();
                points500.Checked = false;
                points100.Checked = true;
            }
        }

        private void plusTeam2_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[1] += point100;
                team2Score.Text = points[1].ToString();
                points100.Checked = false;
                points200.Checked = true;
            }
            else if (points200.Checked)
            {
                points[1] += point200;
                team2Score.Text = points[1].ToString();
                points200.Checked = false;
                points300.Checked = true;
            }
            else if (points300.Checked)
            {
                points[1] += point300;
                team2Score.Text = points[1].ToString();
                points300.Checked = false;
                points400.Checked = true;
            }
            else if (points400.Checked)
            {
                points[1] += point400;
                team2Score.Text = points[1].ToString();
                points400.Checked = false;
                points500.Checked = true;
            }
            else if (points500.Checked)
            {
                points[1] += point500;
                team2Score.Text = points[1].ToString();
                points500.Checked = false;
                points100.Checked = true;
            }
        }

        private void plusTeam3_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[2] += point100;
                team3Score.Text = points[2].ToString();
                points100.Checked = false;
                points200.Checked = true;
            }
            else if (points200.Checked)
            {
                points[2] += point200;
                team3Score.Text = points[2].ToString();
                points200.Checked = false;
                points300.Checked = true;
            }
            else if (points300.Checked)
            {
                points[2] += point300;
                team3Score.Text = points[2].ToString();
                points300.Checked = false;
                points400.Checked = true;
            }
            else if (points400.Checked)
            {
                points[2] += point400;
                team3Score.Text = points[2].ToString();
                points400.Checked = false;
                points500.Checked = true;
            }
            else if (points500.Checked)
            {
                points[2] += point500;
                team3Score.Text = points[2].ToString();
                points500.Checked = false;
                points100.Checked = true;
            }
        }

        private void minusTeam1_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[0] -= point100;
                team1Score.Text = points[0].ToString();
            }
            else if (points200.Checked)
            {
                points[0] -= point200;
                team1Score.Text = points[0].ToString();
            }
            else if (points300.Checked)
            {
                points[0] -= point300;
                team1Score.Text = points[0].ToString();
            }
            else if (points400.Checked)
            {
                points[0] -= point400;
                team1Score.Text = points[0].ToString();
            }
            else if (points500.Checked)
            {
                points[0] -= point500;
                team1Score.Text = points[0].ToString();
            }
        }

        private void minusTeam2_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[1] -= point100;
                team2Score.Text = points[1].ToString();
            }
            else if (points200.Checked)
            {
                points[1] -= point200;
                team2Score.Text = points[1].ToString();
            }
            else if (points300.Checked)
            {
                points[1] -= point300;
                team2Score.Text = points[1].ToString();
            }
            else if (points400.Checked)
            {
                points[1] -= point400;
                team2Score.Text = points[1].ToString();
            }
            else if (points500.Checked)
            {
                points[1] -= point500;
                team2Score.Text = points[1].ToString();
            }
        }

        private void minusTeam3_Click(object sender, EventArgs e)
        {
            if (points100.Checked)
            {
                points[2] -= point100;
                team3Score.Text = points[2].ToString();
            }
            else if (points200.Checked)
            {
                points[2] -= point200;
                team3Score.Text = points[2].ToString();
            }
            else if (points300.Checked)
            {
                points[2] -= point300;
                team3Score.Text = points[2].ToString();
            }
            else if (points400.Checked)
            {
                points[2] -= point400;
                team3Score.Text = points[2].ToString();
            }
            else if (points500.Checked)
            {
                points[2] -= point500;
                team3Score.Text = points[2].ToString();
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            points[0] = 0;
            team1Score.Text = points[0].ToString();
            points[1] = 0;
            team2Score.Text = points[1].ToString();
            points[2] = 0;
            team3Score.Text = points[2].ToString();
            points[3] = 0;
        }

        private void Counter3Teams_FormClosing(object sender, FormClosingEventArgs e)
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

        private void round2Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Counter3Players2Round counter3Players2Round = new Counter3Players2Round(team1Counter.Text, team2Counter.Text, team3Counter.Text,
                team1Score.Text, team2Score.Text, team3Score.Text, points);
            counter3Players2Round.Show();
        }
    }
}
