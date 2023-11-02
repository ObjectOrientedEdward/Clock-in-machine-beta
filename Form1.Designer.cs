
namespace clockIn_forms
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeClock = new System.Windows.Forms.Label();
            this.clockIn = new System.Windows.Forms.Button();
            this.clockOut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeClock
            // 
            this.timeClock.AutoSize = true;
            this.timeClock.Location = new System.Drawing.Point(344, 139);
            this.timeClock.Name = "timeClock";
            this.timeClock.Size = new System.Drawing.Size(90, 17);
            this.timeClock.TabIndex = 1;
            this.timeClock.Text = "Current Time";
            this.timeClock.Click += new System.EventHandler(this.label2_Click);
            // 
            // clockIn
            // 
            this.clockIn.Location = new System.Drawing.Point(194, 217);
            this.clockIn.Name = "clockIn";
            this.clockIn.Size = new System.Drawing.Size(193, 84);
            this.clockIn.TabIndex = 2;
            this.clockIn.Text = "Clock In";
            this.clockIn.UseVisualStyleBackColor = true;
            this.clockIn.Click += new System.EventHandler(this.clockIn_Click);
            // 
            // clockOut
            // 
            this.clockOut.Location = new System.Drawing.Point(393, 217);
            this.clockOut.Name = "clockOut";
            this.clockOut.Size = new System.Drawing.Size(193, 84);
            this.clockOut.TabIndex = 3;
            this.clockOut.Text = "Clock Out";
            this.clockOut.UseVisualStyleBackColor = true;
            this.clockOut.Click += new System.EventHandler(this.clockOut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Employee:";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(532, 82);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(46, 17);
            this.labelTest.TabIndex = 6;
            this.labelTest.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(64, 82);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(12, 17);
            this.labelIn.TabIndex = 8;
            this.labelIn.Text = " ";
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(64, 116);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(12, 17);
            this.labelOut.TabIndex = 9;
            this.labelOut.Text = " ";
            this.labelOut.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(649, 404);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 34);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(64, 150);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(12, 17);
            this.labelHours.TabIndex = 11;
            this.labelHours.Text = " ";
            this.labelHours.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(64, 177);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(12, 17);
            this.labelMoney.TabIndex = 12;
            this.labelMoney.Text = " ";
            this.labelMoney.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.labelIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.clockOut);
            this.Controls.Add(this.clockIn);
            this.Controls.Add(this.timeClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeClock;
        private System.Windows.Forms.Button clockOut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button clockIn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMoney;
    }
}

