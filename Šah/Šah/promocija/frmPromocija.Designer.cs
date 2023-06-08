namespace Šah.promocija
{
    partial class frmPromocija
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
            this.btnBishop = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnKnight = new System.Windows.Forms.Button();
            this.btnKraljica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBishop
            // 
            this.btnBishop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBishop.Location = new System.Drawing.Point(150, 47);
            this.btnBishop.Margin = new System.Windows.Forms.Padding(0);
            this.btnBishop.Name = "btnBishop";
            this.btnBishop.Size = new System.Drawing.Size(80, 80);
            this.btnBishop.TabIndex = 9;
            this.btnBishop.UseVisualStyleBackColor = false;
            this.btnBishop.Click += new System.EventHandler(this.btnBishop_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTop.Location = new System.Drawing.Point(242, 47);
            this.btnTop.Margin = new System.Windows.Forms.Padding(0);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(80, 80);
            this.btnTop.TabIndex = 10;
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnKnight
            // 
            this.btnKnight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKnight.Location = new System.Drawing.Point(333, 47);
            this.btnKnight.Margin = new System.Windows.Forms.Padding(0);
            this.btnKnight.Name = "btnKnight";
            this.btnKnight.Size = new System.Drawing.Size(80, 80);
            this.btnKnight.TabIndex = 11;
            this.btnKnight.UseVisualStyleBackColor = false;
            this.btnKnight.Click += new System.EventHandler(this.btnKnight_Click);
            // 
            // btnKraljica
            // 
            this.btnKraljica.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKraljica.Location = new System.Drawing.Point(59, 47);
            this.btnKraljica.Margin = new System.Windows.Forms.Padding(0);
            this.btnKraljica.Name = "btnKraljica";
            this.btnKraljica.Size = new System.Drawing.Size(80, 80);
            this.btnKraljica.TabIndex = 12;
            this.btnKraljica.UseVisualStyleBackColor = false;
            this.btnKraljica.Click += new System.EventHandler(this.btnKraljica_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Izaberite figuru";
            // 
            // frmPromocija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 168);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKraljica);
            this.Controls.Add(this.btnKnight);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnBishop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPromocija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPromocija";
            this.Load += new System.EventHandler(this.frmPromocija_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBishop;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnKnight;
        private System.Windows.Forms.Button btnKraljica;
        private System.Windows.Forms.Label label1;
    }
}