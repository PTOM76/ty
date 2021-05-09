using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisY
{
    class UNTI_Block : Block
    {
        public UNTI_Block()
        {
            rect1List = new List<Rectangle>
            {
                new Rectangle(20, 0, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(20, 10, 10, 10),
                new Rectangle(30, 10, 10, 10),
                new Rectangle(0, 20, 10, 10),
                new Rectangle(10, 20, 10, 10),
                new Rectangle(20, 20, 10, 10),
                new Rectangle(30, 20, 10, 10),
                new Rectangle(40, 20, 10, 10),
            };
            rect2List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(0, 10, 10, 10),
                new Rectangle(0, 20, 10, 10),
                new Rectangle(0, 30, 10, 10),
                new Rectangle(0, 40, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(10, 20, 10, 10),
                new Rectangle(10, 30, 10, 10),
                new Rectangle(20, 20, 10, 10),
            };
            rect3List = new List<Rectangle>
            {
                new Rectangle(0, 0, 10, 10),
                new Rectangle(10, 0, 10, 10),
                new Rectangle(20, 0, 10, 10),
                new Rectangle(30, 0, 10, 10),
                new Rectangle(40, 0, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(20, 10, 10, 10),
                new Rectangle(30, 10, 10, 10),
                new Rectangle(20, 20, 10, 10),
            };
            rect4List = new List<Rectangle>
            {
                new Rectangle(20, 0, 10, 10),
                new Rectangle(20, 10, 10, 10),
                new Rectangle(20, 20, 10, 10),
                new Rectangle(20, 30, 10, 10),
                new Rectangle(20, 40, 10, 10),
                new Rectangle(10, 10, 10, 10),
                new Rectangle(10, 20, 10, 10),
                new Rectangle(10, 30, 10, 10),
                new Rectangle(0, 20, 10, 10),
            };
            rectList = rect1List;
            widch[0] = 50;
            height[0] = 30;
            widch[1] = 30;
            height[1] = 50;
            widch[2] = 50;
            height[2] = 30;
            widch[3] = 30;
            height[3] = 50;
            color = Color.Brown;
        }
    }
}
