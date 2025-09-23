using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramUtil
{
    public class HistogramHelper
    {
        Bitmap sourceImage;
        public HistogramHelper(Bitmap sourceImage)
        {
            this.sourceImage = sourceImage;
        }
        public Bitmap generate_RedHistogram()
        {
            
            int[] redHistogram = new int[256];
            int maxCount = 0;

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    redHistogram[pixelColor.R]++;
                }
            }

            
            for (int i = 0; i < redHistogram.Length; i++)
            {
                if (redHistogram[i] > maxCount)
                {
                    maxCount = redHistogram[i];
                }
            }

           
            const int histogramWidth = 256;
            const int histogramHeight = 200;

            Bitmap histogramBitmap = new Bitmap(histogramWidth, histogramHeight);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                using (Pen redPen = new Pen(Color.Red))
                {
                    for (int i = 0; i < redHistogram.Length; i++)
                    {
                       
                        float barHeight = ((float)redHistogram[i] / maxCount) * histogramHeight;
                        g.DrawLine(redPen, i, histogramHeight, i, histogramHeight - barHeight);
                    }
                }
            }
            return histogramBitmap;
        }


        public Bitmap generate_GreenHistogram()
        {

            int[] greenHistogram = new int[256];
            int maxCount = 0;

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    greenHistogram[pixelColor.G]++;
                }
            }


            for (int i = 0; i < greenHistogram.Length; i++)
            {
                if (greenHistogram[i] > maxCount)
                {
                    maxCount = greenHistogram[i];
                }
            }


            const int histogramWidth = 256;
            const int histogramHeight = 200;

            Bitmap histogramBitmap = new Bitmap(histogramWidth, histogramHeight);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                using (Pen greenPen = new Pen(Color.Green))
                {
                    for (int i = 0; i < greenHistogram.Length; i++)
                    {

                        float barHeight = ((float)greenHistogram[i] / maxCount) * histogramHeight;
                        g.DrawLine(greenPen, i, histogramHeight, i, histogramHeight - barHeight);
                    }
                }
            }
            return histogramBitmap;
        }

        public Bitmap generate_BlueHistogram()
        {

            int[] blueHistogram = new int[256];
            int maxCount = 0;

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    blueHistogram[pixelColor.B]++;
                }
            }


            for (int i = 0; i < blueHistogram.Length; i++)
            {
                if (blueHistogram[i] > maxCount)
                {
                    maxCount = blueHistogram[i];
                }
            }


            const int histogramWidth = 256;
            const int histogramHeight = 200;

            Bitmap histogramBitmap = new Bitmap(histogramWidth, histogramHeight);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                using (Pen bluePen = new Pen(Color.Blue))
                {
                    for (int i = 0; i < blueHistogram.Length; i++)
                    {

                        float barHeight = ((float)blueHistogram[i] / maxCount) * histogramHeight;
                        g.DrawLine(bluePen, i, histogramHeight, i, histogramHeight - barHeight);
                    }
                }
            }
            return histogramBitmap;
        }

        public Bitmap generate_GrayHistogram()
        {
            
            int[] grayscaleHistogram = new int[256];
            int maxCount = 0;

            for (int y = 0; y < sourceImage.Height; y++)
            {
                for (int x = 0; x < sourceImage.Width; x++)
                {
                    Color pixelColor = sourceImage.GetPixel(x, y);
                    
                    int grayValue = (int)((pixelColor.R + pixelColor.G + pixelColor.B)/3);
                    grayscaleHistogram[grayValue]++;
                }
            }

            
            for (int i = 0; i < grayscaleHistogram.Length; i++)
            {
                if (grayscaleHistogram[i] > maxCount)
                {
                    maxCount = grayscaleHistogram[i];
                }
            }

            
            const int histogramWidth = 256;
            const int histogramHeight = 200;

            Bitmap histogramBitmap = new Bitmap(histogramWidth, histogramHeight);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                using (Pen blackPen = new Pen(Color.Black))
                {
                    for (int i = 0; i < grayscaleHistogram.Length; i++)
                    {
                        float barHeight = ((float)grayscaleHistogram[i] / maxCount) * histogramHeight;
                        g.DrawLine(blackPen, i, histogramHeight, i, histogramHeight - barHeight);
                    }
                }
            }
            return histogramBitmap;
        }
    }
}
