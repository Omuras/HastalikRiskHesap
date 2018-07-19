namespace stajokuluproje
{
    partial class SEKER_HASTALIGI
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
            this.aclık_skr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tok_skr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hesapla_seker_btn = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.ailedeSeker = new System.Windows.Forms.GroupBox();
            this.ailedeSeker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Açlık Kan Şekeri Değerinizi Giriniz:";
            // 
            // aclık_skr
            // 
            this.aclık_skr.BackColor = System.Drawing.Color.OldLace;
            this.aclık_skr.Location = new System.Drawing.Point(725, 237);
            this.aclık_skr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aclık_skr.Name = "aclık_skr";
            this.aclık_skr.Size = new System.Drawing.Size(164, 26);
            this.aclık_skr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tokluk Kan Şekeri Değerinizi Giriniz:";
            // 
            // tok_skr
            // 
            this.tok_skr.BackColor = System.Drawing.Color.OldLace;
            this.tok_skr.Location = new System.Drawing.Point(725, 341);
            this.tok_skr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tok_skr.Name = "tok_skr";
            this.tok_skr.Size = new System.Drawing.Size(164, 26);
            this.tok_skr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ailenizde Şeker Hastalığı Var Mı?";
            // 
            // hesapla_seker_btn
            // 
            this.hesapla_seker_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hesapla_seker_btn.Location = new System.Drawing.Point(899, 590);
            this.hesapla_seker_btn.Name = "hesapla_seker_btn";
            this.hesapla_seker_btn.Size = new System.Drawing.Size(164, 45);
            this.hesapla_seker_btn.TabIndex = 10;
            this.hesapla_seker_btn.Text = "HESAPLA";
            this.hesapla_seker_btn.UseVisualStyleBackColor = false;
            this.hesapla_seker_btn.Click += new System.EventHandler(this.hesapla);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGeri.Location = new System.Drawing.Point(1090, 590);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(97, 45);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.geriDon);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(222, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(83, 24);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "HAYIR";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(56, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 24);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "EVET";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ailedeSeker
            // 
            this.ailedeSeker.Controls.Add(this.radioButton3);
            this.ailedeSeker.Controls.Add(this.radioButton4);
            this.ailedeSeker.Location = new System.Drawing.Point(636, 441);
            this.ailedeSeker.Name = "ailedeSeker";
            this.ailedeSeker.Size = new System.Drawing.Size(384, 62);
            this.ailedeSeker.TabIndex = 12;
            this.ailedeSeker.TabStop = false;
            // 
            // SEKER_HASTALIGI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.ailedeSeker);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.hesapla_seker_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tok_skr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aclık_skr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(500, 300);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SEKER_HASTALIGI";
            this.Text = "Seker hastaligi";
            this.ailedeSeker.ResumeLayout(false);
            this.ailedeSeker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aclık_skr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tok_skr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hesapla_seker_btn;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox ailedeSeker;
    }
}