using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Activity_6
{
    public partial class FormDataMaster : Form
    {
        private string stringConnection = "data source = LAPTOP-CE2MB8Q1\\DINAWULAN;" + "database =KULIAH;User ID=sa; Password=12345";
        private SqlConnection koneksi;

        public FormDataMaster()
        {
            InitializeComponent();
        }
        private void dataProdiiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }

        private void dataMahasiswaaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataMahasiswa fo = new FormDataMahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataStatusmahasiswaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fr = new FormDataStatusMahasiswa();
            fr.Show();
            this.Hide();
        }
    }
}