EDUTRACK: AKADEMİK TAKİP VE PERFORMANS YÖNETİM SİSTEMİ

 PROJENİN ÖZETİ:
Bu proje, eğitim kurumlarında öğrenci kayıtlarını tutmak, eğitim modülleri (dersler) tanımlamak ve bu modüller üzerinden öğrenci performansını analiz etmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır. 
Proje kapsamında C# programlama dili ve Windows Forms arayüzü kullanılmıştır.

 TEKNİK ALTYAPI VE VERİ YAPILARI:
Ödev dokümanında belirtilen zorunlu teknik şartlar projeye şu şekilde yansıtılmıştır:
    • Array (Dizi): Başarı seviyeleri ("Zayıf", "Orta", "İyi", "Mükemmel") sabit bir dizi içerisinde tanımlanmış ve hesaplama algoritmasında bu diziden faydalanılmıştır.
    • List (Dinamik Listeler): Sisteme eklenen her öğrenci ve her eğitim modülü, programın çalışma süresince List<T> yapılarında saklanmıştır. Bu sayede sınırsız veri girişi imkanı sağlanmıştır.
    • Dictionary (Sözlük): Projenin en kritik noktası olan performans eşleştirmesinde, Öğrenci ID’leri "Anahtar" (Key), Performans nesneleri ise "Değer" (Value) olarak eşleştirilerek Dictionary yapısında tutulmuştur.

 ÖNE ÇIKAN ÖZELLİKLER:
    • Otomatik Başarı Hesaplama: Kullanıcının girdiği Ortalama Not ve Devam Yüzdesi değerlerine göre sistem, arka planda başarı seviyesini otomatik olarak belirlemektedir.
    • Kalıcı Veri Depolama (Sahte Veritabanı): Program kapatıldığında verilerin kaybolmaması için XML Serileştirme yöntemi kullanılmıştır.
    Veriler ogrenciler.xml ve moduller.xml dosyalarında saklanmaktadır; program tekrar açıldığında bu veriler otomatik olarak DataGridView üzerine yüklenmektedir.
    • Dinamik Arayüz: Bir sekmede eklenen öğrenci veya modül, "Performans Takibi" sekmesindeki seçim kutularında (ComboBox) anlık olarak güncellenmektedir.

KULLANILAN NESNELER (MODEL):
Proje OOP (Nesne Yönelimli Programlama) prensiplerine uygun olarak 3 ana sınıftan oluşmaktadır:
    1. Ogrenci Sınıfı: Kimlik ve iletişim bilgilerini tutar.
    2. EgitimModulu Sınıfı: Ders içerik ve süre bilgilerini tutar.
    3. Performans Sınıfı: Akademik sonuç verilerini tutar.

 SONUÇ:
EduTrack projesi, bir yazılım geliştirme sürecindeki analiz, tasarım ve kodlama aşamalarının tamamı uygulanarak tek kişi tarafından (tüm roller üstlenilerek) başarıyla tamamlanmıştır. 
Uygulama, hata kontrolleri (Validation) yapılmış ve kullanıcı dostu bir arayüzle teslim edilmeye hazır hale getirilmiştir.
