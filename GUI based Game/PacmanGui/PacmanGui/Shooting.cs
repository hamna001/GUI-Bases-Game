using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PacmanGui
{
    class Shooting:GameObject
    {
        GameDirection direction;
       public Shooting(Image image,GameCell currentCell,GameDirection direction):base(image,GameObjectType.ENEMY)
       {
            this.direction = direction;
       }

        public string move()
        {
            CurrentCell.setGameObject(Game.GetBlankGameObject());
            GameCell nextCell = CurrentCell.nextCell(direction);
            if(CurrentCell==nextCell)
            {
                this.CurrentCell.setGameObject(Game.GetBlankGameObject());
                return "w";
            }
            if(nextCell.currentGameObject.Type==GameObjectType.ENEMY)
            {
                CurrentCell = nextCell;
                CurrentCell.setGameObject(Game.GetBlankGameObject());
                return "E";
            }
            CurrentCell = nextCell;
            return "none";
        }
    }
}
