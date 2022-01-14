
namespace Dualsystem
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox64 = new System.Windows.Forms.CheckBox();
            this.checkBox128 = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtBoxSeachValue = new System.Windows.Forms.NumericUpDown();
            this.lblSeach = new System.Windows.Forms.Label();
            this.lblBin128 = new System.Windows.Forms.Label();
            this.lblBin64 = new System.Windows.Forms.Label();
            this.lblBin32 = new System.Windows.Forms.Label();
            this.lblBin16 = new System.Windows.Forms.Label();
            this.lblBin4 = new System.Windows.Forms.Label();
            this.lblBin2 = new System.Windows.Forms.Label();
            this.lblBin8 = new System.Windows.Forms.Label();
            this.lblBin1 = new System.Windows.Forms.Label();
            this.lblSeachBinary = new System.Windows.Forms.Label();
            this.txtBoxSeachBinaryValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxSeachValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxSeachBinaryValue)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(374, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(330, 80);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 21);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(286, 80);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(38, 21);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(242, 80);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(38, 21);
            this.checkBox8.TabIndex = 21;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(190, 80);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(46, 21);
            this.checkBox16.TabIndex = 22;
            this.checkBox16.Text = "16";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(138, 80);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(46, 21);
            this.checkBox32.TabIndex = 23;
            this.checkBox32.Text = "32";
            this.checkBox32.UseVisualStyleBackColor = true;
            this.checkBox32.CheckedChanged += new System.EventHandler(this.checkBox32_CheckedChanged);
            // 
            // checkBox64
            // 
            this.checkBox64.AutoSize = true;
            this.checkBox64.Location = new System.Drawing.Point(86, 80);
            this.checkBox64.Name = "checkBox64";
            this.checkBox64.Size = new System.Drawing.Size(46, 21);
            this.checkBox64.TabIndex = 24;
            this.checkBox64.Text = "64";
            this.checkBox64.UseVisualStyleBackColor = true;
            this.checkBox64.CheckedChanged += new System.EventHandler(this.checkBox64_CheckedChanged);
            // 
            // checkBox128
            // 
            this.checkBox128.AutoSize = true;
            this.checkBox128.Location = new System.Drawing.Point(26, 80);
            this.checkBox128.Name = "checkBox128";
            this.checkBox128.Size = new System.Drawing.Size(54, 21);
            this.checkBox128.TabIndex = 25;
            this.checkBox128.Text = "128";
            this.checkBox128.UseVisualStyleBackColor = true;
            this.checkBox128.CheckedChanged += new System.EventHandler(this.checkBox128_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(23, 22);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(17, 17);
            this.lblResult.TabIndex = 26;
            this.lblResult.Text = "0";
            // 
            // txtBoxSeachValue
            // 
            this.txtBoxSeachValue.Location = new System.Drawing.Point(474, 79);
            this.txtBoxSeachValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.txtBoxSeachValue.Name = "txtBoxSeachValue";
            this.txtBoxSeachValue.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSeachValue.TabIndex = 27;
            this.txtBoxSeachValue.ValueChanged += new System.EventHandler(this.txtBoxSeachValue_ValueChanged);
            // 
            // lblSeach
            // 
            this.lblSeach.AutoSize = true;
            this.lblSeach.Location = new System.Drawing.Point(420, 81);
            this.lblSeach.Name = "lblSeach";
            this.lblSeach.Size = new System.Drawing.Size(48, 17);
            this.lblSeach.TabIndex = 28;
            this.lblSeach.Text = "Suche";
            // 
            // lblBin128
            // 
            this.lblBin128.AutoSize = true;
            this.lblBin128.Location = new System.Drawing.Point(23, 124);
            this.lblBin128.Name = "lblBin128";
            this.lblBin128.Size = new System.Drawing.Size(16, 17);
            this.lblBin128.TabIndex = 29;
            this.lblBin128.Text = "0";
            // 
            // lblBin64
            // 
            this.lblBin64.AutoSize = true;
            this.lblBin64.Location = new System.Drawing.Point(83, 124);
            this.lblBin64.Name = "lblBin64";
            this.lblBin64.Size = new System.Drawing.Size(16, 17);
            this.lblBin64.TabIndex = 30;
            this.lblBin64.Text = "0";
            this.lblBin64.Click += new System.EventHandler(this.lblBin64_Click);
            // 
            // lblBin32
            // 
            this.lblBin32.AutoSize = true;
            this.lblBin32.Location = new System.Drawing.Point(135, 124);
            this.lblBin32.Name = "lblBin32";
            this.lblBin32.Size = new System.Drawing.Size(16, 17);
            this.lblBin32.TabIndex = 31;
            this.lblBin32.Text = "0";
            // 
            // lblBin16
            // 
            this.lblBin16.AutoSize = true;
            this.lblBin16.Location = new System.Drawing.Point(187, 124);
            this.lblBin16.Name = "lblBin16";
            this.lblBin16.Size = new System.Drawing.Size(16, 17);
            this.lblBin16.TabIndex = 32;
            this.lblBin16.Text = "0";
            // 
            // lblBin4
            // 
            this.lblBin4.AutoSize = true;
            this.lblBin4.Location = new System.Drawing.Point(283, 124);
            this.lblBin4.Name = "lblBin4";
            this.lblBin4.Size = new System.Drawing.Size(16, 17);
            this.lblBin4.TabIndex = 33;
            this.lblBin4.Text = "0";
            // 
            // lblBin2
            // 
            this.lblBin2.AutoSize = true;
            this.lblBin2.Location = new System.Drawing.Point(327, 124);
            this.lblBin2.Name = "lblBin2";
            this.lblBin2.Size = new System.Drawing.Size(16, 17);
            this.lblBin2.TabIndex = 34;
            this.lblBin2.Text = "0";
            // 
            // lblBin8
            // 
            this.lblBin8.AutoSize = true;
            this.lblBin8.Location = new System.Drawing.Point(239, 124);
            this.lblBin8.Name = "lblBin8";
            this.lblBin8.Size = new System.Drawing.Size(16, 17);
            this.lblBin8.TabIndex = 35;
            this.lblBin8.Text = "0";
            // 
            // lblBin1
            // 
            this.lblBin1.AutoSize = true;
            this.lblBin1.Location = new System.Drawing.Point(371, 124);
            this.lblBin1.Name = "lblBin1";
            this.lblBin1.Size = new System.Drawing.Size(16, 17);
            this.lblBin1.TabIndex = 36;
            this.lblBin1.Text = "0";
            // 
            // lblSeachBinary
            // 
            this.lblSeachBinary.AutoSize = true;
            this.lblSeachBinary.Location = new System.Drawing.Point(420, 124);
            this.lblSeachBinary.Name = "lblSeachBinary";
            this.lblSeachBinary.Size = new System.Drawing.Size(48, 17);
            this.lblSeachBinary.TabIndex = 38;
            this.lblSeachBinary.Text = "Suche";
            // 
            // txtBoxSeachBinaryValue
            // 
            this.txtBoxSeachBinaryValue.Location = new System.Drawing.Point(474, 124);
            this.txtBoxSeachBinaryValue.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.txtBoxSeachBinaryValue.Name = "txtBoxSeachBinaryValue";
            this.txtBoxSeachBinaryValue.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSeachBinaryValue.TabIndex = 37;
            this.txtBoxSeachBinaryValue.ValueChanged += new System.EventHandler(this.txtBoxSeachBinaryValue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 180);
            this.Controls.Add(this.lblSeachBinary);
            this.Controls.Add(this.txtBoxSeachBinaryValue);
            this.Controls.Add(this.lblBin1);
            this.Controls.Add(this.lblBin8);
            this.Controls.Add(this.lblBin2);
            this.Controls.Add(this.lblBin4);
            this.Controls.Add(this.lblBin16);
            this.Controls.Add(this.lblBin32);
            this.Controls.Add(this.lblBin64);
            this.Controls.Add(this.lblBin128);
            this.Controls.Add(this.lblSeach);
            this.Controls.Add(this.txtBoxSeachValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.checkBox128);
            this.Controls.Add(this.checkBox64);
            this.Controls.Add(this.checkBox32);
            this.Controls.Add(this.checkBox16);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Dualsystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxSeachValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxSeachBinaryValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.CheckBox checkBox64;
        private System.Windows.Forms.CheckBox checkBox128;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown txtBoxSeachValue;
        private System.Windows.Forms.Label lblSeach;
        private System.Windows.Forms.Label lblBin128;
        private System.Windows.Forms.Label lblBin64;
        private System.Windows.Forms.Label lblBin32;
        private System.Windows.Forms.Label lblBin16;
        private System.Windows.Forms.Label lblBin4;
        private System.Windows.Forms.Label lblBin2;
        private System.Windows.Forms.Label lblBin8;
        private System.Windows.Forms.Label lblBin1;
        private System.Windows.Forms.Label lblSeachBinary;
        private System.Windows.Forms.NumericUpDown txtBoxSeachBinaryValue;
    }
}

