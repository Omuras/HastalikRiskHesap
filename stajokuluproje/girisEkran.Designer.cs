namespace stajokuluproje
{
    partial class girisEkran
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
            this.adtext = new System.Windows.Forms.TextBox();
            this.soyadtext = new System.Windows.Forms.TextBox();
            this.kullanıcıbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adtext
            // 
            this.adtext.BackColor = System.Drawing.Color.OldLace;
            this.adtext.Location = new System.Drawing.Point(583, 242);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(277, 20);
            this.adtext.TabIndex = 0;
            // 
            // soyadtext
            // 
            this.soyadtext.BackColor = System.Drawing.Color.OldLace;
            this.soyadtext.Location = new System.Drawing.Point(583, 328);
            this.soyadtext.Name = "soyadtext";
            this.soyadtext.Size = new System.Drawing.Size(277, 20);
            this.soyadtext.TabIndex = 1;
            // 
            // kullanıcıbutton
            // 
            this.kullanıcıbutton.BackColor = System.Drawing.Color.OldLace;
            this.kullanıcıbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıbutton.Location = new System.Drawing.Point(693, 520);
            this.kullanıcıbutton.Name = "kullanıcıbutton";
            this.kullanıcıbutton.Size = new System.Drawing.Size(164, 45);
            this.kullanıcıbutton.TabIndex = 2;
            this.kullanıcıbutton.Text = "KAYDET";
            this.kullanıcıbutton.UseVisualStyleBackColor = false;
            this.kullanıcıbutton.Click += new System.EventHandler(this.Kaydet_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ADI                              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYADI                       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TELEFON NUMARASI : ";
            // 
            // numberText
            // 
            this.numberText.BackColor = System.Drawing.Color.OldLace;
            this.numberText.Location = new System.Drawing.Point(583, 400);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(277, 20);
            this.numberText.TabIndex = 7;
            // 
            // girisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1426, 802);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcıbutton);
            this.Controls.Add(this.soyadtext);
            this.Controls.Add(this.adtext);
            this.Location = new System.Drawing.Point(500, 300);
            this.Name = "girisEkran";
            this.Text = "GİRİS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adtext;
        private System.Windows.Forms.TextBox soyadtext;
        private System.Windows.Forms.Button kullanıcıbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberText;
    }
}

