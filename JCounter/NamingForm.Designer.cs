
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
            ((System.ComponentModel.ISupportInitialize)(this.homePicture2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type a name of teams/participants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(229, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(96)))), ((int)(((byte)(46)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(229, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Team 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(23)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(229, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Team 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(123)))), ((int)(((byte)(194)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(229, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Team 4";
            // 
            // team1NameField
            // 
            this.team1NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.team1NameField.Location = new System.Drawing.Point(353, 134);
            this.team1NameField.Name = "team1NameField";
            this.team1NameField.Size = new System.Drawing.Size(214, 30);
            this.team1NameField.TabIndex = 1;
            this.team1NameField.Enter += new System.EventHandler(this.team1NameField_Enter);
            this.team1NameField.Leave += new System.EventHandler(this.team1NameField_Leave);
            // 
            // team4NameField
            // 
            this.team4NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.team4NameField.Location = new System.Drawing.Point(353, 292);
            this.team4NameField.Name = "team4NameField";
            this.team4NameField.Size = new System.Drawing.Size(214, 30);
            this.team4NameField.TabIndex = 4;
            this.team4NameField.Enter += new System.EventHandler(this.team4NameField_Enter);
            this.team4NameField.Leave += new System.EventHandler(this.team4NameField_Leave);
            // 
            // team3NameField
            // 
            this.team3NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.team3NameField.Location = new System.Drawing.Point(353, 240);
            this.team3NameField.Name = "team3NameField";
            this.team3NameField.Size = new System.Drawing.Size(214, 30);
            this.team3NameField.TabIndex = 3;
            this.team3NameField.Enter += new System.EventHandler(this.team3NameField_Enter);
            this.team3NameField.Leave += new System.EventHandler(this.team3NameField_Leave);
            // 
            // team2NameField
            // 
            this.team2NameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.team2NameField.Location = new System.Drawing.Point(353, 188);
            this.team2NameField.Name = "team2NameField";
            this.team2NameField.Size = new System.Drawing.Size(214, 30);
            this.team2NameField.TabIndex = 2;
            this.team2NameField.Enter += new System.EventHandler(this.team2NameField_Enter);
            this.team2NameField.Leave += new System.EventHandler(this.team2NameField_Leave);
            // 
            // buttonSecondPage
            // 
            this.buttonSecondPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSecondPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSecondPage.Location = new System.Drawing.Point(315, 363);
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
            this.homePicture2.Location = new System.Drawing.Point(12, 12);
            this.homePicture2.Name = "homePicture2";
            this.homePicture2.Size = new System.Drawing.Size(33, 34);
            this.homePicture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture2.TabIndex = 6;
            this.homePicture2.TabStop = false;
            this.homePicture2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homePicture2_MouseClick);
            // 
            // NamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(44)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "NamingForm";
            this.Text = "JScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NamingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.homePicture2)).EndInit();
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
    }
}