# 🛡️ Sigortacım - Akıllı Sigorta Platformu

.NET MVC ile Geliştirilen Yapay Zeka Destekli Modern Sigorta Portalı

Sigortacım, sigorta sektörüne yönelik geliştirilmiş kapsamlı bir web platformudur. 
Instagram API entegrasyonu, çok dilli destek ve dinamik içerik yönetimi ile zenginleştirilmiş modern bir sigorta çözümü sunar.


🚀 Yapay Zeka (AI) ve Harici API Entegrasyonlarının Detaylı İncelemesi

🤖 Google Gemini  | Sıkça Sorulan Sorular (SSS) için otomatik Soru-Cevap Seti Üretimi  |	Yönetim Paneli - SSS Yönetimi Modülü |

 - Tek bir istek ile sigorta konularına özel, Türkçe ve İngilizce dillerinde içerik oluşturulur.
 - Yöneticilerin zaman kaybetmeden, yapay zeka desteğiyle çok dilli SSS içeriklerini anında üretmesini ve veritabanına kaydetmesini sağlar.

🎨 Hugging Face API | Metin girdisine dayalı Görüntü (Fotoğraf) Üretimi | Yönetim Paneli - Hizmetler Modülü | 

 - Hizmet açıklaması (prompt) API'ye gönderilerek, o hizmetin içeriğine özel ve benzersiz bir görsel dinamik olarak üretilir.
 - Projenin stok görsel bağımlılığını ortadan kaldırır; her bir hizmet için yüksek kaliteli, bağlama uygun görseller sunarak görsel zenginliği artırır.

📈 RapidAPI | 	Sosyal Medya (Instagram) Gerçek Zamanlı Takipçi Sayısı Çekimi | Ön Yüz (Public Site) - Üst Menü/Header |

 - DefaultController içindeki asenkron (async Task) metot ile harici API'ye istek atılarak güncel takipçi sayısı çekilir.
 - Sitenin sadece statik değil, aynı zamanda dinamik ve güncel verileri de gösterebildiğini kanıtlar; sosyal medya varlığı hakkında şeffaflık sunar.
  

🌍 Çoklu Dil Desteği (i18n)

- **Türkçe - İngilizce** dil geçişi sağlanmıştır
- `@Resources.resx` dosyaları üzerinden lokalizasyon yapılmıştır
- Dinamik dil değiştirme özelliği


## 🎯 Temel Özellikler

## 👥 Kullanıcı Paneli (UI)
- ✅ Anasayfa ve Hero Section
- ✅ Hizmetler listesi ve detay sayfaları
- ✅ Hakkımızda ve Ekibimiz bölümü
- ✅ SSS (Sıkça Sorulan Sorular)
- ✅ İletişim formu
- ✅ Responsive tasarım

## 👑 Admin Paneli
- ✅ Dashboard ve istatistikler
- ✅ Hizmet yönetimi (CRUD işlemleri)
- ✅ SSS yönetimi
- ✅ Ekip üyesi yönetimi


## 🏗️ Mimari & Teknolojiler

### Backend
| Teknoloji | Açıklama |
|-----------|----------|
| 💻 **.NET MVC** | ASP.NET MVC Framework |
| 🗃️ **MSSQL** | Veritabanı sistemi |
| 🔐 **Entity Framework** | ORM (Code First yaklaşımı) |
| 🎯 **Repository Pattern** | Veri erişim katmanı |
| 🔑 **Identity** | Kullanıcı kimlik doğrulama |

## Frontend
| Teknoloji | Açıklama |
|-----------|----------|
| 🎨 **Bootstrap 5** | UI Framework |
| ⚡ **jQuery** | JavaScript kütüphanesi |
| 🖼️ **Font Awesome** | Icon kütüphanesi |
| 📱 **Responsive Design** | Mobil uyumlu tasarım |


## API Entegrasyonları
| API | Kullanım Alanı |
|-----|----------------|
| 📸 **Instagram Scraper API** | Takipçi sayısı çekme (RapidAPI) |
| 🌐 **i18n Resources** | Dil desteği |
| ❓ **Gemini API** | SSS (Sık Sorulan Sorular) için soru/cevap çekme |
| 🖼 **Hugging Face API** | Hizmetler için görsel oluşturma |



## 🚀 Kurulum

### Gereksinimler
- Visual Studio 2019 veya üzeri
- .NET Framework 4.7.2 veya üzeri
- MSSQL Server 2016 veya üzeri
- IIS Express (Development için)

### Adım Adım Kurulum

1. **Projeyi Klonlayın**
```bash
git clone https://github.com/NurdanOz/Insurence.git
cd Insurence
```

2. **Veritabanı Bağlantısını Yapılandırın**
`Web.config` dosyasında connection string'i düzenleyin:
```xml
<connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=YOUR_SERVER;Database=InsurenceDb;Trusted_Connection=True;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

3. **NuGet Paketlerini Yükleyin**
```bash
Update-Package -Reinstall
```

4. **Veritabanını Oluşturun**
Package Manager Console'da:
```bash
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```

5. **Instagram API Ayarlarını Yapın**
`InstagramController.cs` dosyasında RapidAPI key'inizi ekleyin:
```csharp
client.DefaultRequestHeaders.Add("x-rapidapi-key", "YOUR_RAPIDAPI_KEY");
```

6. **Projeyi Çalıştırın**
```bash
F5 veya Ctrl+F5
```



<img width="1920" height="1004" alt="Sigorta1" src="https://github.com/user-attachments/assets/a7a18a1e-f785-4661-ad0d-645345074c3c" /> 
<img width="1920" height="1004" alt="Sigorta2" src="https://github.com/user-attachments/assets/b071a694-2efc-4ed7-9acb-09512daa572b" />
<img width="1920" height="1014" alt="Sigorta3" src="https://github.com/user-attachments/assets/97b1c35c-29ef-4819-9def-7dc8cbe86b65" />
<img width="1920" height="1017" alt="Sigorta4" src="https://github.com/user-attachments/assets/79c81016-c0e0-4d2b-b74a-7c2ae5184657" />
<img width="1920" height="1035" alt="Sigorta5" src="https://github.com/user-attachments/assets/fe80c41c-f76e-4747-ae87-c614578d385d" />
<img width="1920" height="1021" alt="Sigorta6" src="https://github.com/user-attachments/assets/75efb54b-e099-45d2-8ec0-381ac7d85ba4" />
<img width="1920" height="1021" alt="Sigorta7" src="https://github.com/user-attachments/assets/0004945e-09c0-4937-8d25-c489e0ed3bc2" />
<img width="1920" height="1011" alt="Sigorta8" src="https://github.com/user-attachments/assets/e6ef5531-fd97-4cb5-adc4-d64c2403da8d" />
<img width="1920" height="1000" alt="İngilizce1" src="https://github.com/user-attachments/assets/b0926b24-32e7-4b67-b8db-7d838c3b5733" />
<img width="1920" height="1021" alt="İngilizce2" src="https://github.com/user-attachments/assets/83709299-19ab-40f0-8812-22b96a538c63" />
<img width="1920" height="1007" alt="HİZMETLERAİ1" src="https://github.com/user-attachments/assets/a3e45287-5907-4509-839d-11d87eaa9cff" />
<img width="1920" height="1017" alt="HİZMETLERAİ2" src="https://github.com/user-attachments/assets/4ffe03a3-837e-4e03-b8a3-40a3138b1766" />
<img width="1920" height="1004" alt="HİZMETLERAİ3" src="https://github.com/user-attachments/assets/01805c4b-270a-4b6f-83ac-18dcc7b21223" />
<img width="1920" height="1014" alt="SSSAİ1" src="https://github.com/user-attachments/assets/8cc3c5dd-52ed-4d1b-a027-731f79e2751b" />
<img width="1920" height="1017" alt="SSSAİ2" src="https://github.com/user-attachments/assets/9e47c408-cde7-4cbe-88d8-4bad63065a07" />
<img width="1920" height="1011" alt="SSSAİ3" src="https://github.com/user-attachments/assets/85cbf625-b0bb-4123-8d61-a6479962fe5d" />
<img width="1920" height="1004" alt="SSSAİ4" src="https://github.com/user-attachments/assets/203d52b2-5b9d-4677-84f6-763c5b552750" />
<img width="1920" height="1007" alt="Dashboard" src="https://github.com/user-attachments/assets/f7367bfe-7c8c-43c7-8a95-c927cbea637f" />
<img width="1920" height="1004" alt="Ekip1" src="https://github.com/user-attachments/assets/6250369b-c008-4f22-b2ae-9ee0ca754584" />
<img width="1920" height="1011" alt="Ekip2" src="https://github.com/user-attachments/assets/4738434f-e703-4239-bba3-0980b756f0e5" />
<img width="1920" height="1007" alt="MüşteriY1" src="https://github.com/user-attachments/assets/0e80fc4f-843f-405f-8832-ce4254127e08" />
<img width="1920" height="990" alt="MüşteriY2" src="https://github.com/user-attachments/assets/9440b452-2bfb-49a7-b9be-b7e47accf15b" />




