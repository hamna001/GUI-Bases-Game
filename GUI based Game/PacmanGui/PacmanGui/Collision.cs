using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGui
{
     class Collision 
     {
        public static bool PlayerCollisionWithPallet(GameCell nextCell)
        {
            if (nextCell == null)
            {
                return false;
            }
            if (nextCell.currentGameObject == null)
            {
                return false;
            }
            if ( nextCell.currentGameObject.Type == GameObjectType.REWARD)
            {
                return true;
            }
            return false;
        }
        public static bool PlayerCollisionWithKey(GameCell nextCell)
        {
            if (nextCell == null)
            {
                return false;
            }
            if (nextCell.currentGameObject == null)
            {
                return false;
            }
            if (nextCell.currentGameObject.Type == GameObjectType.Key)
            {
                return true;
            }
            return false;
        }
        public static bool PlayerCollisionWithGhost(GameCell nextCell)
        {
            if (nextCell == null)
            {
                return false;
            }
            if (nextCell.currentGameObject == null)
            {
                return false;
            }
            if (nextCell.currentGameObject.Type == GameObjectType.ENEMY)
            {
               
                return true;

            }
           
            return false;
        }

        public static bool PlayerCollisionWithWater(GameCell nextCell)
        {
            if (nextCell == null)
            {
                return false;
            }
            if (nextCell.currentGameObject == null)
            {
                return false;
            }
            if (nextCell.currentGameObject.Type == GameObjectType.WATER)
            {

                return true;

            }

            return false;
        }
           
        
    }
}
