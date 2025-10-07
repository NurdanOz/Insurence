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


<img width="1920" height="1004" alt="Sigorta1" src="https://github.com/user-attachments/assets/4b9a1aeb-7268-40d6-85b7-3bb5f9a2a42f" />
<img width="1920" height="1080" alt="Sigorta2" src="https://github.com/user-attachments/assets/0e993a09-4347-4731-8138-b9381f04589e" />
<img width="1920" height="1080" alt="Sigorta3" src="https://github.com/user-attachments/assets/e8f25518-afe9-4791-8ce5-283ea8cbfab3" />
<img width="1920" height="1080" alt="Sigorta4" src="https://github.com/user-attachments/assets/f25b0ae3-91f5-45eb-8435-bb1a30b37e8e" />
<img width="1920" height="1080" alt="Sigorta5" src="https://github.com/user-attachments/assets/7de79b01-f15e-47b2-8f15-5a88309b0edb" />
<img width="1920" height="1080" alt="Sigorta6" src="https://github.com/user-attachments/assets/531a5ae7-271a-4227-a99b-f287965d4da8" />
<img width="1920" height="1080" alt="Sigorta7" src="https://github.com/user-attachments/assets/b08748f6-1ae9-4784-aaac-1590a9dfc160" />
<img width="1920" height="1080" alt="Sigorta8" src="https://github.com/user-attachments/assets/6a7dfafa-eb58-4947-92bc-9906ac1ac889" />
<img width="1920" height="1000" alt="İngilizce1" src="https://github.com/user-attachments/assets/9b7f96bd-1271-4b92-ad1f-471c9e7dee02" />
<img width="1920" height="1080" alt="İngilizce2" src="https://github.com/user-attachments/assets/8f28055e-99b4-46bc-9e28-5b9fd6936970" />
<img width="1920" height="1007" alt="HİZMETLERAİ1" src="https://github.com/user-attachments/assets/2dfa5df4-10d0-4142-96b9-829159c2e22f" />
<img width="1920" height="1017" alt="HİZMETLERAİ2" src="https://github.com/user-attachments/assets/24f5a09f-6994-4a81-81a0-416cb796424a" />
<img width="1920" height="1004" alt="HİZMETLERAİ3" src="https://github.com/user-attachments/assets/a4a9e30b-2be0-41fb-9981-0103ef669592" />
<img width="1920" height="1014" alt="SSSAİ1" src="https://github.com/user-attachments/assets/b2aaeaf0-bdd0-4733-bd99-11db36cabb65" />
<img width="1920" height="1017" alt="SSSAİ2" src="https://github.com/user-attachments/assets/5ec8742a-68c5-45b8-aa9e-77ce2e2cffbb" />
<img width="1920" height="1011" alt="SSSAİ3" src="https://github.com/user-attachments/assets/421783f3-74ca-4b14-ade6-244e92687430" />
<img width="1920" height="1004" alt="SSSAİ4" src="https://github.com/user-attachments/assets/2bccda13-0882-497a-901e-9f369bae30ae" />
<img width="1920" height="1080" alt="Dashboard" src="https://github.com/user-attachments/assets/d076fa1c-fd66-44b7-b9d6-5c53c0c9d3dd" />
<img width="1920" height="1080" alt="Ekip1" src="https://github.com/user-attachments/assets/a997a66d-9c3e-4d8b-a6e4-c023cbf13469" />
<img width="1920" height="1080" alt="Ekip2" src="https://github.com/user-attachments/assets/891a6e91-4452-42c9-acdc-6f295614a215" />
<img width="1920" height="1080" alt="MüşteriY1" src="https://github.com/user-attachments/assets/3a54a717-474a-476b-9759-f4d0d8223022" />
<img width="1920" height="1080" alt="MüşteriY2" src="https://github.com/user-attachments/assets/eb8eb666-e92a-4c27-9fb0-ff0bbd7e371d" />





 





