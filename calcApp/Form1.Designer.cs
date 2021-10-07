namespace calcApp
{
    partial class FormCalc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEnter = new System.Windows.Forms.Label();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDenominator = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.labelFormula = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPM = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonEqure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEnter
            // 
            this.labelEnter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEnter.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelEnter.Location = new System.Drawing.Point(10, 40);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(240, 40);
            this.labelEnter.TabIndex = 1;
            this.labelEnter.Text = "0";
            this.labelEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(70, 90);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(60, 60);
            this.buttonCE.TabIndex = 0;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(130, 90);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(60, 60);
            this.buttonC.TabIndex = 0;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDenominator
            // 
            this.buttonDenominator.Location = new System.Drawing.Point(10, 150);
            this.buttonDenominator.Name = "buttonDenominator";
            this.buttonDenominator.Size = new System.Drawing.Size(60, 60);
            this.buttonDenominator.TabIndex = 0;
            this.buttonDenominator.Text = "1/x";
            this.buttonDenominator.UseVisualStyleBackColor = true;
            this.buttonDenominator.Click += new System.EventHandler(this.buttonDenominator_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(70, 150);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(60, 60);
            this.buttonSquare.TabIndex = 0;
            this.buttonSquare.Text = "x^2";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.Location = new System.Drawing.Point(130, 150);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(60, 60);
            this.buttonSquareRoot.TabIndex = 0;
            this.buttonSquareRoot.Text = "√x";
            this.buttonSquareRoot.UseVisualStyleBackColor = true;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRoot_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(70, 210);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // labelFormula
            // 
            this.labelFormula.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFormula.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelFormula.Location = new System.Drawing.Point(10, 10);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(240, 30);
            this.labelFormula.TabIndex = 2;
            this.labelFormula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 210);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 3;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(130, 210);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 4;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(130, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 7;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(190, 90);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 60);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(190, 150);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(60, 60);
            this.buttonDivide.TabIndex = 0;
            this.buttonDivide.Text = "÷";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.button_Code_Click);
            // 
            // buttonTimes
            // 
            this.buttonTimes.Location = new System.Drawing.Point(190, 210);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(60, 60);
            this.buttonTimes.TabIndex = 4;
            this.buttonTimes.Text = "×";
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.button_Code_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(190, 270);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 7;
            this.buttonMinus.Text = "ー";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.button_Code_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(190, 330);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlus.TabIndex = 7;
            this.buttonPlus.Text = "＋";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button_Code_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(70, 390);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 5;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // buttonPM
            // 
            this.buttonPM.Location = new System.Drawing.Point(10, 390);
            this.buttonPM.Name = "buttonPM";
            this.buttonPM.Size = new System.Drawing.Size(60, 60);
            this.buttonPM.TabIndex = 6;
            this.buttonPM.Text = "+/-";
            this.buttonPM.UseVisualStyleBackColor = true;
            this.buttonPM.Click += new System.EventHandler(this.buttonPM_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Location = new System.Drawing.Point(130, 390);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(60, 60);
            this.buttonDot.TabIndex = 7;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonEqure
            // 
            this.buttonEqure.Location = new System.Drawing.Point(190, 390);
            this.buttonEqure.Name = "buttonEqure";
            this.buttonEqure.Size = new System.Drawing.Size(60, 60);
            this.buttonEqure.TabIndex = 7;
            this.buttonEqure.Text = "=";
            this.buttonEqure.UseVisualStyleBackColor = true;
            this.buttonEqure.Click += new System.EventHandler(this.buttonEqure_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 460);
            this.Controls.Add(this.buttonEqure);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonPM);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonTimes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.labelEnter);
            this.Controls.Add(this.buttonSquareRoot);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonDenominator);
            this.Name = "FormCalc";
            this.Text = "calc";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDenominator;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonSquareRoot;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonPM;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonEqure;
    }
}

