using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    class PictureMerger_for_Practice6
    {
        public static void MergePictures(string directorySource, string directoryOutput)
        {
            try
            {

                ArrayList imgArrList = new ArrayList();
                List<Image> imgArr = new List<Image>();
                string[] strFilter = { "*.jpg", "*.png", "*.gif" };

                foreach (string filter in strFilter)
                {
                    imgArrList.AddRange(Directory.GetFiles(directorySource, filter));
                }

                foreach (string myfile in imgArrList)
                {
                    Image image = Image.FromFile(myfile);
                    imgArr.Add(image);
                }

                int counterForNames = 1;

                foreach (Image image in imgArr)
                {
                    Graphics g = Graphics.FromImage(image);
                    g.DrawImage(Image.FromFile("D:\\logo.jpg"), new Point(10, 10));
                    image.Save(directoryOutput + "\\output" + counterForNames + ".jpg", ImageFormat.Jpeg);
                    counterForNames++;
                }
                MessageBox.Show("Done!", "Succes!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
