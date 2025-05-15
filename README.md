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


## 📸 Ekran Görüntüleri

![Ekran görüntüsü 2025-05-15 032013](https://github.com/user-attachments/assets/7cd4cf88-178e-4d29-a276-1f751ef4d9c5)
![Ekran görüntüsü 2025-05-15 031804](https://github.com/user-attachments/assets/db9f799d-aa91-4df0-be62-8344a4a0ce42)
![Ekran görüntüsü 2025-05-15 031746](https://github.com/user-attachments/assets/4639dcfd-7f66-428c-b6d2-44ee9c104435)
![Ekran görüntüsü 2025-05-15 031733](https://github.com/user-attachments/assets/12df0255-74f0-4e56-bb53-447fb1ae3229)
![Ekran görüntüsü 2025-05-15 031641](https://github.com/user-attachments/assets/492e7cb0-51a5-49f7-8e6b-4c754def24d6)
![Ekran görüntüsü 2025-05-15 031620](https://github.com/user-attachments/assets/ef72bbb1-0ba0-4229-a74c-1a65be3e4ca2)
![Ekran görüntüsü 2025-05-15 031602](https://github.com/user-attachments/assets/8062b9ce-89ec-42e0-bd70-2535d9670581)
![Ekran görüntüsü 2025-05-15 031541](https://github.com/user-attachments/assets/9c9f7e30-8d72-4d73-b8c9-ea72a1f2fef7)
![Ekran görüntüsü 2025-05-15 031258](https://github.com/user-attachments/assets/7c11b06f-f262-48e2-bd76-2e2a68c10ce1)
![Ekran görüntüsü 2025-05-15 031242](https://github.com/user-attachments/assets/2f88b10a-19c9-451f-ba99-7c00307d802c)
![Ekran görüntüsü 2025-05-15 031215](https://github.com/user-attachments/assets/a765111c-1309-4146-8308-fc497ad2c83a)
![Ekran görüntüsü 2025-05-15 031144](https://github.com/user-attachments/assets/07661329-87b2-423d-9d7b-208fae9ba9db)
![Ekran görüntüsü 2025-05-15 031128](https://github.com/user-attachments/assets/5328913a-cc13-4f65-ba45-954dfd573e99)
![Ekran görüntüsü 2025-05-15 031011](https://github.com/user-attachments/assets/f1030253-a430-4f1c-8aae-af0162bd6a6e)
![Ekran görüntüsü 2025-05-15 030940](https://github.com/user-attachments/assets/4dffb213-0402-42a8-8119-b78a6029f66d)
![Ekran görüntüsü 2025-05-15 030907](https://github.com/user-attachments/assets/76497ecb-bbbd-4a50-b564-b7d38ea974f3)
![Ekran görüntüsü 2025-05-15 030809](https://github.com/user-attachments/assets/91635f3f-5f7a-4a11-8b4d-9eb35faf794c)
![Ekran görüntüsü 2025-05-15 030749](https://github.com/user-attachments/assets/c0ee19f3-40f3-42f3-830b-55f5a091ef40)

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
└── Program.cs                      # Uygulama giriş noktası (.NET 8)


---


