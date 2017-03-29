namespace WindowsFormsApplication2
{
    partial class MasterMind
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
            this.retrieveInput = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.compare = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zaistiDarKartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSecret = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retrieveInput
            // 
            this.retrieveInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.retrieveInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.retrieveInput.Location = new System.Drawing.Point(28, 71);
            this.retrieveInput.Name = "retrieveInput";
            this.retrieveInput.Size = new System.Drawing.Size(320, 43);
            this.retrieveInput.TabIndex = 0;
            this.retrieveInput.TabStop = false;
            this.retrieveInput.Text = "Pradėti";
            this.retrieveInput.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.retrieveInput.UseVisualStyleBackColor = true;
            this.retrieveInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.Color.Peru;
            this.lstItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lstItems.ForeColor = System.Drawing.SystemColors.Info;
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 29;
            this.lstItems.Location = new System.Drawing.Point(418, 71);
            this.lstItems.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(221, 323);
            this.lstItems.TabIndex = 3;
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtGen
            // 
            this.txtGen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtGen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGen.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGen.ForeColor = System.Drawing.Color.Chocolate;
            this.txtGen.Location = new System.Drawing.Point(248, 365);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(100, 29);
            this.txtGen.TabIndex = 8;
            this.txtGen.Text = "Paslaptis";
            this.txtGen.Visible = false;
            this.txtGen.TextChanged += new System.EventHandler(this.txtGen_TextChanged);
            // 
            // compare
            // 
            this.compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.compare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.compare.Location = new System.Drawing.Point(203, 168);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(145, 42);
            this.compare.TabIndex = 9;
            this.compare.Text = "Tikrinti";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.compareNum);
            // 
            // txtGuess
            // 
            this.txtGuess.BackColor = System.Drawing.Color.Khaki;
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtGuess.Location = new System.Drawing.Point(28, 169);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(140, 38);
            this.txtGuess.TabIndex = 10;
            this.txtGuess.TextChanged += new System.EventHandler(this.txtGuess_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Peru;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtResult.Location = new System.Drawing.Point(28, 280);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(138, 30);
            this.txtResult.TabIndex = 11;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // txtResult2
            // 
            this.txtResult2.BackColor = System.Drawing.Color.Peru;
            this.txtResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtResult2.ForeColor = System.Drawing.Color.Green;
            this.txtResult2.Location = new System.Drawing.Point(28, 316);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(138, 30);
            this.txtResult2.TabIndex = 12;
            this.txtResult2.TextChanged += new System.EventHandler(this.txtResult2_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaistiDarKartaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaistiDarKartaToolStripMenuItem
            // 
            this.zaistiDarKartaToolStripMenuItem.Name = "zaistiDarKartaToolStripMenuItem";
            this.zaistiDarKartaToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.zaistiDarKartaToolStripMenuItem.Text = "Help";
            this.zaistiDarKartaToolStripMenuItem.Click += new System.EventHandler(this.zaistiDarKartaToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(203, 289);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(159, 21);
            this.radio6.TabIndex = 17;
            this.radio6.TabStop = true;
            this.radio6.Text = "6 skaitmenų skaičius";
            this.radio6.UseVisualStyleBackColor = true;
            this.radio6.CheckedChanged += new System.EventHandler(this.radio6_CheckedChanged);
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(203, 316);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(159, 21);
            this.radio4.TabIndex = 18;
            this.radio4.TabStop = true;
            this.radio4.Text = "4 skaitmenų skaičius";
            this.radio4.UseVisualStyleBackColor = true;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(418, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nr";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(451, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Spėjimas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(550, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Rezultatas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Įveskite skaičių";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnSecret
            // 
            this.btnSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSecret.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnSecret.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSecret.Location = new System.Drawing.Point(216, 357);
            this.btnSecret.Name = "btnSecret";
            this.btnSecret.Size = new System.Drawing.Size(159, 37);
            this.btnSecret.TabIndex = 23;
            this.btnSecret.Text = "Atskleisti paslaptį";
            this.btnSecret.UseVisualStyleBackColor = false;
            this.btnSecret.Click += new System.EventHandler(this.btnSecret_Click);
            // 
            // MasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(672, 437);
            this.Controls.Add(this.btnSecret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio6);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.retrieveInput);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterMind";
            this.Text = "MasterMind";
            this.Load += new System.EventHandler(this.MasterMind_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button retrieveInput;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaistiDarKartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSecret;
    }
}

