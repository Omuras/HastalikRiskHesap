namespace stajokuluproje
{
    partial class HASTALIK_SECİMİ
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
            this.sekeregirisbutton = new System.Windows.Forms.Button();
            this.obezitegirisbutton = new System.Windows.Forms.Button();
            this.kalpgirisbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Aşağıdaki Hastalıklardan Birini Seçiniz.";
            // 
            // sekeregirisbutton
            // 
            this.sekeregirisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sekeregirisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekeregirisbutton.Location = new System.Drawing.Point(352, 193);
            this.sekeregirisbutton.Name = "sekeregirisbutton";
            this.sekeregirisbutton.Size = new System.Drawing.Size(235, 45);
            this.sekeregirisbutton.TabIndex = 1;
            this.sekeregirisbutton.Text = "ŞEKER HASTALIĞI";
            this.sekeregirisbutton.UseVisualStyleBackColor = false;
            this.sekeregirisbutton.Click += new System.EventHandler(this.sekerGiris);
            //this.kalpgirisbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sekerGiris);
  
            // 
            // obezitegirisbutton
            // 
            this.obezitegirisbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.obezitegirisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obezitegirisbutton.Location = new System.Drawing.Point(589, 297);
            this.obezitegirisbutton.Name = "obezitegirisbutton";
            this.obezitegirisbutton.Size = new System.Drawing.Size(240, 42);
            this.obezitegirisbutton.TabIndex = 2;
            this.obezitegirisbutton.Text = "OBEZİTE";
            this.obezitegirisbutton.UseVisualStyleBackColor = false;
            // this.kalpgirisbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obeziteGiris);
            this.obezitegirisbutton.Click += new System.EventHandler(this.obeziteGiris);

            // 
            // kalpgirisbutton
            // 
            this.kalpgirisbutton.BackColor = System.Drawing.Color.PapayaWhip;
            this.kalpgirisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kalpgirisbutton.Location = new System.Drawing.Point(830, 406);
            this.kalpgirisbutton.Name = "kalpgirisbutton";
            this.kalpgirisbutton.Size = new System.Drawing.Size(233, 45);
            this.kalpgirisbutton.TabIndex = 3;
            this.kalpgirisbutton.Text = "KALP HASTALIĞI";
            this.kalpgirisbutton.UseVisualStyleBackColor = false;
            this.kalpgirisbutton.Click += new System.EventHandler(this.kalpGiris);
            //this.kalpgirisbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kalpGiris);
            // 
            // HASTALIK_SECİMİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1426, 802);
            this.Controls.Add(this.kalpgirisbutton);
            this.Controls.Add(this.obezitegirisbutton);
            this.Controls.Add(this.sekeregirisbutton);
            this.Controls.Add(this.label1);
            this.Name = "HASTALIK_SECİMİ";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sekeregirisbutton;
        private System.Windows.Forms.Button obezitegirisbutton;
        private System.Windows.Forms.Button kalpgirisbutton;
    }
}