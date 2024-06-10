using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanGui
{
     class GameGrid
     {
        public GameCell[,] GameCells;
        public int rows;
        public int cols;

        public GameGrid(string filename, int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            GameCells = new GameCell[rows, cols];
            loadGrid();
        }

        public void loadGrid()
        {
            string filename = "maze.txt";
            StreamReader fp = new StreamReader(filename);
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x <70; x++)
                {
                    GameCell cell = new GameCell(row, x, this);
                    char character = record[x];
                    GameObjectType type = GameObject.GetGameObjectType(character);
                    Image displayimage = Game.getGameObjetcImage(character);
                    GameObject obj = new GameObject(displayimage, GameObject.GetGameObjectType(character));
                    cell.setGameObject(obj);
                    GameCells[row, x] = cell;
                }
                row++;
            }

            fp.Close();
        }
        public GameCell getCell(int x, int y)
        {
            return GameCells[x, y];
        }
    }
}
