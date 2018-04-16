namespace FractionCalculator___Michael_Kestner
{
    partial class Form1
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
            this.equalsButton = new System.Windows.Forms.Button();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.firstNumBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstDenomBox = new System.Windows.Forms.TextBox();
            this.secondDenomBox = new System.Windows.Forms.TextBox();
            this.secondNumBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outNumLabel = new System.Windows.Forms.Label();
            this.outDenomLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outFloatStringLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(360, 75);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 37);
            this.equalsButton.TabIndex = 3;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // operationComboBox
            // 
            this.operationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operationComboBox.Location = new System.Drawing.Point(179, 75);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(48, 37);
            this.operationComboBox.TabIndex = 4;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.operationComboBox_SelectedIndexChanged);
            // 
            // firstNumBox
            // 
            this.firstNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumBox.Location = new System.Drawing.Point(74, 21);
            this.firstNumBox.Multiline = true;
            this.firstNumBox.Name = "firstNumBox";
            this.firstNumBox.Size = new System.Drawing.Size(80, 65);
            this.firstNumBox.TabIndex = 5;
            this.firstNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.firstNumBox.TextChanged += new System.EventHandler(this.firstNumBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(74, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(79, 2);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // firstDenomBox
            // 
            this.firstDenomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDenomBox.Location = new System.Drawing.Point(74, 110);
            this.firstDenomBox.Multiline = true;
            this.firstDenomBox.Name = "firstDenomBox";
            this.firstDenomBox.Size = new System.Drawing.Size(80, 65);
            this.firstDenomBox.TabIndex = 7;
            this.firstDenomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondDenomBox
            // 
            this.secondDenomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDenomBox.Location = new System.Drawing.Point(255, 110);
            this.secondDenomBox.Multiline = true;
            this.secondDenomBox.Name = "secondDenomBox";
            this.secondDenomBox.Size = new System.Drawing.Size(80, 65);
            this.secondDenomBox.TabIndex = 8;
            this.secondDenomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secondNumBox
            // 
            this.secondNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumBox.Location = new System.Drawing.Point(255, 21);
            this.secondNumBox.Multiline = true;
            this.secondNumBox.Name = "secondNumBox";
            this.secondNumBox.Size = new System.Drawing.Size(80, 65);
            this.secondNumBox.TabIndex = 9;
            this.secondNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(255, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 2);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // outNumLabel
            // 
            this.outNumLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outNumLabel.Location = new System.Drawing.Point(458, 21);
            this.outNumLabel.Name = "outNumLabel";
            this.outNumLabel.Size = new System.Drawing.Size(80, 65);
            this.outNumLabel.TabIndex = 11;
            this.outNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outDenomLabel
            // 
            this.outDenomLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outDenomLabel.Location = new System.Drawing.Point(458, 110);
            this.outDenomLabel.Name = "outDenomLabel";
            this.outDenomLabel.Size = new System.Drawing.Size(80, 65);
            this.outDenomLabel.TabIndex = 12;
            this.outDenomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(461, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(79, 2);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // outFloatStringLabel
            // 
            this.outFloatStringLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outFloatStringLabel.Location = new System.Drawing.Point(595, 75);
            this.outFloatStringLabel.Name = "outFloatStringLabel";
            this.outFloatStringLabel.Size = new System.Drawing.Size(109, 48);
            this.outFloatStringLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 214);
            this.Controls.Add(this.outFloatStringLabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.outDenomLabel);
            this.Controls.Add(this.outNumLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.secondNumBox);
            this.Controls.Add(this.secondDenomBox);
            this.Controls.Add(this.firstDenomBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.firstNumBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.equalsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.TextBox firstNumBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstDenomBox;
        private System.Windows.Forms.TextBox secondDenomBox;
        private System.Windows.Forms.TextBox secondNumBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label outNumLabel;
        private System.Windows.Forms.Label outDenomLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label outFloatStringLabel;
    }
}

