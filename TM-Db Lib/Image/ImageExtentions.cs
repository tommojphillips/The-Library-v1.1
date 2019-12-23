using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TM_Db_Lib
{
    public static class ImageExtentions
    {
        // Written, 17.12.2019

        /// <summary>
        /// resizes the image to the specified canvas size. parameters. "<paramref name="originalHeight"/>" and "<paramref name="originalWidth"/>" are optional parameters. 
        /// if no value is given (default values '9999'), method will automaticly get the images size. defaults for them are 9999. NOTE,
        /// <paramref name="inCanvasHeight"/> + <paramref name="inCanvasWidth"/> cannot be equal to 0.
        /// </summary>
        /// <param name="inImage">The image to resize.</param>
        /// <param name="inCanvasWidth">The width of the canvas. (where the image will go)</param>
        /// <param name="inCanvasHeight">The Height of the canvas. (where the image will go)</param>
        public static Image resizeImage(this Image inImage, int inCanvasWidth, int inCanvasHeight)
        {
            // Written, 17.12.2019

            Image image = inImage;
            int _originalWidth = image.Width;
            int _originalHeight = image.Height;

            Image thumbnail = new Bitmap(inCanvasWidth, inCanvasHeight);
            Graphics graphic = Graphics.FromImage(thumbnail);
            graphic.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphic.SmoothingMode = SmoothingMode.HighQuality;
            graphic.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphic.CompositingQuality = CompositingQuality.HighQuality;

            // Figure out the ratio
            double ratioX = inCanvasWidth / (double)_originalWidth;
            double ratioY = inCanvasHeight / (double)_originalHeight;
            double ratio = ratioX < ratioY ? ratioX : ratioY;
            int newHeight = Convert.ToInt32(_originalHeight * ratio);
            int newWidth = Convert.ToInt32(_originalWidth * ratio);
            int posX = Convert.ToInt32((inCanvasWidth - (_originalWidth * ratio)) / 2);
            int posY = Convert.ToInt32((inCanvasHeight - (_originalHeight * ratio)) / 2);

            graphic.Clear(Color.White);
            graphic.DrawImage(image, posX, posY, newWidth, newHeight);

            return thumbnail;
        }
    }
}
