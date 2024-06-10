using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
    class HorizontalGhost : Ghost
    {
       
        public GameDirection direction = GameDirection.LEFT;
        public HorizontalGhost(Image image, GameCell c) : base(image, c)
        {
            this.CurrentCell = c;
        }
        public override GameCell Move()
        {
            if (previousObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.GetRewardGameObject());
                MessageBox.Show("hjdfhjfskj");

            }
            if (previousObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.GetBlankGameObject());
            }
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(this.direction);
            if(nextCell.currentGameObject.Type == GameObjectType.PLAYER)
            {
                //endGameform form = new endGameform();
                //form.Show();
                //Form1 frm = new Form1();
                //frm.Hide();
                score--;
                
            }
            this.CurrentCell = nextCell;
            nextCell.setGameObject(this);
            if (currentCell == nextCell && direction == GameDirection.RIGHT)
            {
                direction = GameDirection.LEFT;
            }
            else if (direction == GameDirection.LEFT)
            {
                nextCell = currentCell.nextCell(this.direction);
                currentCell.setGameObject(Game.GetBlankGameObject());
                if (currentCell == nextCell && direction == GameDirection.LEFT)
                {
                    direction = GameDirection.RIGHT;
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