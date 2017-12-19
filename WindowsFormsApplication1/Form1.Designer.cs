namespace WindowsFormsApplication1
{
    partial class Sudoku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sudoku));
            this.Check = new System.Windows.Forms.Panel();
            this.lCheck = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Valid = new System.Windows.Forms.Label();
            this.solve = new System.Windows.Forms.Panel();
            this.lSolve = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Panel();
            this.lClear = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Panel();
            this.lExit = new System.Windows.Forms.Label();
            this.PChoice = new System.Windows.Forms.Panel();
            this.evil = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.extrem = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.BackGroundDrop = new System.Windows.Forms.Panel();
            this.Check.SuspendLayout();
            this.solve.SuspendLayout();
            this.Clear.SuspendLayout();
            this.Exit.SuspendLayout();
            this.PChoice.SuspendLayout();
            this.BackGroundDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Controls.Add(this.lCheck);
            this.Check.Location = new System.Drawing.Point(222, 73);
            this.Check.Margin = new System.Windows.Forms.Padding(2);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(80, 45);
            this.Check.TabIndex = 8;
            // 
            // lCheck
            // 
            this.lCheck.AutoSize = true;
            this.lCheck.Location = new System.Drawing.Point(23, 15);
            this.lCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCheck.Name = "lCheck";
            this.lCheck.Size = new System.Drawing.Size(38, 13);
            this.lCheck.TabIndex = 6;
            this.lCheck.Text = "Check";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(131, 295);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 188);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Valid
            // 
            this.Valid.AutoSize = true;
            this.Valid.Location = new System.Drawing.Point(121, 156);
            this.Valid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(0, 13);
            this.Valid.TabIndex = 9;
            // 
            // solve
            // 
            this.solve.Controls.Add(this.lSolve);
            this.solve.Location = new System.Drawing.Point(134, 73);
            this.solve.Margin = new System.Windows.Forms.Padding(2);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(80, 45);
            this.solve.TabIndex = 9;
            // 
            // lSolve
            // 
            this.lSolve.AutoSize = true;
            this.lSolve.Location = new System.Drawing.Point(22, 15);
            this.lSolve.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSolve.Name = "lSolve";
            this.lSolve.Size = new System.Drawing.Size(34, 13);
            this.lSolve.TabIndex = 6;
            this.lSolve.Text = "Solve";
            this.lSolve.Click += new System.EventHandler(this.solve_Click);
            // 
            // Clear
            // 
            this.Clear.Controls.Add(this.lClear);
            this.Clear.Location = new System.Drawing.Point(310, 73);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 45);
            this.Clear.TabIndex = 10;
            // 
            // lClear
            // 
            this.lClear.AutoSize = true;
            this.lClear.Location = new System.Drawing.Point(26, 15);
            this.lClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lClear.Name = "lClear";
            this.lClear.Size = new System.Drawing.Size(31, 13);
            this.lClear.TabIndex = 6;
            this.lClear.Text = "Clear";
            // 
            // Exit
            // 
            this.Exit.Controls.Add(this.lExit);
            this.Exit.Location = new System.Drawing.Point(399, 73);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 45);
            this.Exit.TabIndex = 11;
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.Location = new System.Drawing.Point(28, 15);
            this.lExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(24, 13);
            this.lExit.TabIndex = 6;
            this.lExit.Text = "Exit";
            // 
            // PChoice
            // 
            this.PChoice.BackColor = System.Drawing.Color.Transparent;
            this.PChoice.Controls.Add(this.evil);
            this.PChoice.Controls.Add(this.hard);
            this.PChoice.Controls.Add(this.medium);
            this.PChoice.Controls.Add(this.easy);
            this.PChoice.Controls.Add(this.extrem);
            this.PChoice.Location = new System.Drawing.Point(3, 0);
            this.PChoice.Name = "PChoice";
            this.PChoice.Size = new System.Drawing.Size(113, 45);
            this.PChoice.TabIndex = 13;
            // 
            // evil
            // 
            this.evil.Location = new System.Drawing.Point(0, 206);
            this.evil.Name = "evil";
            this.evil.Size = new System.Drawing.Size(113, 41);
            this.evil.TabIndex = 4;
            this.evil.Text = "Evil";
            this.evil.UseVisualStyleBackColor = true;
            this.evil.Click += new System.EventHandler(this.evil_Click);
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(0, 154);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(113, 45);
            this.hard.TabIndex = 3;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(0, 104);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(113, 45);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.button8_Click);
            // 
            // easy
            // 
            this.easy.Location = new System.Drawing.Point(0, 51);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(113, 45);
            this.easy.TabIndex = 1;
            this.easy.Text = "Easy";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // extrem
            // 
            this.extrem.Location = new System.Drawing.Point(-3, 0);
            this.extrem.Name = "extrem";
            this.extrem.Size = new System.Drawing.Size(116, 45);
            this.extrem.TabIndex = 0;
            this.extrem.Text = "Extrem Easy";
            this.extrem.UseVisualStyleBackColor = true;
            this.extrem.Click += new System.EventHandler(this.extrem_Click_1);
            this.extrem.MouseHover += new System.EventHandler(this.extrem_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // BackGroundDrop
            // 
            this.BackGroundDrop.BackColor = System.Drawing.Color.Transparent;
            this.BackGroundDrop.Controls.Add(this.PChoice);
            this.BackGroundDrop.Location = new System.Drawing.Point(12, 73);
            this.BackGroundDrop.Name = "BackGroundDrop";
            this.BackGroundDrop.Size = new System.Drawing.Size(117, 258);
            this.BackGroundDrop.TabIndex = 14;
            // 
            // Sudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 506);
            this.Controls.Add(this.BackGroundDrop);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Check);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Sudoku";
            this.Text = "Sudoku";
            this.Check.ResumeLayout(false);
            this.Check.PerformLayout();
            this.solve.ResumeLayout(false);
            this.solve.PerformLayout();
            this.Clear.ResumeLayout(false);
            this.Clear.PerformLayout();
            this.Exit.ResumeLayout(false);
            this.Exit.PerformLayout();
            this.PChoice.ResumeLayout(false);
            this.BackGroundDrop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Check;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Valid;
        private System.Windows.Forms.Panel solve;
        private System.Windows.Forms.Panel Clear;
        private System.Windows.Forms.Panel Exit;
        private System.Windows.Forms.Label lCheck;
        private System.Windows.Forms.Label lSolve;
        private System.Windows.Forms.Label lClear;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Panel PChoice;
        private System.Windows.Forms.Button evil;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button extrem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel BackGroundDrop;
    }
}
