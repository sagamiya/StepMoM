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
            this.boxV0from = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxV0to = new System.Windows.Forms.TextBox();
            this.step = new System.Windows.Forms.Label();
            this.boxV0step = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxV1step = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxV1to = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxV1from = new System.Windows.Forms.TextBox();
            this.boxV2step = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boxV2to = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.boxV2from = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
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
            this.label1.Size = new System.Drawing.Size(273, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step1.  雛形ファイルを選択します。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Step 2.  どの値をどの範囲で振るか指定します。";
            // 
            // boxV0from
            // 
            this.boxV0from.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV0from.Location = new System.Drawing.Point(97, 151);
            this.boxV0from.Name = "boxV0from";
            this.boxV0from.Size = new System.Drawing.Size(100, 19);
            this.boxV0from.TabIndex = 7;
            this.boxV0from.Text = "-0.001";
            this.boxV0from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.boxV0from.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "To";
            // 
            // boxV0to
            // 
            this.boxV0to.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV0to.Location = new System.Drawing.Point(253, 151);
            this.boxV0to.Name = "boxV0to";
            this.boxV0to.Size = new System.Drawing.Size(100, 19);
            this.boxV0to.TabIndex = 9;
            this.boxV0to.Text = "0.001";
            this.boxV0to.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // step
            // 
            this.step.AutoSize = true;
            this.step.Location = new System.Drawing.Point(375, 154);
            this.step.Name = "step";
            this.step.Size = new System.Drawing.Size(28, 12);
            this.step.TabIndex = 10;
            this.step.Text = "Step";
            // 
            // boxV0step
            // 
            this.boxV0step.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV0step.Location = new System.Drawing.Point(423, 151);
            this.boxV0step.Name = "boxV0step";
            this.boxV0step.Size = new System.Drawing.Size(100, 19);
            this.boxV0step.TabIndex = 11;
            this.boxV0step.Text = "0.001";
            this.boxV0step.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(29, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Step 3.  計算を実行します。";
            // 
            // boxV1step
            // 
            this.boxV1step.Enabled = false;
            this.boxV1step.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV1step.Location = new System.Drawing.Point(423, 178);
            this.boxV1step.Name = "boxV1step";
            this.boxV1step.Size = new System.Drawing.Size(100, 19);
            this.boxV1step.TabIndex = 18;
            this.boxV1step.Text = "0.001";
            this.boxV1step.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "Step";
            // 
            // boxV1to
            // 
            this.boxV1to.Enabled = false;
            this.boxV1to.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV1to.Location = new System.Drawing.Point(253, 178);
            this.boxV1to.Name = "boxV1to";
            this.boxV1to.Size = new System.Drawing.Size(100, 19);
            this.boxV1to.TabIndex = 16;
            this.boxV1to.Text = "0.001";
            this.boxV1to.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "To";
            // 
            // boxV1from
            // 
            this.boxV1from.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV1from.Location = new System.Drawing.Point(97, 178);
            this.boxV1from.Name = "boxV1from";
            this.boxV1from.Size = new System.Drawing.Size(100, 19);
            this.boxV1from.TabIndex = 14;
            this.boxV1from.Text = "-0.001";
            this.boxV1from.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // boxV2step
            // 
            this.boxV2step.Enabled = false;
            this.boxV2step.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV2step.Location = new System.Drawing.Point(423, 203);
            this.boxV2step.Name = "boxV2step";
            this.boxV2step.Size = new System.Drawing.Size(100, 19);
            this.boxV2step.TabIndex = 24;
            this.boxV2step.Text = "0.001";
            this.boxV2step.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "Step";
            // 
            // boxV2to
            // 
            this.boxV2to.Enabled = false;
            this.boxV2to.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV2to.Location = new System.Drawing.Point(253, 203);
            this.boxV2to.Name = "boxV2to";
            this.boxV2to.Size = new System.Drawing.Size(100, 19);
            this.boxV2to.TabIndex = 22;
            this.boxV2to.Text = "0.001";
            this.boxV2to.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 12);
            this.label10.TabIndex = 21;
            this.label10.Text = "To";
            // 
            // boxV2from
            // 
            this.boxV2from.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.boxV2from.Location = new System.Drawing.Point(97, 203);
            this.boxV2from.Name = "boxV2from";
            this.boxV2from.Size = new System.Drawing.Size(100, 19);
            this.boxV2from.TabIndex = 20;
            this.boxV2from.Text = "-0.001";
            this.boxV2from.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 152);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "{0}";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(53, 179);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.Text = "{1}";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(53, 204);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(35, 16);
            this.radioButton3.TabIndex = 27;
            this.radioButton3.Text = "{2}";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 431);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.boxV2step);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxV2to);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.boxV2from);
            this.Controls.Add(this.boxV1step);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxV1to);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxV1from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxV0step);
            this.Controls.Add(this.step);
            this.Controls.Add(this.boxV0to);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxV0from);
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
        private System.Windows.Forms.TextBox boxV0from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxV0to;
        private System.Windows.Forms.Label step;
        private System.Windows.Forms.TextBox boxV0step;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxV1step;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox boxV1to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxV1from;
        private System.Windows.Forms.TextBox boxV2step;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxV2to;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox boxV2from;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

