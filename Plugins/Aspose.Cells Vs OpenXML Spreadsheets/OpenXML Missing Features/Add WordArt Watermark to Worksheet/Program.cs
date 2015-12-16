﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Cells;
using Aspose.Cells.Drawing;

namespace Add_WordArt_Watermark_to_Worksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a new Workbook
            Workbook workbook = new Workbook();

            //Get the first default sheet
            Worksheet sheet = workbook.Worksheets[0];

            //Add Watermark
            Aspose.Cells.Drawing.Shape wordart = sheet.Shapes.AddTextEffect(MsoPresetTextEffect.TextEffect1,
            "CONFIDENTIAL", "Arial Black", 50, false, true
            , 18, 8, 1, 1, 130, 800);

            //Get the fill format of the word art
            MsoFillFormat wordArtFormat = wordart.FillFormat;

            //Set the color
            wordArtFormat.ForeColor = System.Drawing.Color.Red;

            //Set the transparency
            wordArtFormat.Transparency = 0.9;

            //Make the line invisible
            MsoLineFormat lineFormat = wordart.LineFormat;
            lineFormat.IsVisible = false;

            //Save the file
            workbook.Save("Watermarkt_Test.xls");
        }
    }
}
