using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JCounter
{
    public partial class StartPage : Form
    {
        Font cocoFat;
        Font cocoAlt;

        public StartPage()
        {
            InitializeComponent();
        }
        private void LoadFont()
        {
            PrivateFontCollection custom_font_cocofat = new PrivateFontCollection();
            PrivateFontCollection custom_font_cocoalternative = new PrivateFontCollection();
            custom_font_cocofat.AddFontFile("coco-gothic.fat");
            custom_font_cocoalternative.AddFontFile("CocoGothicAlternative");
            cocoFat = new Font(custom_font_cocofat.Families[0], 18);
            cocoAlt = new Font(custom_font_cocoalternative.Families[1], 10);
        }

        private void JCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeOfGame.Text == "Jeopardy" && NumberOfTeams.Text == "4")
            {
                this.Hide();
                NamingFormJeopardy namingFormJeopardy = new NamingFormJeopardy();
                namingFormJeopardy.Show();
            }
            if (TypeOfGame.Text == "Jeopardy" && NumberOfTeams.Text == "3")
            {
                MessageBox.Show("Jeopardy is game only for 4 players. Please choose \"four players\".");
                return;
            }
            if (TypeOfGame.Text == "")
            {
                MessageBox.Show("Choose the type of game");
                return;
            }
            if (NumberOfTeams.Text == "")
            {
                MessageBox.Show("Choose the number of teams or participants");
                return;
            }
            if (TypeOfGame.Text == "Xamsa" && NumberOfTeams.Text == "4")
            {
                this.Hide();
                NamingForm namingForm = new NamingForm();
                namingForm.Show();
            }
            if (TypeOfGame.Text == "Xamsa" && NumberOfTeams.Text == "3")
            {
                this.Hide();
                NamingForm3Players namingForm3Players = new NamingForm3Players();
                namingForm3Players.Show();
            }
            
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
