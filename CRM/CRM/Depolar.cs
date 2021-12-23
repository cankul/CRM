using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Depolar : Form
    {
        baglanti bgl = new baglanti();
        public Depolar()
        {
            InitializeComponent();
        }

        private void Depolar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbCRMDataSet8.TBLDEPOLAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet8.TBLDEPOLAR);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLDEPOLAR (DepoAd) VALUES (@DEPOAD)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@DEPOAD", SqlDbType.NVarChar).Value = txtDepoAd.Text;
            komut.ExecuteNonQuery();
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet8.TBLDEPOLAR);
        }
    }
}
