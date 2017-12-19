using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Operation
    {
        internal int Counter = 0;
        public static List<List<int>> elements, Cols, Rows;
        internal List<int> Row, tempRow1, tempRow2, tempRow3, TempCol1, TempCol2, TempCol3;
        public List<int> Col;
        public List<List<int>> sudoku;
        public Operation() {
        elements = new List<List<int>>(9);
        Rows = new List<List<int>>(9);
        Cols = new List<List<int>>(9);
        }
        public virtual void undoMakeRowsToInteger(List<List<int>> sudoku)
        {
            this.sudoku = new List<List<int>>(9);
		    for (int co = 0; co < 9; co += 3)
		    {
			    tempRow1 = new List<int>();
			    tempRow2 = new List<int>();
			    tempRow3 = new List<int>();
			    //bt3d el row 
			    for (int count = co; count < co + 3; count++)
			    {
				    for (int counter = 0; counter < 3; counter++)
				    {
					    tempRow1.Add(sudoku[count][counter]);
					    tempRow2.Add(sudoku[count][counter + 3]);
					    tempRow3.Add(sudoku[count][counter + 6]);
				    }
			    }
			    this.sudoku.Add(tempRow1);
			    this.sudoku.Add(tempRow2);
			    this.sudoku.Add(tempRow3);

		    }
        }

        public virtual void MakeRows()
        {
	        //Deh 3add   el Boxes
	        Rows = new List<List<int>>();
	        for (int co = 0; co < 9; co += 3)
	        {
		        tempRow1 = new List<int>(9);
		        tempRow3 = new List<int>();
		        tempRow2 = new List<int>();
		        //Deh 3dd EL Boxes Fee EL Eow EL wa7ed
		        for (int i = co; i < co + 3; i++)
		        {
                    Row = elements[i]; //BOx=1 ,Box2
			        //Deh 3add EL Text Filed Fee EL Box El wa7ed
			        for (int j = 0; j < 3; j++)
			        {
				        //System.out.print(Row.get(j));
				        //System.out.print(Row.get(j+3));
				        //System.out.print(Row.get(j+6));
				        tempRow1.Add(Row[j]);
				        tempRow2.Add(Row[j + 3]);
				        tempRow3.Add(Row[j + 6]);
				        /*
				        i=0             i=1                     i=2
				        j=0:3           J=0:3                   J=3:0
				        tempRow1=[8,1,2] tempRow2=[8,1,2,7,5,3]   tempRow3=[8,1,2,7,5,3,6,4,9]
					        */
			        }
		        }
		        Rows.Add(tempRow1);
		        Rows.Add(tempRow2);
		        Rows.Add(tempRow3);
		        // System.out.println("---------------------");
	        }
        }

        public virtual void MakeCol()
        {
		    //Deh 3add   el Boxes
		    Cols = new List<List<int>>();
		    for (int co = 0; co < 3; co += 1)
		    {
			    TempCol1 = new List<int>(9);
			    TempCol2 = new List<int>();
			    TempCol3 = new List<int>();
			    //Deh 3dd EL Boxes Fee EL Col EL wa7ed
			    for (int i = co; i < co + 7; i += 3)
			    {
				    Col = new List<int>();
				    Col = elements.[i]; //BOx=0 ,Box=3 ,Box=6
				    //Box=1  .Box=4 ,Box=7
				    //Box=2  ,Box=5 ,Box=8
				    //Deh 3add EL Text Filed Fee EL Box El wa7ed
				    for (int j = 0; j < 9; j += 3)
				    {
					    //System.out.print(Row.get(j+3));
					    //System.out.print(Row.get(j+6));
					    TempCol1.Add(Col[j]);
					    TempCol2.Add(Col[j + 1]);
					    TempCol3.Add(Col[j + 2]);
					    /*
					    i=0             i=3                     i=6
					    j=0:9           J=0:9                   J=0:9
					    TempCol1=[8,9,6] TempCol2=[8,9,6,1,3,2]   TempCol3=[8,9,6,1,3,2,5,4,7]
					        */
				    }
			    }
			    Cols.Add(TempCol1);
			    Cols.Add(TempCol2);
			    Cols.Add(TempCol3);
			    //System.out.println("---------------------");
		    }
        }



    }
}
