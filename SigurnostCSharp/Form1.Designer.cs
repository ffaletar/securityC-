namespace SigurnostCSharp
{
    partial class Form1
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
            this.tbKorisniskoIme = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tbKorisniskoIme
            // 
            this.tbKorisniskoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbKorisniskoIme.Location = new System.Drawing.Point(70, 60);
            this.tbKorisniskoIme.Name = "tbKorisniskoIme";
            this.tbKorisniskoIme.Size = new System.Drawing.Size(165, 26);
            this.tbKorisniskoIme.TabIndex = 0;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbLozinka.Location = new System.Drawing.Point(70, 106);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(165, 26);
            this.tbLozinka.TabIndex = 1;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrijaviSe.Location = new System.Drawing.Point(70, 148);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(165, 29);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijava";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(55, 194);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(189, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nemaš korisnički račun? Registriraj se!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 257);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbKorisniskoIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbKorisniskoIme;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

