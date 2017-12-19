using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SolveSudokuSeq
    {

        internal int size = 9;
        
        public SolveSudokuSeq()
        {
          
        }

        /*
         *          Radwan
         *This Function Find First Position That Didnt Have 
         * Parameters lastRow The Last Row It Found the Free Point on it in last call 
         * lastCol The Last Col It Found the Free Point on it in last call 
         * return the next free Point  
         */
        public virtual Point Find_Unassigned_Location(int lastRow, int lastCol)
        {
            Point Localpoint = new Point();
            for (int row = lastRow; row < size; row++)
            {
                for (int col = lastCol; col < size; col++)
                {
                    if (OperationsSeq.sudoku[row , col].Equals(0))
                    {
                        
                        Localpoint.col = col;
                        Localpoint.row = row;
                        Localpoint.Flage = true;
                        return Localpoint;
                    }
                }
                lastCol = 0;
            }
            Localpoint.Flage = false;
            return Localpoint;
        }


        /*
         *              Radwan
         * Should Call After Initialize suduku matrix in OperationsSeq
         * Take Row and Col That Will Begin Cheeck From Them 
         * in first call should called SolveSudoku(0, 0) ;
         * To begain From Start Of Matrix 
         * 
         */
        public virtual bool SolveSudoku(int lastRow, int lastCol)
        {
            Point point = new Point();
            int [,]s = OperationsSeq.sudoku;
            point = Find_Unassigned_Location(lastRow, lastCol);
            if (!point.Flage)
            {
                return true;
            }
            for (int i = 1; i <= size; i++)
            {
                if (OperationsSeq.Is_Save(point, i)) // Check if can Put This Number in this Box Or Not 
                {
                    OperationsSeq.sudoku[point.row , point.col] = i;
                    if (SolveSudoku(point.row, point.col)) // recursive statment  
                    {
                        return true;
                    }
                    OperationsSeq.sudoku[point.row , point.col] = 0;
                }
            }
            return false;
        }
     

    }

}
