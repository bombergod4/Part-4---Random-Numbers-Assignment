namespace Part_4___Random_Numbers_Assignment
{
    partial class RandomNumbers
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 31);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(412, 45);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Enter a minimum and maximum value";
            // 
            // lblMin
            // 
            this.lblMin.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.Location = new System.Drawing.Point(12, 129);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(131, 45);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Minimum";
            // 
            // lblMax
            // 
            this.lblMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(12, 265);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(131, 45);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Maximum";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(208, 141);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(280, 20);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(208, 277);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(280, 20);
            this.txtMax.TabIndex = 4;
            // 
            // btnInt
            // 
            this.btnInt.BackColor = System.Drawing.Color.Lime;
            this.btnInt.Location = new System.Drawing.Point(2, 318);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(372, 50);
            this.btnInt.TabIndex = 5;
            this.btnInt.Text = "Get Integer";
            this.btnInt.UseVisualStyleBackColor = false;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDouble.Location = new System.Drawing.Point(416, 318);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(372, 50);
            this.btnDouble.TabIndex = 6;
            this.btnDouble.Text = "Get Double";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(43, 384);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(714, 45);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Sample Text";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Visible = false;
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblInstruction);
            this.Name = "RandomNumbers";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Label lblOutput;
    }
}

