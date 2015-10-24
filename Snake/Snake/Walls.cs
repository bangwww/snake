using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> WallList;
        public Walls(int mapWidht, int mapHeight)
        {
            WallList = new List<Figure>();
            HorizontalLine TopLine = new HorizontalLine(0, mapWidht-2, 0, '+');
            HorizontalLine BotLine = new HorizontalLine(0, mapWidht-2, mapHeight-1, '+');
            VerticalLine LeftLine = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine RightLine = new VerticalLine(0, mapHeight-1, mapWidht-2, '+');

            WallList.Add(TopLine);
            WallList.Add(BotLine);
            WallList.Add(LeftLine);
            WallList.Add(RightLine);
        }

        public bool IsHit(Figure figure)
        {
            foreach (Figure item in WallList)
            {
                if (item.IsHit(figure)) return true;
            }
            return false;
        }

        public void Draw()
        {
            foreach (Figure item in WallList)
            {
                item.Draw();
            }
        }

        
    }
}
