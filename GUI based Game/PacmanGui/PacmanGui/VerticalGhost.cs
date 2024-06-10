using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacmanGui
{
    class VerticalGhost : Ghost
    {
        public GameDirection direction = GameDirection.UP;
        public VerticalGhost(Image image, GameCell c) : base(image, c)
        {
            this.CurrentCell = c;

        }
        public override GameCell Move() 
        {

            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(this.direction);
            if (nextCell.currentGameObject.Type == GameObjectType.REWARD)
            {
                previousObject = GameObjectType.REWARD;
            }
            
           
            this.CurrentCell = nextCell;
            nextCell.setGameObject(this);
            if(currentCell == nextCell && direction == GameDirection.UP)
            {
                direction = GameDirection.DOWN;
            }
            else if(direction == GameDirection.DOWN)
            {
                nextCell = currentCell.nextCell(this.direction);
                currentCell.setGameObject(Game.GetBlankGameObject());
                if(currentCell == nextCell && direction == GameDirection.DOWN)
                {
                    direction = GameDirection.UP;
                }
            }
            else
            {
                currentCell.setGameObject(Game.GetBlankGameObject());
            }
            return nextCell;
        }
    }
}
