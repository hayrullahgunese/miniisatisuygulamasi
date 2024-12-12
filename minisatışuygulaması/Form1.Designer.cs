namespace minisatışuygulaması
{
    partial class Form1
    {
       
        private System.ComponentModel.IContainer components = null;

       
       
       
        ///<param name"disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxadetgir = new System.Windows.Forms.TextBox();
            this.comboBoxfidanseç = new System.Windows.Forms.ComboBox();
            this.dataGridViewfidan = new System.Windows.Forms.DataGridView();
            this.fidanDataSet = new minisatışuygulaması.fidanDataSet();
            this.fidanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fidanTableAdapter = new minisatışuygulaması.fidanDataSetTableAdapters.fidanTableAdapter();
            this.fidanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidanadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidanfiyatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonalışverişitamamla = new System.Windows.Forms.Button();
            this.dataGridViewsatislar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fidanDataSet1 = new minisatışuygulaması.fidanDataSet1();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satislarTableAdapter = new minisatışuygulaması.fidanDataSet1TableAdapters.satislarTableAdapter();
            this.satisidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilanfidanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satilanfidanadetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamtutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fidanDataSet2 = new minisatışuygulaması.fidanDataSet2();
            this.fidanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fidanTableAdapter1 = new minisatışuygulaması.fidanDataSet2TableAdapters.fidanTableAdapter();
            this.fidanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fidanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fidanDataSet3 = new minisatışuygulaması.fidanDataSet3();
            this.fidanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fidanTableAdapter2 = new minisatışuygulaması.fidanDataSet3TableAdapters.fidanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfidan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource4)).BeginInit();
            this.SuspendLayout();
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fidan Seçiniz";
                        this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet Giriniz";
            
            this.textBoxadetgir.Location = new System.Drawing.Point(451, 91);
            this.textBoxadetgir.Name = "textBoxadetgir";
            this.textBoxadetgir.Size = new System.Drawing.Size(140, 20);
            this.textBoxadetgir.TabIndex = 2;
             
            this.comboBoxfidanseç.FormattingEnabled = true;
            this.comboBoxfidanseç.Location = new System.Drawing.Point(451, 64);
            this.comboBoxfidanseç.Name = "comboBoxfidanseç";
            this.comboBoxfidanseç.Size = new System.Drawing.Size(140, 21);
            this.comboBoxfidanseç.TabIndex = 3;
            
            this.dataGridViewfidan.AutoGenerateColumns = false;
            this.dataGridViewfidan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfidan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fidanidDataGridViewTextBoxColumn,
            this.fidanadiDataGridViewTextBoxColumn,
            this.fidanfiyatiDataGridViewTextBoxColumn});
            this.dataGridViewfidan.DataSource = this.fidanBindingSource4;
            this.dataGridViewfidan.Location = new System.Drawing.Point(18, 64);
            this.dataGridViewfidan.Name = "dataGridViewfidan";
            this.dataGridViewfidan.Size = new System.Drawing.Size(351, 135);
            this.dataGridViewfidan.TabIndex = 4;
             
            this.fidanDataSet.DataSetName = "fidanDataSet";
            this.fidanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
             
            this.fidanBindingSource.DataMember = "fidan";
            this.fidanBindingSource.DataSource = this.fidanDataSet;
            
            this.fidanTableAdapter.ClearBeforeFill = true;
            
            this.fidanidDataGridViewTextBoxColumn.DataPropertyName = "fidanid";
            this.fidanidDataGridViewTextBoxColumn.HeaderText = "fidanid";
            this.fidanidDataGridViewTextBoxColumn.Name = "fidanidDataGridViewTextBoxColumn";
            this.fidanidDataGridViewTextBoxColumn.ReadOnly = true;
            
            this.fidanadiDataGridViewTextBoxColumn.DataPropertyName = "fidanadi";
            this.fidanadiDataGridViewTextBoxColumn.HeaderText = "fidanadi";
            this.fidanadiDataGridViewTextBoxColumn.Name = "fidanadiDataGridViewTextBoxColumn";
            
            this.fidanfiyatiDataGridViewTextBoxColumn.DataPropertyName = "fidanfiyati";
            this.fidanfiyatiDataGridViewTextBoxColumn.HeaderText = "fidanfiyati";
            this.fidanfiyatiDataGridViewTextBoxColumn.Name = "fidanfiyatiDataGridViewTextBoxColumn";
             
            this.buttonalışverişitamamla.BackColor = System.Drawing.Color.Cyan;
            this.buttonalışverişitamamla.Location = new System.Drawing.Point(451, 135);
            this.buttonalışverişitamamla.Name = "buttonalışverişitamamla";
            this.buttonalışverişitamamla.Size = new System.Drawing.Size(139, 26);
            this.buttonalışverişitamamla.TabIndex = 5;
            this.buttonalışverişitamamla.Text = "Alışverişi Tamamla";
            this.buttonalışverişitamamla.UseVisualStyleBackColor = false;
            this.buttonalışverişitamamla.Click += new System.EventHandler(this.buttonalışverişitamamla_Click);
             
            this.dataGridViewsatislar.AutoGenerateColumns = false;
            this.dataGridViewsatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsatislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisidDataGridViewTextBoxColumn,
            this.satilanfidanidDataGridViewTextBoxColumn,
            this.satilanfidanadetiDataGridViewTextBoxColumn,
            this.toplamtutarDataGridViewTextBoxColumn});
            this.dataGridViewsatislar.DataSource = this.satislarBindingSource;
            this.dataGridViewsatislar.Location = new System.Drawing.Point(18, 450);
            this.dataGridViewsatislar.Name = "dataGridViewsatislar";
            this.dataGridViewsatislar.Size = new System.Drawing.Size(447, 134);
            this.dataGridViewsatislar.TabIndex = 6;
             
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(18, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fidan Çeşitleri ve Fiyatı";
            
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(18, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yapılan Satışlar";
            
            this.fidanDataSet1.DataSetName = "fidanDataSet1";
            this.fidanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
             
            this.satislarBindingSource.DataMember = "satislar";
            this.satislarBindingSource.DataSource = this.fidanDataSet1;
            
            this.satislarTableAdapter.ClearBeforeFill = true;
             
            this.satisidDataGridViewTextBoxColumn.DataPropertyName = "satisid";
            this.satisidDataGridViewTextBoxColumn.HeaderText = "satisid";
            this.satisidDataGridViewTextBoxColumn.Name = "satisidDataGridViewTextBoxColumn";
            this.satisidDataGridViewTextBoxColumn.ReadOnly = true;
            
            this.satilanfidanidDataGridViewTextBoxColumn.DataPropertyName = "satilanfidanid";
            this.satilanfidanidDataGridViewTextBoxColumn.HeaderText = "satilanfidanid";
            this.satilanfidanidDataGridViewTextBoxColumn.Name = "satilanfidanidDataGridViewTextBoxColumn";
            
            this.satilanfidanadetiDataGridViewTextBoxColumn.DataPropertyName = "satilanfidanadeti";
            this.satilanfidanadetiDataGridViewTextBoxColumn.HeaderText = "satilanfidanadeti";
            this.satilanfidanadetiDataGridViewTextBoxColumn.Name = "satilanfidanadetiDataGridViewTextBoxColumn";
             
            this.toplamtutarDataGridViewTextBoxColumn.DataPropertyName = "toplamtutar";
            this.toplamtutarDataGridViewTextBoxColumn.HeaderText = "toplamtutar";
            this.toplamtutarDataGridViewTextBoxColumn.Name = "toplamtutarDataGridViewTextBoxColumn";
             
            this.fidanDataSet2.DataSetName = "fidanDataSet2";
            this.fidanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.fidanBindingSource1.DataMember = "fidan";
            this.fidanBindingSource1.DataSource = this.fidanDataSet2;
            
            this.fidanTableAdapter1.ClearBeforeFill = true;
            
            this.fidanBindingSource2.DataMember = "fidan";
            this.fidanBindingSource2.DataSource = this.fidanDataSet;
            
            this.fidanBindingSource3.DataMember = "fidan";
            this.fidanBindingSource3.DataSource = this.fidanDataSet2;
             
            this.fidanDataSet3.DataSetName = "fidanDataSet3";
            this.fidanDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
             
            this.fidanBindingSource4.DataMember = "fidan";
            this.fidanBindingSource4.DataSource = this.fidanDataSet3;
             
            this.fidanTableAdapter2.ClearBeforeFill = true;
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1019, 698);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewsatislar);
            this.Controls.Add(this.buttonalışverişitamamla);
            this.Controls.Add(this.dataGridViewfidan);
            this.Controls.Add(this.comboBoxfidanseç);
            this.Controls.Add(this.textBoxadetgir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfidan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fidanBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxadetgir;
        private System.Windows.Forms.ComboBox comboBoxfidanseç;
        private System.Windows.Forms.DataGridView dataGridViewfidan;
        private fidanDataSet fidanDataSet;
        private System.Windows.Forms.BindingSource fidanBindingSource;
        private fidanDataSetTableAdapters.fidanTableAdapter fidanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidanadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fidanfiyatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonalışverişitamamla;
        private System.Windows.Forms.DataGridView dataGridViewsatislar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private fidanDataSet1 fidanDataSet1;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private fidanDataSet1TableAdapters.satislarTableAdapter satislarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilanfidanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satilanfidanadetiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamtutarDataGridViewTextBoxColumn;
        private fidanDataSet2 fidanDataSet2;
        private System.Windows.Forms.BindingSource fidanBindingSource1;
        private fidanDataSet2TableAdapters.fidanTableAdapter fidanTableAdapter1;
        private System.Windows.Forms.BindingSource fidanBindingSource2;
        private System.Windows.Forms.BindingSource fidanBindingSource3;
        private fidanDataSet3 fidanDataSet3;
        private System.Windows.Forms.BindingSource fidanBindingSource4;
        private fidanDataSet3TableAdapters.fidanTableAdapter fidanTableAdapter2;
    }
}

