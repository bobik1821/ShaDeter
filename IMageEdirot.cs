using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaDeter
{
    public class IMageEditor
    {
        Bitmap image = null;
        Color brushColor = Color.White;
        int brushRadius;

        public Bitmap Image { get => image; }
        public int Brushradius { get => brushRadius; }
        public Color BrushColor { get => brushColor; }
        public IMageEditor()
        {
            image = new Bitmap(1024, 1024);
            for(int i=0;i<1024;i++)
            {
                for(int j=0;j<1024;j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 30;
        }
        public IMageEditor(int width,int heidth)
        {
            image = new Bitmap(width, heidth);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heidth; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255, 255, 255, 255));
                }
            }
            brushRadius = 30;
        }
    }
}
