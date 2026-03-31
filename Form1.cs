using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Xml.Serialization; 

namespace AkademikTakipPerformansYönetimSistemi
{

    public partial class Form1 : Form
    {
       
        string[] performansSeviyeleri = { "Zayıf", "Orta", "İyi", "Mükemmel" };  

        
        List<Ogrenci> ogrenciListesi = new List<Ogrenci>(); 
        List<EgitimModulu> modulListesi = new List<EgitimModulu>();

       
        Dictionary<int, Performans> performansVerileri = new Dictionary<int, Performans>(); 
        public Form1()
        {
            InitializeComponent();
        }
        private void VerileriKaydet()
        {
            try
            {
              
                XmlSerializer serializerOgr = new XmlSerializer(typeof(List<Ogrenci>));
                using (TextWriter writer = new StreamWriter("ogrenciler.xml"))
                {
                    serializerOgr.Serialize(writer, ogrenciListesi);
                }

               
                XmlSerializer serializerMdl = new XmlSerializer(typeof(List<EgitimModulu>));
                using (TextWriter writer = new StreamWriter("moduller.xml"))
                {
                    serializerMdl.Serialize(writer, modulListesi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message);
            }
        }
        private void VerileriYukle()
        {
            try
            {
              
                if (File.Exists("ogrenciler.xml"))
                {
                    XmlSerializer serOgr = new XmlSerializer(typeof(List<Ogrenci>));
                    using (FileStream fs = new FileStream("ogrenciler.xml", FileMode.Open))
                    {
                        ogrenciListesi = (List<Ogrenci>)serOgr.Deserialize(fs);

                        
                        dgvOgrenciler.DataSource = null;
                        dgvOgrenciler.DataSource = ogrenciListesi;
                    }
                }

              
                if (File.Exists("moduller.xml"))
                {
                    XmlSerializer serMdl = new XmlSerializer(typeof(List<EgitimModulu>));
                    using (FileStream fs = new FileStream("moduller.xml", FileMode.Open))
                    {
                        modulListesi = (List<EgitimModulu>)serMdl.Deserialize(fs);

                       
                        dgvModuller.DataSource = null;
                        dgvModuller.DataSource = modulListesi;
                    }
                }
            }
            catch (Exception ex)
            {
              
            }
            
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
           
            Ogrenci yeniOgrenci = new Ogrenci();
            yeniOgrenci.ID = int.Parse(txtID.Text); 
            yeniOgrenci.AdSoyad = txtAdSoyad.Text; 
            yeniOgrenci.Bolum = txtBolum.Text; 
            yeniOgrenci.AktifMi = cmbDurum.Text == "Aktif"; 

            
            ogrenciListesi.Add(yeniOgrenci);

         
            dgvOgrenciler.DataSource = null;
            dgvOgrenciler.DataSource = ogrenciListesi;

            
            cmbPerformansOgrenciSec.Items.Add(yeniOgrenci.AdSoyad);

            MessageBox.Show("Öğrenci başarıyla kaydedildi!");
        }

        private void btnModulEkle_Click(object sender, EventArgs e)
        {
            EgitimModulu yeniModul = new EgitimModulu();
            yeniModul.ModulKodu = txtModulKodu.Text; 
            yeniModul.ModulAdi = txtModulAdi.Text; 
            yeniModul.Seviye = cmbModulSeviye.Text; 

           
            int sure;
            if (int.TryParse(txtSure.Text, out sure))
            {
                yeniModul.Sure = sure; 
            }
            else
            {
                MessageBox.Show("Lütfen Süre (Saat) kısmına sadece sayı giriniz!");
                return; 
            }

          
            modulListesi.Add(yeniModul);
            dgvModuller.DataSource = null;
            dgvModuller.DataSource = modulListesi;

            
            cmbPerformansModulSec.Items.Add(yeniModul.ModulAdi);
           
            MessageBox.Show("Modül başarıyla eklendi.");
        }

        private void btnPerformansKaydet_Click(object sender, EventArgs e)
        {
            
            double not = double.Parse(txtOrtalamaNot.Text);
            double devam = double.Parse(txtDevamYuzdesi.Text);

            
            string sonucSeviye = "";
            if (not < 50) sonucSeviye = performansSeviyeleri[0]; 
            else if (not < 70) sonucSeviye = performansSeviyeleri[1]; 
            else if (not < 85) sonucSeviye = performansSeviyeleri[2]; 
            else sonucSeviye = performansSeviyeleri[3]; 
           
            Performans p = new Performans();
            p.OrtalamaNot = not;
            p.DevamYuzdesi = devam;
            p.BasariSeviyesi = sonucSeviye;

          
            int secilenOgrenciId = ogrenciListesi[cmbPerformansOgrenciSec.SelectedIndex].ID;

            if (performansVerileri.ContainsKey(secilenOgrenciId))
                performansVerileri[secilenOgrenciId] = p; 
            else
                performansVerileri.Add(secilenOgrenciId, p); 

            lblSonuc.Text = "Hesaplanan Seviye: " + sonucSeviye;
            MessageBox.Show("Performans verisi Dictionary'e kaydedildi!");
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl1.SelectedTab.Text == "Performans Takibi")
            {
                
                cmbPerformansOgrenciSec.Items.Clear();
                cmbPerformansModulSec.Items.Clear();

               
                foreach (var ogr in ogrenciListesi)
                {
                    cmbPerformansOgrenciSec.Items.Add(ogr.AdSoyad);
                }

                
                foreach (var mdl in modulListesi)
                {
                    cmbPerformansModulSec.Items.Add(mdl.ModulAdi);
                }
            }
        }
    }
}
