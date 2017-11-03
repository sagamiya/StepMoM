namespace StepMoM
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
            this.startButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.selectSrcButton = new System.Windows.Forms.Button();
            this.statusArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.variable0From = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.variable0to = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.Label();
            this.variable0step = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(51, 279);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 27);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sourcePath
            // 
            this.sourcePath.Location = new System.Drawing.Point(148, 66);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.ReadOnly = true;
            this.sourcePath.Size = new System.Drawing.Size(646, 19);
            this.sourcePath.TabIndex = 1;
            // 
            // selectSrcButton
            // 
            this.selectSrcButton.Location = new System.Drawing.Point(51, 64);
            this.selectSrcButton.Name = "selectSrcButton";
            this.selectSrcButton.Size = new System.Drawing.Size(75, 23);
            this.selectSrcButton.TabIndex = 2;
            this.selectSrcButton.Text = "Reference...";
            this.selectSrcButton.UseVisualStyleBackColor = true;
            this.selectSrcButton.Click += new System.EventHandler(this.selectSrcButton_Click);
            // 
            // statusArea
            // 
            this.statusArea.Location = new System.Drawing.Point(33, 327);
            this.statusArea.Multiline = true;
            this.statusArea.Name = "statusArea";
            this.statusArea.ReadOnly = true;
            this.statusArea.Size = new System.Drawing.Size(761, 82);
            this.statusArea.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step1.  Select the .smm (modified .omm) file.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Step 2.  Specify the condition: start, stop and step value.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start from";
            // 
            // variable0From
            // 
            this.variable0From.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.variable0From.Location = new System.Drawing.Point(123, 190);
            this.variable0From.Name = "variable0From";
            this.variable0From.Size = new System.Drawing.Size(100, 19);
            this.variable0From.TabIndex = 7;
            this.variable0From.Text = "-0.001";
            this.variable0From.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.variable0From.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop at";
            // 
            // variable0to
            // 
            this.variable0to.Location = new System.Drawing.Point(331, 190);
            this.variable0to.Name = "variable0to";
            this.variable0to.Size = new System.Drawing.Size(100, 19);
            this.variable0to.TabIndex = 9;
            this.variable0to.Text = "0.001";
            this.variable0to.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(465, 193);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(28, 12);
            this.step.TabIndex = 10;
            this.step.Text = "Step";
            // 
            // variable0step
            // 
            this.variable0step.Location = new System.Drawing.Point(529, 190);
            this.variable0step.Name = "variable0step";
            this.variable0step.Size = new System.Drawing.Size(100, 19);
            this.variable0step.TabIndex = 11;
            this.variable0step.Text = "0.001";
            this.variable0step.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Step 3.  Commece  calculation.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.variable0step);
            this.Controls.Add(this.step);
            this.Controls.Add(this.variable0to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.variable0From);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusArea);
            this.Controls.Add(this.selectSrcButton);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Button selectSrcButton;
        private System.Windows.Forms.TextBox statusArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox variable0From;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox variable0to;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.TextBox variable0step;
        private System.Windows.Forms.Label label5;
    }
}

