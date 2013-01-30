namespace Calc
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.BoxA = new System.Windows.Forms.TextBox();
            this.BoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Form1Btn = new System.Windows.Forms.Button();
            this.Form2Btn = new System.Windows.Forms.Button();
            this.MessageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 114);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MultBtn
            // 
            this.MultBtn.Location = new System.Drawing.Point(113, 114);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(75, 23);
            this.MultBtn.TabIndex = 1;
            this.MultBtn.Text = "Multiple";
            this.MultBtn.UseVisualStyleBackColor = true;
            this.MultBtn.Click += new System.EventHandler(this.MultBtn_Click);
            // 
            // BoxA
            // 
            this.BoxA.Location = new System.Drawing.Point(63, 30);
            this.BoxA.Name = "BoxA";
            this.BoxA.Size = new System.Drawing.Size(100, 20);
            this.BoxA.TabIndex = 2;
            this.BoxA.Enter += new System.EventHandler(this.BoxAFocus);
            // 
            // BoxB
            // 
            this.BoxB.Location = new System.Drawing.Point(63, 72);
            this.BoxB.Name = "BoxB";
            this.BoxB.Size = new System.Drawing.Size(100, 20);
            this.BoxB.TabIndex = 3;
            this.BoxB.Enter += new System.EventHandler(this.BoxBFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B = ";
            // 
            // BoxResult
            // 
            this.BoxResult.Location = new System.Drawing.Point(63, 166);
            this.BoxResult.Name = "BoxResult";
            this.BoxResult.Size = new System.Drawing.Size(100, 20);
            this.BoxResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // Form1Btn
            // 
            this.Form1Btn.Location = new System.Drawing.Point(46, 231);
            this.Form1Btn.Name = "Form1Btn";
            this.Form1Btn.Size = new System.Drawing.Size(117, 23);
            this.Form1Btn.TabIndex = 8;
            this.Form1Btn.Text = "Open Form 1";
            this.Form1Btn.UseVisualStyleBackColor = true;
            this.Form1Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2Btn
            // 
            this.Form2Btn.Location = new System.Drawing.Point(46, 260);
            this.Form2Btn.Name = "Form2Btn";
            this.Form2Btn.Size = new System.Drawing.Size(117, 23);
            this.Form2Btn.TabIndex = 9;
            this.Form2Btn.Text = "Open Form 2";
            this.Form2Btn.UseVisualStyleBackColor = true;
            this.Form2Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // MessageBtn
            // 
            this.MessageBtn.Location = new System.Drawing.Point(63, 202);
            this.MessageBtn.Name = "MessageBtn";
            this.MessageBtn.Size = new System.Drawing.Size(82, 23);
            this.MessageBtn.TabIndex = 10;
            this.MessageBtn.Text = "MessageBox";
            this.MessageBtn.UseVisualStyleBackColor = true;
            this.MessageBtn.Click += new System.EventHandler(this.MessageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 300);
            this.Controls.Add(this.MessageBtn);
            this.Controls.Add(this.Form2Btn);
            this.Controls.Add(this.Form1Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxB);
            this.Controls.Add(this.BoxA);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.AddBtn);
            this.Name = "Form1";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.TextBox BoxA;
        private System.Windows.Forms.TextBox BoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Form1Btn;
        private System.Windows.Forms.Button Form2Btn;
        private System.Windows.Forms.Button MessageBtn;
    }
}

