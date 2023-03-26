namespace WindowsFormsApp2
{
    partial class Form2
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
            this.btnEv = new System.Windows.Forms.Button();
            this.btnIs = new System.Windows.Forms.Button();
            this.btnOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEv
            // 
            this.btnEv.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEv.FlatAppearance.BorderSize = 0;
            this.btnEv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEv.Location = new System.Drawing.Point(28, 54);
            this.btnEv.Name = "btnEv";
            this.btnEv.Size = new System.Drawing.Size(161, 49);
            this.btnEv.TabIndex = 15;
            this.btnEv.Text = "Ev İçin Kullanım";
            this.btnEv.UseVisualStyleBackColor = false;
            this.btnEv.Click += new System.EventHandler(this.btnEv_Click);
            // 
            // btnIs
            // 
            this.btnIs.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIs.FlatAppearance.BorderSize = 0;
            this.btnIs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIs.Location = new System.Drawing.Point(195, 54);
            this.btnIs.Name = "btnIs";
            this.btnIs.Size = new System.Drawing.Size(161, 49);
            this.btnIs.TabIndex = 15;
            this.btnIs.Text = "İş İçin Kullanım";
            this.btnIs.UseVisualStyleBackColor = false;
            this.btnIs.Click += new System.EventHandler(this.btnIs_Click);
            // 
            // btnOyun
            // 
            this.btnOyun.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOyun.FlatAppearance.BorderSize = 0;
            this.btnOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOyun.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOyun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOyun.Location = new System.Drawing.Point(362, 54);
            this.btnOyun.Name = "btnOyun";
            this.btnOyun.Size = new System.Drawing.Size(161, 49);
            this.btnOyun.TabIndex = 15;
            this.btnOyun.Text = "Oyun İçin Kullanım";
            this.btnOyun.UseVisualStyleBackColor = false;
            this.btnOyun.Click += new System.EventHandler(this.btnOyun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hangisine Göre Bilgisayar Toplamak İstiyorsunuz ?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(557, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOyun);
            this.Controls.Add(this.btnIs);
            this.Controls.Add(this.btnEv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEv;
        private System.Windows.Forms.Button btnIs;
        private System.Windows.Forms.Button btnOyun;
        private System.Windows.Forms.Label label1;
    }
}