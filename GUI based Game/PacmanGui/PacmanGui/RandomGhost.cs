using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
     class RandomGhost : Ghost
     {
        public RandomGhost(Image image, GameCell c) : base(image, c)
        {
            this.CurrentCell = c;
           
        }
        public Random ghostDirection() 
        {
            Random rad = new Random();
            return rad;
            
        }
        public override GameCell Move()
        {
           
           
            Random rand = ghostDirection();
            if (previousObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.GetRewardGameObject());

            }
            if (previousObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.GetBlankGameObject());
            }
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(GameDirection.LEFT);
           
            if (nextCell.currentGameObject.Type == GameObjectType.PLAYER)
            {
                //endGameform form = new endGameform();
                //form.Show();
                score--;
            }
            if(nextCell.currentGameObject.Type==GameObjectType.REWARD)
            {
                currentCell.setGameObject(Game.GetRewardGameObject());
            }
            this.CurrentCell = nextCell;
            nextCell.setGameObject(this);
            if(currentCell!= nextCell)
            {

                currentCell.setGameObject(Game.GetBlankGameObject());

            }
            else
            {
                currentCell.X = rand.Next(10, 20);
                currentCell.Y = rand.Next(10,20);

            }
            return nextCell;


        }
     }
}
