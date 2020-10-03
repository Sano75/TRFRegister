namespace TRF
{
    partial class Inloggning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inloggning));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.btnLoggin = new System.Windows.Forms.Button();
            this.btnNyReg = new System.Windows.Forms.Button();
            this.lblTRF = new System.Windows.Forms.LinkLabel();
            this.lblSSG = new System.Windows.Forms.LinkLabel();
            this.txtinlognamn = new System.Windows.Forms.TextBox();
            this.txtinloglord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxInloggTyp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 473);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvsluta.ForeColor = System.Drawing.Color.Red;
            this.btnAvsluta.Location = new System.Drawing.Point(392, 420);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(114, 30);
            this.btnAvsluta.TabIndex = 7;
            this.btnAvsluta.Text = "&Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // btnLoggin
            // 
            this.btnLoggin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoggin.ForeColor = System.Drawing.Color.Green;
            this.btnLoggin.Location = new System.Drawing.Point(18, 392);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(151, 30);
            this.btnLoggin.TabIndex = 3;
            this.btnLoggin.Text = "&Logga in";
            this.btnLoggin.UseVisualStyleBackColor = true;
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // btnNyReg
            // 
            this.btnNyReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNyReg.ForeColor = System.Drawing.Color.Navy;
            this.btnNyReg.Location = new System.Drawing.Point(211, 392);
            this.btnNyReg.Name = "btnNyReg";
            this.btnNyReg.Size = new System.Drawing.Size(154, 30);
            this.btnNyReg.TabIndex = 4;
            this.btnNyReg.Text = "&Registrera";
            this.btnNyReg.UseVisualStyleBackColor = true;
            this.btnNyReg.Click += new System.EventHandler(this.btnNyReg_Click);
            // 
            // lblTRF
            // 
            this.lblTRF.AutoSize = true;
            this.lblTRF.BackColor = System.Drawing.Color.Transparent;
            this.lblTRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRF.Location = new System.Drawing.Point(12, 448);
            this.lblTRF.Name = "lblTRF";
            this.lblTRF.Size = new System.Drawing.Size(141, 16);
            this.lblTRF.TabIndex = 6;
            this.lblTRF.TabStop = true;
            this.lblTRF.Text = "Tiger - Panthera Tigris";
            this.lblTRF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTRF_LinkClicked);
            // 
            // lblSSG
            // 
            this.lblSSG.AutoSize = true;
            this.lblSSG.BackColor = System.Drawing.Color.Transparent;
            this.lblSSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSG.Location = new System.Drawing.Point(411, 9);
            this.lblSSG.Name = "lblSSG";
            this.lblSSG.Size = new System.Drawing.Size(90, 16);
            this.lblSSG.TabIndex = 5;
            this.lblSSG.TabStop = true;
            this.lblSSG.Text = "SSG-Linkedin";
            this.lblSSG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSSG_LinkClicked);
            // 
            // txtinlognamn
            // 
            this.txtinlognamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinlognamn.Location = new System.Drawing.Point(15, 345);
            this.txtinlognamn.Name = "txtinlognamn";
            this.txtinlognamn.Size = new System.Drawing.Size(154, 23);
            this.txtinlognamn.TabIndex = 0;
            // 
            // txtinloglord
            // 
            this.txtinloglord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinloglord.Location = new System.Drawing.Point(211, 345);
            this.txtinloglord.Name = "txtinloglord";
            this.txtinloglord.Size = new System.Drawing.Size(154, 23);
            this.txtinloglord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Förnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lösenord:";
            // 
            // cbxInloggTyp
            // 
            this.cbxInloggTyp.FormattingEnabled = true;
            this.cbxInloggTyp.Items.AddRange(new object[] {
            "Admin",
            "Medlem"});
            this.cbxInloggTyp.Location = new System.Drawing.Point(385, 345);
            this.cbxInloggTyp.Name = "cbxInloggTyp";
            this.cbxInloggTyp.Size = new System.Drawing.Size(121, 21);
            this.cbxInloggTyp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kontotyp:";
            // 
            // Inloggning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxInloggTyp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtinloglord);
            this.Controls.Add(this.txtinlognamn);
            this.Controls.Add(this.lblSSG);
            this.Controls.Add(this.lblTRF);
            this.Controls.Add(this.btnNyReg);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inloggning";
            this.Text = "Inloggning";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAvsluta;
        private System.Windows.Forms.Button btnLoggin;
        private System.Windows.Forms.Button btnNyReg;
        private System.Windows.Forms.LinkLabel lblTRF;
        private System.Windows.Forms.LinkLabel lblSSG;
        private System.Windows.Forms.TextBox txtinlognamn;
        private System.Windows.Forms.TextBox txtinloglord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxInloggTyp;
        private System.Windows.Forms.Label label3;
    }
}