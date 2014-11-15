using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Drawing_for_Practice3
    {
        static Form1 form1;
        public Drawing_for_Practice3(Form1 fr1) { form1 = fr1; }
        public void DrawSolidCircleAndChangeBrushes(Graphics graphicsMain, int brushesTypeCounter)
        {
            graphicsMain = form1.panelForDisplaying.CreateGraphics();
            graphicsMain.SmoothingMode = SmoothingMode.HighQuality;

            if (brushesTypeCounter == 6) { brushesTypeCounter = 1; }
            switch (brushesTypeCounter)
            {
                case 1:
                    {
                        SolidBrush mySolidBrush = new SolidBrush(RandomColor.getRandomColor());
                        graphicsMain.FillEllipse(mySolidBrush, 50, 50, 100, 100);
                        form1.labelDescriptionOfMode.Text = "SolidBrush";
                        brushesTypeCounter++;
                    } break;

                case 2:
                    {
                        Random random = new Random();
                        var value = Enum.GetValues(typeof(HatchStyle));
                        HatchStyle randomHatchStyle = (HatchStyle)value.GetValue(random.Next(value.Length));

                        HatchBrush myHatchBrush = new HatchBrush(randomHatchStyle,
                        RandomColor.getRandomColor(), RandomColor.getRandomColor());

                        graphicsMain.FillEllipse(myHatchBrush, 50, 50, 100, 100);

                        form1.labelDescriptionOfMode.Text = "HatchBrush";
                        form1.labelForBrushMode.Text = randomHatchStyle.ToString();
                        brushesTypeCounter++;
                    } break;

                case 3:
                    {
                        TextureBrush myTextureBrush = new TextureBrush(new Bitmap(
                            "D:\\water.jpg"));
                        graphicsMain.FillEllipse(myTextureBrush, 50, 50, 100, 100);

                        form1.labelDescriptionOfMode.Text = "TextureBrush";
                        form1.labelForBrushMode.Text = "";

                        brushesTypeCounter++;
                    } break;

                case 4:
                    {
                        Random random = new Random();
                        var values = Enum.GetValues(typeof(LinearGradientMode));
                        LinearGradientMode randLinGradMode = (LinearGradientMode)values.GetValue(random.Next(values.Length));

                        LinearGradientBrush myLinGradBrush = new LinearGradientBrush(
                            new Rectangle(50, 50, 100, 100), Color.Black, Color.Blue,
                            randLinGradMode);
                        graphicsMain.FillEllipse(myLinGradBrush, 50, 50, 100, 100);

                        form1.labelDescriptionOfMode.Text = "LinearGradientBrush";
                        form1.labelForBrushMode.Text = randLinGradMode.ToString();

                        brushesTypeCounter++;
                        form1.labelForBrushMode.Text = "";

                    } break;

                case 5:
                    {
                        GraphicsPath path = new GraphicsPath();
                        path.AddEllipse(50, 50, 100, 100);
                        PathGradientBrush myPathGradBrush = new PathGradientBrush(path);
                        myPathGradBrush.CenterColor = RandomColor.getRandomColor();
                        Color[] myColors = { RandomColor.getRandomColor() };
                        myPathGradBrush.SurroundColors = myColors;

                        graphicsMain.FillEllipse(myPathGradBrush, 50, 50, 100, 100);

                        form1.labelDescriptionOfMode.Text = "PathGradientBrush";
                        brushesTypeCounter++;

                    } break;
            }
        }
    }
}
