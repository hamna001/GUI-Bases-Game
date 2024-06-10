using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
     class GameCell
     {
        public int X;
        public int Y;
        public GameObject currentGameObject;
        public GameGrid gameGrid;
        public  PictureBox pictureBox;
        const int width = 20;
        const int height = 30;
        public GameCell(int x, int y, GameGrid gameGrid)
        {
            this.X = x;
            this.Y = y;
            this.gameGrid = gameGrid;
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(width,height);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Transparent;
            this.gameGrid = gameGrid;
        }
        public GameCell()
        {

        }
        public GameCell nextCell(GameDirection direction)
        {
            if (direction == GameDirection.UP)
            {
                if (this.X > 0)
                {
                    GameCell cell = gameGrid.getCell(this.X - 1, this.Y);
                    if (cell.currentGameObject.Type != GameObjectType.WALL)
                    {
                        return cell;
                    }
                }
            }
            if (direction == GameDirection.DOWN)
            {
                if (this.X < gameGrid.rows - 1)
                {
                    GameCell cell = gameGrid.getCell(this.X+1, this.Y);
                    if (cell.currentGameObject.Type != GameObjectType.WALL)
                    {
                        return cell;
                    }
                }
            }
            if (direction == GameDirection.RIGHT)
            {
                 if (this.Y < gameGrid.cols -1)
                 {
                     GameCell cell = gameGrid.getCell(this.X, this.Y + 1);
                     if (cell.currentGameObject.Type != GameObjectType.WALL)
                     {
                         return cell;
                     }
                 }
                 
               
            }
            if (direction == GameDirection.LEFT)
            {
                if(this.Y > 0)
                {
                    GameCell cell = gameGrid.getCell(this.X, this.Y - 1);
                    if(cell.currentGameObject.Type != GameObjectType.WALL)
                    {
                        return cell;
                    }
                }
            }
            return gameGrid.GameCells[X, Y];
        }
      public void setGameObject(GameObject gameObject)
      {
            currentGameObject = gameObject;
            pictureBox.Image = gameObject.image;
            
      }
     }
}
