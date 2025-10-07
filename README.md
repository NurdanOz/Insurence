# 🛡️ Sigortacım - Akıllı Sigorta Platformu

.NET MVC ile Geliştirilen Yapay Zeka Destekli Modern Sigorta Portalı

Sigortacım, sigorta sektörüne yönelik geliştirilmiş kapsamlı bir web platformudur. 
Instagram API entegrasyonu, çok dilli destek ve dinamik içerik yönetimi ile zenginleştirilmiş modern bir sigorta çözümü sunar.

---


## ✨ Öne Çıkan Özellikler

### 🌍 Çoklu Dil Desteği (i18n)
- **Türkçe - İngilizce** dil geçişi sağlanmıştır
- `@Resources.resx` dosyaları üzerinden lokalizasyon yapılmıştır
- Dinamik dil değiştirme özelliği

### 📱 Instagram API Entegrasyonu
- Sağ üst köşede gerçek zamanlı **Instagram takipçi sayısı** gösterilir
- RapidAPI üzerinden **Instagram Profile Scraper API** ile veri çekilir
- Takipçi sayısı formatlanarak görüntülenir (örn: 12.3K)

| Özellik | Açıklama |
|---------|----------|
| 📊 **Gerçek Zamanlı Veri** | API'den anlık takipçi sayısı çekilir |
| 🔄 **Otomatik Güncelleme** | Sayfa yüklendiğinde veri güncellenir |
| 🎨 **Formatlanmış Görünüm** | Sayılar K/M formatında gösterilir |

---

## 🎯 Temel Özellikler

### 👥 Kullanıcı Paneli (UI)
- ✅ Anasayfa ve Hero Section
- ✅ Hizmetler listesi ve detay sayfaları
- ✅ Hakkımızda ve Ekibimiz bölümü
- ✅ SSS (Sıkça Sorulan Sorular)
- ✅ İletişim formu
- ✅ Blog ve haberler
- ✅ Responsive tasarım

### 👑 Admin Paneli
- ✅ Dashboard ve istatistikler
- ✅ Hizmet yönetimi (CRUD işlemleri)
- ✅ SSS yönetimi
- ✅ Blog/Haber yönetimi
- ✅ Ekip üyesi yönetimi
- ✅ İletişim mesajları yönetimi
- ✅ Kullanıcı yönetimi

---

## 🏗️ Mimari & Teknolojiler

### Backend
| Teknoloji | Açıklama |
|-----------|----------|
| 💻 **.NET MVC** | ASP.NET MVC Framework |
| 🗃️ **MSSQL** | Veritabanı sistemi |
| 🔐 **Entity Framework** | ORM (Code First yaklaşımı) |
| 🎯 **Repository Pattern** | Veri erişim katmanı |
| 🔑 **Identity** | Kullanıcı kimlik doğrulama |

### Frontend
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

---

## 📊 Veritabanı Yapısı

### Ana Tablolar
```
📦 Insurence Database
 ┣ 📂 Users (Kullanıcılar)
 ┣ 📂 Services (Hizmetler)
 ┣ 📂 FAQs (SSS)
 ┣ 📂 TeamMembers (Ekip Üyeleri)
 ┣ 📂 BlogPosts (Blog Yazıları)
 ┣ 📂 ContactMessages (İletişim Mesajları)
 ┗ 📂 Settings (Ayarlar)
```

---

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

---

## 🔑 Admin Panel Giriş Bilgileri

```
Email: admin@sigortacim.com
Şifre: Admin123!
```

> ⚠️ **Önemli:** Üretim ortamında mutlaka güçlü bir şifre kullanın!

---

## 📱 API Kullanımı

### Instagram Takipçi Sayısı Endpoint

## 🌍 Çoklu Dil Desteği

### Dil Değiştirme



### Kaynak Dosyaları
```
📦 App_GlobalResources
 ┣ 📜 Resources.resx (Türkçe)
 ┗ 📜 Resources.en.resx (İngilizce)
```


## 🎨 Özelleştirme

## 🔒 Güvenlik

- ✅ SQL Injection koruması (Entity Framework)
- ✅ XSS (Cross-Site Scripting) koruması
- ✅ CSRF Token kullanımı
- ✅ Şifre hashleme (Identity)
- ✅ Rol tabanlı yetkilendirme

---

## 📈 Performans

- ⚡ Lazy loading
- ⚡ Image optimization
- ⚡ Minification (CSS/JS)
- ⚡ Caching stratejileri
- ⚡ Asenkron API çağrıları

---


## 🚀 Gelecek Güncellemeler

- [ ] Mobil uygulama (React Native)
- [ ] Real-time notifications (SignalR)
- [ ] AI destekli chatbot
- [ ] Multi-tenant architecture
- [ ] GraphQL API
- [ ] Docker containerization

---

## 🤝 Katkıda Bulunma

1. Fork yapın
2. Feature branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'feat: Add amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Pull Request açın

---

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.



