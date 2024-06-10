using PacmanGui.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGui
{
    class Game
     {
        public static GameObject GetBlankGameObject()
        {
            GameObject BlankGameObject = new GameObject(Resources.fireboy_and_watergirl_1_forest_templeblock,GameObjectType.NONE);
            return BlankGameObject;
        }
        public static GameObject GetRewardGameObject()
        {
            GameObject RewardObject = new GameObject(Resources.gola2, GameObjectType.REWARD);
            return RewardObject;
        }
        public static Image getGameObjetcImage(char displayCharacter)
        {
            Image image = PacmanGui.Properties.Resources.simplebox;
            if (displayCharacter == '#' || displayCharacter == '^' || displayCharacter=='|')
             {
                image = PacmanGui.Properties.Resources.greenBackground;
                return image;
            }
            if(displayCharacter=='-')
            {
                image = PacmanGui.Properties.Resources.waterwater;
                return image;
            }
            else if (displayCharacter == '.')
            {
                image = PacmanGui.Properties.Resources.gola2;
                return image;
            }
            else if(displayCharacter=='$')
            {
                image = PacmanGui.Properties.Resources.keyyyy333;
                return image;
            }
            else if(displayCharacter=='*')
            {
                image = PacmanGui.Properties.Resources.blueBoundary;
                return image;
            }
            return null;
        }
    }
}
