using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    static class RandomColor
    {
        static public Color getRandomColor()
        {
        Random randomGen = new Random();
        KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
        KnownColor randomColorName = names[randomGen.Next(names.Length)];
        Color randomColor = Color.FromKnownColor(randomColorName);
        return randomColor;
        }
  
    }
}
