using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGui
{
    class GameObject
    {
        public char DisplayCharacter;
        public Image image;
        public GameCell CurrentCell;
        public GameObjectType Type;
        public char previous;
       
        
        public GameObject(Image image, GameObjectType Type)
        {
            this.Type = Type; 
            this.image = image;
        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if (displayCharacter == 'P')
                return GameObjectType.PLAYER;
            if (displayCharacter == 'G')
                return GameObjectType.ENEMY;
            if (displayCharacter == '^' || displayCharacter == '|' || displayCharacter == '#' || displayCharacter=='-')
                return GameObjectType.WALL;
            if (displayCharacter == '.')
                return GameObjectType.REWARD;
            if(displayCharacter=='-')
            {
                return GameObjectType.WATER;
            }
            if (displayCharacter =='$')
            {
                return GameObjectType.Key;
            }
            if(displayCharacter=='*')
            {
                return GameObjectType.BULLET;
            }
            else
                return GameObjectType.NONE;
        }
    }
}
