using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Demirbas_takip_programi
{
    public partial class Form1 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= demirbas.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();

        }
        void ac()
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
        void kapat()
        {
            Close();
        }
        void giris()
        {
            da = new OleDbDataAdapter("SELECT * FROM kullanicilar", baglanti);
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM kullanicilar WHERE kullanici_adi='" + textBox1.Text + "'AND kullanici_sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ac();
                if(Form1.ActiveForm == null)
                kapat();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }
            baglanti.Close();
        }
        private void btn_Giris_Click(object sender, EventArgs e)
        {
            giris();
        }
    }
}