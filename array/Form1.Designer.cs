
namespace array
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
            this.btnSHL = new System.Windows.Forms.Button();
            this.btnSHR = new System.Windows.Forms.Button();
            this.btnROL = new System.Windows.Forms.Button();
            this.btnROR = new System.Windows.Forms.Button();
            this.btnINV = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbBit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSHL
            // 
            this.btnSHL.Location = new System.Drawing.Point(87, 198);
            this.btnSHL.Name = "btnSHL";
            this.btnSHL.Size = new System.Drawing.Size(115, 52);
            this.btnSHL.TabIndex = 0;
            this.btnSHL.Text = "SHL";
            this.btnSHL.UseVisualStyleBackColor = true;
            this.btnSHL.Click += new System.EventHandler(this.btnSHL_Click);
            // 
            // btnSHR
            // 
            this.btnSHR.Location = new System.Drawing.Point(225, 198);
            this.btnSHR.Name = "btnSHR";
            this.btnSHR.Size = new System.Drawing.Size(115, 52);
            this.btnSHR.TabIndex = 0;
            this.btnSHR.Text = "SHR";
            this.btnSHR.UseVisualStyleBackColor = true;
            this.btnSHR.Click += new System.EventHandler(this.btnSHR_Click);
            // 
            // btnROL
            // 
            this.btnROL.Location = new System.Drawing.Point(87, 256);
            this.btnROL.Name = "btnROL";
            this.btnROL.Size = new System.Drawing.Size(115, 52);
            this.btnROL.TabIndex = 0;
            this.btnROL.Text = "ROL";
            this.btnROL.UseVisualStyleBackColor = true;
            this.btnROL.Click += new System.EventHandler(this.btnROL_Click);
            // 
            // btnROR
            // 
            this.btnROR.Location = new System.Drawing.Point(225, 256);
            this.btnROR.Name = "btnROR";
            this.btnROR.Size = new System.Drawing.Size(115, 52);
            this.btnROR.TabIndex = 0;
            this.btnROR.Text = "ROR";
            this.btnROR.UseVisualStyleBackColor = true;
            this.btnROR.Click += new System.EventHandler(this.btnROR_Click);
            // 
            // btnINV
            // 
            this.btnINV.Location = new System.Drawing.Point(358, 198);
            this.btnINV.Name = "btnINV";
            this.btnINV.Size = new System.Drawing.Size(115, 52);
            this.btnINV.TabIndex = 0;
            this.btnINV.Text = "INV";
            this.btnINV.UseVisualStyleBackColor = true;
            this.btnINV.Click += new System.EventHandler(this.btnINV_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(89, 70);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(317, 26);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "0,0,0,0,0,0,0,0,0,0,1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(87, 144);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(386, 26);
            this.tbOutput.TabIndex = 2;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(501, 57);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 52);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbBit
            // 
            this.tbBit.Location = new System.Drawing.Point(412, 70);
            this.tbBit.Name = "tbBit";
            this.tbBit.Size = new System.Drawing.Size(62, 26);
            this.tbBit.TabIndex = 4;
            this.tbBit.Text = "1";
            this.tbBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 355);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnROR);
            this.Controls.Add(this.btnROL);
            this.Controls.Add(this.btnINV);
            this.Controls.Add(this.btnSHR);
            this.Controls.Add(this.btnSHL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Shift Bit of Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSHL;
        private System.Windows.Forms.Button btnSHR;
        private System.Windows.Forms.Button btnROL;
        private System.Windows.Forms.Button btnROR;
        private System.Windows.Forms.Button btnINV;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbBit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

