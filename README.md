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


![Ekran görüntüsü 2025-05-15 030907](https://github.com/user-attachments/assets/bb486c08-d324-4fcf-b8cf-26c7f8261bd0)
![Ekran görüntüsü 2025-05-15 030809](https://github.com/user-attachments/assets/0985d886-ca9a-4228-affc-443582605b94)
![Ekran görüntüsü 2025-05-15 030749](https://github.com/user-attachments/assets/ebe06b84-9d36-4867-a1ab-aa084394406c)
![Ekran görüntüsü 2025-05-15 032013](https://github.com/user-attachments/assets/557bf72f-236f-4279-bb79-e7bb3eded887)
![Ekran görüntüsü 2025-05-15 031804](https://github.com/user-attachments/assets/96184e11-ac08-4b57-8008-15c989066035)
![Ekran görüntüsü 2025-05-15 031746](https://github.com/user-attachments/assets/1a8317c8-a630-4a59-ad80-2204aa58d909)
![Ekran görüntüsü 2025-05-15 031733](https://github.com/user-attachments/assets/d5b84a12-7c25-4018-ba4a-60d602d495e7)
![Ekran görüntüsü 2025-05-15 031641](https://github.com/user-attachments/assets/aaf6cd94-fbab-46ed-942b-11ed5e5ddb3d)
![Ekran görüntüsü 2025-05-15 031620](https://github.com/user-attachments/assets/8f47259d-4b84-4696-aa48-615b1b32a443)
![Ekran görüntüsü 2025-05-15 031602](https://github.com/user-attachments/assets/b9850acc-a3b7-4672-961b-de26a24b35a8)
![Ekran görüntüsü 2025-05-15 031541](https://github.com/user-attachments/assets/b25fd640-e1c6-4159-a1b3-2ba276cf0446)
![Ekran görüntüsü 2025-05-15 031258](https://github.com/user-attachments/assets/a22ea0d1-18ca-407d-9df5-9388b414bd63)
![Ekran görüntüsü 2025-05-15 031242](https://github.com/user-attachments/assets/2100bae8-ca21-4922-829f-3149d1beaedb)
![Ekran görüntüsü 2025-05-15 031215](https://github.com/user-attachments/assets/8bcd64c4-36c9-41dd-b690-41ca477f0c63)
![Ekran görüntüsü 2025-05-15 031144](https://github.com/user-attachments/assets/f9d2dcf8-3246-42a3-a527-2c8c103f0bb9)
![Ekran görüntüsü 2025-05-15 031128](https://github.com/user-attachments/assets/e9336594-022c-40a9-a547-2b391ed55417)
![Ekran görüntüsü 2025-05-15 031011](https://github.com/user-attachments/assets/37bede1c-b94d-4b32-8ac6-ad248cf0e8fb)
![Ekran görüntüsü 2025-05-15 030940](https://github.com/user-attachments/assets/dcef69ed-05da-40b9-b79d-c27c2a4d9791)

