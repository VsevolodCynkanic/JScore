
namespace JCounter
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.TypeOfGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfTeams = new System.Windows.Forms.ComboBox();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logoStartPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoStartPage)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeOfGame
            // 
            this.TypeOfGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfGame.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfGame.FormattingEnabled = true;
            this.TypeOfGame.Items.AddRange(new object[] {
            "Xamsa",
            "Jeopardy"});
            this.TypeOfGame.Location = new System.Drawing.Point(316, 255);
            this.TypeOfGame.Name = "TypeOfGame";
            this.TypeOfGame.Size = new System.Drawing.Size(162, 27);
            this.TypeOfGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(122, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "TYPE OF GAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(122, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "NUMBER OF TEAMS";
            // 
            // NumberOfTeams
            // 
            this.NumberOfTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfTeams.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTeams.FormattingEnabled = true;
            this.NumberOfTeams.Items.AddRange(new object[] {
            "3",
            "4"});
            this.NumberOfTeams.Location = new System.Drawing.Point(316, 338);
            this.NumberOfTeams.Name = "NumberOfTeams";
            this.NumberOfTeams.Size = new System.Drawing.Size(162, 27);
            this.NumberOfTeams.TabIndex = 3;
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFirstPage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstPage.Location = new System.Drawing.Point(226, 438);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(148, 53);
            this.buttonFirstPage.TabIndex = 5;
            this.buttonFirstPage.Text = "OK";
            this.buttonFirstPage.UseVisualStyleBackColor = true;
            this.buttonFirstPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "WELCOME TO JSCORE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoStartPage
            // 
            this.logoStartPage.Image = global::JCounter.Properties.Resources.applogo;
            this.logoStartPage.Location = new System.Drawing.Point(258, 77);
            this.logoStartPage.Name = "logoStartPage";
            this.logoStartPage.Size = new System.Drawing.Size(84, 84);
            this.logoStartPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStartPage.TabIndex = 7;
            this.logoStartPage.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(584, 567);
            this.Controls.Add(this.logoStartPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFirstPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfGame);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 606);
            this.MinimumSize = new System.Drawing.Size(600, 606);
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartPage_FormClosing);
            this.Load += new System.EventHandler(this.StartPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoStartPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TypeOfGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NumberOfTeams;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logoStartPage;
    }
}

