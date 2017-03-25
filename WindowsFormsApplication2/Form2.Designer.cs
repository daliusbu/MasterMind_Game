namespace WindowsFormsApplication2
{
    partial class registrationForm
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
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.lblVardas = new System.Windows.Forms.Label();
            this.btnIssaugoti = new System.Windows.Forms.Button();
            this.lblConTest = new System.Windows.Forms.Label();
            this.listScores = new System.Windows.Forms.ListBox();
            this.lblLaikas = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVardas
            // 
            this.txtVardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtVardas.Location = new System.Drawing.Point(36, 59);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(293, 30);
            this.txtVardas.TabIndex = 0;
            this.txtVardas.Text = "JusuVardas";
            this.txtVardas.TextChanged += new System.EventHandler(this.txtVardas_TextChanged);
            // 
            // lblVardas
            // 
            this.lblVardas.AutoSize = true;
            this.lblVardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblVardas.Location = new System.Drawing.Point(33, 27);
            this.lblVardas.Name = "lblVardas";
            this.lblVardas.Size = new System.Drawing.Size(156, 20);
            this.lblVardas.TabIndex = 1;
            this.lblVardas.Text = "Įveskite savo vardą:";
            this.lblVardas.Click += new System.EventHandler(this.lblVardas_Click);
            // 
            // btnIssaugoti
            // 
            this.btnIssaugoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnIssaugoti.Location = new System.Drawing.Point(36, 109);
            this.btnIssaugoti.Name = "btnIssaugoti";
            this.btnIssaugoti.Size = new System.Drawing.Size(111, 40);
            this.btnIssaugoti.TabIndex = 2;
            this.btnIssaugoti.Text = "Išsaugoti";
            this.btnIssaugoti.UseVisualStyleBackColor = true;
            this.btnIssaugoti.Click += new System.EventHandler(this.btnIssaugoti_Click);
            // 
            // lblConTest
            // 
            this.lblConTest.AutoSize = true;
            this.lblConTest.Location = new System.Drawing.Point(12, 369);
            this.lblConTest.Name = "lblConTest";
            this.lblConTest.Size = new System.Drawing.Size(106, 17);
            this.lblConTest.TabIndex = 3;
            this.lblConTest.Text = "Connection test";
            // 
            // listScores
            // 
            this.listScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.listScores.FormattingEnabled = true;
            this.listScores.ItemHeight = 22;
            this.listScores.Location = new System.Drawing.Point(12, 178);
            this.listScores.Name = "listScores";
            this.listScores.Size = new System.Drawing.Size(369, 180);
            this.listScores.TabIndex = 4;
            // 
            // lblLaikas
            // 
            this.lblLaikas.AutoSize = true;
            this.lblLaikas.Location = new System.Drawing.Point(303, 369);
            this.lblLaikas.Name = "lblLaikas";
            this.lblLaikas.Size = new System.Drawing.Size(78, 17);
            this.lblLaikas.TabIndex = 5;
            this.lblLaikas.Text = "Jusu laikas";
            this.lblLaikas.Click += new System.EventHandler(this.lblLaikas_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnExit.Location = new System.Drawing.Point(216, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Grįžti";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 395);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblLaikas);
            this.Controls.Add(this.listScores);
            this.Controls.Add(this.lblConTest);
            this.Controls.Add(this.btnIssaugoti);
            this.Controls.Add(this.lblVardas);
            this.Controls.Add(this.txtVardas);
            this.Name = "registrationForm";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.regitrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.Label lblVardas;
        private System.Windows.Forms.Button btnIssaugoti;
        private System.Windows.Forms.Label lblConTest;
        private System.Windows.Forms.ListBox listScores;
        private System.Windows.Forms.Label lblLaikas;
        private System.Windows.Forms.Button btnExit;
    }
}