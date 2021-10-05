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
    public partial class CounterJeopardy : Form
    {
        public CounterJeopardy(string team1name, string team2name, string team3name, string team4name)
        {
            InitializeComponent();
            team1Counter.Text = team1name;
            team2Counter.Text = team2name;
            team3Counter.Text = team3name;
            team4Counter.Text = team4name;
        }
        int point10 = 10;
        int point20 = 20;
        int point30 = 30;
        int point40 = 40;
        int point50 = 50;
        int[] points = new int[4];

        private void plusTeam1_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[0] += point10;
                team1Score.Text = points[0].ToString();
                points10.Checked = false;
                points20.Checked = true;
            }
            else if (points20.Checked)
            {
                points[0] += point20;
                team1Score.Text = points[0].ToString();
                points20.Checked = false;
                points30.Checked = true;
            }
            else if (points30.Checked)
            {
                points[0] += point30;
                team1Score.Text = points[0].ToString();
                points30.Checked = false;
                points40.Checked = true;
            }
            else if (points40.Checked)
            {
                points[0] += point40;
                team1Score.Text = points[0].ToString();
                points40.Checked = false;
                points50.Checked = true;
            }
            else if (points50.Checked)
            {
                points[0] += point50;
                team1Score.Text = points[0].ToString();
                points50.Checked = false;
                points10.Checked = true;
            }
        }

        private void plusTeam2_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[1] += point10;
                team2Score.Text = points[1].ToString();
                points10.Checked = false;
                points20.Checked = true;
            }
            else if (points20.Checked)
            {
                points[1] += point20;
                team2Score.Text = points[1].ToString();
                points20.Checked = false;
                points30.Checked = true;
            }
            else if (points30.Checked)
            {
                points[1] += point30;
                team2Score.Text = points[1].ToString();
                points30.Checked = false;
                points40.Checked = true;
            }
            else if (points40.Checked)
            {
                points[1] += point40;
                team2Score.Text = points[1].ToString();
                points40.Checked = false;
                points50.Checked = true;
            }
            else if (points50.Checked)
            {
                points[1] += point50;
                team2Score.Text = points[1].ToString();
                points50.Checked = false;
                points10.Checked = true;
            }
        }

        private void plusTeam3_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[2] += point10;
                team3Score.Text = points[2].ToString();
                points10.Checked = false;
                points20.Checked = true;
            }
            else if (points20.Checked)
            {
                points[2] += point20;
                team3Score.Text = points[2].ToString();
                points20.Checked = false;
                points30.Checked = true;
            }
            else if (points30.Checked)
            {
                points[2] += point30;
                team3Score.Text = points[2].ToString();
                points30.Checked = false;
                points40.Checked = true;
            }
            else if (points40.Checked)
            {
                points[2] += point40;
                team3Score.Text = points[2].ToString();
                points40.Checked = false;
                points50.Checked = true;
            }
            else if (points50.Checked)
            {
                points[2] += point50;
                team3Score.Text = points[2].ToString();
                points50.Checked = false;
                points10.Checked = true;
            }
        }

        private void plusTeam4_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[3] += point10;
                team4Score.Text = points[3].ToString();
                points10.Checked = false;
                points20.Checked = true;
            }
            else if (points20.Checked)
            {
                points[3] += point20;
                team4Score.Text = points[3].ToString();
                points20.Checked = false;
                points30.Checked = true;
            }
            else if (points30.Checked)
            {
                points[3] += point30;
                team4Score.Text = points[3].ToString();
                points30.Checked = false;
                points40.Checked = true;
            }
            else if (points40.Checked)
            {
                points[3] += point40;
                team4Score.Text = points[3].ToString();
                points40.Checked = false;
                points50.Checked = true;
            }
            else if (points50.Checked)
            {
                points[3] += point50;
                team4Score.Text = points[3].ToString();
                points50.Checked = false;
                points10.Checked = true;
            }
        }

        private void minusTeam1_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[0] -= point10;
                team1Score.Text = points[0].ToString();
            }
            else if (points20.Checked)
            {
                points[0] -= point20;
                team1Score.Text = points[0].ToString();
            }
            else if (points30.Checked)
            {
                points[0] -= point30;
                team1Score.Text = points[0].ToString();
            }
            else if (points40.Checked)
            {
                points[0] -= point40;
                team1Score.Text = points[0].ToString();
            }
            else if (points50.Checked)
            {
                points[0] -= point50;
                team1Score.Text = points[0].ToString();
            }
        }

        private void minusTeam2_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[1] -= point10;
                team2Score.Text = points[1].ToString();
            }
            else if (points20.Checked)
            {
                points[1] -= point20;
                team2Score.Text = points[1].ToString();
            }
            else if (points30.Checked)
            {
                points[1] -= point30;
                team2Score.Text = points[1].ToString();
            }
            else if (points40.Checked)
            {
                points[1] -= point40;
                team2Score.Text = points[1].ToString();
            }
            else if (points50.Checked)
            {
                points[1] -= point50;
                team2Score.Text = points[1].ToString();
            }
        }

        private void minusTeam3_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[2] -= point10;
                team3Score.Text = points[2].ToString();
            }
            else if (points20.Checked)
            {
                points[2] -= point20;
                team3Score.Text = points[2].ToString();
            }
            else if (points30.Checked)
            {
                points[2] -= point30;
                team3Score.Text = points[2].ToString();
            }
            else if (points40.Checked)
            {
                points[2] -= point40;
                team3Score.Text = points[2].ToString();
            }
            else if (points50.Checked)
            {
                points[2] -= point50;
                team3Score.Text = points[2].ToString();
            }
        }

        private void minusTeam4_Click(object sender, EventArgs e)
        {
            if (points10.Checked)
            {
                points[3] -= point10;
                team4Score.Text = points[3].ToString();
            }
            else if (points20.Checked)
            {
                points[3] -= point20;
                team4Score.Text = points[3].ToString();
            }
            else if (points30.Checked)
            {
                points[3] -= point30;
                team4Score.Text = points[3].ToString();
            }
            else if (points40.Checked)
            {
                points[3] -= point40;
                team4Score.Text = points[3].ToString();
            }
            else if (points50.Checked)
            {
                points[3] -= point50;
                team4Score.Text = points[3].ToString();
            }
        }

        private void CounterJeopardy_FormClosing(object sender, FormClosingEventArgs e)
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
            team4Score.Text = points[3].ToString();
            points10.Checked = true;
        }
    }
}
