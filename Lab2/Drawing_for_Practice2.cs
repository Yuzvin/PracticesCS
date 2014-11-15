using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Drawing_for_Practice2
    {
        static Form1 form1;
        public Drawing_for_Practice2 (Form1 fr1) { form1 = fr1; }
        public void DrawSolidCircleAndChangeColor(Graphics graphicsMain)
        {
            SolidBrush myBrush = new SolidBrush(RandomColor.getRandomColor());
            graphicsMain = form1.panelForDisplaying.CreateGraphics();
            graphicsMain.SmoothingMode = SmoothingMode.HighQuality;
            graphicsMain.FillEllipse(myBrush, 50, 50, 100, 100);
            form1.labelDescriptionOfMode.Text = myBrush.Color.Name;
        }


    }
}
