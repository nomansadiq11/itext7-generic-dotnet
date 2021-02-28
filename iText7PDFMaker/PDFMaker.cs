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

        public static Paragraph GetText(string paragrapshvalue)
        {
            Paragraph paragraph = Helpers.GetParagraph(paragrapshvalue, TextAlignment.LEFT, 8);
            return paragraph;
        }

        public static Table GetTable(int NumOfCols, List<string> Headers, System.Data.DataTable datarows)
        {
            Table _table = new Table(NumOfCols, true);

            
            foreach (var head in Headers)
            {
                var val = new Paragraph(head).SetFontSize(10);
                _table.AddCell(new Cell().Add(val));
            }


            foreach(System.Data.DataRow row in datarows.Rows)
            {
                foreach(System.Data.DataColumn datacol in datarows.Columns)
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


            foreach (var head in datarows.Columns)
            {
                var val = new Paragraph(head.ToString()).SetFontSize(10);
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

    }
}
