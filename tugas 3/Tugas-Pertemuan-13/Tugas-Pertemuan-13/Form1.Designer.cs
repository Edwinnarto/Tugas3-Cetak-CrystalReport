
namespace Tugas_Pertemuan_13
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
            this.grpKriteria = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cboKelas = new System.Windows.Forms.ComboBox();
            this.cboWaktuKuliah = new System.Windows.Forms.ComboBox();
            this.cboProgramStudi = new System.Windows.Forms.ComboBox();
            this.cboJenisKelamin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.lblBanyakRecordData = new System.Windows.Forms.Label();
            this.CRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpKriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKriteria
            // 
            this.grpKriteria.Controls.Add(this.btnClear);
            this.grpKriteria.Controls.Add(this.btnOK);
            this.grpKriteria.Controls.Add(this.cboKelas);
            this.grpKriteria.Controls.Add(this.cboWaktuKuliah);
            this.grpKriteria.Controls.Add(this.cboProgramStudi);
            this.grpKriteria.Controls.Add(this.cboJenisKelamin);
            this.grpKriteria.Controls.Add(this.label5);
            this.grpKriteria.Controls.Add(this.label4);
            this.grpKriteria.Controls.Add(this.label3);
            this.grpKriteria.Controls.Add(this.label2);
            this.grpKriteria.Controls.Add(this.txtNama);
            this.grpKriteria.Controls.Add(this.label1);
            this.grpKriteria.Controls.Add(this.txtNim);
            this.grpKriteria.Controls.Add(this.lblBanyakRecordData);
            this.grpKriteria.Location = new System.Drawing.Point(12, 6);
            this.grpKriteria.Name = "grpKriteria";
            this.grpKriteria.Size = new System.Drawing.Size(274, 245);
            this.grpKriteria.TabIndex = 0;
            this.grpKriteria.TabStop = false;
            this.grpKriteria.Text = "Kriteria";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(184, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(103, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboKelas
            // 
            this.cboKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKelas.FormattingEnabled = true;
            this.cboKelas.Items.AddRange(new object[] {
            "",
            "A",
            "B"});
            this.cboKelas.Location = new System.Drawing.Point(103, 157);
            this.cboKelas.Name = "cboKelas";
            this.cboKelas.Size = new System.Drawing.Size(156, 21);
            this.cboKelas.TabIndex = 5;
            // 
            // cboWaktuKuliah
            // 
            this.cboWaktuKuliah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboWaktuKuliah.FormattingEnabled = true;
            this.cboWaktuKuliah.Items.AddRange(new object[] {
            "",
            "Pagi",
            "Sore"});
            this.cboWaktuKuliah.Location = new System.Drawing.Point(103, 131);
            this.cboWaktuKuliah.Name = "cboWaktuKuliah";
            this.cboWaktuKuliah.Size = new System.Drawing.Size(156, 21);
            this.cboWaktuKuliah.TabIndex = 4;
            // 
            // cboProgramStudi
            // 
            this.cboProgramStudi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgramStudi.FormattingEnabled = true;
            this.cboProgramStudi.Items.AddRange(new object[] {
            "",
            "TI",
            "SI"});
            this.cboProgramStudi.Location = new System.Drawing.Point(103, 105);
            this.cboProgramStudi.Name = "cboProgramStudi";
            this.cboProgramStudi.Size = new System.Drawing.Size(156, 21);
            this.cboProgramStudi.TabIndex = 3;
            // 
            // cboJenisKelamin
            // 
            this.cboJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJenisKelamin.FormattingEnabled = true;
            this.cboJenisKelamin.Items.AddRange(new object[] {
            "",
            "Pria",
            "Wanita"});
            this.cboJenisKelamin.Location = new System.Drawing.Point(103, 79);
            this.cboJenisKelamin.Name = "cboJenisKelamin";
            this.cboJenisKelamin.Size = new System.Drawing.Size(156, 21);
            this.cboJenisKelamin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kelas";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Waktu Kuliah";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Program Studi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Jenis Kelamin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(103, 53);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(156, 20);
            this.txtNama.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNim
            // 
            this.txtNim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNim.Location = new System.Drawing.Point(103, 27);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(156, 20);
            this.txtNim.TabIndex = 0;
            this.txtNim.TextChanged += new System.EventHandler(this.txtNim_TextChanged);
            // 
            // lblBanyakRecordData
            // 
            this.lblBanyakRecordData.Location = new System.Drawing.Point(18, 27);
            this.lblBanyakRecordData.Name = "lblBanyakRecordData";
            this.lblBanyakRecordData.Size = new System.Drawing.Size(79, 20);
            this.lblBanyakRecordData.TabIndex = 18;
            this.lblBanyakRecordData.Text = "Nim";
            this.lblBanyakRecordData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = -1;
            this.CRV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Location = new System.Drawing.Point(292, 12);
            this.CRV.Name = "CRV";
            this.CRV.Size = new System.Drawing.Size(704, 437);
            this.CRV.TabIndex = 1;
            this.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 461);
            this.Controls.Add(this.CRV);
            this.Controls.Add(this.grpKriteria);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKriteria.ResumeLayout(false);
            this.grpKriteria.PerformLayout();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox grpKriteria;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.ComboBox cboKelas;
      private System.Windows.Forms.ComboBox cboWaktuKuliah;
      private System.Windows.Forms.ComboBox cboProgramStudi;
      private System.Windows.Forms.ComboBox cboJenisKelamin;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtNim;
      private System.Windows.Forms.Label lblBanyakRecordData;
      private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
   }
}

