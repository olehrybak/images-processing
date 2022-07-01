using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Task1
{
    public class Matrix
    {
        public int topLeft = 0;
        public int topMid = 0;
        public int topRight = 0;
        public int midLeft = 0;
        public int mid = 0;
        public int midRight = 0;
        public int botLeft = 0;
        public int botMid = 0;
        public int botRight = 0;

        public Matrix(int topLeft, int topMid, int topRight, int midLeft, int mid, int midRight, int botLeft, int botMid, int botRight)
        {
            this.topLeft = topLeft;
            this.topMid = topMid;
            this.topRight = topRight;
            this.midLeft = midLeft;
            this.mid = mid;
            this.midRight = midRight;
            this.botLeft = botLeft;
            this.botMid = botMid;
            this.botRight = botRight;
        }
    }
}
