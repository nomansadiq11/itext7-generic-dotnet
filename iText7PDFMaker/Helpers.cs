﻿using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
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

        //public static Paragraph SetTextBold(string paragrapshvalue)
        //{
        //    PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
        //}


        public static Paragraph GetParagraph(string paragrapshvalue, TextAlignment textAlignment = TextAlignment.LEFT, int Fontsize = 12)
        {
            Paragraph paragraph = new Paragraph(paragrapshvalue).SetTextAlignment(textAlignment).SetFontSize(Fontsize);
            return paragraph;
        }

        public static Paragraph GetParagraph(Text text, TextAlignment textAlignment = TextAlignment.LEFT, int Fontsize = 12)
        {
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            Paragraph paragraph = new Paragraph(text).SetTextAlignment(textAlignment).SetFontSize(Fontsize).SetFont(bold);
            return paragraph;
        }

        public static Paragraph GetParagraph(string paragrapshvalue, int Fontsize = 12)
        {
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);
            Paragraph paragraph = new Paragraph(paragrapshvalue).SetFontSize(Fontsize).SetFont(bold);
            return paragraph;
        }

        public static Paragraph GetParagraph(string paragrapshvalue)
        {
            iText.Kernel.Colors.Color mycolor = new DeviceRgb(5, 115, 212);
            Text redText = new Text(paragrapshvalue).SetFontColor(mycolor);

            Paragraph paragraph = new Paragraph(redText);
            return paragraph;
        }
    }
}
