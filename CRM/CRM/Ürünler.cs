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
    public partial class Ürünler : Form
    {
        baglanti bgl = new baglanti();
        public Ürünler()
        {
            InitializeComponent();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbCRMDataSet13.TBLURUNLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLURUNLERTableAdapter2.Fill(this.dbCRMDataSet13.TBLURUNLER);
            // TODO: Bu kod satırı 'dbCRMDataSet11.TBLDEPOLAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet11.TBLDEPOLAR);
            // TODO: Bu kod satırı 'dbCRMDataSet10.TBLMARKALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet10.TBLMARKALAR);
            // TODO: Bu kod satırı 'dbCRMDataSet9.TBLKATEGORILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet9.TBLKATEGORILER);
            // TODO: Bu kod satırı 'dbCRMDataSet7.TBLURUNLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tBLURUNLERTableAdapter1.Fill(this.dbCRMDataSet7.TBLURUNLER);
            // TODO: This line of code loads data into the 'dbCRMDataSet1.TBLURUNLER' table. You can move, or remove it, as needed.
            //this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet1.TBLURUNLER);

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLURUNLER (UrunKategori, UrunAd, Marka, SatisFiyati, Depo) VALUES (@URUNKATEGORI, @URUNAD, @MARKA, @SATISFIYATI, @DEPO)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@URUNKATEGORI", SqlDbType.NVarChar).Value = cbKategori.Text;
            komut.Parameters.AddWithValue("@URUNAD", SqlDbType.NVarChar).Value = txtUrunAd.Text;
            komut.Parameters.AddWithValue("@MARKA", SqlDbType.NVarChar).Value = cbMarka.Text;
            komut.Parameters.AddWithValue("@SATISFIYATI", SqlDbType.Int).Value = Convert.ToInt32(txtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@DEPO", SqlDbType.NVarChar).Value = cbDepo.Text;
            komut.ExecuteNonQuery();
            //this.tBLURUNLERTableAdapter.Fill(this.dbCRMDataSet1.TBLURUNLER);
            //this.tBLURUNLERTableAdapter1.Fill(this.dbCRMDataSet7.TBLURUNLER);
            this.tBLURUNLERTableAdapter2.Fill(this.dbCRMDataSet13.TBLURUNLER);
        }
    }
}
