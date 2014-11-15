using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Drawing_for_Practice1
    {
        static Form1 form1;
        public Drawing_for_Practice1(Form1 fr1) { form1 = fr1; }
        public void DrawCircleAndChangeSmoothingMode(int smoothingModeCounter, Graphics graphicsMain)
        {
            Pen pen = new Pen(Color.Black);
            graphicsMain = form1.panelForDisplaying.CreateGraphics();
             
            switch (smoothingModeCounter)
            {
                case 1:
                    {
                        graphicsMain.SmoothingMode = SmoothingMode.AntiAlias;
                        smoothingModeCounter++;
                        form1.labelDescriptionOfMode.Text = graphicsMain.SmoothingMode.ToString();
                    } break;

                case 2:
                    {
                        graphicsMain.SmoothingMode = SmoothingMode.HighQuality;
                        smoothingModeCounter++;
                        form1.labelDescriptionOfMode.Text = graphicsMain.SmoothingMode.ToString();
                    } break;

                case 3:
                    {
                        graphicsMain.SmoothingMode = SmoothingMode.HighSpeed;
                        smoothingModeCounter++;
                        form1.labelDescriptionOfMode.Text = graphicsMain.SmoothingMode.ToString();
                    } break;

                case 4:
                    {
                        graphicsMain.SmoothingMode = SmoothingMode.Default;
                        smoothingModeCounter++;
                        form1.labelDescriptionOfMode.Text = graphicsMain.SmoothingMode.ToString();
                    } break;

                case 5:
                    {
                        graphicsMain.SmoothingMode = SmoothingMode.None;
                        smoothingModeCounter++;
                        form1.labelDescriptionOfMode.Text = graphicsMain.SmoothingMode.ToString();
                    } break;
            }
            graphicsMain.DrawEllipse(pen, 50, 50, 100, 100);
        }
    }
}
