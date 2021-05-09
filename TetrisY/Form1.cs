using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TetrisY
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<Block> blockList;
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("フォームが読み込まれました。");
            blockList = new List<Block>();
            AddBlock();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach(Block b in blockList)
            {
                b.Draw(e.Graphics);
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if(blockList.Count > 0)
            {
                Block lastBlock = blockList.Last();
                if(GetTouchBlock(lastBlock)[0] == false)
                {
                    lastBlock.Update(pictureBox1.Height);
                }
                else
                {
                    lastBlock.isFalled = true;
                }
                if (lastBlock.isFalled)
                {
                    if (lastBlock.pos.Y == 0)
                    {
                        List<Block> tempList = new List<Block>();
                        foreach(Block b in blockList)
                        {
                            Block b2 = b;
                            b2.color = Color.Red;
                            tempList.Add(b2);
                        }
                        blockList = tempList;
                        pictureBox1.Refresh();
                        Thread.Sleep(1000);
                        blockList = new List<Block>();
                    }
                    CheckBlockLine();
                    //Console.WriteLine("LastX:" + lastBlock.pos.X);
                    //Console.WriteLine("LastY:" + lastBlock.pos.Y);
                    AddBlock();
                    //Console.WriteLine(blockList.Find(p => p.pos.X == 0 && p.pos.Y == 0).color);
                }
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void CheckBlockLine()
        {
            int lineClearCount = 0;
            for (int y = 0; y <= pictureBox1.Size.Height / 10; y++)
            {
                List<Block> blockList1 = new List<Block>();
                lineClearCount = 0;
                for (int x = 0; x <= pictureBox1.Size.Width / 10; x++)
                {
                    foreach (Block b in blockList)
                    {
                        List<Rectangle> rectList1 = b.GetRectList();
                        if (rectList1.Exists(r => r.X.Equals(x * 10) && r.Y.Equals(y * 10)))//計算中の座標とブロックの座標一致
                        {
                            lineClearCount++;
                            blockList1.Add(b);
                        }
                    }
                    //Console.WriteLine("CheckX:" + 10 * x);
                }
                //Console.WriteLine("CheckY:" + 10 * y);
                if (lineClearCount == pictureBox1.Size.Width / 10)
                {
                    foreach(Block b in blockList1)
                    {
                        blockList.Remove(b);
                    }
                }
                //Console.WriteLine(lineClearCount);

            }
        }

        private void AddBlock()
        {
            Block newBlock = null;
            switch (random.Next(8))
            {
                case 0:
                    newBlock = new O_Block();
                    break;
                case 1:
                    newBlock = new Z_Block();
                    break;
                case 2:
                    newBlock = new I_Block();
                    break;
                case 3:
                    newBlock = new S_Block();
                    break;
                case 4:
                    newBlock = new L_Block();
                    break;
                case 5:
                    newBlock = new J_Block();
                    break;
                case 6:
                    newBlock = new T_Block();
                    break;
                case 7:
                    newBlock = new UNTI_Block();
                    break;
            }
            blockList.Add(newBlock);
        }
        [System.Security.Permissions.UIPermission(
            System.Security.Permissions.SecurityAction.Demand,
            Window = System.Security.Permissions.UIPermissionWindow.AllWindows
            )]
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (blockList.Count > 0)
            {
                Block lastBlock = blockList.Last();
                bool[] touchBlock = GetTouchBlock(lastBlock);
                if ((keyData & Keys.KeyCode) == Keys.S && touchBlock[0] == false)
                {
                    lastBlock.Move(new Point(0, 10), pictureBox1.Size);
                }
                else if ((keyData & Keys.KeyCode) == Keys.A && touchBlock[1] == false)
                {
                    lastBlock.Move(new Point(-10, 0), pictureBox1.Size);
                }
                else if ((keyData & Keys.KeyCode) == Keys.D && touchBlock[2] == false)
                {
                    lastBlock.Move(new Point(10, 0), pictureBox1.Size);
                }
                else if ((keyData & Keys.KeyCode) == Keys.Space && touchBlock[0] == false && touchBlock[1] == false && touchBlock[2] == false)
                {
                    lastBlock.Rotate(1 ,pictureBox1.Size);
                }
            }
            return base.ProcessDialogKey(keyData);
        }

        private bool[] GetTouchBlock(Block block)
        {
            bool[] isTouchArray = new bool[] { false, false, false };
            List<Rectangle> rectList1 = block.GetRectList();

            foreach(Block b in blockList)
            {
                if(b != block)
                {
                    List<Rectangle> rectList2 = b.GetRectList();
                    foreach (Rectangle rect in rectList1)
                    {
                        if(rectList2.Exists(r => rect.Left == r.Left && rect.Bottom == r.Top))
                        {
                            isTouchArray[0] = true;
                        }

                        if(rectList2.Exists(r => rect.Left == r.Right && rect.Top == r.Top))
                        {
                            isTouchArray[1] = true;
                        }

                        if(rectList2.Exists(r => rect.Right == r.Left && rect.Top == r.Top))
                        {
                            isTouchArray[2] = true;
                        }
                    }
                }
            }
            return isTouchArray;
        }
        private bool getBlock(Point point)
        {
            if (blockList.Find(p => p.pos.X == point.X && p.pos.Y == point.Y) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
