using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Sudoku : Form
    {
        public static TextBox[,] text = new TextBox[9, 9];
        //All Levels
        enum Levels
        {
            ExtremEasy = 1,
            Easy = 2,
            Meduim = 3,
            Hard = 4,
            Evil = 5

        }
        public Sudoku()
        {
            InitializeComponent();
            myGenerate();    
        }
        int t1 = 45;
        int diff = 1;

        private void buttons()
        {
            solve.BackColor = Color.FromArgb(96, 51, 5);
            Check.BackColor = Color.FromArgb(96, 51, 5);
            Clear.BackColor = Color.FromArgb(96, 51, 5);
            Exit.BackColor = Color.FromArgb(96, 51, 5);
            OpenGame.BackColor = Color.FromArgb(96, 51, 5);
            solve.Click += solve_Click;
            Check.Click += check_Click;
            Clear.Click += cl_Click;
            Exit.Click += e_Click;
            OpenGame.Click += OpenGame_Click;
            Exit.MouseHover += Panel_MouseHover;
            Exit.MouseLeave += Panel_MouseLeave;
            Check.MouseHover += Panel_MouseHover;
            Check.MouseLeave += Panel_MouseLeave;
            Clear.MouseHover += Panel_MouseHover;
            Clear.MouseLeave += Panel_MouseLeave;
            solve.MouseHover += Panel_MouseHover;
            solve.MouseLeave += Panel_MouseLeave;
            OpenGame.MouseHover += Panel_MouseHover;
            OpenGame.MouseLeave += Panel_MouseLeave;

        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {
            Panel b = (Panel)sender;

            b.BackColor = Color.FromArgb(255, 255, 255);
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel b = (Panel)sender;
            b.BackColor = Color.FromArgb(96, 51, 5);
        }
        private void dropDown()
        {
            extrem.BackColor = Color.FromArgb(96, 51, 5);
            easy.BackColor = Color.FromArgb(96, 51, 5);
            medium.BackColor = Color.FromArgb(96, 51, 5);
            hard.BackColor = Color.FromArgb(96, 51, 5);
            evil.BackColor = Color.FromArgb(96, 51, 5);
            extrem.MouseHover += extrem_MouseHover;
            BackGroundDrop.MouseLeave += PChoice_MouseLeave;
        }


        //init el donia Kolha 
        private void myGenerate()
        {
            Valid.BackColor = Color.FromArgb(96, 51, 5);
            buttons();
            dropDown();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.tableLayoutPanel1.BackColor = Color.Black;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox t1 = new TextBox();
                    t1.TextAlign = HorizontalAlignment.Center;
                    t1.Size = new Size(80, 80);
                    t1.KeyPress += textBox1_KeyPress;
                    if (j == 2 || j == 5)
                    {
                        t1.Margin = new Padding(0, 0, 5, 0);
                    }
                    else
                    {
                        t1.Margin = new Padding(0, 0, 0, 0);
                    }
                    t1.BackColor = Color.FromArgb(96, 51, 5);
                    t1.ForeColor = Color.White;
                    this.tableLayoutPanel1.Controls.Add(t1, j, i);
                    text[i, j] = t1;
                }
            }
        }
        
        private void e_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlayGame(Levels diff)
        {
            MakeSudokuSeq makeGame = new MakeSudokuSeq();
            initGame(makeGame.diff_gen((int)diff));
        }
        

        //init Game To disable TextBox 
        private void  initGame(int [,] suduku){
            ClearGame();//First Clear The Gui
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {

                    if (suduku[Row, Column] != 0)
                    {
                        text[Row, Column].Text = suduku[Row, Column].ToString();
                        text[Row, Column].Enabled = false;
                        text[Row, Column].BackColor = Color.BurlyWood;

                    }
                    else
                    {
                        text[Row, Column].Text = "";

                    }


                }
            }
        }
        private void cl_Click(object sender, EventArgs e)
        {
            ClearGame();
        }

  
        
        private void extrem_MouseHover(object sender, EventArgs e)
        {
           // PChoice.Size = new Size(this.PChoice.Size.Width, t1);
            timer2.Stop();
            timer1.Start();
        }

        private void PChoice_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (t1 > 250)
            {
                timer1.Stop();
            }
            else
            {
                PChoice.Size = new Size(PChoice.Size.Width, t1);
                t1 += 10;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {

            if (t1 < 45)
            {
                timer2.Stop();
            }
            else
            {
                PChoice.Size = new Size(PChoice.Size.Width, t1);
                t1 -= 10;
            }
        }

        
        private void solve_Click(object sender, EventArgs e)
        {
            SolveSudokuSeq solveGame = new SolveSudokuSeq();
            var watch = System.Diagnostics.Stopwatch.StartNew(); // To measure Time 
            ConvertTextBoxToInt(false, null);// It Will Initialize Sudoku Matrix 
            bool is_Solved = solveGame.SolveSudoku(0, 0);//Solve Game begin From start Of Matrix 
            ConvertTextBoxToInt(true, OperationsSeq.sudoku); // Convert The Solved Sudoku
            watch.Stop();

            // Show Message
            Valid.Text = is_Solved ? "Game Solved :)  in " + watch.ElapsedMilliseconds + " ms" : "can not Solve The Game ;("; ;
        }

        /*
         * Radwan
         * It Will Convert TextBox List To int list And vice versa
         * if Reverse Is True It Will Convert From Int list TO TextBox List and Should pass The suduko Variable With it
         * else it will convert From TextBox List To int list 
         */
        public void ConvertTextBoxToInt(bool Reverse, int[,] suduku)
        {
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {

                    if (Reverse)
                        text[Row, Column].Text = suduku[Row, Column] == 0 ? "" : suduku[Row, Column].ToString();
                    else
                        OperationsSeq.sudoku[Row, Column] = text[Row, Column].Text.ToString() == "" ? 0 : int.Parse(text[Row, Column].Text.ToString()); // Initialize Sudoku Matrix 

                }
            }

        }

        public void ClearGame()
        {
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {
                    text[Row, Column].Text = "";
                    text[Row, Column].BackColor = Color.FromArgb(96, 51, 5);
                    text[Row, Column].ForeColor = Color.White;
                    text[Row, Column].Enabled = true;
                }
            }


        }

        private void check_Click(object sender, EventArgs e)
        {
            ConvertTextBoxToInt(false, null);// It Will Initialize Sudoku Matrix
            bool CantSolve = false;
            for (int Row = 0; Row < 9; Row++)
            {
                for (int Column = 0; Column < 9; Column++)
                {

                    if (!OperationsSeq.Is_Save(new Point(Row, Column), OperationsSeq.sudoku[Row, Column]))
                    {
                        CantSolve = true;
                        Valid.Text = "False Sudoku";
                        break;
                    }

                }
                if (CantSolve)
                {
                    break;
                }
            }
            if (!CantSolve)
            {
                Valid.Text = "True Sudoku";
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PlayGame(Levels.Meduim);
        }

        private void extrem_Click_1(object sender, EventArgs e)
        {
            PlayGame(Levels.ExtremEasy);

        }

        private void easy_Click(object sender, EventArgs e)
        {
            PlayGame(Levels.Easy);
        }

        private void hard_Click(object sender, EventArgs e)
        {
            PlayGame(Levels.Hard);
        }

        private void evil_Click(object sender, EventArgs e)
        {
            PlayGame(Levels.Evil);
        }

        private void OpenGame_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Your Sudoku File Game";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            /*Your Function Should called Here :) */
                            string input = System.IO.File.ReadAllText(openFileDialog1.FileName);
                            get_sudoko(input);
                            initGame(OperationsSeq.sudoku);
                            /*Nermeen Section*/
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }



        //Validation on each textBox 
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar)) //Check if Text Box have number  Betwwen  1 and 9 Or not 
            {
                TextBox text = (TextBox)sender;
                String value = "";
                value = text.Text.ToString() + e.KeyChar;
                int numberOfText = int.Parse(value);

                if (numberOfText > 9 || numberOfText < 1)
                {
                    e.Handled = true;
                }
            }
           
        }

        //Read Input From Text File 
        private void get_sudoko(string input)
        {
            int[,] puzzle = new int[9, 9];
            char[] delimiterChars = { ' ', '\n', '\t' };
            string[] lines = input.Split(delimiterChars);
            int[] map_to_int = new int[lines.Length];
            int number;
            for (int a = 0; a < lines.Length; a++)
            {
                if (!string.IsNullOrWhiteSpace(lines[a]))
                {
                    bool result = Int32.TryParse(lines[a], out number);

                    if (result)
                    {
                        map_to_int[a] = number;
                    }
                    else
                    {
                        Console.WriteLine("Failure in conversion");
                    }
                }
            }
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    OperationsSeq.sudoku[x, y] = map_to_int[x * 9 + y];
                }

            }
        }



        public System.IO.Stream myStream { get; set; }
    }
}