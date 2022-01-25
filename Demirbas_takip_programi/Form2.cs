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
    public partial class Form2 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= demirbas.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        
        
        public Form2()
        {
            InitializeComponent();
            
        }

        void listele()
        {
            baglanti.Open();
            da = new OleDbDataAdapter("SELECT * FROM demirbas", baglanti);
            da.Fill(ds,"demirbas");
            dataGridView1.DataSource = ds.Tables["demirbas"];
            da.Dispose();
            baglanti.Close();
        }
        
        public void Form2_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'demirbasDataSet.demirbas' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.demirbasTableAdapter.Fill(this.demirbasDataSet.demirbas);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            demirbasno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urunadet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            urunno.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_KayitEkle_Click(object sender, EventArgs e)
        {
            
            if (demirbasno.Text != "" && urunisim.Text != "" && urunadet.Text != "" && urunno.Text != "")
            {
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO demirbas (demirbas_no, urun_isim, urun_adet, urun_no) VALUES ('"+demirbasno.Text+"','" +urunisim.Text+"','" +urunadet.Text+"','" +urunno.Text+ "')";
                baglanti.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla eklendi..!");
                ds.Clear();
                listele();
            }

            else
            {
                MessageBox.Show("Kayıt eklenmedi, lütfen boşlukları doldurup tekrar deneyiniz!");
            }
        }

        private void btn_Ara_Click(object sender, EventArgs e)
        {
            if (demirbasno.Text != "")
            {
                baglanti.Open();
                da = new OleDbDataAdapter("SELECT * FROM demirbas WHERE demirbas_no=" + Convert.ToInt32(demirbasno.Text), baglanti);
                ds.Clear();
                da.Fill(ds, "demirbas");
                dataGridView1.DataSource = ds.Tables["demirbas"];
                da.Dispose();
                baglanti.Close();
            }
        }

        private void btn_KayitSil_Click(object sender, EventArgs e)
        {
            
            DialogResult c;
            c = MessageBox.Show("Silme işlemi yapmak istediğinizden emin misiniz?", "" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM demirbas WHERE demirbas_no=" + demirbasno.Text + "";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                demirbasno.Text = "";
                urunadet.Text = "";
                urunno.Text = "";
                urunisim.Text = "";
                ds.Clear();
                listele();
            }
        }

        private void btn_KayitGun_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new OleDbCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "UPDATE demirbas SET urun_no=" + urunno.Text + ", urun_isim='" + urunisim.Text + "', urun_adet=" + urunadet.Text + " WHERE demirbas_no=" + demirbasno.Text + "";
                cmd.ExecuteNonQuery();
                baglanti.Close();
                ds.Clear();
                listele();
            }
            catch (Exception edd)
            {
                MessageBox.Show(edd.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}