namespace TRF
{
    partial class AdminInlogg
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
            this.btnbytinfo = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnRadera = new System.Windows.Forms.Button();
            this.btnLeta = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.medlemmarBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tRFDBDataSet = new TRF.TRFDBDataSet();
            this.medlemmarBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tRFAdminDS = new TRF.TRFAdminDS();
            this.medlemmarTableAdapter1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtLeta = new System.Windows.Forms.TextBox();
            this.btnAvslutAdmin = new System.Windows.Forms.Button();
            this.txtmobil = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txttigerNamn = new System.Windows.Forms.TextBox();
            this.txttigerÅlder = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtepost = new System.Windows.Forms.TextBox();
            this.txtefternamn = new System.Windows.Forms.TextBox();
            this.txtnamn = new System.Windows.Forms.TextBox();
            this.cbxtyp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.medlemmarTableAdapter = new TRF.TRFAdminDSTableAdapters.MedlemmarTableAdapter();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLOrd = new System.Windows.Forms.TextBox();
            this.medlemmarTableAdapter2 = new TRF.TRFDBDataSetTableAdapters.MedlemmarTableAdapter();
            this.lblräkna = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.Räknare = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOrdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTillMedlemS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFAdminDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarTableAdapter1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbytinfo
            // 
            this.btnbytinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbytinfo.ForeColor = System.Drawing.Color.Green;
            this.btnbytinfo.Location = new System.Drawing.Point(869, 16);
            this.btnbytinfo.Name = "btnbytinfo";
            this.btnbytinfo.Size = new System.Drawing.Size(188, 32);
            this.btnbytinfo.TabIndex = 11;
            this.btnbytinfo.Text = "&Ändra";
            this.btnbytinfo.UseVisualStyleBackColor = true;
            this.btnbytinfo.Click += new System.EventHandler(this.btnbytinfo_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpara.ForeColor = System.Drawing.Color.Navy;
            this.btnSpara.Location = new System.Drawing.Point(869, 50);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(188, 32);
            this.btnSpara.TabIndex = 10;
            this.btnSpara.Text = "&Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnRadera
            // 
            this.btnRadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadera.ForeColor = System.Drawing.Color.Red;
            this.btnRadera.Location = new System.Drawing.Point(869, 88);
            this.btnRadera.Name = "btnRadera";
            this.btnRadera.Size = new System.Drawing.Size(188, 32);
            this.btnRadera.TabIndex = 18;
            this.btnRadera.Text = "&Radera";
            this.btnRadera.UseVisualStyleBackColor = true;
            this.btnRadera.Click += new System.EventHandler(this.btnRadera_Click);
            // 
            // btnLeta
            // 
            this.btnLeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeta.ForeColor = System.Drawing.Color.Black;
            this.btnLeta.Location = new System.Drawing.Point(12, 179);
            this.btnLeta.Name = "btnLeta";
            this.btnLeta.Size = new System.Drawing.Size(188, 32);
            this.btnLeta.TabIndex = 14;
            this.btnLeta.Text = "&Sök";
            this.btnLeta.UseVisualStyleBackColor = true;
            this.btnLeta.Click += new System.EventHandler(this.btnLeta_Click);
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AllowUserToOrderColumns = true;
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.lOrdDataGridViewTextBoxColumn});
            this.dgvAdmin.DataSource = this.medlemmarBindingSource3;
            this.dgvAdmin.Location = new System.Drawing.Point(12, 217);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.Size = new System.Drawing.Size(1045, 264);
            this.dgvAdmin.TabIndex = 17;
            this.dgvAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_CellContentClick);
            // 
            // medlemmarBindingSource3
            // 
            this.medlemmarBindingSource3.DataMember = "Medlemmar";
            this.medlemmarBindingSource3.DataSource = this.tRFDBDataSet;
            // 
            // tRFDBDataSet
            // 
            this.tRFDBDataSet.DataSetName = "TRFDBDataSet";
            this.tRFDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medlemmarBindingSource2
            // 
            this.medlemmarBindingSource2.DataMember = "Medlemmar";
            this.medlemmarBindingSource2.DataSource = this.tRFAdminDS;
            // 
            // tRFAdminDS
            // 
            this.tRFAdminDS.DataSetName = "TRFAdminDS";
            this.tRFAdminDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLeta
            // 
            this.txtLeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeta.Location = new System.Drawing.Point(238, 184);
            this.txtLeta.Name = "txtLeta";
            this.txtLeta.Size = new System.Drawing.Size(338, 23);
            this.txtLeta.TabIndex = 13;
            // 
            // btnAvslutAdmin
            // 
            this.btnAvslutAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvslutAdmin.ForeColor = System.Drawing.Color.Maroon;
            this.btnAvslutAdmin.Location = new System.Drawing.Point(822, 487);
            this.btnAvslutAdmin.Name = "btnAvslutAdmin";
            this.btnAvslutAdmin.Size = new System.Drawing.Size(235, 32);
            this.btnAvslutAdmin.TabIndex = 19;
            this.btnAvslutAdmin.Text = "&Avsluta";
            this.btnAvslutAdmin.UseVisualStyleBackColor = true;
            this.btnAvslutAdmin.Click += new System.EventHandler(this.btnAvslutAdmin_Click);
            // 
            // txtmobil
            // 
            this.txtmobil.Location = new System.Drawing.Point(13, 122);
            this.txtmobil.Name = "txtmobil";
            this.txtmobil.Size = new System.Drawing.Size(163, 20);
            this.txtmobil.TabIndex = 4;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(239, 122);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(163, 20);
            this.txttelefon.TabIndex = 5;
            // 
            // txttigerNamn
            // 
            this.txttigerNamn.Location = new System.Drawing.Point(465, 122);
            this.txttigerNamn.Name = "txttigerNamn";
            this.txttigerNamn.Size = new System.Drawing.Size(163, 20);
            this.txttigerNamn.TabIndex = 6;
            // 
            // txttigerÅlder
            // 
            this.txttigerÅlder.Location = new System.Drawing.Point(691, 122);
            this.txttigerÅlder.Name = "txttigerÅlder";
            this.txttigerÅlder.Size = new System.Drawing.Size(163, 20);
            this.txttigerÅlder.TabIndex = 7;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(691, 62);
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(163, 20);
            this.txtadress.TabIndex = 3;
            // 
            // txtepost
            // 
            this.txtepost.Location = new System.Drawing.Point(465, 62);
            this.txtepost.Name = "txtepost";
            this.txtepost.Size = new System.Drawing.Size(163, 20);
            this.txtepost.TabIndex = 2;
            // 
            // txtefternamn
            // 
            this.txtefternamn.Location = new System.Drawing.Point(239, 62);
            this.txtefternamn.Name = "txtefternamn";
            this.txtefternamn.Size = new System.Drawing.Size(163, 20);
            this.txtefternamn.TabIndex = 1;
            // 
            // txtnamn
            // 
            this.txtnamn.Location = new System.Drawing.Point(13, 62);
            this.txtnamn.Name = "txtnamn";
            this.txtnamn.Size = new System.Drawing.Size(163, 20);
            this.txtnamn.TabIndex = 0;
            // 
            // cbxtyp
            // 
            this.cbxtyp.FormattingEnabled = true;
            this.cbxtyp.Items.AddRange(new object[] {
            "Admin",
            "Medlem"});
            this.cbxtyp.Location = new System.Drawing.Point(936, 136);
            this.cbxtyp.Name = "cbxtyp";
            this.cbxtyp.Size = new System.Drawing.Size(121, 21);
            this.cbxtyp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Förnamn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Efternamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "E-post:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adress:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mobil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tigers namn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(688, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tigers ålder:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(879, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Med. typ:";
            // 
            // medlemmarTableAdapter
            // 
            this.medlemmarTableAdapter.ClearBeforeFill = true;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.Color.Teal;
            this.btnrefresh.ForeColor = System.Drawing.Color.Green;
            this.btnrefresh.Location = new System.Drawing.Point(1022, 179);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(34, 27);
            this.btnrefresh.TabIndex = 12;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(919, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ladda om tabellen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Lösenord:";
            // 
            // txtLOrd
            // 
            this.txtLOrd.Location = new System.Drawing.Point(692, 182);
            this.txtLOrd.Name = "txtLOrd";
            this.txtLOrd.Size = new System.Drawing.Size(163, 20);
            this.txtLOrd.TabIndex = 9;
            // 
            // medlemmarTableAdapter2
            // 
            this.medlemmarTableAdapter2.ClearBeforeFill = true;
            // 
            // lblräkna
            // 
            this.lblräkna.AutoSize = true;
            this.lblräkna.Location = new System.Drawing.Point(9, 506);
            this.lblräkna.Name = "lblräkna";
            this.lblräkna.Size = new System.Drawing.Size(151, 13);
            this.lblräkna.TabIndex = 15;
            this.lblräkna.Text = "Antal registrerade medlemmar: ";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(166, 509);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 16;
            // 
            // Räknare
            // 
            this.Räknare.Tick += new System.EventHandler(this.Räknare_Tick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn10.FillWeight = 50F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Förnamn";
            this.dataGridViewTextBoxColumn11.HeaderText = "Förnamn";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Efternamn";
            this.dataGridViewTextBoxColumn12.HeaderText = "Efternamn";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Epost";
            this.dataGridViewTextBoxColumn16.HeaderText = "Epost";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn13.FillWeight = 110F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 110;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn14.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Mobil";
            this.dataGridViewTextBoxColumn15.HeaderText = "Mobil";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "TigerNamn";
            this.dataGridViewTextBoxColumn17.HeaderText = "TigerNamn";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "TigerAlder";
            this.dataGridViewTextBoxColumn18.FillWeight = 70F;
            this.dataGridViewTextBoxColumn18.HeaderText = "TigerAlder";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 70;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn19.FillWeight = 70F;
            this.dataGridViewTextBoxColumn19.HeaderText = "Type";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 70;
            // 
            // lOrdDataGridViewTextBoxColumn
            // 
            this.lOrdDataGridViewTextBoxColumn.DataPropertyName = "LOrd";
            this.lOrdDataGridViewTextBoxColumn.HeaderText = "LOrd";
            this.lOrdDataGridViewTextBoxColumn.Name = "lOrdDataGridViewTextBoxColumn";
            // 
            // btnTillMedlemS
            // 
            this.btnTillMedlemS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTillMedlemS.ForeColor = System.Drawing.Color.Green;
            this.btnTillMedlemS.Location = new System.Drawing.Point(356, 487);
            this.btnTillMedlemS.Name = "btnTillMedlemS";
            this.btnTillMedlemS.Size = new System.Drawing.Size(235, 32);
            this.btnTillMedlemS.TabIndex = 22;
            this.btnTillMedlemS.Text = "&Till Medlemssidan";
            this.btnTillMedlemS.UseVisualStyleBackColor = true;
            this.btnTillMedlemS.Click += new System.EventHandler(this.btnTillMedlemS_Click);
            // 
            // AdminInlogg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 538);
            this.Controls.Add(this.btnTillMedlemS);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblräkna);
            this.Controls.Add(this.txtLOrd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxtyp);
            this.Controls.Add(this.txtadress);
            this.Controls.Add(this.txtepost);
            this.Controls.Add(this.txtefternamn);
            this.Controls.Add(this.txtnamn);
            this.Controls.Add(this.txttigerÅlder);
            this.Controls.Add(this.txttigerNamn);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.txtmobil);
            this.Controls.Add(this.btnAvslutAdmin);
            this.Controls.Add(this.txtLeta);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.btnLeta);
            this.Controls.Add(this.btnRadera);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btnbytinfo);
            this.Name = "AdminInlogg";
            this.Text = "AdminInlogg";
            this.Load += new System.EventHandler(this.AdminInlogg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFAdminDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarTableAdapter1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbytinfo;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnRadera;
        private System.Windows.Forms.Button btnLeta;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.TextBox txtLeta;
        private System.Windows.Forms.Button btnAvslutAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tigerNamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tigerAlderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtmobil;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txttigerNamn;
        private System.Windows.Forms.TextBox txttigerÅlder;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtepost;
        private System.Windows.Forms.TextBox txtefternamn;
        private System.Windows.Forms.TextBox txtnamn;
        private System.Windows.Forms.ComboBox cbxtyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource medlemmarTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private TRFAdminDS tRFAdminDS;
        private System.Windows.Forms.BindingSource medlemmarBindingSource2;
        private TRFAdminDSTableAdapters.MedlemmarTableAdapter medlemmarTableAdapter;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLOrd;
        private TRFDBDataSet tRFDBDataSet;
        private System.Windows.Forms.BindingSource medlemmarBindingSource3;
        private TRFDBDataSetTableAdapters.MedlemmarTableAdapter medlemmarTableAdapter2;
        private System.Windows.Forms.Label lblräkna;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Timer Räknare;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOrdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnTillMedlemS;
    }
}