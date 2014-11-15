using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        MyTimer timerOfPractice;
        Graphics graphicsMain;

        int smoothingModeCounter = 1;
        int brushesTypeCounter = 1;        

        int numberOfPractice;

        string directorySource;
        string directoryOutput;

        public Form1()
        {
            InitializeComponent();
            timerOfPractice = new MyTimer();
            this.DoubleBuffered = true;
        }

        private void practice1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnvisibleElements(this);
            timerOfPractice.StartTimer(1000, timer1_Tick);          
            numberOfPractice = 1; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelForDisplaying.Visible = true;

            switch (numberOfPractice)
            {
                case 1:
                    {
                        Drawing_for_Practice1 drPC1 = new Drawing_for_Practice1(this);
                        if (smoothingModeCounter == 6) smoothingModeCounter = 1;
                        labelTypeOfPractice.Text = "Smoothing Mode:";
                        panelForDisplaying.Refresh();                        
                        drPC1.DrawCircleAndChangeSmoothingMode(smoothingModeCounter, graphicsMain);
                        smoothingModeCounter++;                        
                    } break;
                case 2:
                    {
                        Drawing_for_Practice2 drPC2 = new Drawing_for_Practice2(this);
                        labelTypeOfPractice.Text = "Color:";
                        panelForDisplaying.Refresh();
                        drPC2.DrawSolidCircleAndChangeColor(graphicsMain);
                    } break;
                case 3:
                    {
                        Drawing_for_Practice3 drPC3 = new Drawing_for_Practice3(this);
                        labelTypeOfPractice.Text = "Brush:";
                        panelForDisplaying.Refresh();
                        if (brushesTypeCounter == 6) {brushesTypeCounter = 1;}
                        drPC3.DrawSolidCircleAndChangeBrushes(graphicsMain, brushesTypeCounter);
                        brushesTypeCounter++;
                     } break;
            }
        }

        private void practice2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnvisibleElements(this);
            timerOfPractice.StartTimer(2000, timer1_Tick);
            numberOfPractice = 2;
        }

        private void practice3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnvisibleElements(this);
            timerOfPractice.StartTimer(1000, timer1_Tick);
            numberOfPractice = 3;
        }

        private void practice45ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timerOfPractice.StopTimer();
            UnvisibleElements(this);
            //panelForDisplaying.Visible = false;
            panelForDisplaying.Refresh();
            panelForRectangles.Visible = false;
            panelForDisplaying.Visible = true;

            buttonChooseFolderForPreview.Visible = true;
            buttonForMergingImages.Visible = false;
            buttonChooseOutputImages.Visible = false;
        }

        private void buttonForImagePreview_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdSourcePath = new FolderBrowserDialog();
            fbdSourcePath.Description = "Select folder with images:";
            DialogResult resultSource = fbdSourcePath.ShowDialog();
            directorySource = fbdSourcePath.SelectedPath;

            if (resultSource == DialogResult.Cancel)
            {
                MessageBox.Show("You've canceled choose!");
            }

            PictureResizer_for_Practice5 Pr5 = new PictureResizer_for_Practice5(this);
            Pr5.CreateThumbnails(directorySource);
        }
        
        private void buttonChooseOutputImages_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdOutputPath = new FolderBrowserDialog();
            fbdOutputPath.Description = "Select folder for output images: ";
            DialogResult resultOutput = fbdOutputPath.ShowDialog();
            directoryOutput = fbdOutputPath.SelectedPath;

            PictureMerger_for_Practice6.MergePictures(directorySource, directoryOutput);

        }

        private void buttonForMergingImages_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbdSourcePath = new FolderBrowserDialog();
            fbdSourcePath.Description = "Select folder with images:";
            DialogResult resultSource = fbdSourcePath.ShowDialog();
            directorySource = fbdSourcePath.SelectedPath;
        }

        private void practice6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelForDisplaying.Controls.Clear();
            panelForRectangles.Visible = false;
            timerOfPractice.StopTimer();
            UnvisibleElements(this);
            buttonChooseFolderForPreview.Visible = false;
            buttonForMergingImages.Visible = true;
            buttonChooseOutputImages.Visible = true;                        
            
        }

        private void practice7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerOfPractice.StopTimer();
            UnvisibleElements(this);
            panelForDisplaying.Visible = false;
        }

        Point startPos;    
        Point currentPos;    
        bool drawing;      
        List<Rectangle> rectangles = new List<Rectangle>(); 

        private Rectangle getRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
        }

        void myPaintEvent(object sender, PaintEventArgs e)
        {
            if (rectangles.Count > 0) e.Graphics.DrawRectangles(Pens.Black, rectangles.ToArray());
            if (drawing) e.Graphics.DrawRectangle(Pens.Red, getRectangle());            
        }

        public void myMouseDownEvent(object sender, MouseEventArgs e)
        {
            currentPos = startPos = e.Location;
            drawing = true;           
        }

        public void myMouseMoveEvent(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            if (drawing) 
            Invalidate();            
        }

        public void myMouseUpEvent(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                drawing = false;
                Rectangle rc = getRectangle();
                if (rc.Width > 0 && rc.Height > 0) rectangles.Add(rc);
                Invalidate();
            }           
        }

        private void practice8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerOfPractice.StopTimer();
            UnvisibleElements(this);
            panelForDisplaying.Controls.Clear();
            panelForDisplaying.Refresh();
            panelForRectangles.Visible = true;
            panelForRectangles.Dock = DockStyle.Fill;
            panelForRectangles.Refresh();
            graphicsMain = panelForRectangles.CreateGraphics();
            RandomRectangles_for_Practice8.GetRandomRectangles(graphicsMain);
        }

        static void UnvisibleElements(Form1 e)
        {
            e.panelForDisplaying.Refresh();
            e.labelDescriptionOfMode.Text = "";
            e.labelForBrushMode.Text = "";
            e.labelTypeOfPractice.Text = "";
            e.buttonChooseFolderForPreview.Visible = false;
            e.buttonChooseOutputImages.Visible = false;
            e.buttonForMergingImages.Visible = false;
        }





       
    }
}
