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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.topLabel = new System.Windows.Forms.Label();
            this.escapeLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.easyLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
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
            this.topLabel.Location = new System.Drawing.Point(175, 46);
            this.topLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(218, 80);
            this.topLabel.TabIndex = 3;
            this.topLabel.Text = "You Win!";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.Visible = false;
            // 
            // escapeLabel
            // 
            this.escapeLabel.BackColor = System.Drawing.Color.Transparent;
            this.escapeLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escapeLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.escapeLabel.Location = new System.Drawing.Point(312, 179);
            this.escapeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.escapeLabel.Name = "escapeLabel";
            this.escapeLabel.Size = new System.Drawing.Size(160, 29);
            this.escapeLabel.TabIndex = 4;
            this.escapeLabel.Text = "Press \"Escape\" to Exit";
            this.escapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Aquamarine;
            this.winLabel.Location = new System.Drawing.Point(160, 115);
            this.winLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(258, 54);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "You Took (Time) Seconds to Win on (Difficulty) Mode!";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // easyLabel
            // 
            this.easyLabel.BackColor = System.Drawing.Color.Transparent;
            this.easyLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.easyLabel.Location = new System.Drawing.Point(75, 148);
            this.easyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.easyLabel.Name = "easyLabel";
            this.easyLabel.Size = new System.Drawing.Size(201, 32);
            this.easyLabel.TabIndex = 6;
            this.easyLabel.Text = "Press \"E\" for Easy Difficulty";
            this.easyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mediumLabel
            // 
            this.mediumLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediumLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.mediumLabel.Location = new System.Drawing.Point(58, 180);
            this.mediumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(218, 28);
            this.mediumLabel.TabIndex = 7;
            this.mediumLabel.Text = "Press \"M\" for Medium Difficulty";
            this.mediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hardLabel
            // 
            this.hardLabel.BackColor = System.Drawing.Color.Transparent;
            this.hardLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.Color.Turquoise;
            this.hardLabel.Location = new System.Drawing.Point(291, 147);
            this.hardLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(209, 32);
            this.hardLabel.TabIndex = 8;
            this.hardLabel.Text = "Press \"H\" for Hard Difficulty";
            this.hardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.easyLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.escapeLabel);
            this.Controls.Add(this.topLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Catch Game";
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
    }
}

