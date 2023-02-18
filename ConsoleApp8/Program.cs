using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Mat pic = new Mat();
            pic = CvInvoke.Imread(@"C:\Users\User2\source\repos\ConsoleApp8\ConsoleApp8");
            Mat gaussianBlur = new Mat();

            CvInvoke.GaussianBlur(pic, gaussianBlur, new System.Drawing.Size(pic.Rows, pic.Cols), 6,6);

            CvInvoke.Imshow("starry night", pic);
            CvInvoke.Imshow("blurry night", gaussianBlur);

            CvInvoke.WaitKey();
        }
    }
}

