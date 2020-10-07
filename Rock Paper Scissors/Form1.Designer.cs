namespace Rock_Paper_Scissors
{
    partial class MainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblScoreNum = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.grpPlayerChoice = new System.Windows.Forms.GroupBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblRoundPop = new System.Windows.Forms.Label();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grpPlayerChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Acceptance Letter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(21, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(314, 63);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Rock Paper Scissors\r\nBest out of 3 wins!";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Indigo;
            this.lblScore.Location = new System.Drawing.Point(109, 422);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 27);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVs
            // 
            this.lblVs.Font = new System.Drawing.Font("Acceptance Letter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.ForeColor = System.Drawing.Color.Indigo;
            this.lblVs.Location = new System.Drawing.Point(145, 171);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(63, 40);
            this.lblVs.TabIndex = 5;
            this.lblVs.Text = "V.S";
            this.lblVs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreNum
            // 
            this.lblScoreNum.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNum.Location = new System.Drawing.Point(173, 424);
            this.lblScoreNum.Name = "lblScoreNum";
            this.lblScoreNum.Size = new System.Drawing.Size(68, 23);
            this.lblScoreNum.TabIndex = 10;
            this.lblScoreNum.Text = "0 / 0";
            this.lblScoreNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Acceptance Letter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(30, 84);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(109, 32);
            this.lblPlayer.TabIndex = 11;
            this.lblPlayer.Text = "You";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpponent
            // 
            this.lblOpponent.Font = new System.Drawing.Font("Acceptance Letter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.Location = new System.Drawing.Point(214, 84);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(113, 32);
            this.lblOpponent.TabIndex = 12;
            this.lblOpponent.Text = "Opponent";
            this.lblOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radPaper
            // 
            this.radPaper.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.radPaper.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.ForeColor = System.Drawing.Color.ForestGreen;
            this.radPaper.Location = new System.Drawing.Point(107, 26);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(87, 24);
            this.radPaper.TabIndex = 14;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // grpPlayerChoice
            // 
            this.grpPlayerChoice.Controls.Add(this.radPaper);
            this.grpPlayerChoice.Controls.Add(this.radScissors);
            this.grpPlayerChoice.Controls.Add(this.radRock);
            this.grpPlayerChoice.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPlayerChoice.Location = new System.Drawing.Point(28, 236);
            this.grpPlayerChoice.Name = "grpPlayerChoice";
            this.grpPlayerChoice.Size = new System.Drawing.Size(299, 67);
            this.grpPlayerChoice.TabIndex = 16;
            this.grpPlayerChoice.TabStop = false;
            this.grpPlayerChoice.Text = "Players Choice";
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = global::Rock_Paper_Scissors.Properties.Resources.QuestionMark;
            this.imgOpponent.Location = new System.Drawing.Point(214, 119);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(113, 109);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 1;
            this.imgOpponent.TabStop = false;
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources.QuestionMark;
            this.imgPlayer.Location = new System.Drawing.Point(28, 119);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(111, 109);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 0;
            this.imgPlayer.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gold;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Acceptance Letter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(28, 314);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 61);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblRoundPop
            // 
            this.lblRoundPop.BackColor = System.Drawing.Color.Indigo;
            this.lblRoundPop.Font = new System.Drawing.Font("Acceptance Letter", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundPop.ForeColor = System.Drawing.Color.Gold;
            this.lblRoundPop.Location = new System.Drawing.Point(28, 384);
            this.lblRoundPop.Name = "lblRoundPop";
            this.lblRoundPop.Size = new System.Drawing.Size(299, 32);
            this.lblRoundPop.TabIndex = 18;
            this.lblRoundPop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Checked = true;
            this.radRock.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.ForeColor = System.Drawing.Color.SteelBlue;
            this.radRock.Location = new System.Drawing.Point(17, 26);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(69, 21);
            this.radRock.TabIndex = 13;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.Font = new System.Drawing.Font("Acceptance Letter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.ForeColor = System.Drawing.Color.Red;
            this.radScissors.Location = new System.Drawing.Point(200, 26);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(88, 24);
            this.radScissors.TabIndex = 15;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(354, 451);
            this.Controls.Add(this.lblRoundPop);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.grpPlayerChoice);
            this.Name = "MainForm";
            this.Text = "Rock, Paper, Scissors ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpPlayerChoice.ResumeLayout(false);
            this.grpPlayerChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblScoreNum;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.GroupBox grpPlayerChoice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRoundPop;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radRock;
    }
}

