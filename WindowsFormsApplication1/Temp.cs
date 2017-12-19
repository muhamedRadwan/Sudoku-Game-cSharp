using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class Temp
    {
        internal int Counter = 0;
        public static List<List<int>> elements, Cols, Rows;
        internal List<int> Row, tempRow1, tempRow2, tempRow3, TempCol1, TempCol2, TempCol3;
        public List<int> Col;
        public List<List<int>> sudoku;

        public Temp()
	{
        elements = new List<List<int>>(9);
        Rows     = new List<List<int>>(9);
        Cols     = new List<List<int>>(9);
	}







    }
}
