using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Dodge_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random randGen = new Random();

        List <Rectangle> balls = new List<Rectangle>();

        List <int> ballWidthSizes = new List<int>();
        List<int> ballLengthSizes = new List<int>();
        List <int> ballSpeeds = new List<int>();

        List <string> shapes = new List<string>();

        Rectangle player = new Rectangle(20, 177, 20, 20);

        Brush whiteBrush = new SolidBrush(Color.White);
        Brush grayBrush = new SolidBrush(Color.Gray);
        Brush orangeBrush = new SolidBrush(Color.Orange);

        Pen redPen = new Pen(Color.OrangeRed, 3);
        Pen bluePen = new Pen(Color.Aquamarine, 3);

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;

        int playerSpeed = 7;

        int randValue;

        string difficulty = "Easy";

        Stopwatch gameTime = new Stopwatch();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.E:
                    difficulty = "Easy";
                    startGame();
                    break;
                case Keys.M:
                    startGame();
                    difficulty = "Medium";
                    break;
                case Keys.H:
                    startGame();
                    difficulty = "Hard";
                    break;

                case Keys.Escape:
                    if (gameTimer.Enabled == false)
                    {
                        Application.Exit();
                    }
                        break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(orangeBrush, player);

            if (gameTimer.Enabled == false)
            {
                e.Graphics.FillRectangle(whiteBrush, 47, 47, 487, 267);
                e.Graphics.FillRectangle(grayBrush, 50, 50, 480, 260);

                e.Graphics.DrawLine(redPen, 60, 90, 90, 60);
                e.Graphics.DrawLine(redPen, 60, 110, 110, 60);

                e.Graphics.DrawLine(bluePen, 520, 270, 490, 300);
                e.Graphics.DrawLine(bluePen, 520, 250, 470, 300);
            }

            for (int i = 0; i < balls.Count; i++)
            {
                if (shapes[i] == "rectangle")
                {
                    e.Graphics.FillRectangle(whiteBrush, balls[i]);
                }
                else if (shapes[i] == "ellipse")
                {
                    e.Graphics.FillEllipse(whiteBrush, balls[i]);
                }
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (wDown == true && player.Y > 2)
            {
                player.Y -= playerSpeed;
            }
            if (sDown == true && player.Y < this.Height - 23)
            {
                player.Y += playerSpeed;
            }
            if (aDown == true && player.X > 2)
            {
                player.X -= playerSpeed;
            }
            if (dDown == true && player.X < this.Width - 23)
            {
                player.X += playerSpeed;
            }

            //move ball objects
            for (int i = 0; i < balls.Count(); i++)
            {
                int y = balls[i].Y + ballSpeeds[i];
                balls[i] = new Rectangle(balls[i].X, y, ballWidthSizes[i], ballLengthSizes[i]);

                //remove balls at bottom of screen
                if (balls[i].Y >= this.Height)
                {
                    balls.RemoveAt(i);
                    ballWidthSizes.RemoveAt(i);
                    ballLengthSizes.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    shapes.RemoveAt(i);
                }

                //check if balls have player collision
                if (balls[i].IntersectsWith(player))
                {
                    player.Y = 177;
                    player.X = 20;
                }
            }

            //generate a random value
            if (difficulty == "Easy")
            {
                randValue = randGen.Next(1, 151);
            }
            else if (difficulty == "Medium")
            {
                randValue = randGen.Next(1, 91);
            }
            else if (difficulty == "Hard")
            {
                randValue = randGen.Next(1, 71);
            }

            //generate new ball if it is time
            if (randValue < 40)
            {
                balls.Add(new Rectangle(randGen.Next(40, this.Width - 60), 0, 0, 0));
                ballWidthSizes.Add(randGen.Next(7, 20));
                ballLengthSizes.Add(randGen.Next(7, 20));
                ballSpeeds.Add(randGen.Next(6, 12));

                randValue = randGen.Next(1, 20);

                if (randValue < 10)
                {
                    shapes.Add("rectangle");
                }
                else
                {
                    shapes.Add("ellipse");
                }
            }

            if (player.X >= this.Width - player.Width)
            {
                gameTimer.Enabled = false;

                balls.Clear();
                ballSpeeds.Clear();
                ballWidthSizes.Clear();
                ballLengthSizes.Clear();
                shapes.Clear();

                easyLabel.Visible = true;
                mediumLabel.Visible = true;
                hardLabel.Visible = true;

                topLabel.Visible = true;
                winLabel.Visible = true;
                escapeLabel.Visible = true;

                player.X = 20;
                player.Y = 177;

                gameTime.Stop();
                long time = gameTime.ElapsedMilliseconds;
                winLabel.Text = $"You took {gameTime.Elapsed.ToString(@"s\.fff")} Seconds to Win on {difficulty} Mode!";
                gameTime.Reset();

                this.Focus();
            }

            Refresh();
        }
        public void startGame()
        {
            if (gameTimer.Enabled == false)
            {
                gameTimer.Enabled = true;

                easyLabel.Visible = false;
                mediumLabel.Visible = false;
                hardLabel.Visible = false;

                topLabel.Visible = false;
                winLabel.Visible = false;
                escapeLabel.Visible = false;

                easyLabel.Location = new Point(easyLabel.Location.X, 180);
                mediumLabel.Location = new Point(mediumLabel.Location.X, 214);

                hardLabel.Location = new Point(hardLabel.Location.X, 180);
                escapeLabel.Location = new Point(escapeLabel.Location.X, 210);

                gameTime.Start();
            }
        }
    }
}
