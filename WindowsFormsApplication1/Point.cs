using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Point
    {
        internal int row, col;
        internal bool Flage;
        public Point(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
        public Point()
        {
        }
    }
}
