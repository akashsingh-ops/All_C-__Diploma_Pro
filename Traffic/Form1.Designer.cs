namespace Traffic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redtoplight = new System.Windows.Forms.PictureBox();
            this.yellowlight = new System.Windows.Forms.PictureBox();
            this.greenlight = new System.Windows.Forms.PictureBox();
            this.btnstop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redtoplight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).BeginInit();
            this.SuspendLayout();
            // 
            // redtoplight
            // 
            this.redtoplight.Image = ((System.Drawing.Image)(resources.GetObject("redtoplight.Image")));
            this.redtoplight.Location = new System.Drawing.Point(227, 47);
            this.redtoplight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.redtoplight.Name = "redtoplight";
            this.redtoplight.Size = new System.Drawing.Size(246, 205);
            this.redtoplight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redtoplight.TabIndex = 0;
            this.redtoplight.TabStop = false;
            // 
            // yellowlight
            // 
            this.yellowlight.Image = ((System.Drawing.Image)(resources.GetObject("yellowlight.Image")));
            this.yellowlight.Location = new System.Drawing.Point(227, 47);
            this.yellowlight.Name = "yellowlight";
            this.yellowlight.Size = new System.Drawing.Size(246, 205);
            this.yellowlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yellowlight.TabIndex = 1;
            this.yellowlight.TabStop = false;
            // 
            // greenlight
            // 
            this.greenlight.Image = ((System.Drawing.Image)(resources.GetObject("greenlight.Image")));
            this.greenlight.Location = new System.Drawing.Point(227, 47);
            this.greenlight.Name = "greenlight";
            this.greenlight.Size = new System.Drawing.Size(246, 205);
            this.greenlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenlight.TabIndex = 2;
            this.greenlight.TabStop = false;
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnstop.Location = new System.Drawing.Point(471, 47);
            this.btnstop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(61, 36);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox1.Location = new System.Drawing.Point(626, 146);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(62, 28);
            this.TextBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(552, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.greenlight);
            this.Controls.Add(this.yellowlight);
            this.Controls.Add(this.redtoplight);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.redtoplight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenlight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redtoplight;
        private System.Windows.Forms.PictureBox yellowlight;
        private System.Windows.Forms.PictureBox greenlight;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
    }
}

