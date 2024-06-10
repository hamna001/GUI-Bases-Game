using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
     class PacmanPlayer : GameObject
     {
        public static int score;
        public static int health=10;
        public PacmanPlayer(Image image, GameCell startcell) : base(image, GameObjectType.PLAYER)
        {
            this.CurrentCell = startcell;
            
        } 
        public GameCell move(GameDirection direction)  
        {
           
            GameCell currentcell = this.CurrentCell;
         
            GameCell nextcell = currentcell.nextCell(direction);
            bool check =  Collision.PlayerCollisionWithPallet(nextcell);
            if(Collision.PlayerCollisionWithPallet(nextcell))
            {
                score++;
            }
            if(Collision.PlayerCollisionWithGhost(nextcell))
            {
               health--;
            }
            if(Collision.PlayerCollisionWithWater(nextcell))
            {
                health--;
            }
            if(Collision.PlayerCollisionWithKey(nextcell))
            {
                WonForm form = new WonForm();
                form.Show();
                Form1 frm = new Form1();
                frm.Hide();
            }
            if (nextcell == null)
                return null;
            nextcell.setGameObject(this);
            this.CurrentCell = nextcell;
            if(currentcell != nextcell )
            {
                currentcell.setGameObject(Game.GetBlankGameObject());
            }
            return nextcell;
        }
     }
}
