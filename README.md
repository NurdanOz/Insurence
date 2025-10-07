# 🛡️ Sigortacım - Akıllı Sigorta Platformu

.NET MVC ile Geliştirilen Yapay Zeka Destekli Modern Sigorta Portalı

Sigortacım, sigorta sektörüne yönelik geliştirilmiş kapsamlı bir web platformudur. 
Instagram API entegrasyonu, çok dilli destek ve dinamik içerik yönetimi ile zenginleştirilmiş modern bir sigorta çözümü sunar.


🚀 Yapay Zeka (AI) ve Harici API Entegrasyonlarının Detaylı İncelemesi

🤖 Google Gemini  | Sıkça Sorulan Sorular (SSS) için otomatik Soru-Cevap Seti Üretimi  |	Yönetim Paneli - SSS Yönetimi Modülü |

 -Tek bir istek ile sigorta konularına özel, Türkçe ve İngilizce dillerinde içerik oluşturulur.
 -Yöneticilerin zaman kaybetmeden, yapay zeka desteğiyle çok dilli SSS içeriklerini anında üretmesini ve veritabanına kaydetmesini sağlar.

🎨 Hugging Face API | Metin girdisine dayalı Görüntü (Fotoğraf) Üretimi | Yönetim Paneli - Hizmetler Modülü | 

 -Hizmet açıklaması (prompt) API'ye gönderilerek, o hizmetin içeriğine özel ve benzersiz bir görsel dinamik olarak üretilir.
 -Projenin stok görsel bağımlılığını ortadan kaldırır; her bir hizmet için yüksek kaliteli, bağlama uygun görseller sunarak görsel zenginliği artırır.

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

### API Entegrasyonları
| API | Kullanım Alanı |
|-----|---------------|
| 📸 **Instagram Scraper API** | Takipçi sayısı çekme (RapidAPI) |
| 🌐 **i18n Resources** | Dil desteği |


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



