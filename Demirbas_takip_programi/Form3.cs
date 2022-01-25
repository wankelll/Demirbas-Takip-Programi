using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Demirbas_takip_programi
{
    public partial class Form3 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= demirbas.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbDataReader dr;
        DataSet ds = new DataSet();
        
        Form1 fr = new Form1();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                da = new OleDbDataAdapter("SELECT * FROM kullanicilar", baglanti);
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO kullanicilar (kullanici_adi, kullanici_sifre) VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"')";
                dr = cmd.ExecuteReader();
                baglanti.Close();
                MessageBox.Show("Kullanıcı başarıyla eklendi!");
                dataGridView1.Visible = true;
                da = new OleDbDataAdapter("SELECT * FROM kullanicilar", baglanti);
                da.Fill(ds, "kullanicilar");
                dataGridView1.DataSource = ds.Tables["kullanicilar"];
                da.Dispose();
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Boşlukları doldurunuz!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silme işlemi yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(c == DialogResult.Yes)
            {
                da = new OleDbDataAdapter("SELECT * FROM kullanicilar", baglanti);
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "DELETE FROM kullanicilar WHERE kullanici_adi='"+textBox3.Text+ "'";
                dr = cmd.ExecuteReader();
                baglanti.Close();
                this.Close();
                if(Form2.ActiveForm != null)
                {
                    Form2.ActiveForm.Close();
                }
                fr.Show();
            }
        }
    }
}