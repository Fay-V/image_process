using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_process.ConvolutionImageAssist
{
    public class ConvMatrix
    {
        public int TopLeft = 0, TopMid = 0, TopRight = 0;

        public int MidLeft = 0, Pixel = 1, MidRight = 0;

        public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;

        public int Factor = 1;

        public int Offset = 0;

        public void SetAll(int nVal)

        {

            TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight =

            BottomLeft = BottomMid = BottomRight = nVal;

        }

        public void SetRow ((int, int, int) tuple, int row)
        {
            if (row == 0)
            {
                TopLeft = tuple.Item1;
                TopMid = tuple.Item2;
                TopRight = tuple.Item3;
            }
            else if (row == 1)
            {
                MidLeft = tuple.Item1;
                Pixel = tuple.Item2;
                MidRight = tuple.Item3;
            }
            else if (row == 2)
            {
                BottomLeft = tuple.Item1;
                BottomMid = tuple.Item2;
                BottomRight = tuple.Item3;
            }
            else
            {
                throw new ArgumentOutOfRangeException("row", "Row must be 0, 1, or 2.");
            }
        }
    }
}
