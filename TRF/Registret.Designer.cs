namespace TRF
{
    partial class Registret
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
            this.components = new System.ComponentModel.Container();
            this.btnavsluta = new System.Windows.Forms.Button();
            this.btnregnymedlem = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Medlemmar = new System.Windows.Forms.TabPage();
            this.dgvMedlem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medlemmarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.medlemDS = new TRF.MedlemDS();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnamnMedlem = new System.Windows.Forms.TextBox();
            this.btnregsökMedlem = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.medlemmarTableAdapter = new TRF.MedlemDSTableAdapters.MedlemmarTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Medlemmar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedlem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemDS)).BeginInit();
            this.Admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnavsluta
            // 
            this.btnavsluta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnavsluta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnavsluta.Location = new System.Drawing.Point(859, 411);
            this.btnavsluta.Name = "btnavsluta";
            this.btnavsluta.Size = new System.Drawing.Size(116, 31);
            this.btnavsluta.TabIndex = 3;
            this.btnavsluta.Text = "&Avsluta";
            this.btnavsluta.UseVisualStyleBackColor = true;
            this.btnavsluta.Click += new System.EventHandler(this.btnavsluta_Click);
            // 
            // btnregnymedlem
            // 
            this.btnregnymedlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregnymedlem.Location = new System.Drawing.Point(15, 411);
            this.btnregnymedlem.Name = "btnregnymedlem";
            this.btnregnymedlem.Size = new System.Drawing.Size(186, 31);
            this.btnregnymedlem.TabIndex = 0;
            this.btnregnymedlem.Text = "&Registrera en ny medlem";
            this.btnregnymedlem.UseVisualStyleBackColor = true;
            this.btnregnymedlem.Click += new System.EventHandler(this.btnregnymedlem_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(379, 444);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(196, 24);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tiger - Panthera Tigris";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(903, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "SSG-Linkedin";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Medlemmar);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 381);
            this.tabControl1.TabIndex = 40;
            // 
            // Medlemmar
            // 
            this.Medlemmar.Controls.Add(this.dgvMedlem);
            this.Medlemmar.Controls.Add(this.label1);
            this.Medlemmar.Controls.Add(this.txtnamnMedlem);
            this.Medlemmar.Controls.Add(this.btnregsökMedlem);
            this.Medlemmar.Location = new System.Drawing.Point(4, 22);
            this.Medlemmar.Name = "Medlemmar";
            this.Medlemmar.Padding = new System.Windows.Forms.Padding(3);
            this.Medlemmar.Size = new System.Drawing.Size(959, 355);
            this.Medlemmar.TabIndex = 0;
            this.Medlemmar.Text = "Medlemmar";
            this.Medlemmar.UseVisualStyleBackColor = true;
            // 
            // dgvMedlem
            // 
            this.dgvMedlem.AllowUserToAddRows = false;
            this.dgvMedlem.AllowUserToDeleteRows = false;
            this.dgvMedlem.AutoGenerateColumns = false;
            this.dgvMedlem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedlem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvMedlem.DataSource = this.medlemmarBindingSource2;
            this.dgvMedlem.Location = new System.Drawing.Point(9, 77);
            this.dgvMedlem.Name = "dgvMedlem";
            this.dgvMedlem.ReadOnly = true;
            this.dgvMedlem.Size = new System.Drawing.Size(944, 264);
            this.dgvMedlem.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Förnamn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Förnamn";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Efternamn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Efternamn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobil";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobil";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Epost";
            this.dataGridViewTextBoxColumn6.HeaderText = "Epost";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TigerNamn";
            this.dataGridViewTextBoxColumn7.HeaderText = "TigerNamn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TigerAlder";
            this.dataGridViewTextBoxColumn8.HeaderText = "TigerAlder";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn9.HeaderText = "Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // medlemmarBindingSource2
            // 
            this.medlemmarBindingSource2.DataMember = "Medlemmar";
            this.medlemmarBindingSource2.DataSource = this.medlemDS;
            // 
            // medlemDS
            // 
            this.medlemDS.DataSetName = "MedlemDS";
            this.medlemDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Namn:";
            // 
            // txtnamnMedlem
            // 
            this.txtnamnMedlem.Location = new System.Drawing.Point(205, 51);
            this.txtnamnMedlem.Name = "txtnamnMedlem";
            this.txtnamnMedlem.Size = new System.Drawing.Size(306, 20);
            this.txtnamnMedlem.TabIndex = 0;
            // 
            // btnregsökMedlem
            // 
            this.btnregsökMedlem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregsökMedlem.ForeColor = System.Drawing.Color.Green;
            this.btnregsökMedlem.Location = new System.Drawing.Point(870, 39);
            this.btnregsökMedlem.Name = "btnregsökMedlem";
            this.btnregsökMedlem.Size = new System.Drawing.Size(83, 31);
            this.btnregsökMedlem.TabIndex = 1;
            this.btnregsökMedlem.Text = "&Sök";
            this.btnregsökMedlem.UseVisualStyleBackColor = true;
            this.btnregsökMedlem.Click += new System.EventHandler(this.btnregsökMedlem_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Admin.Controls.Add(this.label3);
            this.Admin.Controls.Add(this.label2);
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.Color.Silver;
            this.Admin.Location = new System.Drawing.Point(4, 22);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(959, 355);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-post: admin@trf-reg.mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kontakta Admin för att ändra medlemsinfo eller avsluta medlemskap:";
            // 
            // medlemmarTableAdapter
            // 
            this.medlemmarTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(698, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 31);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "&Stäng ruta";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Registret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnavsluta);
            this.Controls.Add(this.btnregnymedlem);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Registret";
            this.Text = "Registret";
            this.Load += new System.EventHandler(this.Registret_Load);
            this.tabControl1.ResumeLayout(false);
            this.Medlemmar.ResumeLayout(false);
            this.Medlemmar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedlem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemDS)).EndInit();
            this.Admin.ResumeLayout(false);
            this.Admin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnavsluta;
        private System.Windows.Forms.Button btnregnymedlem;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Medlemmar;
        private System.Windows.Forms.DataGridView dgvMedlem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnamnMedlem;
        private System.Windows.Forms.Button btnregsökMedlem;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tigerNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tigerAlderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private MedlemDS medlemDS;
        private System.Windows.Forms.BindingSource medlemmarBindingSource2;
        private MedlemDSTableAdapters.MedlemmarTableAdapter medlemmarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnClose;
    }
}