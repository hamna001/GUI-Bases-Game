using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGui
{
    class SmartGhost : Ghost
    {
          GameDirection Direction;
          PacmanPlayer player;
          public SmartGhost(Image G, GameCell start, PacmanPlayer targetplayer) : base(G, start)
          {
              player = targetplayer;
          }
          public override GameCell Move() 
          {
            if (previousObject == GameObjectType.REWARD)
            {
                CurrentCell.setGameObject(Game.GetRewardGameObject());
                MessageBox.Show("dfesfaf");

            }
            if (previousObject == GameObjectType.NONE)
            {
                CurrentCell.setGameObject(Game.GetBlankGameObject());
            }
            GameCell currentCell = this.CurrentCell;
              GameCell nextCell = FindNextCell(currentCell,player);
            if (nextCell.currentGameObject.Type == GameObjectType.PLAYER)
            {
                //endGameform form = new endGameform();
                //form.Show();
                score--;
            }

            if (nextCell != null)
              {
                  currentCell.setGameObject(Game.GetBlankGameObject());
                  nextCell.setGameObject(this);
                  this.CurrentCell = nextCell;
              }

              return nextCell;
          }
          private GameCell FindNextCell(GameCell currentCell, PacmanPlayer player)
          {
              List<GameCell> availableCells = GetAvailableCells(currentCell);

              GameCell closestCell = null;
              double closestDistance = double.MaxValue;

              foreach (GameCell cell in availableCells)
              {
                  double distance = CalculateDistance(cell, player);
                  if (distance < closestDistance)
                  {
                      closestCell = cell;
                      closestDistance = distance;
                  }
              }

              return closestCell;
          }
          private List<GameCell> GetAvailableCells(GameCell currentCell)
          {
              List<GameCell> availableCells = new List<GameCell>();

              foreach (GameDirection direction in Enum.GetValues(typeof(GameDirection)))
              {
                  GameCell nextCell = currentCell.nextCell(direction);
                  if (nextCell != null)
                  {
                      availableCells.Add(nextCell);
                  }
              }

              return availableCells;
          }

          private double CalculateDistance(GameCell cell1, GameObject cell2)
          {
              int xDiff = Math.Abs(cell1.X - cell2.CurrentCell.X);
              int yDiff = Math.Abs(cell1.Y - cell2.CurrentCell.Y);
              double distance = Math.Sqrt(xDiff * 2 + yDiff * 2);

              return distance;
          }
    }
}
