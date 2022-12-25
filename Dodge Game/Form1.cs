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
using System.Media;
using Dodge_Game.Properties;

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
        List<string> direction = new List<string>();

        Rectangle player1 = new Rectangle(200, 320, 20, 20);
        Rectangle player2 = new Rectangle(370, 320, 20, 20);

        Brush whiteBrush = new SolidBrush(Color.White);
        Brush grayBrush = new SolidBrush(Color.Gray);

        Pen redPen = new Pen(Color.OrangeRed, 3);
        Pen bluePen = new Pen(Color.Aquamarine, 3);
        Pen orangePen = new Pen(Color.Orange, 3);
        Pen bigOrangePen = new Pen(Color.Orange, 7);

        Image flames = Properties.Resources.flamesImage;

        bool wDown = false;
        bool sDown = false;
        bool upDown = false;
        bool downDown = false;

        bool p1Flames = false;
        bool p2Flames = false;

        int playerSpeed = 4;

        int player1Score;
        int player2Score;

        int randValue;
        int x;

        string difficulty = "Easy";

        int clock = 1800;

        Stopwatch player1Timer = new Stopwatch();
        Stopwatch player2Timer = new Stopwatch();

        SoundPlayer explosion = new SoundPlayer(Resources.explosionSound);
        SoundPlayer coins = new SoundPlayer(Resources.coinNoise);
        SoundPlayer endGame = new SoundPlayer(Resources.gameOverNoise);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (player1Timer.IsRunning == false)
                    {
                        wDown = true;
                        p1Flames = true;
                    }
                    break;
                case Keys.S:
                    if (player1Timer.IsRunning == false)
                    {
                        sDown = true;
                    }
                    break;
                case Keys.Up:
                    if (player2Timer.IsRunning == false)
                    {
                        upDown = true;
                        p2Flames = true;
                    }
                    break;
                case Keys.Down:
                    if (player2Timer.IsRunning == false)
                    {
                        downDown = true;
                    }
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
                    p1Flames = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upDown = false;
                    p2Flames = false;
                    break;
                case Keys.Down:
                    downDown = false;
                    break;
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //draws players if they are not in limbo from hitting object
            if (player1Timer.IsRunning == false)
            {
                e.Graphics.DrawLine(bigOrangePen, player1.X + 8, player1.Y, player1.X + 20, player1.Y + 20);
                e.Graphics.DrawLine(bigOrangePen, player1.X + 11, player1.Y, player1.X, player1.Y + 20);

                if (p1Flames == true)
                {
                    e.Graphics.DrawImage(flames, player1.X, player1.Y + player1.Height, 20, 20);
                }

               // player1Image.Y = player1.Y + 72;
            }
            if (player2Timer.IsRunning == false)
            {
                e.Graphics.DrawLine(bigOrangePen, player2.X + 8, player2.Y, player2.X + 20, player2.Y + 20);
                e.Graphics.DrawLine(bigOrangePen, player2.X + 11, player2.Y, player2.X, player2.Y + 20);

                if (p2Flames == true)
                {
                    e.Graphics.DrawImage(flames, player2.X, player2.Y + player2.Height, 20, 20);
                }
            }

            //draws players if they are invisible on end of game
            if (player1Timer.IsRunning && clock <= 2)
            {
                e.Graphics.DrawLine(bigOrangePen, player1.X + 8, player1.Y, player1.X + 20, player1.Y + 20);
                e.Graphics.DrawLine(bigOrangePen, player1.X + 11, player1.Y, player1.X, player1.Y + 20);
                p1Flames = false;
            }
            if (player2Timer.IsRunning && clock <= 2)
            {
                e.Graphics.DrawLine(bigOrangePen, player2.X + 8, player2.Y, player2.X + 20, player2.Y + 20);
                e.Graphics.DrawLine(bigOrangePen, player2.X + 11, player2.Y, player2.X, player2.Y + 20);
                p2Flames = false;
            }

            e.Graphics.DrawLine(orangePen, this.Width / 2, 0, this.Width / 2, this.Height);

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
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }
            if (sDown == true && player1.Y < this.Height - 25)
            {
                player1.Y += playerSpeed;
            }
            if (upDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }
            if (downDown == true && player2.Y < this.Height - 25)
            {
                player2.Y += playerSpeed;
            }

            //move ball objects
            for (int i = 0; i < balls.Count(); i++)
            {
                if (direction[i] == "right")
                {
                    x = balls[i].X + ballSpeeds[i];
                    balls[i] = new Rectangle(x, balls[i].Y, ballWidthSizes[i], ballLengthSizes[i]);
                }
                else if (direction[i] == "left")
                {
                    x = balls[i].X - ballSpeeds[i];
                    balls[i] = new Rectangle(x, balls[i].Y, ballWidthSizes[i], ballLengthSizes[i]);
                }

                //remove balls at side of screen
                if (balls[i].X >= this.Width)
                {
                    balls.RemoveAt(i);
                    ballWidthSizes.RemoveAt(i);
                    ballLengthSizes.RemoveAt(i);
                    ballSpeeds.RemoveAt(i);
                    shapes.RemoveAt(i);
                    direction.RemoveAt(i);
                }

                //check if balls have player1 collision
                if (balls[i].IntersectsWith(player1))
                {
                    explosion.Play();

                    player1.Y = 320;
                    player1.X = 200;

                    player1Timer.Start();

                    wDown = false;
                    sDown = false;
                }

                //check if balls have player2 collision
                if (balls[i].IntersectsWith(player2))
                {
                    explosion.Play();

                    player2.Y = 320;
                    player2.X = 370;

                    player2Timer.Start();

                    upDown = false;
                    downDown = false;
                }

                if (player1Timer.ElapsedMilliseconds >= 1000)
                {
                    player1Timer.Stop();
                    player1Timer.Reset();
                }

                if (player2Timer.ElapsedMilliseconds >= 1000)
                {
                    player2Timer.Stop();
                    player2Timer.Reset();
                }
            }

            //generate a random value
            if (difficulty == "Easy")
            {
                randValue = randGen.Next(1, 251);
            }
            else if (difficulty == "Medium")
            {
                randValue = randGen.Next(1, 171);
            }
            else if (difficulty == "Hard")
            {
                randValue = randGen.Next(1, 111);
            }

            //generate new ball if it is time
            if (randValue < 40)
            {
                ballWidthSizes.Add(randGen.Next(7, 20));
                ballLengthSizes.Add(randGen.Next(3, 10));
                ballSpeeds.Add(randGen.Next(3, 7));

                randValue = randGen.Next(1, 20);

                if (randValue < 10)
                {
                    shapes.Add("rectangle");
                }
                else
                {
                    shapes.Add("ellipse");
                }

                randValue = randGen.Next(1, 3);

                if (randValue == 1)
                {
                    direction.Add("right");
                }
                else
                {
                    direction.Add("left");
                }

                if (direction.Last() == "right")
                {
                    balls.Add(new Rectangle(0, randGen.Next(40, this.Height - 60), 0, 0));
                }
                else
                {
                    balls.Add(new Rectangle(this.Width, randGen.Next(40, this.Height - 60), 0, 0));
                }
            }

            //check for player collision with the roof
            if (player1.Y <= 0)
            {
                player1.X = 200;
                player1.Y = 350;

                player1Score++;
                p1ScoreLabel.Text = $"{player1Score}";

                coins.Play();
            }

            if (player2.Y <= 0)
            {
                player2.X = 370;
                player2.Y = 350;

                player2Score++;
                p2ScoreLabel.Text = $"{player2Score}";

                coins.Play();
            }

            //timer
            if (clock % 30 == 0)
            {
                timeLabel.Text = $"Time Left: {clock / 30} Seconds";
            }
            clock--;

            //end game
            if (clock <= 0)
            {
                gameTimer.Enabled = false;

                balls.Clear();
                ballSpeeds.Clear();
                ballWidthSizes.Clear();
                ballLengthSizes.Clear();
                shapes.Clear();
                direction.Clear();

                easyLabel.Visible = true;
                mediumLabel.Visible = true;
                hardLabel.Visible = true;

                topLabel.Visible = true;
                winLabel.Visible = true;
                escapeLabel.Visible = true;

                p1ScoreLabel.Visible = false;
                p2ScoreLabel.Visible = false;
                timeLabel.Visible = false;

                timeLabel.Text = "";

                if (player1Score > player2Score)
                {
                    winLabel.Text = $"Player 1 Wins With a Final Score of {player1Score} Points to {player2Score}!";
                }
                else if (player1Score < player2Score)
                {
                    winLabel.Text = $"Player 2 Wins With a Final Score of {player2Score} Points to {player1Score}!";
                }
                else
                {
                    winLabel.Text = $"The Game Was a Draw With a Final Score of {player1Score} Points Each!";
                }

                player1.X = 200;
                player1.Y = 320;

                player2.X = 370;
                player2.Y = 320;

                endGame.Play();
            }

            Refresh();
        }
        public void startGame()
        {
            //checks if the game is running, and wont let the keys do anything if so
            if (gameTimer.Enabled == false)
            {
                //starts game
                gameTimer.Enabled = true;

                //removes labels
                easyLabel.Visible = false;
                mediumLabel.Visible = false;
                hardLabel.Visible = false;
                hardLabel.Visible = false;

                topLabel.Visible = false;
                winLabel.Visible = false;
                escapeLabel.Visible = false;

                //resets button labels to their set position after first runthrough
                easyLabel.Location = new Point(easyLabel.Location.X, 180);
                mediumLabel.Location = new Point(mediumLabel.Location.X, 214);

                hardLabel.Location = new Point(hardLabel.Location.X, 180);
                escapeLabel.Location = new Point(escapeLabel.Location.X, 210);

                p1ScoreLabel.Visible = true;
                p1ScoreLabel.Text = "0";

                p2ScoreLabel.Visible = true;
                p2ScoreLabel.Text = "0";

                timeLabel.Visible = true;

                clock = 1800;
            }
        }
    }
}
