using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisY
{
    class I_Block : Block
    {
        public I_Block()
        {
            rect1List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(20, 0, 10, 10),
                new Rectangle(30, 0, 10, 10),
            };
            rect2List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(0, 20, 10, 10),
                new Rectangle(0, 30, 10, 10),
            };
            rect3List = rect1List;
            rect4List = rect2List;
            rectList = rect1List;
            widch[0] = 40;
            height[0] = 10;
            widch[1] = 10;
            height[1] = 40;
            widch[2] = 40;
            height[2] = 10;
            widch[3] = 10;
            height[3] = 40;
            color = Color.LightBlue;
        }
    }
}
