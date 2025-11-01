using Microsoft.AspNetCore.Mvc;

namespace Classroom.Controllers
{
    public class HelloController : Controller
    {
        private readonly List<dynamic> kursDetaylari = new List<dynamic>
        {
            new {
                Baslik = "Java ile Full-Stack Web Development",
                Kategori = "Web",
                Fiyat = "5000 TL",
                Sure = "8 ay",
                Saat = 400,
                Egitmen = "İbrahim Yağar",
                EgitmenPuani = 4.9,
                BaslangicTarihi = "15.09.2025",
                Seviye = "Orta",
                DersSayisi = 32,
                Sertifika = "Var",
                Aciklama = "Java ve Spring ile uçtan uca web uygulamaları geliştirme. Modern web teknolojileriyle tam kapsamlı backend ve frontend geliştirme.",
                KimlerIcin = "Temel programlama bilgisine sahip, kurumsal web uygulamaları geliştirmek isteyenler.",
                Hedefler = new[] {
                    "Java ile nesne yönelimli programlama",
                    "Spring Boot ile RESTful API geliştirme",
                    "Veritabanı yönetimi (MySQL, PostgreSQL)",
                    "React ile modern frontend geliştirme",
                    "CI/CD ve test otomasyonu"
                },
                Program = new[] {
                    "Java Temelleri ve İleri Konular",
                    "Spring Boot ile Web Geliştirme",
                    "Hibernate ile ORM",
                    "RESTful API Tasarımı",
                    "React ile Frontend Geliştirme",
                    "JWT ile Kimlik Doğrulama",
                    "Unit Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, proje tabanlı ödevler, birebir mentorluk, topluluk forumu, kod incelemeleri.",
                KariyerDestegi = "CV hazırlama, teknik mülakat simülasyonları, LinkedIn optimizasyonu, iş ilanlarına yönlendirme.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 20:00-22:00",
                    "Proje Sunumu: Her ayın sonunda",
                    "Mentorluk: Her ay birebir görüşme"
                },
                Teknolojiler = new[] { "Java", "Spring Boot", "Hibernate", "React", "MySQL", "Docker", "Git" },
                Proje = "Kurumsal bir e-ticaret platformu: Kullanıcı yönetimi, ürün yönetimi, sipariş ve ödeme sistemleri.",
                MezunYorumlari = new[] {
                    "Java ve Spring Boot'u gerçek projede uygulama fırsatı buldum. (Ali T.)",
                    "Kariyer desteği ve canlı dersler çok faydalıydı. (Zeynep S.)"
                },
                EkKaynaklar = new[] {
                    "Java resmi dokümantasyonu",
                    "Spring Boot Guides",
                    "React resmi dökümanları"
                },
                SertifikaIcerigi = "Final projesi ve teknik sınav sonrası uluslararası geçerli sertifika.",
                BaslikRenk = "#6c2eb7",
                KategoriRenk = "#38bdf8",
                SureRenk = "#fd5e53",
                Ikon = "fa-code"
            },
            new {
                Baslik = "PHP ile Full-Stack Web Development",
                Kategori = "Web",
                Fiyat = "4000 TL",
                Sure = "6 ay",
                Saat = 300,
                Egitmen = "Nazlıcan Soykan",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "01.10.2025",
                Seviye = "Başlangıç",
                DersSayisi = 24,
                Sertifika = "Var",
                Aciklama = "PHP ve MySQL ile dinamik web uygulamaları geliştirme. Laravel ile modern backend, Bootstrap ile responsive frontend.",
                KimlerIcin = "Web geliştirmeye başlamak isteyen, temel HTML/CSS bilgisi olanlar.",
                Hedefler = new[] {
                    "PHP ile backend geliştirme",
                    "Laravel ile MVC mimarisi",
                    "MySQL ile veritabanı yönetimi",
                    "Bootstrap ile responsive tasarım",
                    "Temel güvenlik ve test"
                },
                Program = new[] {
                    "PHP Temelleri",
                    "Laravel ile Proje Geliştirme",
                    "Veritabanı ve ORM",
                    "RESTful API Geliştirme",
                    "Bootstrap ile Frontend",
                    "Kullanıcı Kimlik Doğrulama",
                    "Test ve Debugging",
                    "Proje Sunumu"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, eğitmenle birebir görüşmeler.",
                KariyerDestegi = "Portföy projesi, CV hazırlama, iş başvurusu desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 19:00-21:00",
                    "Proje Sunumu: Her ay",
                    "Mentorluk: Her ay birebir görüşme"
                },
                Teknolojiler = new[] { "PHP", "Laravel", "MySQL", "Bootstrap", "Git" },
                Proje = "Blog ve içerik yönetim sistemi: Kullanıcı yönetimi, içerik ekleme, yorumlar.",
                MezunYorumlari = new[] {
                    "Laravel ile gerçek projeler geliştirdim, iş bulmam kolaylaştı. (Burak K.)"
                },
                EkKaynaklar = new[] {
                    "PHP.net dokümantasyonu",
                    "Laravel resmi dökümanları"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#fd5e53",
                KategoriRenk = "#6c2eb7",
                SureRenk = "#38bdf8",
                Ikon = "fa-paint-brush"
            },
            new {
                Baslik = ".NET Core ile Full-Stack Web Development",
                Kategori = "Web",
                Fiyat = "6000 TL",
                Sure = "8 ay",
                Saat = 420,
                Egitmen = "Yusuf Efe Yağar",
                EgitmenPuani = 4.7,
                BaslangicTarihi = "20.09.2025",
                Seviye = "Orta",
                DersSayisi = 30,
                Sertifika = "Var",
                Aciklama = "ASP.NET Core ile modern web uygulamaları geliştirme. Entity Framework ile veritabanı, React ile frontend.",
                KimlerIcin = "C# temeli olan, kurumsal web uygulamaları geliştirmek isteyenler.",
                Hedefler = new[] {
                    "ASP.NET Core ile backend geliştirme",
                    "Entity Framework ile ORM",
                    "React ile modern frontend",
                    "RESTful API geliştirme",
                    "Bulut dağıtımı ve test"
                },
                Program = new[] {
                    "C# Temelleri",
                    "ASP.NET Core ile Web API",
                    "Entity Framework Core",
                    "React ile Frontend",
                    "Kimlik Doğrulama",
                    "Unit Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, proje tabanlı ödevler, birebir mentorluk, kod incelemeleri.",
                KariyerDestegi = "CV hazırlama, LinkedIn optimizasyonu, teknik mülakat simülasyonları.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 20:00-22:00",
                    "Proje Sunumu: Her ay",
                    "Mentorluk: Her ay birebir görüşme"
                },
                Teknolojiler = new[] { "C#", "ASP.NET Core", "Entity Framework", "React", "Docker", "Git" },
                Proje = "Online rezervasyon sistemi: Kullanıcı yönetimi, rezervasyon, bildirimler.",
                MezunYorumlari = new[] {
                    "Kurumsal projelerde .NET Core kullanmaya başladım. (Gizem T.)"
                },
                EkKaynaklar = new[] {
                    "Microsoft Learn",
                    "ASP.NET Core dökümanları"
                },
                SertifikaIcerigi = "Final projesi ve teknik sınav sonrası uluslararası geçerli sertifika.",
                BaslikRenk = "#fbbf24",
                KategoriRenk = "#fd5e53",
                SureRenk = "#6c2eb7",
                Ikon = "fa-html5"
            },
            new {
                Baslik = "React Native ile Mobil Uygulama Geliştirme",
                Kategori = "Mobil",
                Fiyat = "4500 TL",
                Sure = "4 ay",
                Saat = 180,
                Egitmen = "Furkan Cebe",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "10.10.2025",
                Seviye = "Başlangıç",
                DersSayisi = 16,
                Sertifika = "Var",
                Aciklama = "React Native ile çapraz platform mobil uygulamalar. iOS ve Android için tek kod tabanı ile uygulama geliştirme.",
                KimlerIcin = "Mobil uygulama geliştirmeye başlamak isteyenler, temel JavaScript bilgisi olanlar.",
                Hedefler = new[] {
                    "React Native ile mobil uygulama geliştirme",
                    "Redux ile state yönetimi",
                    "API entegrasyonu",
                    "Uygulama yayınlama (App Store, Google Play)",
                    "Test ve hata ayıklama"
                },
                Program = new[] {
                    "React Native Temelleri",
                    "Component ve State Yönetimi",
                    "API Entegrasyonu",
                    "Navigasyon ve Routing",
                    "Redux ile State Management",
                    "Mobil UI Tasarımı",
                    "Test ve Debugging",
                    "Uygulama Yayınlama"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "Portföy oluşturma, iş bulma desteği, mülakat hazırlığı.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 21:00-23:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "React Native", "JavaScript", "Redux", "Expo", "Git" },
                Proje = "Sosyal medya uygulaması: Kullanıcı profili, gönderi paylaşımı, bildirimler.",
                MezunYorumlari = new[] {
                    "İlk mobil uygulamamı bu eğitimle markete yükledim. (Serkan D.)"
                },
                EkKaynaklar = new[] {
                    "React Native resmi dökümanları",
                    "Expo.io rehberleri"
                },
                SertifikaIcerigi = "Proje teslimi ve teknik sınav sonrası başarı sertifikası.",
                BaslikRenk = "#38bdf8",
                KategoriRenk = "#fd5e53",
                SureRenk = "#6c2eb7",
                Ikon = "fa-mobile-alt"
            },
            // Diğer kurslar da aynı sırayla eğitmen isimleri döngüsel olarak atanacak ve EgitmenPuani eklenecek
            new {
                Baslik = "Java + React ile Full-Stack Geliştirme",
                Kategori = "Web",
                Fiyat = "7000 TL",
                Sure = "8 ay",
                Saat = 420,
                Egitmen = "İbrahim Yağar",
                EgitmenPuani = 4.9,
                BaslangicTarihi = "05.09.2025",
                Seviye = "İleri",
                DersSayisi = 36,
                Sertifika = "Var",
                Aciklama = "Java ve React teknolojileriyle bütüncül geliştirme. Modern web uygulamaları için uçtan uca çözüm.",
                KimlerIcin = "Full-stack geliştirme yapmak isteyen, hem backend hem frontend öğrenmek isteyenler.",
                Hedefler = new[] {
                    "Java ile backend geliştirme",
                    "Spring Boot ile REST API",
                    "React ile modern frontend",
                    "JWT ile kimlik doğrulama",
                    "DevOps ve CI/CD"
                },
                Program = new[] {
                    "Java Temelleri",
                    "Spring Boot ile API Geliştirme",
                    "React ile Component Geliştirme",
                    "Redux ile State Management",
                    "JWT ile Kimlik Doğrulama",
                    "Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, proje tabanlı ödevler, birebir mentorluk, kod incelemeleri.",
                KariyerDestegi = "Kariyer koçluğu, referans mektubu, portföy desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 3 gün 19:00-21:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Java", "Spring Boot", "React", "Redux", "JWT", "Docker", "Git" },
                Proje = "Online eğitim platformu: Kullanıcı yönetimi, kurs ekleme, ödeme sistemi.",
                MezunYorumlari = new[] {
                    "Full-stack projede hem backend hem frontend geliştirdim. (Elif S.)"
                },
                EkKaynaklar = new[] {
                    "Spring Boot Guides",
                    "React resmi dökümanları"
                },
                SertifikaIcerigi = "Final projesi ve teknik sınav sonrası uluslararası geçerli sertifika.",
                BaslikRenk = "#6c2eb7",
                KategoriRenk = "#fbbf24",
                SureRenk = "#fd5e53",
                Ikon = "fa-layer-group"
            },
            new {
                Baslik = "ASP.NET Core + React ile Full-Stack Geliştirme",
                Kategori = "Web",
                Fiyat = "6500 TL",
                Sure = "7 ay",
                Saat = 350,
                Egitmen = "Nazlıcan Soykan",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "12.09.2025",
                Seviye = "Orta",
                DersSayisi = 28,
                Sertifika = "Var",
                Aciklama = "Backend'de .NET, frontend'de React ile güçlü çözümler. Modern web uygulamaları için tam kapsamlı eğitim.",
                KimlerIcin = "Hem backend hem frontend geliştirmek isteyenler, C# ve JavaScript temeli olanlar.",
                Hedefler = new[] {
                    "ASP.NET Core ile backend geliştirme",
                    "React ile kullanıcı arayüzü geliştirme",
                    "API ve veritabanı entegrasyonu",
                    "JWT ile kimlik doğrulama",
                    "Test ve DevOps"
                },
                Program = new[] {
                    "ASP.NET Core ile Web API",
                    "React ile Frontend",
                    "Entity Framework Core",
                    "JWT ile Kimlik Doğrulama",
                    "Unit Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, birebir mentorluk, kod incelemeleri.",
                KariyerDestegi = "İş bulma desteği, portföy incelemesi, mülakat hazırlığı.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 20:00-22:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "ASP.NET Core", "React", "C#", "Entity Framework", "JWT", "Docker", "Git" },
                Proje = "İş ilanı platformu: Kullanıcı yönetimi, ilan ekleme, başvuru sistemi.",
                MezunYorumlari = new[] {
                    "Hem .NET hem React ile gerçek projeler geliştirdim. (Murat K.)"
                },
                EkKaynaklar = new[] {
                    "Microsoft Learn",
                    "React resmi dökümanları"
                },
                SertifikaIcerigi = "Proje teslimi ve teknik sınav sonrası başarı sertifikası.",
                BaslikRenk = "#232a36",
                KategoriRenk = "#38bdf8",
                SureRenk = "#fbbf24",
                Ikon = "fa-cubes"
            },
            new {
                Baslik = "Angular + ASP.NET Core ile Full-Stack Geliştirme",
                Kategori = "Web",
                Fiyat = "6000 TL",
                Sure = "7 ay",
                Saat = 320,
                Egitmen = "Yusuf Efe Yağar",
                EgitmenPuani = 4.7,
                BaslangicTarihi = "18.09.2025",
                Seviye = "Orta",
                DersSayisi = 26,
                Sertifika = "Var",
                Aciklama = "Angular ve ASP.NET Core ile dinamik web geliştirme. Modern frontend ve güçlü backend mimarisi.",
                KimlerIcin = "Kurumsal web uygulamaları geliştirmek isteyenler, C# ve TypeScript temeli olanlar.",
                Hedefler = new[] {
                    "Angular ile modern frontend geliştirme",
                    "ASP.NET Core ile backend geliştirme",
                    "API ve veritabanı entegrasyonu",
                    "JWT ile kimlik doğrulama",
                    "Test ve DevOps"
                },
                Program = new[] {
                    "Angular Temelleri",
                    "Component ve Service Geliştirme",
                    "ASP.NET Core ile Web API",
                    "Entity Framework Core",
                    "JWT ile Kimlik Doğrulama",
                    "Unit Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, birebir mentorluk, kod incelemeleri.",
                KariyerDestegi = "Kariyer danışmanlığı, iş başvuru desteği, portföy desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 19:00-21:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Angular", "ASP.NET Core", "C#", "TypeScript", "Entity Framework", "JWT", "Docker", "Git" },
                Proje = "Online rezervasyon sistemi: Kullanıcı yönetimi, rezervasyon, bildirimler.",
                MezunYorumlari = new[] {
                    "Angular ve .NET Core ile kurumsal projeler geliştirdim. (Seda Y.)"
                },
                EkKaynaklar = new[] {
                    "Angular resmi dökümanları",
                    "Microsoft Learn"
                },
                SertifikaIcerigi = "Final projesi ve teknik sınav sonrası uluslararası geçerli sertifika.",
                BaslikRenk = "#e44d26",
                KategoriRenk = "#fbbf24",
                SureRenk = "#38bdf8",
                Ikon = "fa-angular"
            },
            new {
                Baslik = "Node.js / Express + React / Redux ile Full-Stack Web Development",
                Kategori = "Web",
                Fiyat = "5500 TL",
                Sure = "5 ay",
                Saat = 200,
                Egitmen = "Furkan Cebe",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "25.09.2025",
                Seviye = "Orta",
                DersSayisi = 20,
                Sertifika = "Var",
                Aciklama = "Modern JavaScript stack ile tam kapsamlı geliştirme. Node.js ile backend, React ile frontend.",
                KimlerIcin = "JavaScript temeli olan, modern web uygulamaları geliştirmek isteyenler.",
                Hedefler = new[] {
                    "Node.js ile backend geliştirme",
                    "Express ile RESTful API",
                    "React ve Redux ile frontend geliştirme",
                    "MongoDB ile veritabanı yönetimi",
                    "JWT ile kimlik doğrulama"
                },
                Program = new[] {
                    "Node.js Temelleri",
                    "Express ile API Geliştirme",
                    "React ile Component Geliştirme",
                    "Redux ile State Management",
                    "MongoDB ile Veritabanı",
                    "JWT ile Kimlik Doğrulama",
                    "Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, proje tabanlı ödevler, birebir mentorluk, topluluk forumu.",
                KariyerDestegi = "Mentorluk, portföy desteği, iş bulma desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 2 gün 20:00-22:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Node.js", "Express", "React", "Redux", "MongoDB", "JWT", "Docker", "Git" },
                Proje = "Sosyal medya platformu: Kullanıcı yönetimi, gönderi paylaşımı, yorumlar.",
                MezunYorumlari = new[] {
                    "Node.js ve React ile tam kapsamlı proje geliştirdim. (Ahmet B.)"
                },
                EkKaynaklar = new[] {
                    "Node.js resmi dökümanları",
                    "React ve Redux dökümanları"
                },
                SertifikaIcerigi = "Proje teslimi ve teknik sınav sonrası başarı sertifikası.",
                BaslikRenk = "#68a063",
                KategoriRenk = "#232a36",
                SureRenk = "#fd5e53",
                Ikon = "fa-node-js"
            },
            new {
                Baslik = "JavaScript ile Front-End Geliştirme",
                Kategori = "Web",
                Fiyat = "4000 TL",
                Sure = "6 ay",
                Saat = 160,
                Egitmen = "İbrahim Yağar",
                EgitmenPuani = 4.9,
                BaslangicTarihi = "02.10.2025",
                Seviye = "Başlangıç",
                DersSayisi = 18,
                Sertifika = "Var",
                Aciklama = "Modern JavaScript, HTML ve CSS ile etkileşimli web arayüzleri. Temelden ileri seviyeye front-end geliştirme.",
                KimlerIcin = "Web geliştirmeye başlamak isteyen, temel HTML/CSS bilgisi olanlar.",
                Hedefler = new[] {
                    "JavaScript ile dinamik web arayüzleri",
                    "HTML5 ve CSS3 ile responsive tasarım",
                    "DOM manipülasyonu",
                    "AJAX ve API entegrasyonu",
                    "Temel test ve hata ayıklama"
                },
                Program = new[] {
                    "HTML5 ve CSS3 Temelleri",
                    "JavaScript Temelleri",
                    "DOM Manipülasyonu",
                    "AJAX ve Fetch API",
                    "Responsive Tasarım",
                    "Bootstrap ile UI Geliştirme",
                    "Test ve Debugging",
                    "Mini Projeler"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "CV hazırlama, iş bulma desteği, portföy desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 19:00-21:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "JavaScript", "HTML5", "CSS3", "Bootstrap", "Git" },
                Proje = "Kişisel portföy sitesi: Proje galerisi, iletişim formu, blog.",
                MezunYorumlari = new[] {
                    "İlk web sitemi bu eğitimle yayına aldım. (Melis K.)"
                },
                EkKaynaklar = new[] {
                    "MDN Web Docs",
                    "freeCodeCamp JavaScript kursu"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#fbbf24",
                KategoriRenk = "#38bdf8",
                SureRenk = "#fd5e53",
                Ikon = "fa-js"
            },
            new {
                Baslik = "React.js ile Front-End Geliştirme",
                Kategori = "Web",
                Fiyat = "4500 TL",
                Sure = "5 ay",
                Saat = 140,
                Egitmen = "Nazlıcan Soykan",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "08.10.2025",
                Seviye = "Orta",
                DersSayisi = 15,
                Sertifika = "Var",
                Aciklama = "React kütüphanesiyle dinamik kullanıcı arayüzleri geliştirme. Component tabanlı modern web uygulamaları.",
                KimlerIcin = "JavaScript temeli olan, modern frontend geliştirmek isteyenler.",
                Hedefler = new[] {
                    "React ile component tabanlı geliştirme",
                    "State ve props yönetimi",
                    "API entegrasyonu",
                    "React Router ile sayfa yönetimi",
                    "Test ve hata ayıklama"
                },
                Program = new[] {
                    "React Temelleri",
                    "Component ve Props",
                    "State Management",
                    "React Router",
                    "API Entegrasyonu",
                    "Redux ile State Management",
                    "Test ve Debugging",
                    "Mini Projeler"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "Portföy desteği, iş bulma desteği, mülakat hazırlığı.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 20:00-22:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "React", "JavaScript", "Redux", "React Router", "Git" },
                Proje = "Blog uygulaması: Kullanıcı yönetimi, içerik ekleme, yorumlar.",
                MezunYorumlari = new[] {
                    "React ile gerçek projeler geliştirdim, iş bulmam kolaylaştı. (Berk A.)"
                },
                EkKaynaklar = new[] {
                    "React resmi dökümanları",
                    "freeCodeCamp React kursu"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#38bdf8",
                KategoriRenk = "#232a36",
                SureRenk = "#fbbf24",
                Ikon = "fa-react"
            },
            new {
                Baslik = "Node.js ile Back-End Geliştirme",
                Kategori = "Web",
                Fiyat = "5000 TL",
                Sure = "6 ay",
                Saat = 180,
                Egitmen = "Yusuf Efe Yağar",
                EgitmenPuani = 4.7,
                BaslangicTarihi = "15.10.2025",
                Seviye = "Orta",
                DersSayisi = 18,
                Sertifika = "Var",
                Aciklama = "Node.js ile sunucu tarafı uygulamalar ve API geliştirme. Express ile RESTful servisler, MongoDB ile veritabanı yönetimi.",
                KimlerIcin = "JavaScript temeli olan, backend geliştirmek isteyenler.",
                Hedefler = new[] {
                    "Node.js ile backend geliştirme",
                    "Express ile RESTful API",
                    "MongoDB ile veritabanı yönetimi",
                    "JWT ile kimlik doğrulama",
                    "Test ve hata ayıklama"
                },
                Program = new[] {
                    "Node.js Temelleri",
                    "Express ile API Geliştirme",
                    "MongoDB ile Veritabanı",
                    "JWT ile Kimlik Doğrulama",
                    "Test ve Debugging",
                    "Docker ile Deployment",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Canlı dersler, proje tabanlı ödevler, birebir mentorluk, topluluk forumu.",
                KariyerDestegi = "Mentorluk, iş bulma desteği, portföy desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 21:00-23:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Node.js", "Express", "MongoDB", "JWT", "Docker", "Git" },
                Proje = "RESTful API projesi: Kullanıcı yönetimi, ürün yönetimi, siparişler.",
                MezunYorumlari = new[] {
                    "Node.js ile backend geliştirmede uzmanlaştım. (Ece S.)"
                },
                EkKaynaklar = new[] {
                    "Node.js resmi dökümanları",
                    "MongoDB University"
                },
                SertifikaIcerigi = "Proje teslimi ve teknik sınav sonrası başarı sertifikası.",
                BaslikRenk = "#68a063",
                KategoriRenk = "#fd5e53",
                SureRenk = "#fbbf24",
                Ikon = "fa-server"
            },
            new {
                Baslik = "Python ile Back-End Geliştirme",
                Kategori = "Web",
                Fiyat = "5500 TL",
                Sure = "7 ay",
                Saat = 210,
                Egitmen = "Furkan Cebe",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "20.10.2025",
                Seviye = "Orta",
                DersSayisi = 20,
                Sertifika = "Var",
                Aciklama = "Django ve Flask kullanarak web uygulamalarının backend kısmını geliştirme. Bu eğitimde Python ile modern web uygulamaları geliştirmeyi, RESTful API'ler oluşturmayı, veritabanı yönetimini ve dağıtım süreçlerini öğreneceksiniz.",
                KimlerIcin = "Temel Python bilgisine sahip, web geliştirme alanında backend uzmanlaşmak isteyen herkes.",
                Hedefler = new[] {
                    "Python ile backend geliştirme yetkinliği kazanmak",
                    "Django ve Flask ile web uygulamaları geliştirmek",
                    "RESTful API tasarımı ve uygulaması",
                    "Veritabanı (PostgreSQL, SQLite) ile çalışma",
                    "Kullanıcı kimlik doğrulama ve yetkilendirme",
                    "Test yazımı ve hata ayıklama",
                    "Bulut sunuculara dağıtım (Heroku, AWS, Azure)"
                },
                Program = new[] {
                    "Python Temelleri ve İleri Konular",
                    "Django ile Proje Geliştirme",
                    "Flask ile Mikroservis Mimarisi",
                    "ORM ve Veritabanı Yönetimi",
                    "RESTful API Geliştirme",
                    "JWT ile Kimlik Doğrulama",
                    "Unit Test ve Debugging",
                    "Docker ile Deployment",
                    "CI/CD Temelleri",
                    "Gerçek Hayat Projesi"
                },
                NasilOgretiliyor = "Her hafta canlı dersler, interaktif ödevler, proje tabanlı öğrenme, eğitmen ve asistan desteği, topluluk forumu ve birebir mentorluk.",
                KariyerDestegi = "CV hazırlama, LinkedIn optimizasyonu, teknik mülakat simülasyonları, iş ilanlarına yönlendirme, portföy projesi desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 20:00-22:00",
                    "Soru-Cevap: Her hafta forumda",
                    "Proje Sunumu: Her ayın sonunda",
                    "Mentorluk: Her ay birebir görüşme"
                },
                Teknolojiler = new[] { "Python", "Django", "Flask", "PostgreSQL", "SQLite", "Docker", "Git", "Heroku", "AWS" },
                Proje = "Gerçek bir e-ticaret REST API projesi: Kullanıcı yönetimi, ürün yönetimi, sipariş ve ödeme sistemleri, JWT ile kimlik doğrulama.",
                MezunYorumlari = new[] {
                    "Bu kurs sayesinde ilk backend işimi buldum. Proje odaklı eğitim çok faydalıydı. (Ayşe K.)",
                    "Mentorluk ve kariyer desteği harikaydı, tavsiye ederim. (Mert D.)"
                },
                EkKaynaklar = new[] {
                    "Python resmi dokümantasyonu",
                    "Django ve Flask dökümanları",
                    "Ücretsiz Git ve Docker eğitimleri"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, portföy projesi ve teknik sınav sonrası uluslararası geçerli sertifika verilir.",
                BaslikRenk = "#3776ab",
                KategoriRenk = "#fbbf24",
                SureRenk = "#fd5e53",
                Ikon = "fa-python"
            },
            new {
                Baslik = "Kotlin ile Android Mobil Geliştirme",
                Kategori = "Mobil",
                Fiyat = "5000 TL",
                Sure = "6 ay",
                Saat = 160,
                Egitmen = "İbrahim Yağar",
                EgitmenPuani = 4.9,
                BaslangicTarihi = "01.11.2025",
                Seviye = "Başlangıç",
                DersSayisi = 16,
                Sertifika = "Var",
                Aciklama = "Kotlin diliyle Android uygulamaları geliştirme. Modern Android mimarisi ve Google Play'e uygulama yayınlama.",
                KimlerIcin = "Mobil uygulama geliştirmeye başlamak isteyenler, temel programlama bilgisi olanlar.",
                Hedefler = new[] {
                    "Kotlin ile Android uygulama geliştirme",
                    "Android Studio kullanımı",
                    "Material Design ile UI geliştirme",
                    "Firebase entegrasyonu",
                    "Google Play'e uygulama yayınlama"
                },
                Program = new[] {
                    "Kotlin Temelleri",
                    "Android Studio ile Proje Geliştirme",
                    "UI/UX Tasarımı",
                    "Veritabanı ve Firebase",
                    "API Entegrasyonu",
                    "Test ve Debugging",
                    "Uygulama Yayınlama"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "Portföy desteği, iş bulma desteği, mülakat hazırlığı.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 19:00-21:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Kotlin", "Android Studio", "Firebase", "Git" },
                Proje = "Not alma uygulaması: Kullanıcı yönetimi, not ekleme, bildirimler.",
                MezunYorumlari = new[] {
                    "İlk Android uygulamamı markete yükledim. (Cansu T.)"
                },
                EkKaynaklar = new[] {
                    "Kotlin resmi dökümanları",
                    "Android Developers"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#7f52ff",
                KategoriRenk = "#38bdf8",
                SureRenk = "#fd5e53",
                Ikon = "fa-android"
            },
            new {
                Baslik = "Swift ile iOS Mobil Geliştirme",
                Kategori = "Mobil",
                Fiyat = "5500 TL",
                Sure = "6 ay",
                Saat = 160,
                Egitmen = "Nazlıcan Soykan",
                EgitmenPuani = 4.8,
                BaslangicTarihi = "10.11.2025",
                Seviye = "Başlangıç",
                DersSayisi = 16,
                Sertifika = "Var",
                Aciklama = "Swift dili ve Xcode kullanarak iOS uygulamaları geliştirme. App Store'a uygulama yayınlama.",
                KimlerIcin = "iOS uygulama geliştirmek isteyenler, temel programlama bilgisi olanlar.",
                Hedefler = new[] {
                    "Swift ile iOS uygulama geliştirme",
                    "Xcode ile proje yönetimi",
                    "UIKit ile UI geliştirme",
                    "CoreData ile veri yönetimi",
                    "App Store'a uygulama yayınlama"
                },
                Program = new[] {
                    "Swift Temelleri",
                    "Xcode ile Proje Geliştirme",
                    "UI/UX Tasarımı",
                    "CoreData ile Veritabanı",
                    "API Entegrasyonu",
                    "Test ve Debugging",
                    "Uygulama Yayınlama"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "Mentorluk, iş bulma desteği, portföy desteği.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 20:00-22:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Swift", "Xcode", "UIKit", "CoreData", "Git" },
                Proje = "Kişisel finans uygulaması: Gelir-gider takibi, raporlama, bildirimler.",
                MezunYorumlari = new[] {
                    "App Store'a ilk uygulamamı yükledim. (Barış E.)"
                },
                EkKaynaklar = new[] {
                    "Swift resmi dökümanları",
                    "Apple Developer"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#ffac45",
                KategoriRenk = "#232a36",
                SureRenk = "#38bdf8",
                Ikon = "fa-apple"
            },
            new {
                Baslik = "Flutter ile Çapraz Platform Mobil Geliştirme",
                Kategori = "Mobil",
                Fiyat = "4500 TL",
                Sure = "5 ay",
                Saat = 120,
                Egitmen = "Yusuf Efe Yağar",
                EgitmenPuani = 4.7,
                BaslangicTarihi = "20.11.2025",
                Seviye = "Başlangıç",
                DersSayisi = 12,
                Sertifika = "Var",
                Aciklama = "Dart dili ile Android ve iOS için tek kod tabanı üzerinden uygulama geliştirme. Modern UI ve performanslı uygulamalar.",
                KimlerIcin = "Mobil uygulama geliştirmeye başlamak isteyenler, temel programlama bilgisi olanlar.",
                Hedefler = new[] {
                    "Flutter ile çapraz platform uygulama geliştirme",
                    "Dart dili ile programlama",
                    "Material Design ile UI geliştirme",
                    "Firebase entegrasyonu",
                    "Google Play ve App Store'a uygulama yayınlama"
                },
                Program = new[] {
                    "Dart Temelleri",
                    "Flutter ile Proje Geliştirme",
                    "UI/UX Tasarımı",
                    "Veritabanı ve Firebase",
                    "API Entegrasyonu",
                    "Test ve Debugging",
                    "Uygulama Yayınlama"
                },
                NasilOgretiliyor = "Canlı dersler, uygulamalı ödevler, topluluk desteği, birebir mentorluk.",
                KariyerDestegi = "Portföy desteği, iş bulma desteği, mülakat hazırlığı.",
                Takvim = new[] {
                    "Canlı Ders: Haftada 1 gün 19:00-21:00",
                    "Proje Sunumu: Her ay"
                },
                Teknolojiler = new[] { "Dart", "Flutter", "Firebase", "Git" },
                Proje = "Alışveriş listesi uygulaması: Kullanıcı yönetimi, ürün ekleme, bildirimler.",
                MezunYorumlari = new[] {
                    "Flutter ile hem Android hem iOS için uygulama geliştirdim. (Derya S.)"
                },
                EkKaynaklar = new[] {
                    "Flutter resmi dökümanları",
                    "Dart.dev"
                },
                SertifikaIcerigi = "Başarıyla tamamlayanlara, proje sunumu sonrası sertifika.",
                BaslikRenk = "#02569b",
                KategoriRenk = "#38bdf8",
                SureRenk = "#fd5e53",
                Ikon = "fa-bolt"
            }
        };

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("Home/Index");
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Detail(string title)
        {
            var kursDetay = kursDetaylari.FirstOrDefault(k => k.Baslik == title);
            if (kursDetay == null)
            {
                return NotFound("Kurs bulunamadı.");
            }
            return View(kursDetay);
        }
    }
}