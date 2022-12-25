namespace Dodge_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.topLabel = new System.Windows.Forms.Label();
            this.escapeLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.easyLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.topLabel.Location = new System.Drawing.Point(233, 57);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(291, 98);
            this.topLabel.TabIndex = 3;
            this.topLabel.Text = "Game Over!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.Visible = false;
            // 
            // escapeLabel
            // 
            this.escapeLabel.BackColor = System.Drawing.Color.Transparent;
            this.escapeLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.escapeLabel.Location = new System.Drawing.Point(416, 220);
            this.escapeLabel.Name = "escapeLabel";
            this.escapeLabel.Size = new System.Drawing.Size(213, 36);
            this.escapeLabel.TabIndex = 4;
            this.escapeLabel.Text = "Press \"Escape\" to Exit";
            this.escapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.winLabel.Location = new System.Drawing.Point(213, 142);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(344, 66);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "Player (1 || 2) Wins With a Final Score of (#) to (#)!";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // easyLabel
            // 
            this.easyLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.easyLabel.Location = new System.Drawing.Point(100, 182);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(268, 39);
            this.easyLabel.TabIndex = 6;
            this.easyLabel.Text = "Press \"E\" for Easy Difficulty";
            this.easyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mediumLabel
            // 
            this.mediumLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediumLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.mediumLabel.Location = new System.Drawing.Point(77, 222);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(291, 34);
            this.mediumLabel.TabIndex = 7;
            this.mediumLabel.Text = "Press \"M\" for Medium Difficulty";
            this.mediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardLabel
            // 
            this.hardLabel.BackColor = System.Drawing.Color.Transparent;
            this.hardLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.hardLabel.Location = new System.Drawing.Point(388, 181);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(279, 39);
            this.hardLabel.TabIndex = 8;
            this.hardLabel.Text = "Press \"H\" for Hard Difficulty";
            this.hardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.timeLabel.Location = new System.Drawing.Point(0, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(294, 39);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time Left: (time)";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeLabel.Visible = false;
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.p1ScoreLabel.Location = new System.Drawing.Point(12, 381);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(102, 63);
            this.p1ScoreLabel.TabIndex = 10;
            this.p1ScoreLabel.Text = "0";
            this.p1ScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.p1ScoreLabel.Visible = false;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.p2ScoreLabel.Location = new System.Drawing.Point(667, 381);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(102, 63);
            this.p2ScoreLabel.TabIndex = 11;
            this.p2ScoreLabel.Text = "0";
            this.p2ScoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.p2ScoreLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.escapeLabel);
            this.Controls.Add(this.topLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Space Race";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label escapeLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label easyLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
    }
}

