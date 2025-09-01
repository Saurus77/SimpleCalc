namespace SimpleCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Parentheses_Panel = new Panel();
            BackSpace_Btn = new Button();
            Right_Parentheses_Btn = new Button();
            Left_Parentheses_Btn = new Button();
            HistoryDataGrid = new DataGridView();
            BasicOperationsPanel = new Panel();
            Result_Key = new Button();
            Add_Key = new Button();
            Subtract_Key = new Button();
            Multiply_Key = new Button();
            Divide_Key = new Button();
            NumberKeysPanel = new Panel();
            NumberKey_Comma = new Button();
            Clear_Key = new Button();
            NumberKey_0 = new Button();
            NumberKey_3 = new Button();
            NumberKey_2 = new Button();
            NumberKey_1 = new Button();
            NumberKey_6 = new Button();
            NumberKey_5 = new Button();
            NumberKey_4 = new Button();
            NumberKey_9 = new Button();
            NumberKey_8 = new Button();
            NumberKey_7 = new Button();
            MainCalculatorPanel = new Panel();
            DisplayPanel = new Panel();
            ResultDisplay_Label = new Label();
            ExpressionDisplay_Label = new Label();
            menuStrip1 = new MenuStrip();
            ToolMenu_Strip = new ToolStripMenuItem();
            Menu_Strip_History = new ToolStripMenuItem();
            Parentheses_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).BeginInit();
            BasicOperationsPanel.SuspendLayout();
            NumberKeysPanel.SuspendLayout();
            MainCalculatorPanel.SuspendLayout();
            DisplayPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Parentheses_Panel
            // 
            Parentheses_Panel.Controls.Add(BackSpace_Btn);
            Parentheses_Panel.Controls.Add(Right_Parentheses_Btn);
            Parentheses_Panel.Controls.Add(Left_Parentheses_Btn);
            Parentheses_Panel.Location = new Point(3, 87);
            Parentheses_Panel.Name = "Parentheses_Panel";
            Parentheses_Panel.Size = new Size(171, 57);
            Parentheses_Panel.TabIndex = 3;
            // 
            // BackSpace_Btn
            // 
            BackSpace_Btn.Font = new Font("Segoe UI", 15F);
            BackSpace_Btn.Location = new Point(115, 4);
            BackSpace_Btn.Name = "BackSpace_Btn";
            BackSpace_Btn.Size = new Size(50, 50);
            BackSpace_Btn.TabIndex = 3;
            BackSpace_Btn.Text = "<=";
            BackSpace_Btn.UseVisualStyleBackColor = true;
            BackSpace_Btn.Click += BackSpace_Btn_Click;
            // 
            // Right_Parentheses_Btn
            // 
            Right_Parentheses_Btn.Font = new Font("Segoe UI", 20F);
            Right_Parentheses_Btn.Location = new Point(59, 4);
            Right_Parentheses_Btn.Name = "Right_Parentheses_Btn";
            Right_Parentheses_Btn.Size = new Size(50, 50);
            Right_Parentheses_Btn.TabIndex = 2;
            Right_Parentheses_Btn.Text = ")";
            Right_Parentheses_Btn.UseVisualStyleBackColor = true;
            Right_Parentheses_Btn.Click += UniversalKey_Click;
            // 
            // Left_Parentheses_Btn
            // 
            Left_Parentheses_Btn.Font = new Font("Segoe UI", 20F);
            Left_Parentheses_Btn.Location = new Point(3, 4);
            Left_Parentheses_Btn.Name = "Left_Parentheses_Btn";
            Left_Parentheses_Btn.Size = new Size(50, 50);
            Left_Parentheses_Btn.TabIndex = 1;
            Left_Parentheses_Btn.Text = "(";
            Left_Parentheses_Btn.UseVisualStyleBackColor = true;
            Left_Parentheses_Btn.Click += UniversalKey_Click;
            // 
            // HistoryDataGrid
            // 
            HistoryDataGrid.AllowUserToAddRows = false;
            HistoryDataGrid.AllowUserToDeleteRows = false;
            HistoryDataGrid.AllowUserToResizeColumns = false;
            HistoryDataGrid.AllowUserToResizeRows = false;
            HistoryDataGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            HistoryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoryDataGrid.Location = new Point(0, 222);
            HistoryDataGrid.Name = "HistoryDataGrid";
            HistoryDataGrid.ReadOnly = true;
            HistoryDataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            HistoryDataGrid.Size = new Size(369, 375);
            HistoryDataGrid.TabIndex = 2;
            HistoryDataGrid.Visible = false;
            HistoryDataGrid.CellFormatting += HistoryDataGridCellFormatting;
            // 
            // BasicOperationsPanel
            // 
            BasicOperationsPanel.Controls.Add(Result_Key);
            BasicOperationsPanel.Controls.Add(Add_Key);
            BasicOperationsPanel.Controls.Add(Subtract_Key);
            BasicOperationsPanel.Controls.Add(Multiply_Key);
            BasicOperationsPanel.Controls.Add(Divide_Key);
            BasicOperationsPanel.Location = new Point(174, 87);
            BasicOperationsPanel.Name = "BasicOperationsPanel";
            BasicOperationsPanel.Size = new Size(57, 282);
            BasicOperationsPanel.TabIndex = 2;
            // 
            // Result_Key
            // 
            Result_Key.Font = new Font("Segoe UI", 15F);
            Result_Key.Location = new Point(3, 227);
            Result_Key.Name = "Result_Key";
            Result_Key.Size = new Size(50, 50);
            Result_Key.TabIndex = 4;
            Result_Key.Text = "=";
            Result_Key.UseVisualStyleBackColor = true;
            Result_Key.Click += Result_Key_Click;
            // 
            // Add_Key
            // 
            Add_Key.Location = new Point(3, 171);
            Add_Key.Name = "Add_Key";
            Add_Key.Size = new Size(50, 50);
            Add_Key.TabIndex = 3;
            Add_Key.Text = "+";
            Add_Key.UseVisualStyleBackColor = true;
            Add_Key.Click += UniversalKey_Click;
            // 
            // Subtract_Key
            // 
            Subtract_Key.Font = new Font("Segoe UI", 15F);
            Subtract_Key.Location = new Point(3, 115);
            Subtract_Key.Name = "Subtract_Key";
            Subtract_Key.Size = new Size(50, 50);
            Subtract_Key.TabIndex = 2;
            Subtract_Key.Text = "-";
            Subtract_Key.UseVisualStyleBackColor = true;
            Subtract_Key.Click += UniversalKey_Click;
            // 
            // Multiply_Key
            // 
            Multiply_Key.Font = new Font("Segoe UI", 12F);
            Multiply_Key.Location = new Point(3, 59);
            Multiply_Key.Name = "Multiply_Key";
            Multiply_Key.Size = new Size(50, 50);
            Multiply_Key.TabIndex = 1;
            Multiply_Key.Text = "*";
            Multiply_Key.UseVisualStyleBackColor = true;
            Multiply_Key.Click += UniversalKey_Click;
            // 
            // Divide_Key
            // 
            Divide_Key.Font = new Font("Segoe UI", 12F);
            Divide_Key.Location = new Point(3, 4);
            Divide_Key.Name = "Divide_Key";
            Divide_Key.Size = new Size(50, 50);
            Divide_Key.TabIndex = 0;
            Divide_Key.Text = "/";
            Divide_Key.UseVisualStyleBackColor = true;
            Divide_Key.Click += UniversalKey_Click;
            // 
            // NumberKeysPanel
            // 
            NumberKeysPanel.Controls.Add(NumberKey_Comma);
            NumberKeysPanel.Controls.Add(Clear_Key);
            NumberKeysPanel.Controls.Add(NumberKey_0);
            NumberKeysPanel.Controls.Add(NumberKey_3);
            NumberKeysPanel.Controls.Add(NumberKey_2);
            NumberKeysPanel.Controls.Add(NumberKey_1);
            NumberKeysPanel.Controls.Add(NumberKey_6);
            NumberKeysPanel.Controls.Add(NumberKey_5);
            NumberKeysPanel.Controls.Add(NumberKey_4);
            NumberKeysPanel.Controls.Add(NumberKey_9);
            NumberKeysPanel.Controls.Add(NumberKey_8);
            NumberKeysPanel.Controls.Add(NumberKey_7);
            NumberKeysPanel.Location = new Point(3, 143);
            NumberKeysPanel.Name = "NumberKeysPanel";
            NumberKeysPanel.Size = new Size(171, 226);
            NumberKeysPanel.TabIndex = 0;
            // 
            // NumberKey_Comma
            // 
            NumberKey_Comma.Font = new Font("Segoe UI", 20F);
            NumberKey_Comma.Location = new Point(115, 171);
            NumberKey_Comma.Name = "NumberKey_Comma";
            NumberKey_Comma.Size = new Size(50, 50);
            NumberKey_Comma.TabIndex = 11;
            NumberKey_Comma.Text = ",";
            NumberKey_Comma.UseVisualStyleBackColor = true;
            NumberKey_Comma.Click += UniversalKey_Click;
            // 
            // Clear_Key
            // 
            Clear_Key.Font = new Font("Segoe UI", 15F);
            Clear_Key.Location = new Point(3, 171);
            Clear_Key.Name = "Clear_Key";
            Clear_Key.Size = new Size(50, 50);
            Clear_Key.TabIndex = 10;
            Clear_Key.Text = "C";
            Clear_Key.UseVisualStyleBackColor = true;
            Clear_Key.Click += Clear_Key_Click;
            // 
            // NumberKey_0
            // 
            NumberKey_0.Font = new Font("Segoe UI", 20F);
            NumberKey_0.Location = new Point(59, 171);
            NumberKey_0.Name = "NumberKey_0";
            NumberKey_0.Size = new Size(50, 50);
            NumberKey_0.TabIndex = 9;
            NumberKey_0.Text = "0";
            NumberKey_0.UseVisualStyleBackColor = true;
            NumberKey_0.Click += UniversalKey_Click;
            // 
            // NumberKey_3
            // 
            NumberKey_3.Font = new Font("Segoe UI", 20F);
            NumberKey_3.Location = new Point(115, 115);
            NumberKey_3.Name = "NumberKey_3";
            NumberKey_3.Size = new Size(50, 50);
            NumberKey_3.TabIndex = 8;
            NumberKey_3.Text = "3";
            NumberKey_3.UseVisualStyleBackColor = true;
            NumberKey_3.Click += UniversalKey_Click;
            // 
            // NumberKey_2
            // 
            NumberKey_2.Font = new Font("Segoe UI", 20F);
            NumberKey_2.Location = new Point(59, 115);
            NumberKey_2.Name = "NumberKey_2";
            NumberKey_2.Size = new Size(50, 50);
            NumberKey_2.TabIndex = 7;
            NumberKey_2.Text = "2";
            NumberKey_2.UseVisualStyleBackColor = true;
            NumberKey_2.Click += UniversalKey_Click;
            // 
            // NumberKey_1
            // 
            NumberKey_1.Font = new Font("Segoe UI", 20F);
            NumberKey_1.Location = new Point(3, 115);
            NumberKey_1.Name = "NumberKey_1";
            NumberKey_1.Size = new Size(50, 50);
            NumberKey_1.TabIndex = 6;
            NumberKey_1.Text = "1";
            NumberKey_1.UseVisualStyleBackColor = true;
            NumberKey_1.Click += UniversalKey_Click;
            // 
            // NumberKey_6
            // 
            NumberKey_6.Font = new Font("Segoe UI", 20F);
            NumberKey_6.Location = new Point(115, 59);
            NumberKey_6.Name = "NumberKey_6";
            NumberKey_6.Size = new Size(50, 50);
            NumberKey_6.TabIndex = 5;
            NumberKey_6.Text = "6";
            NumberKey_6.UseVisualStyleBackColor = true;
            NumberKey_6.Click += UniversalKey_Click;
            // 
            // NumberKey_5
            // 
            NumberKey_5.Font = new Font("Segoe UI", 20F);
            NumberKey_5.Location = new Point(59, 59);
            NumberKey_5.Name = "NumberKey_5";
            NumberKey_5.Size = new Size(50, 50);
            NumberKey_5.TabIndex = 4;
            NumberKey_5.Text = "5";
            NumberKey_5.UseVisualStyleBackColor = true;
            NumberKey_5.Click += UniversalKey_Click;
            // 
            // NumberKey_4
            // 
            NumberKey_4.Font = new Font("Segoe UI", 20F);
            NumberKey_4.Location = new Point(3, 59);
            NumberKey_4.Name = "NumberKey_4";
            NumberKey_4.Size = new Size(50, 50);
            NumberKey_4.TabIndex = 3;
            NumberKey_4.Text = "4";
            NumberKey_4.UseVisualStyleBackColor = true;
            NumberKey_4.Click += UniversalKey_Click;
            // 
            // NumberKey_9
            // 
            NumberKey_9.Font = new Font("Segoe UI", 20F);
            NumberKey_9.Location = new Point(115, 3);
            NumberKey_9.Name = "NumberKey_9";
            NumberKey_9.Size = new Size(50, 50);
            NumberKey_9.TabIndex = 2;
            NumberKey_9.Text = "9";
            NumberKey_9.UseVisualStyleBackColor = true;
            NumberKey_9.Click += UniversalKey_Click;
            // 
            // NumberKey_8
            // 
            NumberKey_8.Font = new Font("Segoe UI", 20F);
            NumberKey_8.Location = new Point(59, 3);
            NumberKey_8.Name = "NumberKey_8";
            NumberKey_8.Size = new Size(50, 50);
            NumberKey_8.TabIndex = 1;
            NumberKey_8.Text = "8";
            NumberKey_8.UseVisualStyleBackColor = true;
            NumberKey_8.Click += UniversalKey_Click;
            // 
            // NumberKey_7
            // 
            NumberKey_7.Font = new Font("Segoe UI", 20F);
            NumberKey_7.Location = new Point(3, 3);
            NumberKey_7.Name = "NumberKey_7";
            NumberKey_7.Size = new Size(50, 50);
            NumberKey_7.TabIndex = 0;
            NumberKey_7.Text = "7";
            NumberKey_7.UseVisualStyleBackColor = true;
            NumberKey_7.Click += UniversalKey_Click;
            // 
            // MainCalculatorPanel
            // 
            MainCalculatorPanel.Controls.Add(Parentheses_Panel);
            MainCalculatorPanel.Controls.Add(BasicOperationsPanel);
            MainCalculatorPanel.Controls.Add(NumberKeysPanel);
            MainCalculatorPanel.Location = new Point(0, 222);
            MainCalculatorPanel.Name = "MainCalculatorPanel";
            MainCalculatorPanel.Size = new Size(369, 375);
            MainCalculatorPanel.TabIndex = 0;
            // 
            // DisplayPanel
            // 
            DisplayPanel.Controls.Add(ResultDisplay_Label);
            DisplayPanel.Controls.Add(ExpressionDisplay_Label);
            DisplayPanel.Location = new Point(0, 43);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(369, 90);
            DisplayPanel.TabIndex = 1;
            // 
            // ResultDisplay_Label
            // 
            ResultDisplay_Label.BackColor = Color.Black;
            ResultDisplay_Label.Font = new Font("Segoe UI", 25F);
            ResultDisplay_Label.ForeColor = Color.White;
            ResultDisplay_Label.Location = new Point(3, 40);
            ResultDisplay_Label.Name = "ResultDisplay_Label";
            ResultDisplay_Label.Size = new Size(363, 50);
            ResultDisplay_Label.TabIndex = 1;
            ResultDisplay_Label.Text = "0";
            ResultDisplay_Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExpressionDisplay_Label
            // 
            ExpressionDisplay_Label.BackColor = Color.Black;
            ExpressionDisplay_Label.Font = new Font("Segoe UI", 13F);
            ExpressionDisplay_Label.ForeColor = Color.White;
            ExpressionDisplay_Label.Location = new Point(3, 0);
            ExpressionDisplay_Label.Name = "ExpressionDisplay_Label";
            ExpressionDisplay_Label.Size = new Size(363, 40);
            ExpressionDisplay_Label.TabIndex = 0;
            ExpressionDisplay_Label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolMenu_Strip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(370, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolMenu_Strip
            // 
            ToolMenu_Strip.DropDownItems.AddRange(new ToolStripItem[] { Menu_Strip_History });
            ToolMenu_Strip.Name = "ToolMenu_Strip";
            ToolMenu_Strip.Size = new Size(50, 20);
            ToolMenu_Strip.Text = "Menu";
            // 
            // Menu_Strip_History
            // 
            Menu_Strip_History.Name = "Menu_Strip_History";
            Menu_Strip_History.Size = new Size(112, 22);
            Menu_Strip_History.Text = "History";
            Menu_Strip_History.Click += Menu_Strip_History_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(370, 597);
            Controls.Add(HistoryDataGrid);
            Controls.Add(MainCalculatorPanel);
            Controls.Add(menuStrip1);
            Controls.Add(DisplayPanel);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load;
            KeyDown += UniversalKeyDown_Click;
            Parentheses_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HistoryDataGrid).EndInit();
            BasicOperationsPanel.ResumeLayout(false);
            NumberKeysPanel.ResumeLayout(false);
            MainCalculatorPanel.ResumeLayout(false);
            DisplayPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private Panel NumberKeysPanel;
        private Button NumberKey_1;
        private Button NumberKey_2;
        private Button NumberKey_3;
        private Button NumberKey_4;
        private Button NumberKey_5;
        private Button NumberKey_6;
        private Button NumberKey_7;
        private Button NumberKey_8;
        private Button NumberKey_9;
        private Button NumberKey_0;
        private Button NumberKey_Comma;
        private Button Clear_Key;
        private Panel DisplayPanel;
        private Panel BasicOperationsPanel;
        private Button Divide_Key;
        private Button Add_Key;
        private Button Subtract_Key;
        private Button Multiply_Key;
        private Button Result_Key;
        private Label ExpressionDisplay_Label;
        private Label ResultDisplay_Label;
        private ToolStripMenuItem ToolMenu_Strip;
        private ToolStripMenuItem Menu_Strip_History;
        private Panel Parentheses_Panel;
        private Button BackSpace_Btn;
        private Button Right_Parentheses_Btn;
        private Button Left_Parentheses_Btn;
        private Panel MainCalculatorPanel;
        private DataGridView HistoryDataGrid;
    }
}
