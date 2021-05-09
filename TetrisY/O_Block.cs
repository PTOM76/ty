using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisY
{
    class O_Block : Block
    {
        public O_Block()
        {
            rect1List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(10, 10, 10, 10),
            };
            rect2List = rect1List;
            rect3List = rect1List;
            rect4List = rect1List;
            rectList = rect1List;
            widch[0] = 20;
            height[0] = 20;
            widch[1] = 20;
            height[1] = 20;
            widch[2] = 20;
            height[2] = 20;
            widch[3] = 20;
            height[3] = 20;
            color = Color.Yellow;
        }
    }
}
