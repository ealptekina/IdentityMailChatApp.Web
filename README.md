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

![image](https://github.com/user-attachments/assets/2faa08b5-ca00-4fe3-8ee6-f3fbd4085201)
![image](https://github.com/user-attachments/assets/9da2bb18-b8cc-4431-944e-225c6dcf5b3b)
![image](https://github.com/user-attachments/assets/ab4ca01d-b65e-473a-814d-9344c7f62b36)
![image](https://github.com/user-attachments/assets/ce699963-90dc-4257-bbc3-db84eec6b764)
![image](https://github.com/user-attachments/assets/d03200d6-82b6-480c-9d70-2b32cd598fe0)
![image](https://github.com/user-attachments/assets/16e597e2-a985-4f18-a5df-0cd74b8a408d)
![image](https://github.com/user-attachments/assets/b5d67cd3-c018-40b4-8695-d1d38a2f0c76)
![image](https://github.com/user-attachments/assets/b9be76ca-fa0e-4877-8b09-9c02883fbbbc)
![image](https://github.com/user-attachments/assets/55d1ecaf-ff98-4673-9fdc-ec2a87a87005)
![image](https://github.com/user-attachments/assets/229c8660-4079-47d4-9a75-722c75159fd4)
![image](https://github.com/user-attachments/assets/a49ec72b-ab6d-4efd-88ce-8545e997512e)
![image](https://github.com/user-attachments/assets/8c294fbe-1852-4c19-9fb6-ae5ef10485f5)
![image](https://github.com/user-attachments/assets/5215cf69-04d0-4527-8381-629de6c3f664)
![image](https://github.com/user-attachments/assets/aa64d635-3810-4d33-ab25-6e5e4353793d)
![image](https://github.com/user-attachments/assets/08a2d98b-8610-43b0-bd6a-7cdcd0757d2d)
![image](https://github.com/user-attachments/assets/0496b9ba-7ece-470c-a150-6387f0570037)
![image](https://github.com/user-attachments/assets/5410c1ed-d481-4e8e-bdf0-448b66c3d2da)
![image](https://github.com/user-attachments/assets/8c3a6bf5-5b41-443b-ae41-7baad1232e62)
![image](https://github.com/user-attachments/assets/bd1550bd-eafa-4340-bd0b-a2f07a7a804c)


