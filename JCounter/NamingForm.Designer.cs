
namespace JCounter
{
    partial class NamingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.team1NameField = new System.Windows.Forms.TextBox();
            this.team4NameField = new System.Windows.Forms.TextBox();
            this.team3NameField = new System.Windows.Forms.TextBox();
            this.team2NameField = new System.Windows.Forms.TextBox();
            this.buttonSecondPage = new System.Windows.Forms.Button();
            this.homePicture2 = new System.Windows.Forms.PictureBox();
            this.logoStartPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoStartPage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TYPE A NAME OF TEAMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEAM 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(96)))), ((int)(((byte)(46)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(108, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "TEAM 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(23)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "TEAM 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(123)))), ((int)(((byte)(194)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(108, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "TEAM 4";
            // 
            // team1NameField
            // 
            this.team1NameField.Font = new System.Drawing.Font("Tahoma", 16F);
            this.team1NameField.Location = new System.Drawing.Point(226, 210);
            this.team1NameField.MaxLength = 40;
            this.team1NameField.Name = "team1NameField";
            this.team1NameField.Size = new System.Drawing.Size(266, 33);
            this.team1NameField.TabIndex = 1;
            this.team1NameField.Enter += new System.EventHandler(this.team1NameField_Enter);
            this.team1NameField.Leave += new System.EventHandler(this.team1NameField_Leave);
            // 
            // team4NameField
            // 
            this.team4NameField.Font = new System.Drawing.Font("Tahoma", 16F);
            this.team4NameField.Location = new System.Drawing.Point(226, 372);
            this.team4NameField.MaxLength = 40;
            this.team4NameField.Name = "team4NameField";
            this.team4NameField.Size = new System.Drawing.Size(266, 33);
            this.team4NameField.TabIndex = 4;
            this.team4NameField.Enter += new System.EventHandler(this.team4NameField_Enter);
            this.team4NameField.Leave += new System.EventHandler(this.team4NameField_Leave);
            // 
            // team3NameField
            // 
            this.team3NameField.Font = new System.Drawing.Font("Tahoma", 16F);
            this.team3NameField.Location = new System.Drawing.Point(226, 318);
            this.team3NameField.MaxLength = 40;
            this.team3NameField.Name = "team3NameField";
            this.team3NameField.Size = new System.Drawing.Size(266, 33);
            this.team3NameField.TabIndex = 3;
            this.team3NameField.Enter += new System.EventHandler(this.team3NameField_Enter);
            this.team3NameField.Leave += new System.EventHandler(this.team3NameField_Leave);
            // 
            // team2NameField
            // 
            this.team2NameField.Font = new System.Drawing.Font("Tahoma", 16F);
            this.team2NameField.Location = new System.Drawing.Point(226, 264);
            this.team2NameField.MaxLength = 40;
            this.team2NameField.Name = "team2NameField";
            this.team2NameField.Size = new System.Drawing.Size(266, 33);
            this.team2NameField.TabIndex = 2;
            this.team2NameField.Enter += new System.EventHandler(this.team2NameField_Enter);
            this.team2NameField.Leave += new System.EventHandler(this.team2NameField_Leave);
            // 
            // buttonSecondPage
            // 
            this.buttonSecondPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSecondPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSecondPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSecondPage.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSecondPage.ForeColor = System.Drawing.Color.White;
            this.buttonSecondPage.Location = new System.Drawing.Point(226, 461);
            this.buttonSecondPage.Name = "buttonSecondPage";
            this.buttonSecondPage.Size = new System.Drawing.Size(148, 53);
            this.buttonSecondPage.TabIndex = 5;
            this.buttonSecondPage.Text = "START";
            this.buttonSecondPage.UseVisualStyleBackColor = true;
            this.buttonSecondPage.Click += new System.EventHandler(this.buttonSecondPage_Click);
            // 
            // homePicture2
            // 
            this.homePicture2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homePicture2.Image = global::JCounter.Properties.Resources.home;
            this.homePicture2.Location = new System.Drawing.Point(22, 22);
            this.homePicture2.Name = "homePicture2";
            this.homePicture2.Size = new System.Drawing.Size(33, 34);
            this.homePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture2.TabIndex = 6;
            this.homePicture2.TabStop = false;
            this.homePicture2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homePicture2_MouseClick);
            // 
            // logoStartPage
            // 
            this.logoStartPage.Image = global::JCounter.Properties.Resources.applogo;
            this.logoStartPage.Location = new System.Drawing.Point(258, 60);
            this.logoStartPage.Name = "logoStartPage";
            this.logoStartPage.Size = new System.Drawing.Size(84, 84);
            this.logoStartPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoStartPage.TabIndex = 8;
            this.logoStartPage.TabStop = false;
            // 
            // NamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(584, 567);
            this.Controls.Add(this.logoStartPage);
            this.Controls.Add(this.homePicture2);
            this.Controls.Add(this.buttonSecondPage);
            this.Controls.Add(this.team2NameField);
            this.Controls.Add(this.team3NameField);
            this.Controls.Add(this.team4NameField);
            this.Controls.Add(this.team1NameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NamingForm";
            this.Text = "JScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NamingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.homePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoStartPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox team1NameField;
        private System.Windows.Forms.TextBox team4NameField;
        private System.Windows.Forms.TextBox team3NameField;
        private System.Windows.Forms.TextBox team2NameField;
        private System.Windows.Forms.Button buttonSecondPage;
        private System.Windows.Forms.PictureBox homePicture2;
        private System.Windows.Forms.PictureBox logoStartPage;
    }
}