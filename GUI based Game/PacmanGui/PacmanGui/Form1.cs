using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace PacmanGui
{
    public partial class Form1 : Form
    {
        public int score;
        public int health=5;
        GameGrid grid;
        PacmanPlayer pacman;
        HorizontalGhost horizontalGhost;
        RandomGhost randomGhost;
        VerticalGhost verticalGhost;
        SmartGhost smartGhost;
        GameCell startPlayer;
        List<Shooting> bullets = new List<Shooting>();
        List<Ghost> ghosts = new List<Ghost>();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid = new GameGrid("maze.txt", 24, 70);
            startPlayer = new GameCell(1,1, grid);
            GameCell startGhostH = new GameCell(15, 42, grid);
            GameCell startGhostR = new GameCell(1,20,grid);
            GameCell startGhostR1 = new GameCell(20,21,grid);
            GameCell startGhostV = new GameCell(11,50,grid);
            GameCell startGhostS = new GameCell(15,59,grid);
            pacman = new PacmanPlayer(PacmanGui.Properties.Resources.BigFireboy,startPlayer);
            horizontalGhost = new HorizontalGhost(PacmanGui.Properties.Resources.cuteboo, startGhostH);
            randomGhost = new RandomGhost(PacmanGui.Properties.Resources.tera,startGhostR);
            verticalGhost = new VerticalGhost(PacmanGui.Properties.Resources.gastly2,startGhostV);
            smartGhost = new SmartGhost(PacmanGui.Properties.Resources.boo2, startGhostS,pacman);
            startPlayer.setGameObject(pacman);
            startGhostH.setGameObject(horizontalGhost);
            startGhostR.setGameObject(randomGhost);
            startGhostV.setGameObject(verticalGhost);
            startGhostS.setGameObject(smartGhost);
            //Adding ghost to list
            ghosts.Add(horizontalGhost);
            ghosts.Add(verticalGhost);
            ghosts.Add(smartGhost);
            ghosts.Add(randomGhost);
            //........
            printPacman(pacman);
            printHorizontalGhost(horizontalGhost);
            printRandomGhost(randomGhost);
            printVerticalGhost(verticalGhost);
            printSmartGhost(smartGhost);
            printMaze(grid);
        }
        private void picturelocation(GameCell cell)
        {
            cell.pictureBox.Left = cell.Y * cell.pictureBox.Width;
            cell.pictureBox.Top = cell.X * cell.pictureBox.Height;

        }
        private  void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.rows; x++)
            {
                for (int y = 0; y < grid.cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    picturelocation(cell);
                    this.Controls.Add(cell.pictureBox);

                }

            }
        }
        void printPacman(GameObject player)
        {
            picturelocation(player.CurrentCell);
            this.Controls.Add(player.CurrentCell.pictureBox);
           
        }
        void printHorizontalGhost(GameObject ghostH)
        {
            picturelocation(ghostH.CurrentCell);
            this.Controls.Add(ghostH.CurrentCell.pictureBox);
           
        }
        void printRandomGhost(GameObject ghostR)
        {
            picturelocation(ghostR.CurrentCell);
            this.Controls.Add(ghostR.CurrentCell.pictureBox);

        }
        void printRandomGhost1(GameObject ghostR1)
        {
            picturelocation(ghostR1.CurrentCell);
            this.Controls.Add(ghostR1.CurrentCell.pictureBox);

        }
        void printVerticalGhost(GameObject ghostV) 
        {
            picturelocation(ghostV.CurrentCell);
            this.Controls.Add(ghostV.CurrentCell.pictureBox);

        }
        void printSmartGhost(GameObject ghostS)
        {
            picturelocation(ghostS.CurrentCell);
            this.Controls.Add(ghostS.CurrentCell.pictureBox);

        }
        void gravity()
        {
            pacman.move(GameDirection.DOWN);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    pacman.move(GameDirection.UP);
                }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.DOWN);
            }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    pacman.move(GameDirection.RIGHT);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    pacman.move(GameDirection.LEFT);
                }
                
            GameCell g = new GameCell();
            if (Collision.PlayerCollisionWithPallet(g))
            {
              
               PacmanPlayer.score++;
             
            }
            if (PacmanPlayer.health == 0)
            {
                endGameform form = new endGameform();
                this.Hide();
                form.Show();
            }
            lblScore.Visible = true;
           lblScore.Text =PacmanPlayer.score.ToString();
            //if (Collision.PlayerCollisionWithGhost(g))
            //{
            //    PacmanPlayer.health--;
            //}
            lblHealth.Visible = true;
            lblHealth.Text = PacmanPlayer.health.ToString();
            




            randomGhost.Move();
            verticalGhost.Move();
            horizontalGhost.Move();
            smartGhost.Move();
            //  gravity();
            generateBullet();
            foreach (var bullet in bullets)
            {
                string x = bullet.move();
                if (x == "w")
                {
                    bullets.Remove(bullet);
                    break;
                }
                if (x == "E")
                {
                 foreach (Ghost ghost in ghosts)
                 {
                        if (Collision.PlayerCollisionWithGhost(startPlayer))
                        {
                          ghosts.Remove(ghost);
                        }
                 }

                }
            }



        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
        private void generateBullet() 
        {
            if(Keyboard.IsKeyPressed(Key.V))
            {
                Image bulletimage = PacmanGui.Properties.Resources.blueBoundary;
                Shooting shoot = new Shooting(bulletimage, pacman.CurrentCell, GameDirection.LEFT);
                shoot.CurrentCell = pacman.CurrentCell.nextCell(GameDirection.LEFT);
                bullets.Add(shoot);
            }
            if (Keyboard.IsKeyPressed(Key.B))
            {
                Image bulletimage = PacmanGui.Properties.Resources.blueBoundary;
                Shooting shoot = new Shooting(bulletimage, pacman.CurrentCell, GameDirection.UP);
                shoot.CurrentCell = pacman.CurrentCell.nextCell(GameDirection.UP);
                bullets.Add(shoot);
            }
            if (Keyboard.IsKeyPressed(Key.N))
            {
                Image bulletimage = PacmanGui.Properties.Resources.blueBoundary;
                Shooting shoot = new Shooting(bulletimage, pacman.CurrentCell, GameDirection.DOWN);
                shoot.CurrentCell = pacman.CurrentCell.nextCell(GameDirection.DOWN);
                bullets.Add(shoot);
            }
            if (Keyboard.IsKeyPressed(Key.M))
            {
                Image bulletimage = PacmanGui.Properties.Resources.blueBoundary;
                Shooting shoot = new Shooting(bulletimage, pacman.CurrentCell, GameDirection.RIGHT);
                shoot.CurrentCell = pacman.CurrentCell.nextCell(GameDirection.RIGHT);
                bullets.Add(shoot);
            }


        }

        private void lblHealth_Click(object sender, EventArgs e)
        {

        }
    }
}
