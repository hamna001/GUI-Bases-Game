using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGui
{
     abstract class Ghost : GameObject
      
     {
        public GameObjectType previousObject;
        public abstract GameCell Move();
        public int score;
       // public static int health;
        public Ghost(Image image, GameCell c) : base(image, GameObjectType.ENEMY)
        {
            CurrentCell = c;
            this.image = image;
        }

    }
}
