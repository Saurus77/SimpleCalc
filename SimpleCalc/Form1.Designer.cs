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
            MainCalculatorPanel = new Panel();
            DisplayPanel = new Panel();
            MainDisplay = new TextBox();
            NumberKeysPanel = new Panel();
            NumberKey_Comma = new Button();
            NumberKey_PosNeg = new Button();
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
            menuStrip1 = new MenuStrip();
            MainCalculatorPanel.SuspendLayout();
            DisplayPanel.SuspendLayout();
            NumberKeysPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainCalculatorPanel
            // 
            MainCalculatorPanel.Controls.Add(DisplayPanel);
            MainCalculatorPanel.Controls.Add(NumberKeysPanel);
            MainCalculatorPanel.Dock = DockStyle.Bottom;
            MainCalculatorPanel.Location = new Point(0, 37);
            MainCalculatorPanel.Name = "MainCalculatorPanel";
            MainCalculatorPanel.Size = new Size(369, 430);
            MainCalculatorPanel.TabIndex = 0;
            MainCalculatorPanel.Paint += MainCalculatorPanel_Paint;
            // 
            // DisplayPanel
            // 
            DisplayPanel.Controls.Add(MainDisplay);
            DisplayPanel.Location = new Point(3, 3);
            DisplayPanel.Name = "DisplayPanel";
            DisplayPanel.Size = new Size(363, 91);
            DisplayPanel.TabIndex = 1;
            // 
            // MainDisplay
            // 
            MainDisplay.Location = new Point(3, 3);
            MainDisplay.Multiline = true;
            MainDisplay.Name = "MainDisplay";
            MainDisplay.ReadOnly = true;
            MainDisplay.Size = new Size(357, 83);
            MainDisplay.TabIndex = 0;
            // 
            // NumberKeysPanel
            // 
            NumberKeysPanel.Controls.Add(NumberKey_Comma);
            NumberKeysPanel.Controls.Add(NumberKey_PosNeg);
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
            NumberKeysPanel.Location = new Point(12, 192);
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
            NumberKey_Comma.Click += UniversalNumberKey_Click;

            // 
            // NumberKey_PosNeg
            // 
            NumberKey_PosNeg.Font = new Font("Segoe UI", 15F);
            NumberKey_PosNeg.Location = new Point(3, 171);
            NumberKey_PosNeg.Name = "NumberKey_PosNeg";
            NumberKey_PosNeg.Size = new Size(50, 50);
            NumberKey_PosNeg.TabIndex = 10;
            NumberKey_PosNeg.Text = "+/-";
            NumberKey_PosNeg.UseVisualStyleBackColor = true;
     
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
            NumberKey_0.Click += UniversalNumberKey_Click;

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
            NumberKey_3.Click += UniversalNumberKey_Click;

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
            NumberKey_2.Click += UniversalNumberKey_Click;

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
            NumberKey_1.Click += UniversalNumberKey_Click;

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
            NumberKey_6.Click += UniversalNumberKey_Click;

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
            NumberKey_5.Click += UniversalNumberKey_Click;

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
            NumberKey_4.Click += UniversalNumberKey_Click;

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
            NumberKey_9.Click += UniversalNumberKey_Click;

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
            NumberKey_8.Click += UniversalNumberKey_Click;

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
            NumberKey_7.Click += UniversalNumberKey_Click;

            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(369, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            ClientSize = new Size(369, 467);
            Controls.Add(MainCalculatorPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load_1;
            MainCalculatorPanel.ResumeLayout(false);
            DisplayPanel.ResumeLayout(false);
            DisplayPanel.PerformLayout();
            NumberKeysPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Panel MainCalculatorPanel;
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
        private Button NumberKey_PosNeg;
        private Panel DisplayPanel;
        private TextBox MainDisplay;
    }
}
