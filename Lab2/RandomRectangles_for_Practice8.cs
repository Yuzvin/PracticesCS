using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RandomRectangles_for_Practice8
    {
        static Form1 form1;
        public RandomRectangles_for_Practice8(Form1 fr1) { form1 = fr1; }
        public static void GetRandomRectangles(Graphics graphicsMain)
        {
            Random rand = new Random();
            Pen myPen = new Pen(Color.Black, 2);
            

            RectangleF[] arrRectList = new RectangleF[10];

            for (int i = 0; i < 10; i++)
            {
                arrRectList[i] =
                    new RectangleF(rand.Next(10, 300), rand.Next(10, 200), rand.Next(50, 100), rand.Next(10, 100));
            }
            graphicsMain.DrawRectangles(myPen, arrRectList);
        }
    }
}
