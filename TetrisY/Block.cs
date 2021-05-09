using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisY
{
    abstract class Block
    {
        public List<Rectangle> rectList;
        public List<Rectangle> rect1List;
        public List<Rectangle> rect2List;
        public List<Rectangle> rect3List;
        public List<Rectangle> rect4List;
        public Point pos;
        public int[] widch = new int[4];
        public int[] height = new int[4];
        public int rotated = 0;
        public bool isFalled;
        public Color color;

        public void Update(int fieldHeight)
        {
            if (isFalled == false)
            {
                Point newPos = new Point(pos.X, pos.Y + 10);
                if (newPos.Y + height[rotated] > fieldHeight)
                {
                    newPos.Y = fieldHeight - height[rotated];
                    isFalled = true;
                }
                pos = newPos;
            }
        }

        public void Draw(Graphics g)
        {
            using(SolidBrush b = new SolidBrush(color)) 
            {
                foreach (Rectangle r in GetRectList())
                {
                    g.FillRectangle(b, new Rectangle(r.Left,r.Top, r.Width - 1, r.Height - 1));
                }
            }
        }
        public void Rotate(int rotate,Size fieldSize)
        {
            rotated = rotated + rotate;
            if (rotated == 1)
            {
                rectList = rect2List;
            }
            else if (rotated == 2)
            {
                rectList = rect3List;
            }
            else if (rotated == 3)
            {
                rectList = rect4List;
            }
            else if (rotated == 4)
            {
                rotated = 0;
                rectList = rect1List;
            }
        }

        public void Move(Point offset,Size fieldSize)
        {
            Point newPos = new Point(pos.X + offset.X,pos.Y + offset.Y);
            if (newPos.X < 0)
            {
                newPos.X = 0;
            }
            else if(newPos.X + widch[rotated] > fieldSize.Width)
            {
                newPos.X = fieldSize.Width - widch[rotated];
            }
            if(newPos.Y + height[rotated] > fieldSize.Height)
            {
                newPos.Y = fieldSize.Height - height[rotated];
            }
            pos = newPos;
        }

        public List<Rectangle> GetRectList()
        {
            List<Rectangle> drawRectList = new List<Rectangle>();
            foreach (Rectangle r in rectList)
            {
                drawRectList.Add(new Rectangle(pos.X + r.Left, pos.Y + r.Top, r.Width, r.Height));
            }
            return drawRectList;
        }
    }
}
