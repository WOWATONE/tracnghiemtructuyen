using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 
namespace TNTT.Component
{
    public static class Com_Base
    {
        public static Bitmap Convert_Text_to_Image(string txt, string fontname, int fontsize)
        {
            //creating bitmap image
            Bitmap bmp = new Bitmap(1, 1);
           
            //FromImage method creates a new Graphics from the specified Image.
            Graphics graphics = Graphics.FromImage(bmp);
            // Create the Font object for the image text drawing.
            Font font = new Font(fontname, fontsize);
           // Instantiating object of Bitmap image again with the correct size for the text and font.
            SizeF stringSize = graphics.MeasureString(txt, font);
            bmp = new Bitmap(bmp,(int)stringSize.Width,(int)stringSize.Height); 
            graphics = Graphics.FromImage(bmp);
 
           /* It can also be a way
          bmp = new Bitmap(bmp, new Size((int)graphics.MeasureString(txt, font).Width, (int)graphics.MeasureString(txt, font).Height));*/
 
            //Draw Specified text with specified format 
            graphics.DrawString(txt, font, Brushes.Red, 0, 0);
            font.Dispose();            
            graphics.Flush();
            graphics.Dispose();
            return bmp;     //return Bitmap Image 
         }
    }
}
