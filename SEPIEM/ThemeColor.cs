using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEPIEM
{
    class ThemeColor
    {
        public static Color PrimaryColor {get; set;}
        public static Color SecondaryColor { get; set; }

        public static List<string> colorList = new List<string>()
        {
            "#003366",
             "#000066",
             "#000033",
              "#003366",
               "#000033",
               "#000066",
                "#003366",
                 "#000033"


        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if(correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;

                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
