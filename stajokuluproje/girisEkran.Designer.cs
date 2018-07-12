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
            this.SuspendLayout();
            // 
            // adtext
            // 
            this.adtext.BackColor = System.Drawing.Color.OldLace;
            this.adtext.Location = new System.Drawing.Point(580, 334);
            this.adtext.Multiline = false;
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(277, 40);
            this.adtext.TabIndex = 0;
            this.adtext.TextChanged += new System.EventHandler(this.adChanged);
            // 
            // soyadtext
            // 
            this.soyadtext.BackColor = System.Drawing.Color.OldLace;
            this.soyadtext.Location = new System.Drawing.Point(580, 418);
            this.soyadtext.Multiline = false;
            this.soyadtext.Name = "soyadtext";
            this.soyadtext.Size = new System.Drawing.Size(277, 40);
            this.soyadtext.TabIndex = 1;
            this.soyadtext.TextChanged += new System.EventHandler(this.soyadChanged);
            // 
            // kullanıcıbutton
            // 
            this.kullanıcıbutton.BackColor = System.Drawing.Color.OldLace;
            this.kullanıcıbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıbutton.Location = new System.Drawing.Point(749, 516);
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
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYADI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1426, 802);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcıbutton);
            this.Controls.Add(this.soyadtext);
            this.Controls.Add(this.adtext);
            this.Name = "Form1";
            this.Text = "GİRİS";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

