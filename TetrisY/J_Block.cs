using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisY
{
    class J_Block : Block
    {
        public J_Block()
        {
            rect1List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(20, 10, 10, 10),
            };
            rect2List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(0, 20, 10, 10),
            };
            rect3List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(20, 0, 10, 10),
                new Rectangle(20, 10, 10, 10),
            };
            rect4List = new List<Rectangle>
            {
                new Rectangle(10, 0, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(10, 20, 10, 10),
                new Rectangle(0, 20, 10, 10),
            };
            rectList = rect1List;
            widch[0] = 30;
            height[0] = 20;
            widch[1] = 20;
            height[1] = 30;
            widch[2] = 30;
            height[2] = 20;
            widch[3] = 20;
            height[3] = 30;
            color = Color.Blue;
        }
    }
}
