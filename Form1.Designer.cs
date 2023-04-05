namespace Upotreba_radio_dugmeta
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
            this.rbtZelena = new System.Windows.Forms.RadioButton();
            this.rbtPlava = new System.Windows.Forms.RadioButton();
            this.rbtZuta = new System.Windows.Forms.RadioButton();
            this.rbtCrvena = new System.Windows.Forms.RadioButton();
            this.rbtSiva = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtZelena
            // 
            this.rbtZelena.AutoSize = true;
            this.rbtZelena.Location = new System.Drawing.Point(32, 54);
            this.rbtZelena.Name = "rbtZelena";
            this.rbtZelena.Size = new System.Drawing.Size(58, 19);
            this.rbtZelena.TabIndex = 0;
            this.rbtZelena.TabStop = true;
            this.rbtZelena.Text = "zelena";
            this.rbtZelena.UseVisualStyleBackColor = true;
            // 
            // rbtPlava
            // 
            this.rbtPlava.AutoSize = true;
            this.rbtPlava.Location = new System.Drawing.Point(32, 107);
            this.rbtPlava.Name = "rbtPlava";
            this.rbtPlava.Size = new System.Drawing.Size(53, 19);
            this.rbtPlava.TabIndex = 1;
            this.rbtPlava.TabStop = true;
            this.rbtPlava.Text = "plava";
            this.rbtPlava.UseVisualStyleBackColor = true;
            // 
            // rbtZuta
            // 
            this.rbtZuta.AutoSize = true;
            this.rbtZuta.Location = new System.Drawing.Point(32, 165);
            this.rbtZuta.Name = "rbtZuta";
            this.rbtZuta.Size = new System.Drawing.Size(47, 19);
            this.rbtZuta.TabIndex = 2;
            this.rbtZuta.TabStop = true;
            this.rbtZuta.Text = "zuta";
            this.rbtZuta.UseVisualStyleBackColor = true;
            // 
            // rbtCrvena
            // 
            this.rbtCrvena.AutoSize = true;
            this.rbtCrvena.Location = new System.Drawing.Point(32, 220);
            this.rbtCrvena.Name = "rbtCrvena";
            this.rbtCrvena.Size = new System.Drawing.Size(60, 19);
            this.rbtCrvena.TabIndex = 3;
            this.rbtCrvena.TabStop = true;
            this.rbtCrvena.Text = "crvena";
            this.rbtCrvena.UseVisualStyleBackColor = true;
            // 
            // rbtSiva
            // 
            this.rbtSiva.AutoSize = true;
            this.rbtSiva.Location = new System.Drawing.Point(32, 279);
            this.rbtSiva.Name = "rbtSiva";
            this.rbtSiva.Size = new System.Drawing.Size(45, 19);
            this.rbtSiva.TabIndex = 4;
            this.rbtSiva.TabStop = true;
            this.rbtSiva.Text = "siva";
            this.rbtSiva.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Promeni boju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtSiva);
            this.Controls.Add(this.rbtCrvena);
            this.Controls.Add(this.rbtZuta);
            this.Controls.Add(this.rbtPlava);
            this.Controls.Add(this.rbtZelena);
            this.Name = "Form1";
            this.Text = "Odaberi boju pozadine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton rbtZelena;
        public RadioButton rbtPlava;
        private RadioButton rbtZuta;
        private RadioButton rbtCrvena;
        private RadioButton rbtSiva;
        private Button button1;
    }
}