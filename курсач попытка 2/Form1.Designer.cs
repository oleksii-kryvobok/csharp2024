namespace Calculator
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBracketOpen = new System.Windows.Forms.Button();
            this.buttonBracketClose = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSin = new System.Windows.Forms.Button();
            this.buttonCos = new System.Windows.Forms.Button();
            this.buttonTan = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonCbrt = new System.Windows.Forms.Button();
            this.buttonLn = new System.Windows.Forms.Button();
            this.buttonFactorial = new System.Windows.Forms.Button();
            this.buttonAbs = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonPi = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonPower2 = new System.Windows.Forms.Button();
            this.buttonPower10 = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.OliveDrab;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.Color.Cyan;
            this.button0.Location = new System.Drawing.Point(210, 295);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 40);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(144, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(210, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OliveDrab;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(276, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.OliveDrab;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Cyan;
            this.button4.Location = new System.Drawing.Point(144, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OliveDrab;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Cyan;
            this.button5.Location = new System.Drawing.Point(210, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 40);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OliveDrab;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Cyan;
            this.button6.Location = new System.Drawing.Point(276, 203);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 40);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.OliveDrab;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Cyan;
            this.button7.Location = new System.Drawing.Point(144, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 40);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.OliveDrab;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Cyan;
            this.button8.Location = new System.Drawing.Point(210, 157);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 40);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OliveDrab;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Cyan;
            this.button9.Location = new System.Drawing.Point(276, 157);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 40);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAdd.Location = new System.Drawing.Point(342, 249);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubtract.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSubtract.Location = new System.Drawing.Point(342, 203);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(60, 40);
            this.buttonSubtract.TabIndex = 12;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMultiply.ForeColor = System.Drawing.Color.Cyan;
            this.buttonMultiply.Location = new System.Drawing.Point(342, 157);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(60, 40);
            this.buttonMultiply.TabIndex = 13;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivide.ForeColor = System.Drawing.Color.Cyan;
            this.buttonDivide.Location = new System.Drawing.Point(342, 111);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 40);
            this.buttonDivide.TabIndex = 14;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonBracketOpen
            // 
            this.buttonBracketOpen.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonBracketOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBracketOpen.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBracketOpen.ForeColor = System.Drawing.Color.Cyan;
            this.buttonBracketOpen.Location = new System.Drawing.Point(210, 111);
            this.buttonBracketOpen.Name = "buttonBracketOpen";
            this.buttonBracketOpen.Size = new System.Drawing.Size(60, 40);
            this.buttonBracketOpen.TabIndex = 15;
            this.buttonBracketOpen.Text = "(";
            this.buttonBracketOpen.UseVisualStyleBackColor = false;
            this.buttonBracketOpen.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonBracketClose
            // 
            this.buttonBracketClose.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonBracketClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBracketClose.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBracketClose.ForeColor = System.Drawing.Color.Cyan;
            this.buttonBracketClose.Location = new System.Drawing.Point(276, 111);
            this.buttonBracketClose.Name = "buttonBracketClose";
            this.buttonBracketClose.Size = new System.Drawing.Size(60, 40);
            this.buttonBracketClose.TabIndex = 16;
            this.buttonBracketClose.Text = ")";
            this.buttonBracketClose.UseVisualStyleBackColor = false;
            this.buttonBracketClose.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonComma.ForeColor = System.Drawing.Color.Cyan;
            this.buttonComma.Location = new System.Drawing.Point(276, 295);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(60, 40);
            this.buttonComma.TabIndex = 17;
            this.buttonComma.Text = ".";
            this.buttonComma.UseVisualStyleBackColor = false;
            this.buttonComma.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResult.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ForeColor = System.Drawing.Color.Cyan;
            this.buttonResult.Location = new System.Drawing.Point(342, 295);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(60, 40);
            this.buttonResult.TabIndex = 18;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.Cyan;
            this.buttonClear.Location = new System.Drawing.Point(144, 295);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 40);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSin
            // 
            this.buttonSin.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSin.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSin.Location = new System.Drawing.Point(78, 111);
            this.buttonSin.Name = "buttonSin";
            this.buttonSin.Size = new System.Drawing.Size(60, 40);
            this.buttonSin.TabIndex = 20;
            this.buttonSin.Text = "sin";
            this.buttonSin.UseVisualStyleBackColor = false;
            this.buttonSin.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonCos
            // 
            this.buttonCos.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCos.ForeColor = System.Drawing.Color.Cyan;
            this.buttonCos.Location = new System.Drawing.Point(78, 157);
            this.buttonCos.Name = "buttonCos";
            this.buttonCos.Size = new System.Drawing.Size(60, 40);
            this.buttonCos.TabIndex = 21;
            this.buttonCos.Text = "cos";
            this.buttonCos.UseVisualStyleBackColor = false;
            this.buttonCos.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonTan
            // 
            this.buttonTan.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTan.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTan.ForeColor = System.Drawing.Color.Cyan;
            this.buttonTan.Location = new System.Drawing.Point(78, 203);
            this.buttonTan.Name = "buttonTan";
            this.buttonTan.Size = new System.Drawing.Size(60, 40);
            this.buttonTan.TabIndex = 22;
            this.buttonTan.Text = "tan";
            this.buttonTan.UseVisualStyleBackColor = false;
            this.buttonTan.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSquare.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSquare.Location = new System.Drawing.Point(12, 112);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(60, 40);
            this.buttonSquare.TabIndex = 23;
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.ForeColor = System.Drawing.Color.Cyan;
            this.buttonLog.Location = new System.Drawing.Point(78, 65);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(60, 40);
            this.buttonLog.TabIndex = 24;
            this.buttonLog.Text = "log";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSqrt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSqrt.ForeColor = System.Drawing.Color.Cyan;
            this.buttonSqrt.Location = new System.Drawing.Point(78, 249);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(60, 40);
            this.buttonSqrt.TabIndex = 24;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = false;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonCbrt
            // 
            this.buttonCbrt.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonCbrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCbrt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCbrt.ForeColor = System.Drawing.Color.Cyan;
            this.buttonCbrt.Location = new System.Drawing.Point(78, 296);
            this.buttonCbrt.Name = "buttonCbrt";
            this.buttonCbrt.Size = new System.Drawing.Size(60, 40);
            this.buttonCbrt.TabIndex = 25;
            this.buttonCbrt.Text = "³√";
            this.buttonCbrt.UseVisualStyleBackColor = false;
            this.buttonCbrt.Click += new System.EventHandler(this.buttonCbrt_Click);
            // 
            // buttonLn
            // 
            this.buttonLn.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLn.ForeColor = System.Drawing.Color.Cyan;
            this.buttonLn.Location = new System.Drawing.Point(144, 65);
            this.buttonLn.Name = "buttonLn";
            this.buttonLn.Size = new System.Drawing.Size(60, 40);
            this.buttonLn.TabIndex = 26;
            this.buttonLn.Text = "ln";
            this.buttonLn.UseVisualStyleBackColor = false;
            this.buttonLn.Click += new System.EventHandler(this.buttonLn_Click);
            // 
            // buttonFactorial
            // 
            this.buttonFactorial.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactorial.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFactorial.ForeColor = System.Drawing.Color.Cyan;
            this.buttonFactorial.Location = new System.Drawing.Point(144, 111);
            this.buttonFactorial.Name = "buttonFactorial";
            this.buttonFactorial.Size = new System.Drawing.Size(60, 40);
            this.buttonFactorial.TabIndex = 27;
            this.buttonFactorial.Text = "n!";
            this.buttonFactorial.UseVisualStyleBackColor = false;
            this.buttonFactorial.Click += new System.EventHandler(this.buttonFactorial_Click);
            // 
            // buttonAbs
            // 
            this.buttonAbs.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAbs.ForeColor = System.Drawing.Color.Cyan;
            this.buttonAbs.Location = new System.Drawing.Point(12, 295);
            this.buttonAbs.Name = "buttonAbs";
            this.buttonAbs.Size = new System.Drawing.Size(60, 40);
            this.buttonAbs.TabIndex = 28;
            this.buttonAbs.Text = "|x|";
            this.buttonAbs.UseVisualStyleBackColor = false;
            this.buttonAbs.Click += new System.EventHandler(this.buttonAbs_Click);
            // 
            // buttonE
            // 
            this.buttonE.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonE.ForeColor = System.Drawing.Color.Cyan;
            this.buttonE.Location = new System.Drawing.Point(276, 65);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(60, 40);
            this.buttonE.TabIndex = 29;
            this.buttonE.Text = "e";
            this.buttonE.UseVisualStyleBackColor = false;
            this.buttonE.Click += new System.EventHandler(this.buttonE_Click);
            // 
            // buttonPi
            // 
            this.buttonPi.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPi.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPi.Location = new System.Drawing.Point(210, 65);
            this.buttonPi.Name = "buttonPi";
            this.buttonPi.Size = new System.Drawing.Size(60, 40);
            this.buttonPi.TabIndex = 30;
            this.buttonPi.Text = "π";
            this.buttonPi.UseVisualStyleBackColor = false;
            this.buttonPi.Click += new System.EventHandler(this.buttonPi_Click);
            // 
            // buttonPower
            // 
            this.buttonPower.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPower.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPower.Location = new System.Drawing.Point(12, 157);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(60, 40);
            this.buttonPower.TabIndex = 31;
            this.buttonPower.Text = "xʸ";
            this.buttonPower.UseVisualStyleBackColor = false;
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);
            // 
            // buttonPower2
            // 
            this.buttonPower2.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonPower2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPower2.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPower2.Location = new System.Drawing.Point(12, 203);
            this.buttonPower2.Name = "buttonPower2";
            this.buttonPower2.Size = new System.Drawing.Size(60, 40);
            this.buttonPower2.TabIndex = 32;
            this.buttonPower2.Text = "2ˣ";
            this.buttonPower2.UseVisualStyleBackColor = false;
            this.buttonPower2.Click += new System.EventHandler(this.buttonPower2_Click);
            // 
            // buttonPower10
            // 
            this.buttonPower10.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonPower10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPower10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPower10.ForeColor = System.Drawing.Color.Cyan;
            this.buttonPower10.Location = new System.Drawing.Point(12, 249);
            this.buttonPower10.Name = "buttonPower10";
            this.buttonPower10.Size = new System.Drawing.Size(60, 40);
            this.buttonPower10.TabIndex = 33;
            this.buttonPower10.Text = "10ˣ";
            this.buttonPower10.UseVisualStyleBackColor = false;
            this.buttonPower10.Click += new System.EventHandler(this.buttonPower10_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackspace.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackspace.ForeColor = System.Drawing.Color.Cyan;
            this.buttonBackspace.Location = new System.Drawing.Point(342, 65);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(60, 40);
            this.buttonBackspace.TabIndex = 25;
            this.buttonBackspace.Text = "←";
            this.buttonBackspace.UseVisualStyleBackColor = false;
            this.buttonBackspace.Click += new System.EventHandler(this.buttonBackspace_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Yellow;
            this.buttonHelp.Location = new System.Drawing.Point(12, 65);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(60, 40);
            this.buttonHelp.TabIndex = 34;
            this.buttonHelp.Text = "i";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(414, 347);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonBackspace);
            this.Controls.Add(this.buttonPower10);
            this.Controls.Add(this.buttonPower2);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonPi);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonAbs);
            this.Controls.Add(this.buttonFactorial);
            this.Controls.Add(this.buttonLn);
            this.Controls.Add(this.buttonCbrt);
            this.Controls.Add(this.buttonSqrt);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonTan);
            this.Controls.Add(this.buttonCos);
            this.Controls.Add(this.buttonSin);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.buttonBracketOpen);
            this.Controls.Add(this.buttonBracketClose);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        /*private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBracketOpen = new System.Windows.Forms.Button();
            this.buttonBracketClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(110, 378);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.Location = new System.Drawing.Point(176, 378);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(60, 60);
            this.buttonComma.TabIndex = 2;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = true;
            this.buttonComma.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(242, 378);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(60, 60);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(44, 378);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button0_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 6;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(242, 312);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(60, 60);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Location = new System.Drawing.Point(242, 246);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(60, 60);
            this.buttonSubtract.TabIndex = 9;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.button0_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(176, 246);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 10;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button0_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(110, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 11;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button0_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button0_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(44, 180);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 13;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button0_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(110, 180);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(176, 180);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 15;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(242, 180);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(60, 60);
            this.buttonMultiply.TabIndex = 16;
            this.buttonMultiply.Text = "×";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(242, 114);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 60);
            this.buttonDivide.TabIndex = 17;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonBracketOpen
            // 
            this.buttonBracketOpen.Location = new System.Drawing.Point(110, 114);
            this.buttonBracketOpen.Name = "buttonBracketOpen";
            this.buttonBracketOpen.Size = new System.Drawing.Size(60, 60);
            this.buttonBracketOpen.TabIndex = 18;
            this.buttonBracketOpen.Text = "(";
            this.buttonBracketOpen.UseVisualStyleBackColor = true;
            this.buttonBracketOpen.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonBracketClose
            // 
            this.buttonBracketClose.Location = new System.Drawing.Point(176, 114);
            this.buttonBracketClose.Name = "buttonBracketClose";
            this.buttonBracketClose.Size = new System.Drawing.Size(60, 60);
            this.buttonBracketClose.TabIndex = 19;
            this.buttonBracketClose.Text = ")";
            this.buttonBracketClose.UseVisualStyleBackColor = true;
            this.buttonBracketClose.Click += new System.EventHandler(this.button0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.buttonBracketClose);
            this.Controls.Add(this.buttonBracketOpen);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonComma);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonBracketOpen;
        private System.Windows.Forms.Button buttonBracketClose;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSin;
        private System.Windows.Forms.Button buttonCos;
        private System.Windows.Forms.Button buttonTan;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonCbrt;
        private System.Windows.Forms.Button buttonLn;
        private System.Windows.Forms.Button buttonFactorial;
        private System.Windows.Forms.Button buttonAbs;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonPi;
        private System.Windows.Forms.Button buttonPower;
        private System.Windows.Forms.Button buttonPower2;
        private System.Windows.Forms.Button buttonPower10;
        private System.Windows.Forms.Button buttonBackspace;
        private System.Windows.Forms.Button buttonHelp;
    }
}

