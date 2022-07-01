using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CG_Task1
{
    class PolylineBox : PictureBox
    {
        private List<PointF> endPoints = new List<PointF>();
        string Filter;
        bool isGamma = false;

        public PolylineBox()
        {

        }

        public void initEndpoints()
        {
            endPoints.Add(new PointF(0, 255));
            endPoints.Add(new PointF(100, 100));
            endPoints.Add(new PointF(255, 0));

            Graphics g = CreateGraphics();
            foreach (var point in endPoints)
                g.DrawRectangle(Pens.Red, point.X - 2.0f, point.Y - 2.0f, 4.0f, 4.0f);
            if (endPoints.Count > 1)
                g.DrawLines(Pens.Red, endPoints.ToArray());
            Invalidate();
        }

        public void Inversion()
        {
            endPoints.Add(new PointF(0, 0));
            endPoints.Add(new PointF(255, 255));
            Invalidate();
        }
        public void Brightness(double val)
        {
            float pixelVal = (float)(255 / 100 * Math.Abs(val));
            if (val > 0)
            {
                endPoints.Add(new PointF(0, 255 - pixelVal));
                endPoints.Add(new PointF(255 - pixelVal, 0));
                endPoints.Add(new PointF(255, 0));
            }
            else
            {
                endPoints.Add(new PointF(0, 255));
                endPoints.Add(new PointF(pixelVal, 255));
                endPoints.Add(new PointF(255, pixelVal));
            }
            Invalidate();
        }

        public void Contrast(double val)
        {
            double pixelVal = Math.Pow((100.0 + val) / 100.0, 2);
        }

        public void Gamma(double val)
        {
            isGamma = true;
            endPoints.Add(new PointF(0, 255));
            for(int x = 1; x < 255; x++)
            {
                endPoints.Add(new PointF(x, 255 - (float)Math.Pow(x, val)));
            }
            endPoints.Add(new PointF(255, 0));
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

           Graphics g = pe.Graphics;
           if(!isGamma)
                foreach (PointF point in endPoints)
                    g.DrawRectangle(Pens.Red, point.X - 2.0f, point.Y - 2.0f, 4.0f, 4.0f);
           if (endPoints.Count > 1)
                g.DrawLines(Pens.Red, endPoints.ToArray());
        }
        
    }
}
