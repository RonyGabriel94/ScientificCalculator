namespace ScientificCalculator
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
            TxtResult = new Label();
            BackSpaceButton = new Button();
            ClearEntryButton = new Button();
            ClearButton = new Button();
            PlusMinusButton = new Button();
            Button1 = new Button();
            Button2 = new Button();
            Button3 = new Button();
            PlusButton = new Button();
            Button4 = new Button();
            Button7 = new Button();
            Button5 = new Button();
            Button8 = new Button();
            Button6 = new Button();
            Button9 = new Button();
            SubtractionButton = new Button();
            MultipleButton = new Button();
            PointButton = new Button();
            Button0 = new Button();
            EqualButton = new Button();
            DivitionButton = new Button();
            Menu = new MenuStrip();
            modeToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            PiButton = new Button();
            LogButton = new Button();
            SquareRootButton = new Button();
            Exponencial2Button = new Button();
            SineHButton = new Button();
            SineButton = new Button();
            DecimalButton = new Button();
            Exponential3Button = new Button();
            CosineHButton = new Button();
            TangentHButton = new Button();
            CosineButton = new Button();
            TangentButton = new Button();
            BinaryButton = new Button();
            HexadecimalButton = new Button();
            OneOverXButton = new Button();
            InXButton = new Button();
            ExponentialButton = new Button();
            ModulusButton = new Button();
            OctalButton = new Button();
            PercentageButton = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // TxtResult
            // 
            TxtResult.BackColor = SystemColors.Control;
            TxtResult.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResult.Location = new Point(24, 31);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(254, 55);
            TxtResult.TabIndex = 0;
            TxtResult.Text = "0";
            TxtResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BackSpaceButton
            // 
            BackSpaceButton.BackColor = SystemColors.ControlText;
            BackSpaceButton.Font = new Font("Wingdings 3", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 2);
            BackSpaceButton.ForeColor = SystemColors.ControlLightLight;
            BackSpaceButton.Location = new Point(24, 93);
            BackSpaceButton.Name = "BackSpaceButton";
            BackSpaceButton.Size = new Size(59, 53);
            BackSpaceButton.TabIndex = 1;
            BackSpaceButton.Text = "";
            BackSpaceButton.UseVisualStyleBackColor = false;
            BackSpaceButton.Click += BackSpaceButton_Click;
            // 
            // ClearEntryButton
            // 
            ClearEntryButton.BackColor = SystemColors.ControlText;
            ClearEntryButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearEntryButton.ForeColor = SystemColors.ControlLightLight;
            ClearEntryButton.Location = new Point(89, 93);
            ClearEntryButton.Name = "ClearEntryButton";
            ClearEntryButton.Size = new Size(59, 53);
            ClearEntryButton.TabIndex = 1;
            ClearEntryButton.Text = "CE";
            ClearEntryButton.UseVisualStyleBackColor = false;
            ClearEntryButton.Click += ClearEntryButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = SystemColors.ControlText;
            ClearButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.ForeColor = SystemColors.ControlLightLight;
            ClearButton.Location = new Point(154, 93);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(59, 53);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // PlusMinusButton
            // 
            PlusMinusButton.BackColor = SystemColors.ControlText;
            PlusMinusButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusMinusButton.ForeColor = SystemColors.ControlLightLight;
            PlusMinusButton.Location = new Point(219, 93);
            PlusMinusButton.Name = "PlusMinusButton";
            PlusMinusButton.Size = new Size(59, 53);
            PlusMinusButton.TabIndex = 1;
            PlusMinusButton.Text = "±";
            PlusMinusButton.UseVisualStyleBackColor = false;
            PlusMinusButton.Click += PlusMinusButton_Click;
            // 
            // Button1
            // 
            Button1.BackColor = SystemColors.ControlText;
            Button1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button1.ForeColor = SystemColors.ControlLightLight;
            Button1.Location = new Point(24, 152);
            Button1.Name = "Button1";
            Button1.Size = new Size(59, 53);
            Button1.TabIndex = 1;
            Button1.Text = "1";
            Button1.UseVisualStyleBackColor = false;
            Button1.Click += EnterNumbers;
            // 
            // Button2
            // 
            Button2.BackColor = SystemColors.ControlText;
            Button2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button2.ForeColor = SystemColors.ControlLightLight;
            Button2.Location = new Point(89, 152);
            Button2.Name = "Button2";
            Button2.Size = new Size(59, 53);
            Button2.TabIndex = 1;
            Button2.Text = "2";
            Button2.UseVisualStyleBackColor = false;
            Button2.Click += EnterNumbers;
            // 
            // Button3
            // 
            Button3.BackColor = SystemColors.ControlText;
            Button3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button3.ForeColor = SystemColors.ControlLightLight;
            Button3.Location = new Point(154, 152);
            Button3.Name = "Button3";
            Button3.Size = new Size(59, 53);
            Button3.TabIndex = 1;
            Button3.Text = "3";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += EnterNumbers;
            // 
            // PlusButton
            // 
            PlusButton.BackColor = SystemColors.ControlText;
            PlusButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlusButton.ForeColor = SystemColors.ControlLightLight;
            PlusButton.Location = new Point(219, 152);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(59, 53);
            PlusButton.TabIndex = 1;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = false;
            PlusButton.Click += OperationsEnter;
            // 
            // Button4
            // 
            Button4.BackColor = SystemColors.ControlText;
            Button4.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button4.ForeColor = SystemColors.ControlLightLight;
            Button4.Location = new Point(24, 211);
            Button4.Name = "Button4";
            Button4.Size = new Size(59, 53);
            Button4.TabIndex = 1;
            Button4.Text = "4";
            Button4.UseVisualStyleBackColor = false;
            Button4.Click += EnterNumbers;
            // 
            // Button7
            // 
            Button7.BackColor = SystemColors.ControlText;
            Button7.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button7.ForeColor = SystemColors.ControlLightLight;
            Button7.Location = new Point(24, 270);
            Button7.Name = "Button7";
            Button7.Size = new Size(59, 53);
            Button7.TabIndex = 1;
            Button7.Text = "7";
            Button7.UseVisualStyleBackColor = false;
            Button7.Click += EnterNumbers;
            // 
            // Button5
            // 
            Button5.BackColor = SystemColors.ControlText;
            Button5.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button5.ForeColor = SystemColors.ControlLightLight;
            Button5.Location = new Point(89, 211);
            Button5.Name = "Button5";
            Button5.Size = new Size(59, 53);
            Button5.TabIndex = 1;
            Button5.Text = "5";
            Button5.UseVisualStyleBackColor = false;
            Button5.Click += EnterNumbers;
            // 
            // Button8
            // 
            Button8.BackColor = SystemColors.ControlText;
            Button8.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button8.ForeColor = SystemColors.ControlLightLight;
            Button8.Location = new Point(89, 270);
            Button8.Name = "Button8";
            Button8.Size = new Size(59, 53);
            Button8.TabIndex = 1;
            Button8.Text = "8";
            Button8.UseVisualStyleBackColor = false;
            Button8.Click += EnterNumbers;
            // 
            // Button6
            // 
            Button6.BackColor = SystemColors.ControlText;
            Button6.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button6.ForeColor = SystemColors.ControlLightLight;
            Button6.Location = new Point(154, 211);
            Button6.Name = "Button6";
            Button6.Size = new Size(59, 53);
            Button6.TabIndex = 1;
            Button6.Text = "6";
            Button6.UseVisualStyleBackColor = false;
            Button6.Click += EnterNumbers;
            // 
            // Button9
            // 
            Button9.BackColor = SystemColors.ControlText;
            Button9.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button9.ForeColor = SystemColors.ControlLightLight;
            Button9.Location = new Point(154, 270);
            Button9.Name = "Button9";
            Button9.Size = new Size(59, 53);
            Button9.TabIndex = 1;
            Button9.Text = "9";
            Button9.UseVisualStyleBackColor = false;
            Button9.Click += EnterNumbers;
            // 
            // SubtractionButton
            // 
            SubtractionButton.BackColor = SystemColors.ControlText;
            SubtractionButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubtractionButton.ForeColor = SystemColors.ControlLightLight;
            SubtractionButton.Location = new Point(219, 211);
            SubtractionButton.Name = "SubtractionButton";
            SubtractionButton.Size = new Size(59, 53);
            SubtractionButton.TabIndex = 1;
            SubtractionButton.Text = "-";
            SubtractionButton.UseVisualStyleBackColor = false;
            SubtractionButton.Click += OperationsEnter;
            // 
            // MultipleButton
            // 
            MultipleButton.BackColor = SystemColors.ControlText;
            MultipleButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MultipleButton.ForeColor = SystemColors.ControlLightLight;
            MultipleButton.Location = new Point(219, 270);
            MultipleButton.Name = "MultipleButton";
            MultipleButton.Size = new Size(59, 53);
            MultipleButton.TabIndex = 1;
            MultipleButton.Text = "*";
            MultipleButton.TextAlign = ContentAlignment.BottomCenter;
            MultipleButton.UseVisualStyleBackColor = false;
            MultipleButton.Click += OperationsEnter;
            // 
            // PointButton
            // 
            PointButton.BackColor = SystemColors.ControlText;
            PointButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PointButton.ForeColor = SystemColors.ControlLightLight;
            PointButton.Location = new Point(24, 329);
            PointButton.Name = "PointButton";
            PointButton.Size = new Size(59, 53);
            PointButton.TabIndex = 1;
            PointButton.Text = ".";
            PointButton.UseVisualStyleBackColor = false;
            PointButton.Click += EnterNumbers;
            // 
            // Button0
            // 
            Button0.BackColor = SystemColors.ControlText;
            Button0.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Button0.ForeColor = SystemColors.ControlLightLight;
            Button0.Location = new Point(89, 329);
            Button0.Name = "Button0";
            Button0.Size = new Size(59, 53);
            Button0.TabIndex = 1;
            Button0.Text = "0";
            Button0.UseVisualStyleBackColor = false;
            Button0.Click += EnterNumbers;
            // 
            // EqualButton
            // 
            EqualButton.BackColor = SystemColors.ControlText;
            EqualButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EqualButton.ForeColor = SystemColors.ControlLightLight;
            EqualButton.Location = new Point(154, 329);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(59, 53);
            EqualButton.TabIndex = 1;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = false;
            EqualButton.Click += EqualButton_Click;
            // 
            // DivitionButton
            // 
            DivitionButton.BackColor = SystemColors.ControlText;
            DivitionButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DivitionButton.ForeColor = SystemColors.ControlLightLight;
            DivitionButton.Location = new Point(219, 329);
            DivitionButton.Name = "DivitionButton";
            DivitionButton.Size = new Size(59, 53);
            DivitionButton.TabIndex = 1;
            DivitionButton.Text = "/";
            DivitionButton.UseVisualStyleBackColor = false;
            DivitionButton.Click += OperationsEnter;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ControlLight;
            Menu.BackgroundImageLayout = ImageLayout.None;
            Menu.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { modeToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.No;
            Menu.Size = new Size(598, 24);
            Menu.TabIndex = 2;
            // 
            // modeToolStripMenuItem
            // 
            modeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, exitToolStripMenuItem });
            modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            modeToolStripMenuItem.Size = new Size(54, 20);
            modeToolStripMenuItem.Text = "Mode";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(136, 22);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(136, 22);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(136, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // PiButton
            // 
            PiButton.BackColor = SystemColors.ControlText;
            PiButton.Font = new Font("Centaur", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PiButton.ForeColor = SystemColors.ControlLightLight;
            PiButton.Location = new Point(311, 93);
            PiButton.Name = "PiButton";
            PiButton.Size = new Size(59, 53);
            PiButton.TabIndex = 1;
            PiButton.Text = "π";
            PiButton.UseVisualStyleBackColor = false;
            PiButton.Click += PiButton_Click;
            // 
            // LogButton
            // 
            LogButton.BackColor = SystemColors.ControlText;
            LogButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogButton.ForeColor = SystemColors.ControlLightLight;
            LogButton.Location = new Point(376, 93);
            LogButton.Name = "LogButton";
            LogButton.Size = new Size(59, 53);
            LogButton.TabIndex = 1;
            LogButton.Text = "Log";
            LogButton.UseVisualStyleBackColor = false;
            LogButton.Click += LogButton_Click;
            // 
            // SquareRootButton
            // 
            SquareRootButton.BackColor = SystemColors.ControlText;
            SquareRootButton.Font = new Font("Elephant", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SquareRootButton.ForeColor = SystemColors.ControlLightLight;
            SquareRootButton.Location = new Point(441, 93);
            SquareRootButton.Name = "SquareRootButton";
            SquareRootButton.Size = new Size(59, 53);
            SquareRootButton.TabIndex = 1;
            SquareRootButton.Text = "√";
            SquareRootButton.UseVisualStyleBackColor = false;
            SquareRootButton.Click += SquareRootButton_Click;
            // 
            // Exponencial2Button
            // 
            Exponencial2Button.BackColor = SystemColors.ControlText;
            Exponencial2Button.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exponencial2Button.ForeColor = SystemColors.ControlLightLight;
            Exponencial2Button.Location = new Point(506, 93);
            Exponencial2Button.Name = "Exponencial2Button";
            Exponencial2Button.Size = new Size(59, 53);
            Exponencial2Button.TabIndex = 1;
            Exponencial2Button.Text = "x²";
            Exponencial2Button.UseVisualStyleBackColor = false;
            Exponencial2Button.Click += Exponencial2Button_Click;
            // 
            // SineHButton
            // 
            SineHButton.BackColor = SystemColors.ControlText;
            SineHButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SineHButton.ForeColor = SystemColors.ControlLightLight;
            SineHButton.Location = new Point(311, 152);
            SineHButton.Name = "SineHButton";
            SineHButton.Size = new Size(59, 53);
            SineHButton.TabIndex = 1;
            SineHButton.Text = "Sinh";
            SineHButton.UseVisualStyleBackColor = false;
            SineHButton.Click += SineHButton_Click;
            // 
            // SineButton
            // 
            SineButton.BackColor = SystemColors.ControlText;
            SineButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SineButton.ForeColor = SystemColors.ControlLightLight;
            SineButton.Location = new Point(376, 152);
            SineButton.Name = "SineButton";
            SineButton.Size = new Size(59, 53);
            SineButton.TabIndex = 1;
            SineButton.Text = "Sin";
            SineButton.UseVisualStyleBackColor = false;
            SineButton.Click += SineButton_Click;
            // 
            // DecimalButton
            // 
            DecimalButton.BackColor = SystemColors.ControlText;
            DecimalButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DecimalButton.ForeColor = SystemColors.ControlLightLight;
            DecimalButton.Location = new Point(441, 152);
            DecimalButton.Name = "DecimalButton";
            DecimalButton.Size = new Size(59, 53);
            DecimalButton.TabIndex = 1;
            DecimalButton.Text = "Dec";
            DecimalButton.UseVisualStyleBackColor = false;
            DecimalButton.Click += DecimalButton_Click;
            // 
            // Exponential3Button
            // 
            Exponential3Button.BackColor = SystemColors.ControlText;
            Exponential3Button.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exponential3Button.ForeColor = SystemColors.ControlLightLight;
            Exponential3Button.Location = new Point(506, 152);
            Exponential3Button.Name = "Exponential3Button";
            Exponential3Button.Size = new Size(59, 53);
            Exponential3Button.TabIndex = 1;
            Exponential3Button.Text = "x³";
            Exponential3Button.UseVisualStyleBackColor = false;
            Exponential3Button.Click += Exponential3Button_Click;
            // 
            // CosineHButton
            // 
            CosineHButton.BackColor = SystemColors.ControlText;
            CosineHButton.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CosineHButton.ForeColor = SystemColors.ControlLightLight;
            CosineHButton.Location = new Point(310, 211);
            CosineHButton.Name = "CosineHButton";
            CosineHButton.Size = new Size(59, 53);
            CosineHButton.TabIndex = 1;
            CosineHButton.Text = "Cosh";
            CosineHButton.UseVisualStyleBackColor = false;
            CosineHButton.Click += CosineHButton_Click;
            // 
            // TangentHButton
            // 
            TangentHButton.BackColor = SystemColors.ControlText;
            TangentHButton.Font = new Font("Arial Rounded MT Bold", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TangentHButton.ForeColor = SystemColors.ControlLightLight;
            TangentHButton.Location = new Point(311, 270);
            TangentHButton.Name = "TangentHButton";
            TangentHButton.Size = new Size(59, 53);
            TangentHButton.TabIndex = 1;
            TangentHButton.Text = "Tanh";
            TangentHButton.UseVisualStyleBackColor = false;
            TangentHButton.Click += TangentHButton_Click;
            // 
            // CosineButton
            // 
            CosineButton.BackColor = SystemColors.ControlText;
            CosineButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CosineButton.ForeColor = SystemColors.ControlLightLight;
            CosineButton.Location = new Point(375, 211);
            CosineButton.Name = "CosineButton";
            CosineButton.Size = new Size(59, 53);
            CosineButton.TabIndex = 1;
            CosineButton.Text = "Cos";
            CosineButton.UseVisualStyleBackColor = false;
            CosineButton.Click += CosineButton_Click;
            // 
            // TangentButton
            // 
            TangentButton.BackColor = SystemColors.ControlText;
            TangentButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TangentButton.ForeColor = SystemColors.ControlLightLight;
            TangentButton.Location = new Point(376, 270);
            TangentButton.Name = "TangentButton";
            TangentButton.Size = new Size(59, 53);
            TangentButton.TabIndex = 1;
            TangentButton.Text = "Tan";
            TangentButton.UseVisualStyleBackColor = false;
            TangentButton.Click += TangentButton_Click;
            // 
            // BinaryButton
            // 
            BinaryButton.BackColor = SystemColors.ControlText;
            BinaryButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BinaryButton.ForeColor = SystemColors.ControlLightLight;
            BinaryButton.Location = new Point(440, 211);
            BinaryButton.Name = "BinaryButton";
            BinaryButton.Size = new Size(59, 53);
            BinaryButton.TabIndex = 1;
            BinaryButton.Text = "Bin";
            BinaryButton.UseVisualStyleBackColor = false;
            BinaryButton.Click += BinaryButton_Click;
            // 
            // HexadecimalButton
            // 
            HexadecimalButton.BackColor = SystemColors.ControlText;
            HexadecimalButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HexadecimalButton.ForeColor = SystemColors.ControlLightLight;
            HexadecimalButton.Location = new Point(441, 270);
            HexadecimalButton.Name = "HexadecimalButton";
            HexadecimalButton.Size = new Size(59, 53);
            HexadecimalButton.TabIndex = 1;
            HexadecimalButton.Text = "Hex";
            HexadecimalButton.UseVisualStyleBackColor = false;
            HexadecimalButton.Click += HexadecimalButton_Click;
            // 
            // OneOverXButton
            // 
            OneOverXButton.BackColor = SystemColors.ControlText;
            OneOverXButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OneOverXButton.ForeColor = SystemColors.ControlLightLight;
            OneOverXButton.Location = new Point(505, 211);
            OneOverXButton.Name = "OneOverXButton";
            OneOverXButton.Size = new Size(59, 53);
            OneOverXButton.TabIndex = 1;
            OneOverXButton.Text = "1/x";
            OneOverXButton.UseVisualStyleBackColor = false;
            OneOverXButton.Click += OneOverXButton_Click;
            // 
            // InXButton
            // 
            InXButton.BackColor = SystemColors.ControlText;
            InXButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InXButton.ForeColor = SystemColors.ControlLightLight;
            InXButton.Location = new Point(506, 270);
            InXButton.Name = "InXButton";
            InXButton.Size = new Size(59, 53);
            InXButton.TabIndex = 1;
            InXButton.Text = "In X";
            InXButton.UseVisualStyleBackColor = false;
            InXButton.Click += InXButton_Click;
            // 
            // ExponentialButton
            // 
            ExponentialButton.BackColor = SystemColors.ControlText;
            ExponentialButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExponentialButton.ForeColor = SystemColors.ControlLightLight;
            ExponentialButton.Location = new Point(311, 329);
            ExponentialButton.Name = "ExponentialButton";
            ExponentialButton.Size = new Size(59, 53);
            ExponentialButton.TabIndex = 1;
            ExponentialButton.Text = "Exp";
            ExponentialButton.UseVisualStyleBackColor = false;
            ExponentialButton.Click += OperationsEnter;
            // 
            // ModulusButton
            // 
            ModulusButton.BackColor = SystemColors.ControlText;
            ModulusButton.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModulusButton.ForeColor = SystemColors.ControlLightLight;
            ModulusButton.Location = new Point(376, 329);
            ModulusButton.Name = "ModulusButton";
            ModulusButton.Size = new Size(59, 53);
            ModulusButton.TabIndex = 1;
            ModulusButton.Text = "Mod";
            ModulusButton.UseVisualStyleBackColor = false;
            ModulusButton.Click += OperationsEnter;
            // 
            // OctalButton
            // 
            OctalButton.BackColor = SystemColors.ControlText;
            OctalButton.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OctalButton.ForeColor = SystemColors.ControlLightLight;
            OctalButton.Location = new Point(441, 329);
            OctalButton.Name = "OctalButton";
            OctalButton.Size = new Size(59, 53);
            OctalButton.TabIndex = 1;
            OctalButton.Text = "Oct";
            OctalButton.UseVisualStyleBackColor = false;
            OctalButton.Click += OctalButton_Click;
            // 
            // PercentageButton
            // 
            PercentageButton.BackColor = SystemColors.ControlText;
            PercentageButton.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PercentageButton.ForeColor = SystemColors.ControlLightLight;
            PercentageButton.Location = new Point(506, 329);
            PercentageButton.Name = "PercentageButton";
            PercentageButton.Size = new Size(59, 53);
            PercentageButton.TabIndex = 1;
            PercentageButton.Text = "%";
            PercentageButton.UseVisualStyleBackColor = false;
            PercentageButton.Click += PercentageButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(598, 399);
            Controls.Add(DivitionButton);
            Controls.Add(MultipleButton);
            Controls.Add(PlusButton);
            Controls.Add(SubtractionButton);
            Controls.Add(PercentageButton);
            Controls.Add(InXButton);
            Controls.Add(Exponential3Button);
            Controls.Add(OneOverXButton);
            Controls.Add(Exponencial2Button);
            Controls.Add(PlusMinusButton);
            Controls.Add(EqualButton);
            Controls.Add(Button9);
            Controls.Add(Button3);
            Controls.Add(Button6);
            Controls.Add(OctalButton);
            Controls.Add(HexadecimalButton);
            Controls.Add(DecimalButton);
            Controls.Add(BinaryButton);
            Controls.Add(SquareRootButton);
            Controls.Add(ClearButton);
            Controls.Add(Button0);
            Controls.Add(Button8);
            Controls.Add(Button2);
            Controls.Add(ModulusButton);
            Controls.Add(TangentButton);
            Controls.Add(SineButton);
            Controls.Add(CosineButton);
            Controls.Add(LogButton);
            Controls.Add(Button5);
            Controls.Add(ClearEntryButton);
            Controls.Add(PointButton);
            Controls.Add(Button7);
            Controls.Add(Button1);
            Controls.Add(ExponentialButton);
            Controls.Add(TangentHButton);
            Controls.Add(CosineHButton);
            Controls.Add(SineHButton);
            Controls.Add(PiButton);
            Controls.Add(Button4);
            Controls.Add(BackSpaceButton);
            Controls.Add(TxtResult);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtResult;
        private Button BackSpaceButton;
        private Button ClearEntryButton;
        private Button ClearButton;
        private Button PlusMinusButton;
        private Button Button1;
        private Button Button2;
        private Button Button3;
        private Button PlusButton;
        private Button Button4;
        private Button Button7;
        private Button Button5;
        private Button Button8;
        private Button Button6;
        private Button Button9;
        private Button SubtractionButton;
        private Button MultipleButton;
        private Button PointButton;
        private Button Button0;
        private Button EqualButton;
        private Button DivitionButton;
        private MenuStrip Menu;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button PiButton;
        private Button LogButton;
        private Button SquareRootButton;
        private Button Exponencial2Button;
        private Button SineHButton;
        private Button SineButton;
        private Button DecimalButton;
        private Button Exponential3Button;
        private Button CosineHButton;
        private Button TangentHButton;
        private Button CosineButton;
        private Button TangentButton;
        private Button BinaryButton;
        private Button HexadecimalButton;
        private Button OneOverXButton;
        private Button InXButton;
        private Button ExponentialButton;
        private Button ModulusButton;
        private Button OctalButton;
        private Button PercentageButton;
    }
}
