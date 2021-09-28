﻿using System;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeOfGame.Text == "Jeopardy (TBC)")
            {
                MessageBox.Show("Sorry, Jeopardy will be added with the future updates. We are working on it.");
                return;
            }
            if (NumberOfTeams.Text == "2 (TBC)")
            {
                MessageBox.Show("Sorry, currently the futurues for 2 teams are not implemented. We are working on it.");
                return;
            }
            if (NumberOfTeams.Text == "3 (TBC)")
            {
                MessageBox.Show("Sorry, currently the futurues for 3 teams are not implemented. We are working on it.");
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
            this.Hide();
            NamingForm namingForm = new NamingForm();
            namingForm.Show();
        }

        private void StartPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
