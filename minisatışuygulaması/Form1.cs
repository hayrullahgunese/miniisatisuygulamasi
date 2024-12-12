using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing; 
using System.Windows.Forms;

namespace minisatışuygulaması
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private string connectionString = "Server=DESKTOP-8FACNE8; Database=fidan; Integrated Security=True;";
        private int selectedFidanId;
        private string selectedFidanAdi;
        private int adet;
        private decimal toplamTutar;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fidanTableAdapter2.Fill(this.fidanDataSet3.fidan);
            LoadFidanData();
            LoadSalesData();
        }

        private void LoadFidanData()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM fidan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxfidanseç.DataSource = dt;
                comboBoxfidanseç.DisplayMember = "fidanadi";
                comboBoxfidanseç.ValueMember = "fidanid";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadSalesData()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM satislar", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewsatislar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış verileri yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void buttonalışverişitamamla_Click(object sender, EventArgs e)
        {
            selectedFidanId = Convert.ToInt32(comboBoxfidanseç.SelectedValue);
            selectedFidanAdi = comboBoxfidanseç.Text;
            adet = Convert.ToInt32(textBoxadetgir.Text);
            decimal fidanFiyati = GetFidanPrice(selectedFidanId);

            toplamTutar = adet * fidanFiyati;

            try
            {
                conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("INSERT INTO satislar (satilanfidanid, satilanfidanadeti, toplamtutar) VALUES (@fidanId, @adet, @toplamTutar)", conn);
                cmd.Parameters.AddWithValue("@fidanId", selectedFidanId);
                cmd.Parameters.AddWithValue("@adet", adet);
                cmd.Parameters.AddWithValue("@toplamTutar", toplamTutar);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Satış başarılı!");

                LoadSalesData();

                PrintReceipt();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış kaydı eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private decimal GetFidanPrice(int fidanId)
        {
            decimal price = 0;
            try
            {
                conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("SELECT fidanfiyati FROM fidan WHERE fidanid = @fidanId", conn);
                cmd.Parameters.AddWithValue("@fidanId", fidanId);

                conn.Open();
                price = Convert.ToDecimal(cmd.ExecuteScalar());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fidan fiyatı alınırken bir hata oluştu: " + ex.Message);
            }

            return price;
        }

        private void PrintReceipt()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            int yPos = 20;
            int lineHeight = 25;

            g.DrawString("Fidan Satış Fişi", new Font("Arial", 16, FontStyle.Bold), brush, 100, yPos);
            yPos += lineHeight;

            g.DrawString("Fidan Adı: " + selectedFidanAdi, font, brush, 20, yPos);
            yPos += lineHeight;

            g.DrawString("Adet: " + adet, font, brush, 20, yPos);
            yPos += lineHeight;

            g.DrawString("Fiyat: " + GetFidanPrice(selectedFidanId).ToString("C"), font, brush, 20, yPos);
            yPos += lineHeight;

            g.DrawString("Toplam Tutar: " + toplamTutar.ToString("C"), font, brush, 20, yPos);
            yPos += lineHeight;

            g.DrawLine(Pens.Black, 20, yPos, 280, yPos);
            yPos += 10;

            g.DrawString("Teşekkür ederiz!", font, brush, 20, yPos);
        }
    }
}
