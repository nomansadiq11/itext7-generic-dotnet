using iText.Kernel.Colors;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iText7PDFMaker
{
    public static class PDFMaker
    {
        public static Paragraph GetHeading2(string paragrapshvalue)
        {
            iText.Kernel.Colors.Color mycolor = new DeviceRgb(8, 134, 254);
            Text redText = new Text(paragrapshvalue).SetFontColor(mycolor);

            Paragraph paragraph = Helpers.GetParagraph(redText, TextAlignment.LEFT, 12);
            return paragraph;
        }

        public static Paragraph GetHeading3(string paragrapshvalue)
        {
            iText.Kernel.Colors.Color mycolor = new DeviceRgb(153, 204, 255);
            Text redText = new Text(paragrapshvalue).SetFontColor(mycolor);
            

            Paragraph paragraph = Helpers.GetParagraph(redText, TextAlignment.LEFT, 10);
            return paragraph;
        }
    }
}
