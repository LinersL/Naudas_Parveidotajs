namespace Naudas_parveidotajs_12G
{
    partial class Form3
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
            this.buttonCallApi = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSourceCurrency = new System.Windows.Forms.ComboBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.comboBoxTargetCurrency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCallApi
            // 
            this.buttonCallApi.Location = new System.Drawing.Point(15, 353);
            this.buttonCallApi.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCallApi.Name = "buttonCallApi";
            this.buttonCallApi.Size = new System.Drawing.Size(203, 36);
            this.buttonCallApi.TabIndex = 0;
            this.buttonCallApi.Text = "Pārveidot";
            this.buttonCallApi.UseVisualStyleBackColor = true;
            this.buttonCallApi.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(41, 134);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(262, 30);
            this.textBoxAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Eiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Izvēlies piemērotāko valūtu";
            // 
            // comboBoxSourceCurrency
            // 
            this.comboBoxSourceCurrency.FormattingEnabled = true;
            this.comboBoxSourceCurrency.Location = new System.Drawing.Point(41, 254);
            this.comboBoxSourceCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxSourceCurrency.Name = "comboBoxSourceCurrency";
            this.comboBoxSourceCurrency.Size = new System.Drawing.Size(397, 33);
            this.comboBoxSourceCurrency.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(296, 359);
            this.labelResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(70, 25);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "label3";
            // 
            // comboBoxTargetCurrency
            // 
            this.comboBoxTargetCurrency.FormattingEnabled = true;
            this.comboBoxTargetCurrency.Location = new System.Drawing.Point(41, 297);
            this.comboBoxTargetCurrency.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxTargetCurrency.Name = "comboBoxTargetCurrency";
            this.comboBoxTargetCurrency.Size = new System.Drawing.Size(397, 33);
            this.comboBoxTargetCurrency.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(765, 461);
            this.Controls.Add(this.comboBoxTargetCurrency);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboBoxSourceCurrency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.buttonCallApi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCallApi;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSourceCurrency;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ComboBox comboBoxTargetCurrency;
    }
}