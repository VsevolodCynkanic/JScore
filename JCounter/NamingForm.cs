﻿using System;
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
    public partial class NamingForm : Form
    {
        public NamingForm()
        {
            InitializeComponent();

            team1NameField.Text = "Enter the name";
            team1NameField.ForeColor = Color.Gray;

            team2NameField.Text = "Enter the name";
            team2NameField.ForeColor = Color.Gray;

            team3NameField.Text = "Enter the name";
            team3NameField.ForeColor = Color.Gray;

            team4NameField.Text = "Enter the name";
            team4NameField.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void team1NameField_Enter(object sender, EventArgs e)
        {
            if(team1NameField.Text == "Enter the name")
            {
               team1NameField.Text = "";
               team1NameField.ForeColor = Color.Black;
            }

        }

        private void team1NameField_Leave(object sender, EventArgs e)
        {
            if (team1NameField.Text == "")
            {
                team1NameField.Text = "Enter the name";
                team1NameField.ForeColor = Color.Gray;
            }
                
        }

        private void team2NameField_Enter(object sender, EventArgs e)
        {
            if (team2NameField.Text == "Enter the name")
            {
                team2NameField.Text = "";
                team2NameField.ForeColor = Color.Black;
            }
        }

        private void team2NameField_Leave(object sender, EventArgs e)
        {
            if (team2NameField.Text == "")
            {
                team2NameField.Text = "Enter the name";
                team2NameField.ForeColor = Color.Gray;
            }
        }

        private void team3NameField_Enter(object sender, EventArgs e)
        {
            if (team3NameField.Text == "Enter the name")
            {
                team3NameField.Text = "";
                team3NameField.ForeColor = Color.Black;
            }
        }

        private void team3NameField_Leave(object sender, EventArgs e)
        {
            if (team3NameField.Text == "")
            {
                team3NameField.Text = "Enter the name";
                team3NameField.ForeColor = Color.Gray;
            }
        }

        private void team4NameField_Enter(object sender, EventArgs e)
        {
            if (team4NameField.Text == "Enter the name")
            {
                team4NameField.Text = "";
                team4NameField.ForeColor = Color.Black;
            }
        }

        private void team4NameField_Leave(object sender, EventArgs e)
        {
            if (team4NameField.Text == "")
            {
                team4NameField.Text = "Enter the name";
                team4NameField.ForeColor = Color.Gray;
            }
        }

        private void buttonSecondPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Counter4Teams counter4Teams = new Counter4Teams(team1NameField.Text, team2NameField.Text, team3NameField.Text, team4NameField.Text);
            counter4Teams.Show();
        }

        private void NamingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
