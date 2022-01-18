namespace JsonProject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string dosyaYolu = "C:\\Ogrenci\\OgrenciList.txt";
        List<Ogrenci> ogList = new List<Ogrenci>();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ogrenci o = new Ogrenci();
            o.ID = Convert.ToInt32(txtID.Text);
            o.Ad = txtAd.Text;
            o.Soyad = txtSoyad.Text;
            ogList.Add(o);

            Goster(ogList);
        }

        private void Goster(List<Ogrenci> ogList)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogList;
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.Open(dosyaYolu, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(dosya);
            sw.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(ogList));
            sw.Close();
            sw.Dispose();
            dosya.Close();
            MessageBox.Show("Dosya Kaydedildi!");
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            FileStream dosya = File.OpenRead(dosyaYolu);
            StreamReader dosyaOku = new StreamReader(dosya);
            string veri = dosyaOku.ReadToEnd();
            dosya.Close();
            dosyaOku.Close();
            dosyaOku.Dispose();
            List<Ogrenci> ogr = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Ogrenci>>(veri);
            Goster(ogr);
            MessageBox.Show("Liste Okundu!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            File.Delete(dosyaYolu);
        }
    }
}