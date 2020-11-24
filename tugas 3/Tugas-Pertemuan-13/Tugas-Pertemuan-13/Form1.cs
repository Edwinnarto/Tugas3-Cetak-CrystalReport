using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;

namespace Tugas_Pertemuan_13
{
   public partial class Form1 : Form
   {
        ReportDocument Cryrpt = new ReportDocument();
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_Sample;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {   
            try
            {   
                RptMahasiswa rptmhsw = new RptMahasiswa();
                SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_Sample;Integrated Security=True");

                DataSet ds = new DataSet();
                    
                string nim = this.txtNim.Text;
                string nama = this.txtNama.Text;
                string jnskelamin = this.cboJenisKelamin.Text;
                string prgmstudi = this.cboProgramStudi.Text;
                string watkul = this.cboWaktuKuliah.Text;
                string kls = this.cboKelas.Text;
                SqlDataAdapter sda = new SqlDataAdapter(@"Select * from TMahasiswa where [nim] like '" + nim + "%' and[nama] like '" + nama + "%' and[jeniskelamin] like '"
                            + jnskelamin + "%'  and [programstudi] like '" + prgmstudi + "%'  and [waktukuliah] like '" + watkul + "%' and [kelas] like '" + kls + "%' ", conn);

                sda.Fill(ds, "TMahasiswa");
                DataTable dt = ds.Tables["TMahasiswa"];

                rptmhsw.SetDataSource(ds.Tables["TMahasiswa"]);

                CRV.ReportSource = rptmhsw;
                CRV.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry data tidak ditemukan", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearflter();
        }
        private void clearflter()
        {
            this.txtNim.Clear();
            this.txtNama.Clear();
            this.cboJenisKelamin.SelectedIndex = -1;
            this.cboProgramStudi.SelectedIndex = -1;
            this.cboWaktuKuliah.SelectedIndex = -1;
            this.cboKelas.SelectedIndex = -1;
        }

       
    }
}
