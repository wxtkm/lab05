namespace zadania_5_24832
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
            lblTitle = new Label();
            gbInput = new GroupBox();
            lblCapacity = new Label();
            txtCapacity = new TextBox();
            lblPercent = new Label();
            lblCount = new Label();
            txtPercent = new TextBox();
            txtCount = new TextBox();
            gbTypes = new GroupBox();
            lblVessel = new Label();
            lblSolution = new Label();
            cmbVessel = new ComboBox();
            cmbSolution = new ComboBox();
            btnCalculate = new Button();
            btnClear = new Button();
            gbResults = new GroupBox();
            lblTotalVolume = new Label();
            lblPureVolume = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(299, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kalkulator procentowy";
            // 
            // gbInput
            // 
            gbInput.Location = new Point(21, 50);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(115, 22);
            gbInput.TabIndex = 1;
            gbInput.TabStop = false;
            gbInput.Text = "Dane wejściowe";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(21, 88);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(91, 15);
            lblCapacity.TabIndex = 2;
            lblCapacity.Text = "Pojemność (ml)";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(155, 85);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 4;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(29, 122);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(82, 15);
            lblPercent.TabIndex = 5;
            lblPercent.Text = "Zawartość (%)";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(31, 154);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(80, 15);
            lblCount.TabIndex = 6;
            lblCount.Text = "Liczba naczyń";
            // 
            // txtPercent
            // 
            txtPercent.Location = new Point(161, 122);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(100, 23);
            txtPercent.TabIndex = 7;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(155, 158);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(100, 23);
            txtCount.TabIndex = 8;
            // 
            // gbTypes
            // 
            gbTypes.Location = new Point(33, 193);
            gbTypes.Name = "gbTypes";
            gbTypes.Size = new Size(113, 20);
            gbTypes.TabIndex = 9;
            gbTypes.TabStop = false;
            gbTypes.Text = "Typowe wartości";
            // 
            // lblVessel
            // 
            lblVessel.AutoSize = true;
            lblVessel.Location = new Point(37, 226);
            lblVessel.Name = "lblVessel";
            lblVessel.Size = new Size(74, 15);
            lblVessel.TabIndex = 0;
            lblVessel.Text = "Typ naczynia";
            // 
            // lblSolution
            // 
            lblSolution.AutoSize = true;
            lblSolution.Location = new Point(37, 256);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(75, 15);
            lblSolution.TabIndex = 10;
            lblSolution.Text = "Typ roztworu";
            // 
            // cmbVessel
            // 
            cmbVessel.FormattingEnabled = true;
            cmbVessel.Location = new Point(140, 219);
            cmbVessel.Name = "cmbVessel";
            cmbVessel.Size = new Size(121, 23);
            cmbVessel.TabIndex = 11;
            // 
            // cmbSolution
            // 
            cmbSolution.FormattingEnabled = true;
            cmbSolution.Location = new Point(140, 258);
            cmbSolution.Name = "cmbSolution";
            cmbSolution.Size = new Size(121, 23);
            cmbSolution.TabIndex = 12;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(89, 314);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 13;
            btnCalculate.Text = "Oblicz";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(245, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Wyczyść";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // gbResults
            // 
            gbResults.Location = new Point(554, 37);
            gbResults.Name = "gbResults";
            gbResults.Size = new Size(62, 20);
            gbResults.TabIndex = 15;
            gbResults.TabStop = false;
            gbResults.Text = "Wyniki";
            // 
            // lblTotalVolume
            // 
            lblTotalVolume.AutoSize = true;
            lblTotalVolume.Location = new Point(532, 88);
            lblTotalVolume.Name = "lblTotalVolume";
            lblTotalVolume.Size = new Size(120, 15);
            lblTotalVolume.TabIndex = 16;
            lblTotalVolume.Text = "Łączna objętość: 0 ml";
            // 
            // lblPureVolume
            // 
            lblPureVolume.AutoSize = true;
            lblPureVolume.Location = new Point(538, 126);
            lblPureVolume.Name = "lblPureVolume";
            lblPureVolume.Size = new Size(177, 15);
            lblPureVolume.TabIndex = 17;
            lblPureVolume.Text = "Objętość czystej substancji: 0 ml";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPureVolume);
            Controls.Add(lblTotalVolume);
            Controls.Add(gbResults);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(cmbSolution);
            Controls.Add(cmbVessel);
            Controls.Add(lblSolution);
            Controls.Add(lblVessel);
            Controls.Add(gbTypes);
            Controls.Add(txtCount);
            Controls.Add(txtPercent);
            Controls.Add(lblCount);
            Controls.Add(lblPercent);
            Controls.Add(txtCapacity);
            Controls.Add(lblCapacity);
            Controls.Add(gbInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox gbInput;
        private Label lblCapacity;
        private TextBox txtCapacity;
        private Label lblPercent;
        private Label lblCount;
        private TextBox txtPercent;
        private TextBox txtCount;
        private GroupBox gbTypes;
        private Label lblVessel;
        private Label lblSolution;
        private ComboBox cmbVessel;
        private ComboBox cmbSolution;
        private Button btnCalculate;
        private Button btnClear;
        private GroupBox gbResults;
        private Label lblTotalVolume;
        private Label lblPureVolume;
    }
}
