namespace StopUhr
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xstart = new System.Windows.Forms.Button();
            this.xstop = new System.Windows.Forms.Button();
            this.xreset = new System.Windows.Forms.Button();
            this.lmin = new System.Windows.Forms.Label();
            this.lsec = new System.Windows.Forms.Label();
            this.lmsec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xstart
            // 
            this.xstart.Location = new System.Drawing.Point(25, 144);
            this.xstart.Name = "xstart";
            this.xstart.Size = new System.Drawing.Size(75, 23);
            this.xstart.TabIndex = 0;
            this.xstart.Text = "Start";
            this.xstart.UseVisualStyleBackColor = true;
            this.xstart.Click += new System.EventHandler(this.xstart_Click);
            // 
            // xstop
            // 
            this.xstop.Location = new System.Drawing.Point(127, 144);
            this.xstop.Name = "xstop";
            this.xstop.Size = new System.Drawing.Size(75, 23);
            this.xstop.TabIndex = 1;
            this.xstop.Text = "Stop";
            this.xstop.UseVisualStyleBackColor = true;
            this.xstop.Click += new System.EventHandler(this.xstop_Click);
            // 
            // xreset
            // 
            this.xreset.Location = new System.Drawing.Point(228, 144);
            this.xreset.Name = "xreset";
            this.xreset.Size = new System.Drawing.Size(75, 23);
            this.xreset.TabIndex = 2;
            this.xreset.Text = "Reset";
            this.xreset.UseVisualStyleBackColor = true;
            this.xreset.Click += new System.EventHandler(this.xreset_Click);
            // 
            // lmin
            // 
            this.lmin.AutoSize = true;
            this.lmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmin.Location = new System.Drawing.Point(80, 62);
            this.lmin.Name = "lmin";
            this.lmin.Size = new System.Drawing.Size(57, 39);
            this.lmin.TabIndex = 3;
            this.lmin.Text = "00";
            // 
            // lsec
            // 
            this.lsec.AutoSize = true;
            this.lsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsec.Location = new System.Drawing.Point(143, 62);
            this.lsec.Name = "lsec";
            this.lsec.Size = new System.Drawing.Size(57, 39);
            this.lsec.TabIndex = 5;
            this.lsec.Text = "00";
            // 
            // lmsec
            // 
            this.lmsec.AutoSize = true;
            this.lmsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmsec.Location = new System.Drawing.Point(217, 70);
            this.lmsec.Name = "lmsec";
            this.lmsec.Size = new System.Drawing.Size(41, 29);
            this.lmsec.TabIndex = 7;
            this.lmsec.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Timer in Sec";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(328, 183);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lmsec);
            this.Controls.Add(this.lsec);
            this.Controls.Add(this.lmin);
            this.Controls.Add(this.xreset);
            this.Controls.Add(this.xstop);
            this.Controls.Add(this.xstart);
            this.Name = "Form1";
            this.Text = "Stoppuhr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xstart;
        private System.Windows.Forms.Button xstop;
        private System.Windows.Forms.Button xreset;
        private System.Windows.Forms.Label lmin;
        private System.Windows.Forms.Label lsec;
        private System.Windows.Forms.Label lmsec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

