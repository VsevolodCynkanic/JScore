
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
            this.TypeOfGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfTeams = new System.Windows.Forms.ComboBox();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeOfGame
            // 
            this.TypeOfGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfGame.FormattingEnabled = true;
            this.TypeOfGame.Items.AddRange(new object[] {
            "Xamsa",
            "Jeopardy (TBC)"});
            this.TypeOfGame.Location = new System.Drawing.Point(457, 207);
            this.TypeOfGame.Name = "TypeOfGame";
            this.TypeOfGame.Size = new System.Drawing.Size(292, 32);
            this.TypeOfGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type of game";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(199, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of teams";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NumberOfTeams
            // 
            this.NumberOfTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberOfTeams.FormattingEnabled = true;
            this.NumberOfTeams.Items.AddRange(new object[] {
            "2 (TBC)",
            "3 (TBC)",
            "4"});
            this.NumberOfTeams.Location = new System.Drawing.Point(457, 290);
            this.NumberOfTeams.Name = "NumberOfTeams";
            this.NumberOfTeams.Size = new System.Drawing.Size(292, 32);
            this.NumberOfTeams.TabIndex = 3;
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFirstPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirstPage.Location = new System.Drawing.Point(367, 391);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(193, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(564, 63);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to JCounter";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(902, 482);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFirstPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberOfTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeOfGame);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StartPage";
            this.Text = "JScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartPage_FormClosing);
            this.Load += new System.EventHandler(this.StartPage_Load);
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
    }
}

