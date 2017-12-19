using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class OperationsSeq
    {
        internal static int Counter = 0;
        public static int[,] sudokuCols =  new int[9, 9];
        public static int[,] sudoku = new int[9, 9];


        public OperationsSeq()
        {
           
        }

        //Should Call First To initialize the sudoku array 
        public static void convertTextBoxToInt()
        {
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    sudoku[Row, Column] = Int16.Parse(Sudoku.text[Row, Column].Text.ToString());
                }
            }
        }

        //Shold Call Once Before any Operation that done in  Colmuns to speed app operations (Page Fault)
        public static void ConvertRowsToCols()
        {
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    sudokuCols[Column, Row] = sudoku[Column, Row];
                }
            }
        }

        //Check if This number repeated in This Row Or Not
        public static bool Is_SaveRow(int row, int num, Point point)
        {
            for (int Colmun = 0; Colmun < 9; Colmun++)
            {
                if (!(row == point.row && Colmun == point.col))
                {
                    if (sudoku[row, Colmun] == num)
                    {
                        return false;

                    }
                }
            }
            return true;
        }



        //Check if This number repeated in This Col Or Not
        public static bool Is_SaveCol(int col, int num, Point point)
        {
            for (int Row = 0; Row < 9; Row++)
            {
                if (!(Row == point.row && col == point.col))
                {
                    if (sudoku[Row, col] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        //Check if This number repeated in This BOx Or Not
        public static bool Is_SaveBox(int boxStartRow, int boxStartCol, int num, Point point)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (!(row + boxStartRow == point.row && col + boxStartCol == point.col))
                    {
                        if (sudoku[row + boxStartRow, col + boxStartCol] == num)
                        {
                            return false;
                        }
                    }
                    
                }
            }
            return true;
        }


        //Call To Check if Passed Point Row and Col Or Box Have This Number Or not 
        public static bool Is_Save(Point point, int num)
        {
            return Is_SaveRow(point.row, num, point) && Is_SaveCol(point.col, num, point) && Is_SaveBox(point.row - point.row % 3, point.col - point.col % 3, num, point); //1 to row & 1 to col & 1 to BOx
        }
  

    }
}
