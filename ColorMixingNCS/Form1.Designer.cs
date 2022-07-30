namespace ColorMixingNCS
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ncs_lbl = new System.Windows.Forms.Label();
            this.rgb_lbl = new System.Windows.Forms.Label();
            this.rgb_lbl_val = new System.Windows.Forms.Label();
            this.currentColorPct = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.targetColorPct = new System.Windows.Forms.PictureBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetColorPct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "90,15,38";
            // 
            // ncs_lbl
            // 
            this.ncs_lbl.AutoSize = true;
            this.ncs_lbl.Location = new System.Drawing.Point(12, 15);
            this.ncs_lbl.Name = "ncs_lbl";
            this.ncs_lbl.Size = new System.Drawing.Size(29, 13);
            this.ncs_lbl.TabIndex = 1;
            this.ncs_lbl.Text = "RYB";
            // 
            // rgb_lbl
            // 
            this.rgb_lbl.AutoSize = true;
            this.rgb_lbl.Location = new System.Drawing.Point(324, 131);
            this.rgb_lbl.Name = "rgb_lbl";
            this.rgb_lbl.Size = new System.Drawing.Size(30, 13);
            this.rgb_lbl.TabIndex = 2;
            this.rgb_lbl.Text = "RGB";
            // 
            // rgb_lbl_val
            // 
            this.rgb_lbl_val.AutoSize = true;
            this.rgb_lbl_val.Location = new System.Drawing.Point(375, 131);
            this.rgb_lbl_val.Name = "rgb_lbl_val";
            this.rgb_lbl_val.Size = new System.Drawing.Size(16, 13);
            this.rgb_lbl_val.TabIndex = 3;
            this.rgb_lbl_val.Text = "...";
            // 
            // currentColorPct
            // 
            this.currentColorPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentColorPct.Location = new System.Drawing.Point(215, 131);
            this.currentColorPct.Name = "currentColorPct";
            this.currentColorPct.Size = new System.Drawing.Size(103, 90);
            this.currentColorPct.TabIndex = 4;
            this.currentColorPct.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(168, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(142, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "P";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(201, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "P";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Purple;
            this.button4.Location = new System.Drawing.Point(168, 500);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 51);
            this.button4.TabIndex = 8;
            this.button4.Text = "S";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.Location = new System.Drawing.Point(74, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 51);
            this.button5.TabIndex = 9;
            this.button5.Text = "S";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.OrangeRed;
            this.button6.Location = new System.Drawing.Point(262, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 51);
            this.button6.TabIndex = 10;
            this.button6.Text = "S";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.GreenYellow;
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(121, 265);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 51);
            this.button7.TabIndex = 11;
            this.button7.Text = "T";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Orange;
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(210, 265);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 51);
            this.button8.TabIndex = 12;
            this.button8.Text = "T";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkGreen;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(23, 417);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 51);
            this.button9.TabIndex = 13;
            this.button9.Text = "T";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkOrange;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(321, 417);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 51);
            this.button10.TabIndex = 14;
            this.button10.Text = "T";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Indigo;
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(87, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 51);
            this.button11.TabIndex = 15;
            this.button11.Text = "T";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Magenta;
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(250, 522);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(53, 51);
            this.button12.TabIndex = 16;
            this.button12.Text = "T";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 239);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ml";
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(15, 63);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(151, 20);
            this.button14.TabIndex = 20;
            this.button14.Text = "Generovat náhodnou cílovou";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // targetColorPct
            // 
            this.targetColorPct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetColorPct.Location = new System.Drawing.Point(94, 131);
            this.targetColorPct.Name = "targetColorPct";
            this.targetColorPct.Size = new System.Drawing.Size(103, 90);
            this.targetColorPct.TabIndex = 21;
            this.targetColorPct.TabStop = false;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 37);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 20);
            this.button15.TabIndex = 22;
            this.button15.Text = "Nastavit cilovou";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "...";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(351, 268);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 45);
            this.button16.TabIndex = 24;
            this.button16.Text = "Bílá";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "5000 ml";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(476, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(206, 563);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(298, 38);
            this.trackBar1.Maximum = 20000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.Value = 10000;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Cílová";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Aktuální";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "RYB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Síla pigmentu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "10000";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(351, 319);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 45);
            this.button13.TabIndex = 33;
            this.button13.Text = "Černá";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 585);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.targetColorPct);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentColorPct);
            this.Controls.Add(this.rgb_lbl_val);
            this.Controls.Add(this.rgb_lbl);
            this.Controls.Add(this.ncs_lbl);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Míchání barev";
            ((System.ComponentModel.ISupportInitialize)(this.currentColorPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetColorPct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ncs_lbl;
        private System.Windows.Forms.Label rgb_lbl;
        private System.Windows.Forms.Label rgb_lbl_val;
        private System.Windows.Forms.PictureBox currentColorPct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox targetColorPct;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button13;
    }
}

