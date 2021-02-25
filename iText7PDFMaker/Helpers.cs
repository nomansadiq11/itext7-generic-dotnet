using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iText7PDFMaker
{
    public static class Helpers
    {

        public static Paragraph GetParagraph(string paragrapshvalue, TextAlignment textAlignment = TextAlignment.LEFT, int Fontsize = 12)
        {
            Paragraph paragraph = new Paragraph(paragrapshvalue).SetTextAlignment(textAlignment).SetFontSize(Fontsize);
            return paragraph;
        }

        public static Paragraph GetParagraph(string paragrapshvalue, int Fontsize = 12)
        {
            Paragraph paragraph = new Paragraph(paragrapshvalue).SetFontSize(Fontsize);
            return paragraph;
        }

        public static Paragraph GetParagraph(string paragrapshvalue)
        {
            Paragraph paragraph = new Paragraph(paragrapshvalue);
            return paragraph;
        }
    }
}
