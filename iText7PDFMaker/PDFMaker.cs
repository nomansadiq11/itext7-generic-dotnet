using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Renderer;
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
            redText.SetUnderline(1.5f, -1);

            Paragraph paragraph = Helpers.GetParagraph(redText, TextAlignment.LEFT, 12);
            return paragraph;
        }

        public static Paragraph GetHeading3(string paragrapshvalue)
        {
            //iText.Kernel.Colors.Color mycolor = new DeviceRgb(153, 204, 255);
            Text redText = new Text(paragrapshvalue);
            redText.SetUnderline(1.5f, -1);


            Paragraph paragraph = Helpers.GetParagraph(redText, TextAlignment.LEFT, 10);
            return paragraph;
        }

        public static Paragraph GetText(string paragrapshvalue, int fontsize = 8)
        {
            Paragraph paragraph = Helpers.GetParagraph(paragrapshvalue, TextAlignment.LEFT, fontsize);
            return paragraph;
        }
        public static Paragraph GetTextHeader(string paragrapshvalue)
        {
            Paragraph paragraph = Helpers.GetParagraph(paragrapshvalue, TextAlignment.LEFT, 8);
            return paragraph;
        }

        public static Table GetTable(int NumOfCols, List<string> Headers, System.Data.DataTable datarows)
        {
            Table _table = new Table(NumOfCols, true);
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);

            foreach (var head in Headers)
            {
                var val = new Paragraph(head).SetFontSize(10).SetFont(bold);
                _table.AddCell(new Cell().Add(val));
            }


            foreach (System.Data.DataRow row in datarows.Rows)
            {
                foreach (System.Data.DataColumn datacol in datarows.Columns)
                {
                    var val = new Paragraph(row[datacol].ToString()).SetFontSize(10);
                    _table.AddCell(new Cell().Add(val));
                }
            }

            
            return _table;

        }

        public static Table GetTable(int NumOfCols, System.Data.DataTable datarows)
        {
            Table _table = new Table(NumOfCols, true);
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD);

            foreach (var head in datarows.Columns)
            {
                
                var val = new Paragraph(head.ToString()).SetFontSize(10).SetFont(bold);
                _table.AddCell(new Cell().Add(val));
            }


            foreach (System.Data.DataRow row in datarows.Rows)
            {
                foreach (System.Data.DataColumn datacol in datarows.Columns)
                {
                    var val = new Paragraph(row[datacol].ToString()).SetFontSize(10);
                    _table.AddCell(new Cell().Add(val));
                }
            }


            


            return _table;

        }

        public static Paragraph GetSpace()
        {
            Paragraph space = new Paragraph();
            space.Add("\n");

            return space;

        }

        private class TableBorderRenderer : TableRenderer
        {
            public TableBorderRenderer(Table modelElement)
                : base(modelElement)
            {
            }

            // If renderer overflows on the next area, iText uses getNextRender() method to create a renderer for the overflow part.
            // If getNextRenderer isn't overriden, the default method will be used and thus a default rather than custom
            // renderer will be created
            public override IRenderer GetNextRenderer()
            {
                return new TableBorderRenderer((Table)modelElement);
            }

            protected override void DrawBorders(DrawContext drawContext)
            {
                Rectangle rect = GetOccupiedAreaBBox();
                drawContext.GetCanvas()
                    .SaveState()
                    .Rectangle(rect.GetLeft(), rect.GetBottom(), rect.GetWidth(), rect.GetHeight())
                    .Stroke()
                    .RestoreState();
            }
        }

    }
}
