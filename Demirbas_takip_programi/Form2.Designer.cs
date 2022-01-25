namespace Demirbas_takip_programi
{
    partial class Form2
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.demirbasnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasDataSet = new Demirbas_takip_programi.demirbasDataSet();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.btn_KayitEkle = new System.Windows.Forms.Button();
            this.btn_KayitSil = new System.Windows.Forms.Button();
            this.btn_KayitGun = new System.Windows.Forms.Button();
            this.demirbasno = new System.Windows.Forms.TextBox();
            this.urunisim = new System.Windows.Forms.TextBox();
            this.urunadet = new System.Windows.Forms.TextBox();
            this.urunno = new System.Windows.Forms.TextBox();
            this.demirbasTableAdapter = new Demirbas_takip_programi.demirbasDataSetTableAdapters.demirbasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demirbasnoDataGridViewTextBoxColumn,
            this.urunisimDataGridViewTextBoxColumn,
            this.urunadetDataGridViewTextBoxColumn,
            this.urunnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demirbasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(979, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // demirbasnoDataGridViewTextBoxColumn
            // 
            this.demirbasnoDataGridViewTextBoxColumn.DataPropertyName = "demirbas_no";
            this.demirbasnoDataGridViewTextBoxColumn.HeaderText = "demirbas_no";
            this.demirbasnoDataGridViewTextBoxColumn.Name = "demirbasnoDataGridViewTextBoxColumn";
            this.demirbasnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunisimDataGridViewTextBoxColumn
            // 
            this.urunisimDataGridViewTextBoxColumn.DataPropertyName = "urun_isim";
            this.urunisimDataGridViewTextBoxColumn.HeaderText = "urun_isim";
            this.urunisimDataGridViewTextBoxColumn.Name = "urunisimDataGridViewTextBoxColumn";
            this.urunisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadetDataGridViewTextBoxColumn
            // 
            this.urunadetDataGridViewTextBoxColumn.DataPropertyName = "urun_adet";
            this.urunadetDataGridViewTextBoxColumn.HeaderText = "urun_adet";
            this.urunadetDataGridViewTextBoxColumn.Name = "urunadetDataGridViewTextBoxColumn";
            this.urunadetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunnoDataGridViewTextBoxColumn
            // 
            this.urunnoDataGridViewTextBoxColumn.DataPropertyName = "urun_no";
            this.urunnoDataGridViewTextBoxColumn.HeaderText = "urun_no";
            this.urunnoDataGridViewTextBoxColumn.Name = "urunnoDataGridViewTextBoxColumn";
            this.urunnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demirbasBindingSource
            // 
            this.demirbasBindingSource.DataMember = "demirbas";
            this.demirbasBindingSource.DataSource = this.demirbasDataSet;
            // 
            // demirbasDataSet
            // 
            this.demirbasDataSet.DataSetName = "demirbasDataSet";
            this.demirbasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ara.Location = new System.Drawing.Point(565, 113);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(75, 50);
            this.btn_Ara.TabIndex = 1;
            this.btn_Ara.Text = "Kayıt Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // btn_KayitEkle
            // 
            this.btn_KayitEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitEkle.Location = new System.Drawing.Point(461, 113);
            this.btn_KayitEkle.Name = "btn_KayitEkle";
            this.btn_KayitEkle.Size = new System.Drawing.Size(75, 50);
            this.btn_KayitEkle.TabIndex = 2;
            this.btn_KayitEkle.Text = "Kayıt Ekle";
            this.btn_KayitEkle.UseVisualStyleBackColor = true;
            this.btn_KayitEkle.Click += new System.EventHandler(this.btn_KayitEkle_Click);
            // 
            // btn_KayitSil
            // 
            this.btn_KayitSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitSil.Location = new System.Drawing.Point(461, 177);
            this.btn_KayitSil.Name = "btn_KayitSil";
            this.btn_KayitSil.Size = new System.Drawing.Size(75, 50);
            this.btn_KayitSil.TabIndex = 3;
            this.btn_KayitSil.Text = "Kayıt Sil";
            this.btn_KayitSil.UseVisualStyleBackColor = true;
            this.btn_KayitSil.Click += new System.EventHandler(this.btn_KayitSil_Click);
            // 
            // btn_KayitGun
            // 
            this.btn_KayitGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KayitGun.Location = new System.Drawing.Point(565, 173);
            this.btn_KayitGun.Name = "btn_KayitGun";
            this.btn_KayitGun.Size = new System.Drawing.Size(75, 50);
            this.btn_KayitGun.TabIndex = 4;
            this.btn_KayitGun.Text = "Kayıt Güncelle";
            this.btn_KayitGun.UseVisualStyleBackColor = true;
            this.btn_KayitGun.Click += new System.EventHandler(this.btn_KayitGun_Click);
            // 
            // demirbasno
            // 
            this.demirbasno.Location = new System.Drawing.Point(151, 86);
            this.demirbasno.Name = "demirbasno";
            this.demirbasno.Size = new System.Drawing.Size(100, 20);
            this.demirbasno.TabIndex = 5;
            // 
            // urunisim
            // 
            this.urunisim.Location = new System.Drawing.Point(151, 129);
            this.urunisim.Name = "urunisim";
            this.urunisim.Size = new System.Drawing.Size(100, 20);
            this.urunisim.TabIndex = 6;
            // 
            // urunadet
            // 
            this.urunadet.Location = new System.Drawing.Point(151, 177);
            this.urunadet.Name = "urunadet";
            this.urunadet.Size = new System.Drawing.Size(100, 20);
            this.urunadet.TabIndex = 7;
            // 
            // urunno
            // 
            this.urunno.Location = new System.Drawing.Point(151, 221);
            this.urunno.Name = "urunno";
            this.urunno.Size = new System.Drawing.Size(100, 20);
            this.urunno.TabIndex = 8;
            // 
            // demirbasTableAdapter
            // 
            this.demirbasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "DEMİRBAŞ NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ÜRÜN İSİM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ÜRÜN ADET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ÜRÜN NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(912, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ayarlar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(986, 520);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunno);
            this.Controls.Add(this.urunadet);
            this.Controls.Add(this.urunisim);
            this.Controls.Add(this.demirbasno);
            this.Controls.Add(this.btn_KayitGun);
            this.Controls.Add(this.btn_KayitSil);
            this.Controls.Add(this.btn_KayitEkle);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private demirbasDataSet demirbasDataSet;
        private System.Windows.Forms.BindingSource demirbasBindingSource;
        private demirbasDataSetTableAdapters.demirbasTableAdapter demirbasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.Button btn_KayitEkle;
        private System.Windows.Forms.Button btn_KayitSil;
        private System.Windows.Forms.Button btn_KayitGun;
        private System.Windows.Forms.TextBox demirbasno;
        private System.Windows.Forms.TextBox urunisim;
        private System.Windows.Forms.TextBox urunadet;
        private System.Windows.Forms.TextBox urunno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

