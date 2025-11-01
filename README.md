# Classroom Management System

ASP.NET Core MVC tabanlı bir sınıf yönetim sistemi. Öğretmenler ve öğrenciler için sınıf oluşturma, ödev yönetimi, duyuru paylaşımı ve değerlendirme özellikleri sunar.

## 🚀 Özellikler

- **Kullanıcı Yönetimi**: ASP.NET Core Identity ile kimlik doğrulama
- **Sınıf Yönetimi**: Öğretmenler sınıf oluşturabilir, öğrenciler sınıflara katılabilir
- **Ödev Sistemi**: Ödev oluşturma, yükleme ve değerlendirme
- **Duyurular**: Sınıf içi duyuru paylaşımı
- **Yorumlar**: Ödevler ve duyurular üzerinde yorum yapabilme
- **Öğretmen Değerlendirme**: Öğrenciler öğretmenleri değerlendirebilir

## 📋 Gereksinimler

- .NET 8.0 SDK
- SQL Server (LocalDB veya SQL Server)
- Visual Studio 2022 veya Visual Studio Code

## 🔧 Kurulum

1. Projeyi klonlayın:
```bash
git clone https://github.com/kullaniciadi/bitirmeOdevim.git
cd bitirmeOdevim/Classroom
```

2. `appsettings.json` dosyasını oluşturun:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-Classroom-xxx;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```

3. Paketleri yükleyin:
```bash
dotnet restore
```

4. Veritabanını oluşturun:
```bash
dotnet ef database update
```

5. Uygulamayı çalıştırın:
```bash
dotnet run
```

## 📁 Proje Yapısı

```
Classroom/
├── Areas/
│   └── Identity/          # Identity sayfaları
├── Controllers/           # MVC Controller'ları
│   ├── ClassroomController.cs
│   ├── CommentController.cs
│   ├── HelloController.cs
│   ├── HomeController.cs
│   └── HomeworkController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/        # Entity Framework migrations
├── Models/                 # Veri modelleri
│   ├── Announcements.cs
│   ├── ApplicationUser.cs
│   ├── ClassRoom.cs
│   ├── Comment.cs
│   ├── Homework.cs
│   └── TeacherRating.cs
├── Views/                 # Razor view dosyaları
│   ├── Classroom/
│   ├── Homework/
│   └── Shared/
├── ViewModels/            # View modelleri
├── wwwroot/               # Statik dosyalar (CSS, JS, resimler)
│   ├── css/
│   ├── js/
│   ├── lib/               # Kütüphaneler (Bootstrap, jQuery)
│   └── uploads/           # Yüklenen dosyalar
├── Program.cs             # Uygulama giriş noktası
└── appsettings.json       # Yapılandırma dosyası
```

## 🗄️ Veritabanı Modelleri

- **ClassRoom**: Sınıf bilgileri
- **ApplicationUser**: Kullanıcı bilgileri (Identity genişletilmiş)
- **Homework**: Ödev bilgileri
- **Announcements**: Duyurular
- **Comment**: Yorumlar
- **TeacherRating**: Öğretmen değerlendirmeleri
- **Class_User**: Sınıf-Öğrenci ilişkisi
- **Homework_User**: Ödev-Öğrenci ilişkisi

## 🔐 Güvenlik

- Hassas bilgiler (ConnectionString, API anahtarları vb.) `appsettings.json` dosyasında saklanmamalıdır
- Production ortamında `appsettings.Production.json` kullanın
- Gizli bilgiler için User Secrets veya Azure Key Vault kullanın

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

## 👨‍💻 Geliştirici

Proje bitirme ödevi kapsamında geliştirilmiştir.

## 🤝 Katkıda Bulunma

1. Fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Push edin (`git push origin feature/AmazingFeature`)
5. Pull Request açın

