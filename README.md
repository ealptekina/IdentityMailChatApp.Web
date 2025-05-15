# IdentityMailChatApp.Web

# 📬 IdentityMailChatApp – ASP.NET Core 8.0 ile Gelişmiş Mail Uygulaması

Kullanıcıların güvenli bir şekilde birbirine e-posta benzeri mesajlar gönderebildiği, okunma ve silinme durumlarının izlenebildiği modern bir **Mail Uygulaması**. Projede, ASP.NET Core 8.0 ve Identity kullanılarak **kimlik doğrulama**, **profil yönetimi** ve **mesajlaşma sistemi** başarıyla entegre edildi.

---

## 🚀 Proje Özeti

Bu proje, .NET ekosisteminde tam işlevsel bir mesajlaşma altyapısının nasıl oluşturulacağını göstermek amacıyla geliştirilmiştir. Amaç, hem **kullanıcı yönetimini** hem de **mesaj trafiğini** sade, güvenli ve ölçeklenebilir bir yapıyla birleştirmektir.

> 📌 ASP.NET Core öğrenme sürecimde gerçek bir senaryo üzerinden uygulamalı olarak tüm yapıyı sıfırdan inşa ettim.

---

## 🛠️ Kullanılan Teknolojiler

| Katman       | Teknolojiler                                 |
|--------------|----------------------------------------------|
| Backend      | ASP.NET Core 8.0 MVC, Entity Framework Core  |
| Identity     | ASP.NET Core Identity (şifreleme + giriş/çıkış) |
| Database     | MS SQL Server (Code First Migration)         |
| Frontend     | Razor View, HTML5, CSS3, Bootstrap 4         |
| UI Library   | SweetAlert (bildirimler)                     |
| ORM + Query  | LINQ + MS SQL Server                         |
| Mimarî       | Tek katmanlı, sade ve genişletilebilir yapı |

---

## 🎯 Uygulama Özellikleri

### 🔐 Kimlik Doğrulama & Hesap Yönetimi
- Kullanıcı kaydı (email, parola, ad, soyad)
- Giriş/çıkış işlemleri
- Şifre hatası sonrası geçici bloke özelliği
- Kullanıcı bilgilerini güncelleme (profil sayfası)

### ✉️ Mesajlaşma Sistemi
- 📥 Gelen Kutusu: Kullanıcının aldığı tüm mesajlar
- 📤 Gönderilenler: Kullanıcının gönderdiği tüm mesajlar
- 🗑️ Çöp Kutusu: Silinen mesajlar
- 🔍 Arama ve filtreleme desteği (konuya veya göndericiye göre)
- 📌 Çoklu seçim ile mesaj silme veya taşıma
- ✔️ Okundu/okunmadı durumu takibi (IsRead)

### 📝 Yeni Mesaj Gönderimi
- Alıcı adı veya e-posta ile mesaj gönderimi
- Konu + mesaj içeriği ile mail formu
- SweetAlert ile kullanıcıya bildirimler
- Sunucu tarafı validasyonlar

### 👤 Profil Sayfası
- Kullanıcı adı, soyadı ve e-posta bilgileri düzenlenebilir
- Canlı sayaçlarla alınan/gönderilen mesaj sayısı
- Profil fotoğrafı desteği (opsiyonel)

---

## 🗂️ Proje Yapısı

```plaintext
IdentityMailChatApp.Web/
│
├── Connected Services/             # Harici servis bağlantıları
├── Dependencies/                   # NuGet bağımlılıkları
├── Properties/                     # Proje ayarları (ör. launchSettings.json)
├── wwwroot/                        # Statik dosyalar (CSS, JS, görseller)
├── Context/                        # DbContext sınıfı (EF Core ile veritabanı bağlantısı)
├── Controllers/                    # MVC Controller sınıfları
├── Entities/                       # Veritabanı entity (model) sınıfları
├── Migrations/                     # Entity Framework migration dosyaları
├── Models/                         # Domain modelleri veya form modelleri
├── ViewComponents/                 # Razor ViewComponent sınıfları
├── ViewModels/                     # UI katmanında kullanılan ViewModel sınıfları
│
├── Views/
│   ├── Account/                    # Giriş, kayıt, şifre işlemleri view dosyaları
│   ├── Home/                       # Anasayfa view dosyaları
│   ├── MailChat/                   # Mail/chat arayüzü view dosyaları
│   ├── Profile/                    # Kullanıcı profil sayfası view dosyaları
│   └── Shared/
│       ├── Components/             # Paylaşılan ViewComponent view dosyaları
│       ├── _Layout.cshtml          # Genel layout dosyası (örnek)
│       └── PartialView'ler         # Ortak kullanılan diğer kısımlar
│
├── _ViewImports.cshtml             # Razor için namespace ve tag helper tanımlamaları
├── _ViewStart.cshtml               # Razor view'lar için başlangıç yapılandırması
│
├── appsettings.json                # Uygulama yapılandırma ayarları
└── Program.cs                      # Uygulama giriş noktası (.NET 6+)


---

## 📸 Ekran Görüntüleri


