namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.practice1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practice8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTypeOfPractice = new System.Windows.Forms.Label();
            this.labelDescriptionOfMode = new System.Windows.Forms.Label();
            this.labelForBrushMode = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonChooseFolderForPreview = new System.Windows.Forms.Button();
            this.panelForDisplaying = new System.Windows.Forms.Panel();
            this.buttonChooseOutputImages = new System.Windows.Forms.Button();
            this.buttonForMergingImages = new System.Windows.Forms.Button();
            this.panelForRectangles = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practice1ToolStripMenuItem,
            this.practice2ToolStripMenuItem,
            this.practice3ToolStripMenuItem,
            this.practice45ToolStripMenuItem,
            this.practice6ToolStripMenuItem,
            this.practice7ToolStripMenuItem,
            this.practice8ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // practice1ToolStripMenuItem
            // 
            this.practice1ToolStripMenuItem.Name = "practice1ToolStripMenuItem";
            this.practice1ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice1ToolStripMenuItem.Text = "Practice1";
            this.practice1ToolStripMenuItem.Click += new System.EventHandler(this.practice1ToolStripMenuItem_Click);
            // 
            // practice2ToolStripMenuItem
            // 
            this.practice2ToolStripMenuItem.Name = "practice2ToolStripMenuItem";
            this.practice2ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice2ToolStripMenuItem.Text = "Practice2";
            this.practice2ToolStripMenuItem.Click += new System.EventHandler(this.practice2ToolStripMenuItem_Click);
            // 
            // practice3ToolStripMenuItem
            // 
            this.practice3ToolStripMenuItem.Name = "practice3ToolStripMenuItem";
            this.practice3ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice3ToolStripMenuItem.Text = "Practice3";
            this.practice3ToolStripMenuItem.Click += new System.EventHandler(this.practice3ToolStripMenuItem_Click);
            // 
            // practice45ToolStripMenuItem
            // 
            this.practice45ToolStripMenuItem.Name = "practice45ToolStripMenuItem";
            this.practice45ToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.practice45ToolStripMenuItem.Text = "Practice4-5";
            this.practice45ToolStripMenuItem.Click += new System.EventHandler(this.practice45ToolStripMenuItem_Click);
            // 
            // practice6ToolStripMenuItem
            // 
            this.practice6ToolStripMenuItem.Name = "practice6ToolStripMenuItem";
            this.practice6ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice6ToolStripMenuItem.Text = "Practice6";
            this.practice6ToolStripMenuItem.Click += new System.EventHandler(this.practice6ToolStripMenuItem_Click);
            // 
            // practice7ToolStripMenuItem
            // 
            this.practice7ToolStripMenuItem.Name = "practice7ToolStripMenuItem";
            this.practice7ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice7ToolStripMenuItem.Text = "Practice7";
            this.practice7ToolStripMenuItem.Click += new System.EventHandler(this.practice7ToolStripMenuItem_Click);
            // 
            // practice8ToolStripMenuItem
            // 
            this.practice8ToolStripMenuItem.Name = "practice8ToolStripMenuItem";
            this.practice8ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.practice8ToolStripMenuItem.Text = "Practice8";
            this.practice8ToolStripMenuItem.Click += new System.EventHandler(this.practice8ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTypeOfPractice
            // 
            this.labelTypeOfPractice.AutoSize = true;
            this.labelTypeOfPractice.Location = new System.Drawing.Point(13, 205);
            this.labelTypeOfPractice.Name = "labelTypeOfPractice";
            this.labelTypeOfPractice.Size = new System.Drawing.Size(0, 13);
            this.labelTypeOfPractice.TabIndex = 2;
            // 
            // labelDescriptionOfMode
            // 
            this.labelDescriptionOfMode.AutoSize = true;
            this.labelDescriptionOfMode.Location = new System.Drawing.Point(109, 205);
            this.labelDescriptionOfMode.Name = "labelDescriptionOfMode";
            this.labelDescriptionOfMode.Size = new System.Drawing.Size(0, 13);
            this.labelDescriptionOfMode.TabIndex = 3;
            // 
            // labelForBrushMode
            // 
            this.labelForBrushMode.AutoSize = true;
            this.labelForBrushMode.Location = new System.Drawing.Point(222, 205);
            this.labelForBrushMode.Name = "labelForBrushMode";
            this.labelForBrushMode.Size = new System.Drawing.Size(0, 13);
            this.labelForBrushMode.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonChooseFolderForPreview
            // 
            this.buttonChooseFolderForPreview.Location = new System.Drawing.Point(22, 194);
            this.buttonChooseFolderForPreview.Name = "buttonChooseFolderForPreview";
            this.buttonChooseFolderForPreview.Size = new System.Drawing.Size(194, 49);
            this.buttonChooseFolderForPreview.TabIndex = 5;
            this.buttonChooseFolderForPreview.Text = "Вибрати папку із зображеннями для прев\'ю";
            this.buttonChooseFolderForPreview.UseVisualStyleBackColor = true;
            this.buttonChooseFolderForPreview.Visible = false;
            this.buttonChooseFolderForPreview.Click += new System.EventHandler(this.buttonForImagePreview_Click);
            // 
            // panelForDisplaying
            // 
            this.panelForDisplaying.AutoScroll = true;
            this.panelForDisplaying.Location = new System.Drawing.Point(22, 27);
            this.panelForDisplaying.Name = "panelForDisplaying";
            this.panelForDisplaying.Size = new System.Drawing.Size(409, 161);
            this.panelForDisplaying.TabIndex = 6;
            this.panelForDisplaying.Visible = false;
            // 
            // buttonChooseOutputImages
            // 
            this.buttonChooseOutputImages.Location = new System.Drawing.Point(222, 194);
            this.buttonChooseOutputImages.Name = "buttonChooseOutputImages";
            this.buttonChooseOutputImages.Size = new System.Drawing.Size(209, 49);
            this.buttonChooseOutputImages.TabIndex = 7;
            this.buttonChooseOutputImages.Text = "Вибрати папку для збереження";
            this.buttonChooseOutputImages.UseVisualStyleBackColor = true;
            this.buttonChooseOutputImages.Visible = false;
            this.buttonChooseOutputImages.Click += new System.EventHandler(this.buttonChooseOutputImages_Click);
            // 
            // buttonForMergingImages
            // 
            this.buttonForMergingImages.Location = new System.Drawing.Point(22, 194);
            this.buttonForMergingImages.Name = "buttonForMergingImages";
            this.buttonForMergingImages.Size = new System.Drawing.Size(194, 49);
            this.buttonForMergingImages.TabIndex = 8;
            this.buttonForMergingImages.Text = "Вибрати папку для склеювання зображень";
            this.buttonForMergingImages.UseVisualStyleBackColor = true;
            this.buttonForMergingImages.Visible = false;
            this.buttonForMergingImages.Click += new System.EventHandler(this.buttonForMergingImages_Click);
            // 
            // panelForRectangles
            // 
            this.panelForRectangles.AutoScroll = true;
            this.panelForRectangles.Location = new System.Drawing.Point(22, 27);
            this.panelForRectangles.Name = "panelForRectangles";
            this.panelForRectangles.Size = new System.Drawing.Size(409, 161);
            this.panelForRectangles.TabIndex = 7;
            this.panelForRectangles.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 325);
            this.Controls.Add(this.panelForRectangles);
            this.Controls.Add(this.buttonForMergingImages);
            this.Controls.Add(this.buttonChooseOutputImages);
            this.Controls.Add(this.panelForDisplaying);
            this.Controls.Add(this.buttonChooseFolderForPreview);
            this.Controls.Add(this.labelForBrushMode);
            this.Controls.Add(this.labelDescriptionOfMode);
            this.Controls.Add(this.labelTypeOfPractice);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.myPaintEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myMouseDownEvent);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myMouseMoveEvent);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myMouseUpEvent);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem practice1ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem practice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practice3ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem practice45ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practice6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practice7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practice8ToolStripMenuItem;
        public System.Windows.Forms.Label labelTypeOfPractice;
        public System.Windows.Forms.Label labelDescriptionOfMode;
        public System.Windows.Forms.Label labelForBrushMode;
        public System.Windows.Forms.Panel panelForDisplaying;
        private System.Windows.Forms.Button buttonChooseOutputImages;
        private System.Windows.Forms.Button buttonForMergingImages;
        public System.Windows.Forms.Button buttonChooseFolderForPreview;
        public System.Windows.Forms.Panel panelForRectangles;
    }
}

