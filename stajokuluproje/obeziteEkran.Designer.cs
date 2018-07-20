namespace stajokuluproje
{
    partial class OBEZİTE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boytext = new System.Windows.Forms.TextBox();
            this.kilotext = new System.Windows.Forms.TextBox();
            this.radiolinkButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.obezite_buton = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.linkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boy Bilginizi Giriniz (Cm) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilo Bilginizi Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet Bilginizi Seçiniz:";
            // 
            // boytext
            // 
            this.boytext.BackColor = System.Drawing.Color.OldLace;
            this.boytext.Location = new System.Drawing.Point(673, 173);
            this.boytext.MaxLength = 3;
            this.boytext.Name = "boytext";
            this.boytext.Size = new System.Drawing.Size(164, 20);
            this.boytext.TabIndex = 3;
            // 
            // kilotext
            // 
            this.kilotext.BackColor = System.Drawing.Color.OldLace;
            this.kilotext.Location = new System.Drawing.Point(673, 285);
            this.kilotext.Name = "kilotext";
            this.kilotext.Size = new System.Drawing.Size(164, 20);
            this.kilotext.TabIndex = 4;
            // 
            // radiolinkButton
            // 
            this.radiolinkButton.AutoSize = true;
            this.radiolinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiolinkButton.Location = new System.Drawing.Point(619, 413);
            this.radiolinkButton.Name = "radiolinkButton";
            this.radiolinkButton.Size = new System.Drawing.Size(81, 24);
            this.radiolinkButton.TabIndex = 5;
            this.radiolinkButton.TabStop = true;
            this.radiolinkButton.Text = "KADIN";
            this.radiolinkButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.LightCyan;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(778, 415);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ERKEK";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // obezite_buton
            // 
            this.obezite_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.obezite_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obezite_buton.Location = new System.Drawing.Point(778, 548);
            this.obezite_buton.Name = "obezite_buton";
            this.obezite_buton.Size = new System.Drawing.Size(164, 45);
            this.obezite_buton.TabIndex = 7;
            this.obezite_buton.Text = "HESAPLA";
            this.obezite_buton.UseVisualStyleBackColor = false;
            this.obezite_buton.Click += new System.EventHandler(this.hesapla);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.Location = new System.Drawing.Point(979, 548);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(113, 45);
            this.btnGeri.TabIndex = 8;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.geriDon);
            // 
            // linkButton
            // 
            this.linkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.linkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkButton.Location = new System.Drawing.Point(208, 548);
            this.linkButton.Name = "linkButton";
            this.linkButton.Size = new System.Drawing.Size(311, 45);
            this.linkButton.TabIndex = 32;
            this.linkButton.Text = "Online randevu platformu";
            this.linkButton.UseVisualStyleBackColor = false;
            this.linkButton.Click += new System.EventHandler(this.linkOpen);
            // 
            // OBEZİTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1426, 802);
            this.Controls.Add(this.linkButton);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.obezite_buton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radiolinkButton);
            this.Controls.Add(this.kilotext);
            this.Controls.Add(this.boytext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(500, 300);
            this.Name = "OBEZİTE";
            this.Text = "Obezite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boytext;
        private System.Windows.Forms.TextBox kilotext;
        private System.Windows.Forms.RadioButton radiolinkButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button obezite_buton;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button linkButton;
    }
}