namespace bne
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
            colorPanel = new Panel();
            textBox1 = new TextBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            redRadioButton = new RadioButton();
            panel1 = new Panel();
            textBox2 = new TextBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            DrawingPanel = new Panel();
            colorPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // colorPanel
            // 
            colorPanel.Controls.Add(textBox1);
            colorPanel.Controls.Add(radioButton3);
            colorPanel.Controls.Add(radioButton2);
            colorPanel.Controls.Add(radioButton1);
            colorPanel.Controls.Add(redRadioButton);
            colorPanel.Location = new Point(52, 41);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(135, 191);
            colorPanel.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "Color";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(15, 147);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(65, 24);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Black";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(15, 117);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 24);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Green";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(15, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 24);
            radioButton1.TabIndex = 1;
            radioButton1.Text = "Blue";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // redRadioButton
            // 
            redRadioButton.AutoSize = true;
            redRadioButton.Location = new Point(15, 57);
            redRadioButton.Name = "redRadioButton";
            redRadioButton.Size = new Size(56, 24);
            redRadioButton.TabIndex = 0;
            redRadioButton.Text = "Red";
            redRadioButton.UseVisualStyleBackColor = true;
            redRadioButton.CheckedChanged += redRadioButton_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton7);
            panel1.Location = new Point(52, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 161);
            panel1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "Size";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(15, 117);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(67, 24);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "Large";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(15, 87);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(85, 24);
            radioButton6.TabIndex = 1;
            radioButton6.TabStop = true;
            radioButton6.Text = "Medium";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(15, 57);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(67, 24);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "Small";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += radioButton7_CheckedChanged;
            // 
            // DrawingPanel
            // 
            DrawingPanel.BackColor = SystemColors.ControlLightLight;
            DrawingPanel.Location = new Point(232, 41);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(556, 358);
            DrawingPanel.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(DrawingPanel);
            Controls.Add(panel1);
            Controls.Add(colorPanel);
            Name = "Form1";
            Text = "Form1";
            colorPanel.ResumeLayout(false);
            colorPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel colorPanel;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private Panel DrawingPanel;
        private RadioButton redRadioButton;
    }
}