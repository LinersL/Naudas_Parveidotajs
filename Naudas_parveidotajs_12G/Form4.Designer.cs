
namespace Naudas_parveidotajs_12G
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DzestBTN = new System.Windows.Forms.Button();
            this.RegistrsBTN = new System.Windows.Forms.Button();
            this.MainitBTN = new System.Windows.Forms.Button();
            this.NaudaDatiBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // DzestBTN
            // 
            this.DzestBTN.Location = new System.Drawing.Point(55, 244);
            this.DzestBTN.Name = "buttonDelete";
            this.DzestBTN.Size = new System.Drawing.Size(137, 47);
            this.DzestBTN.TabIndex = 2;
            this.DzestBTN.Text = "DzestDatus";
            this.DzestBTN.UseVisualStyleBackColor = true;
            this.DzestBTN.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // RegistrsBTN
            // 
            this.RegistrsBTN.Location = new System.Drawing.Point(55, 84);
            this.RegistrsBTN.Name = "buttonLoadRegistracija";
            this.RegistrsBTN.Size = new System.Drawing.Size(137, 47);
            this.RegistrsBTN.TabIndex = 3;
            this.RegistrsBTN.Text = "RegistracijasDati";
            this.RegistrsBTN.UseVisualStyleBackColor = true;
            this.RegistrsBTN.Click += new System.EventHandler(this.buttonLoadRegistracija_Click);
            // 
            // MainitBTN
            // 
            this.MainitBTN.Location = new System.Drawing.Point(55, 324);
            this.MainitBTN.Name = "MainitBTN";
            this.MainitBTN.Size = new System.Drawing.Size(137, 47);
            this.MainitBTN.TabIndex = 4;
            this.MainitBTN.Text = "MainitDatus";
            this.MainitBTN.UseVisualStyleBackColor = true;
            // 
            // NaudaDatiBTN
            // 
            this.NaudaDatiBTN.Location = new System.Drawing.Point(54, 164);
            this.NaudaDatiBTN.Name = "buttonLoadNauda";
            this.NaudaDatiBTN.Size = new System.Drawing.Size(137, 47);
            this.NaudaDatiBTN.TabIndex = 5;
            this.NaudaDatiBTN.Text = "NaudasDati";
            this.NaudaDatiBTN.UseVisualStyleBackColor = true;
            this.NaudaDatiBTN.Click += new System.EventHandler(this.buttonLoadNauda_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NaudaDatiBTN);
            this.Controls.Add(this.MainitBTN);
            this.Controls.Add(this.RegistrsBTN);
            this.Controls.Add(this.DzestBTN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DzestBTN;
        private System.Windows.Forms.Button RegistrsBTN;
        private System.Windows.Forms.Button MainitBTN;
        private System.Windows.Forms.Button NaudaDatiBTN;
    }
}