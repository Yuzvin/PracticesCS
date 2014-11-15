using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    class PictureResizer_for_Practice5
    {
        static Form1 form1;
        public PictureResizer_for_Practice5(Form1 fr1) { form1 = fr1; }
        public void CreateThumbnails(string directorySource)
        {            

            ArrayList list = new ArrayList();

            string[] strFilter = { "*.jpg", "*.png", "*.gif" };

            try
            {
                DirectoryInfo directory = new DirectoryInfo(directorySource);

                foreach (string filter in strFilter)
                {

                    list.AddRange(Directory.GetFiles(directorySource, filter));
                    if (list.Count == 0)
                    {
                        throw new System.InvalidOperationException("Виберіть папку ще раз!");
                    }
                }
                PictureBox[] myPictureBox = new PictureBox[list.Count];

                form1.panelForDisplaying.Controls.Clear();

                int y = 0;
                int x = 0;

                for (int index = 0; index < myPictureBox.Length; index++)
                {
                    x = index * 100 + 10;
                    if (index != 0 && index % 4 == 0)
                    {
                        y = y + 90;
                    }

                    myPictureBox[index] = new PictureBox();
                    myPictureBox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                    if (index >= 4)
                        myPictureBox[index].Location = new Point(myPictureBox[index - 4].Location.X, y);
                    else
                        myPictureBox[index].Location = new Point(x, y);
                    myPictureBox[index].Size = new Size(80, 80);
                    myPictureBox[index].Image = Image.FromFile((string)list[index]);
                    form1.panelForDisplaying.Controls.Add(myPictureBox[index]);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Помилка-Inv!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!");
            }
        }
    }
}
