using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Naudas_parveidotajs_12G
{
    partial class Registracija
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
            this.txtVards = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtEpasts = new System.Windows.Forms.TextBox();
            this.txtParole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVards
            // 
            this.txtVards.Location = new System.Drawing.Point(161, 140);
            this.txtVards.Margin = new System.Windows.Forms.Padding(4);
            this.txtVards.Name = "txtVards";
            this.txtVards.Size = new System.Drawing.Size(175, 22);
            this.txtVards.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 205);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 1;
            // 
            // txtEpasts
            // 
            this.txtEpasts.Location = new System.Drawing.Point(161, 274);
            this.txtEpasts.Margin = new System.Windows.Forms.Padding(4);
            this.txtEpasts.Name = "txtEpasts";
            this.txtEpasts.Size = new System.Drawing.Size(175, 22);
            this.txtEpasts.TabIndex = 2;
            // 
            // txtParole
            // 
            this.txtParole.Location = new System.Drawing.Point(161, 343);
            this.txtParole.Margin = new System.Windows.Forms.Padding(4);
            this.txtParole.Name = "txtParole";
            this.txtParole.Size = new System.Drawing.Size(175, 22);
            this.txtParole.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(154, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reģistrācija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vārds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.label3.Location = new System.Drawing.Point(43, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uzvārds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(46, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-Pasts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.label5.Location = new System.Drawing.Point(50, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parole";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.button1.Location = new System.Drawing.Point(147, 447);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reģistrēties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(60)))), ((int)(((byte)(94)))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "<-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(469, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParole);
            this.Controls.Add(this.txtEpasts);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtVards);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registracija";
            this.Text = "Registracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.TextBox txtVards;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtEpasts;
        private System.Windows.Forms.TextBox txtParole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;

        public Registracija(IContainer components, TextBox txtVards, TextBox textBox2, TextBox txtEpasts, TextBox txtParole, Label label1, Label label2, Label label3, Label label4, Label label5, Button button1)
        {
            this.components = components;
            this.txtVards = txtVards;
            this.textBox2 = textBox2;
            this.txtEpasts = txtEpasts;
            this.txtParole = txtParole;
            this.label1 = label1;
            this.label2 = label2;
            this.label3 = label3;
            this.label4 = label4;
            this.label5 = label5;
            this.button1 = button1;
        }

        private Button button2;
    }
}

