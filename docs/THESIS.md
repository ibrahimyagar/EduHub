# LİSANS BİTİRME PROJESİ TEZ DOKÜMANI

**Proje Adı**: Canlı Ders Destekli ve Online Kod Editörü Gömülü Eğitim Platformu

**Öğrenci**: İbrahim YAĞAR  
**Danışman**: Doç. Dr. Mehmet Akif Çifçi  
**Bölüm**: Bilgisayar Mühendisliği  
**Üniversite**: Bandırma Onyedi Eylül Üniversitesi, Mühendislik ve Doğa Bilimleri Fakültesi  
**Tarih**: 19/06/2025

---

## 📋 İçindekiler

- [Özet](#özet)
- [Teşekkür](#teşekkür)
- [1. GİRİŞ](#1-giriş)
  - [1.1 Literatür Taraması](#11-literatür-taraması)
  - [1.2 Eğitimde Dijitalleşme](#12-eğitimde-dijitalleşme)
  - [1.3 Projenin Amacı](#13-projenin-amacı)
  - [1.4 Kullanılan Teknolojilerin Tanıtımı](#14-kullanılan-teknolojilerin-tanıtımı)
- [2. ÇALIŞMA](#2-çalışma)
  - [2.1 Kullanıcı Rolleri](#21-kullanıcı-rolleri)
  - [2.2 Veritabanı Tasarımı](#22-veritabanı-tasarımı)
  - [2.3 MVC Katmanı](#23-mvc-katmanı)
  - [2.4 Controller'lar](#24-controllerlar)
  - [2.5 Model'ler](#25-modeller)
  - [2.6 Hello Sayfası](#26-hello-sayfası)
  - [2.7 Kurs Detayları](#27-kurs-detayları)
  - [2.8 StackBlitz Entegrasyonu](#28-stackblitz-entegrasyonu)
  - [2.9 Jitsi Meet Entegrasyonu](#29-jitsi-meet-entegrasyonu)
- [3. SONUÇ](#3-sonuç)
- [4. KAYNAKLAR](#4-kaynaklar)

---

## Özet

Bu bitirme projesi, YouTube ve Google Classroom benzeri bir yapıya sahip olan, açık katılımlı ve dinamik bir bootcamp platformunun geliştirilmesini kapsamaktadır. Platform, katılımcıların hem eğitmen hem öğrenci rollerinde içerik oluşturabildiği, eğitim alıp değerlendirme yapabildiği ve canlı olarak etkileşime geçebildiği, kullanıcı merkezli bir öğrenim ekosistemi sunmaktadır. ASP.NET Core 8.0, Entity Framework Core ve Razor Pages teknolojileriyle geliştirilmiş bu sistemde, SQL Server tabanlı bir veri yönetimi uygulanmıştır.

Projenin temel yapı taşı olan "Hello Sayfası", ziyaretçileri ilk karşılayan ana sayfadır. Burada platformun vizyonu ve kullanım şekli anlatılmakta, en güncel veya öne çıkan eğitimler sergilenmektedir. Eğitim kartlarına tıklayan kullanıcılar, eğitimin detay sayfasına yönlendirilir. Detay sayfasında; eğitimin adı, eğitmeni, içerik takvimi, kullanılacak teknolojiler, fiyatlandırma, kullanıcı puanları ve yazılmış yorumlar gibi kapsamlı bilgiler yer almaktadır.

Kullanıcılar yüksek puanlı eğitmenleri tercih edebilmekte, eğitim hakkında yapılan yorumları okuyarak karar verebilmektedir. Satın alma işlemi sonrası kullanıcıya eğitmen tarafından bir "kurs kodu" iletilmekte ve bu kod ile sisteme giriş yaptıktan sonra derse erişim sağlanmaktadır. Eğitime katılan kullanıcıları, canlı ders bağlantısı, online gömülü kod editörü (StackBlitz), eğitmen tarafından yüklenen ödevler, duyurular, katılımcı listesi ve eğitmen değerlendirme modülü karşılamaktadır.

Platform, geleneksel bootcamp uygulamalarından farklı olarak, tüm kullanıcılara sınıf oluşturma, içerik paylaşma ve eğitmenlik imkanı tanımaktadır. Ayrıca eğitmenlerin puanları, platformun en dikkat çekici rekabet unsurlarından biridir. Puan sistemi, eğitmenlerin performanslarını şeffaf bir biçimde göstererek öğrencilerin seçim yapmasını kolaylaştırmaktadır.

Bu proje, klasik eğitim yöntemlerinin dijitalleştiği ve kullanıcıların sadece tüketici değil üretici olduğu yeni nesil eğitim anlayışını temel almaktadır. Sosyal etkileşim, eş zamanlı canlı dersler, kod yazma ortamı ve değerlendirme mekanizmaları ile donatılan platform; öğrenme deneyimini daha katılımcı, kişiselleştirilmiş ve etkileşimli hale getirmektedir.

---

## Teşekkür

Öncelikle, tez danışmanım Doç. Dr. Mehmet Akif Çifçi'ye sonsuz teşekkürlerimi sunarım. Kendisinin bilgi ve deneyimleri, bu çalışmanın her aşamasında bana ilham kaynağı oldu.

Bu çalışmada yanımda olan ve bana destek veren herkese teşekkür etmek isterim. Öncelikle aileme; anneme, babama ve kardeşlerime sonsuz minnettarım. İyi ve zor günlerimde hep yanımda oldunuz, sevginiz ve desteğiniz bana güç verdi.

Özel olarak sevgili kız arkadaşım Nazlıcan Soykan'a teşekkür ederim. Sabırla beni dinleyip motive ettiğin için bu süreci daha kolay atlattım.

Ayrıca, bu yolculukta birlikte ilerlediğim ve bilgi alışverişinde bulunduğum sınıf arkadaşım Furkan Cebe'ye teşekkür ederim. Varlığın çalışmamı daha zengin hale getirdi.

Bu tez, benim için büyük bir deneyim oldu ve burada emeği geçen herkese gönülden teşekkür ederim.

İbrahim YAĞAR

---

## 1. GİRİŞ

### 1.1 Literatür Taraması

Eğitim yönetim sistemleri (Learning Management Systems - LMS), öğretmenlerin, öğrencilerin ve eğitim kurumlarının eğitim süreçlerini dijital ortamda yönetmelerine olanak tanıyan platformlar olarak günümüzde büyük önem kazanmıştır. Bu sistemler, eğitim materyallerinin paylaşımı, sınıf yönetimi, ödev takibi ve iletişim gibi pek çok fonksiyonu bünyelerinde barındırmaktadır. Ayrıca günümüzde eğitimde giderek popülerleşen bootcamp modelleri, pratik odaklı ve hızlı öğrenme yaklaşımları ile eğitim teknolojilerinde önemli bir yer tutmaktadır.

#### 1.1.1 Eğitim Yönetim Sistemlerinin Temel Özellikleri

Eğitim platformları, kullanıcı dostu arayüzler, rol tabanlı erişim, etkileşimli içerik yönetimi ve öğrenci performans takibi gibi özellikleri ön plana çıkarmaktadır. Moodle gibi dünyada yaygın kullanılan açık kaynaklı bir LMS olarak; ders materyalleri paylaşımı, sınav ve değerlendirme, forumlar ve bildirim sistemleri gibi çok çeşitli işlevleri desteklemektedir.

#### 1.1.2 Bootcamp Modelleri ve Eğitimde Pratik Odaklı Yaklaşımlar

Bootcamp'ler, kısa sürede yoğun ve pratik ağırlıklı eğitimlerle katılımcıların hızlı şekilde yetkinlik kazanmasını hedefler. Bu yaklaşım özellikle yazılım geliştirme ve teknoloji alanlarında yaygınlaşmıştır. Patika.dev ve Workintech.com.tr gibi platformlar, bootcamp temelli eğitimler sunarak öğrencilere ve profesyonellere gerçek dünya projeleri üzerinden öğrenme fırsatı sağlamaktadır.

### 1.2 Eğitimde Dijitalleşme

Eğitim, insanlık tarihi boyunca toplumların kültürel, sosyal ve ekonomik gelişiminde en temel unsurlardan biri olmuştur. 20. yüzyılın ikinci yarısından itibaren özellikle bilgi teknolojilerindeki gelişmeler, eğitimin yapısını ve sunum biçimini temelden değiştirmiştir.

#### 1.2.1 Dijital Eğitim Platformlarının Evrimi

MOOCs (Massive Open Online Courses) olarak adlandırılan kitlesel açık online kurslar, dijital eğitimin en önemli örneklerinden biridir. Coursera, edX, Udacity gibi platformlar milyonlarca kullanıcıya ulaşarak, geleneksel üniversite eğitiminin sınırlarını aşmış ve bilgiye erişimi demokratikleştirmiştir.

#### 1.2.2 Bootcamplerin Tarihçesi

Bootcamp terimi, askeri eğitim kamplarından esinlenmiş olup, kısa süreli, yoğun ve disiplinli eğitim programlarını ifade eder. Yazılım geliştirme alanında ilk bootcampler, Amerika Birleşik Devletleri'nde 2011-2012 yıllarında başlamış ve hızla yaygınlaşmıştır.

### 1.3 Projenin Amacı

Bu projenin temel amacı, herkesin kolayca eğitim içeriği oluşturup paylaşabileceği, eğitmenler ve öğrenciler arasında etkileşimi maksimuma çıkaran, modern ve dinamik bir dijital bootcamp platformu geliştirmektir. Platform, YouTube benzeri açık yapısı sayesinde kullanıcıların özgürce eğitim materyalleri hazırlayıp sunabilmelerine olanak tanırken, farklı öğrenme ihtiyaçlarına uygun zengin içerik çeşitliliği sağlamaktadır.

### 1.4 Kullanılan Teknolojilerin Tanıtımı

#### 1.4.1 .NET 8

.NET 8, Microsoft tarafından geliştirilen ve Kasım 2023'te yayımlanan, açık kaynaklı ve platformlar arası bir yazılım geliştirme altyapısıdır. Performans, güvenlik, esneklik ve üretkenlik gibi modern yazılım geliştirme ihtiyaçlarını karşılamak amacıyla tasarlanmıştır.

#### 1.4.2 ASP.NET Core Razor Pages

ASP.NET Core Razor Pages, Microsoft tarafından ASP.NET Core 2.0 ile birlikte tanıtılan, sayfa tabanlı bir programlama yaklaşımı sunar. Her Razor sayfası, bir .cshtml (Razor View) dosyası ve onunla ilişkili olan .cshtml.cs (PageModel) dosyasından oluşur.

#### 1.4.3 ASP.NET Core MVC Mimarisi

ASP.NET Core MVC, uygulamayı üç temel bileşene ayırarak kodun daha organize, okunabilir ve sürdürülebilir olmasını sağlar: Model (Veri Katmanı), View (Görünüm Katmanı) ve Controller (Denetleyici Katmanı).

#### 1.4.4 C#

C#, Microsoft tarafından 2000 yılında geliştirilmiş, nesne yönelimli, modern ve güçlü bir programlama dilidir. Güçlü tip denetimi, otomatik bellek yönetimi ve istisna işleme mekanizmaları ile güvenli kod yazmaya olanak tanır.

#### 1.4.5 ASP.NET Core Identity

ASP.NET Core Identity, web uygulamalarında kullanıcıların güvenli şekilde kayıt olma, giriş yapma, parola sıfırlama, rol ve yetki yönetimi gibi işlemlerini kolaylaştırmak amacıyla tasarlanmıştır.

#### 1.4.6 Entity Framework Core

Entity Framework Core, .NET platformu için açık kaynak kodlu ve hafif bir nesne-ilişkisel haritalama (ORM) kütüphanesidir. EF Core, geliştiricilerin veritabanı işlemlerini SQL sorguları yazmadan, C# nesneleri üzerinden gerçekleştirmelerine olanak sağlar.

#### 1.4.7 SQL Server

SQL Server, Microsoft tarafından geliştirilen, kurumsal düzeyde ilişkisel veritabanı yönetim sistemidir. İlişkisel veri modeli, T-SQL desteği, yüksek performans ve ölçeklenebilirlik gibi özellikler sunar.

#### 1.4.8 JavaScript

JavaScript, dinamik ve etkileşimli web sayfaları oluşturmak için kullanılan, yüksek seviyeli, yorumlanan, çok paradigmalı bir programlama dilidir. DOM manipülasyonu, olay tabanlı programlama ve asenkron programlama gibi özellikler içerir.

#### 1.4.9 HTTP

HTTP (Hypertext Transfer Protocol), web üzerinde veri iletişimini sağlayan temel protokoldür. İstemci-sunucu modeline dayanan bir protokol olup, GET, POST, PUT, DELETE gibi yöntemler kullanır.

#### 1.4.10 Jitsi Meet

Jitsi Meet, açık kaynak kodlu ve ücretsiz bir video konferans platformudur. WebRTC teknolojisini temel alarak, kullanıcıların tarayıcı üzerinden herhangi bir eklenti ya da yazılım yüklemeye gerek kalmadan anlık sesli ve görüntülü görüşmeler gerçekleştirmesine olanak tanır.

#### 1.4.11 StackBlitz

StackBlitz, geliştiricilere doğrudan web tarayıcıları üzerinden tam işlevli yazılım geliştirme ortamı (IDE) sunan bulut tabanlı bir geliştirme platformudur. Visual Studio Code benzeri bir arayüz ile çalışan StackBlitz, JavaScript, TypeScript, Angular, React, Vue gibi popüler web teknolojileriyle projeler geliştirmeye olanak tanır.

---

## 2. ÇALIŞMA

### 2.1 Kullanıcı Rolleri (Roller)

Bir eğitim yönetim sistemi veya sınıf yönetim platformu gibi projelerde kullanıcıların farklı yetki ve erişim seviyelerine sahip olması gerekmektedir. Bu farklı yetkiler, kullanıcının sistem içindeki rolüyle belirlenir.

#### 2.1.1 Öğretmen Rolü (Eğitmen)

- Ders ve Sınıf Yönetimi
- Ödev Yönetimi
- Duyuru ve Materyal Paylaşımı
- Öğrenci Yönetimi
- Raporlama

#### 2.1.2 Öğrenci Rolü

- Sınıfa Katılım
- Ödev Takibi
- Duyuru Görüntüleme
- Not Görüntüleme
- Materyal Erişimi

#### 2.1.3 Roller Nasıl Uygulandı?

Proje, ASP.NET Core Identity kullanılarak kullanıcı ve rol yönetimi gerçekleştirilmiştir. Identity framework, kullanıcı kimlik doğrulaması ve yetkilendirme işlemlerini standart ve güvenli bir biçimde sağlamaktadır.

### 2.2 Veritabanı Tasarımı ve Entity Framework Core Kullanımı

Projede veri yönetimi işlemleri için Microsoft'un modern ORM kütüphanesi olan Entity Framework Core tercih edilmiştir. Code-First yaklaşımı benimsenmiş, veritabanı tabloları C# içerisinde oluşturulan model sınıflarının birebir karşılığı olarak yapılandırılmıştır.

### 2.3 MVC Katmanı ile Geliştirme

Proje, modern web uygulama geliştirme mimarilerinden biri olan MVC (Model–View–Controller) yapısı ile geliştirilmiştir. ASP.NET Core MVC çatısı kullanılarak uygulamanın kullanıcı arayüzü, iş mantığı ve veri yönetimi katmanları ayrıştırılmıştır.

### 2.4 Controller

#### 2.4.1 Comment Controller

Comment Controller, öğrencilerin veya eğitmenlerin ödevler üzerinde yaptığı yorumların yönetiminden sorumludur.

#### 2.4.2 Hello Controller

HelloController, uygulamada temel test veya selamlaşma amaçlı kullanılan, daha çok sistemin çalıştığını kontrol etmek için oluşturulmuş bir denetleyicidir.

#### 2.4.3 Home Controller

HomeController, sistemin ana giriş noktalarından biri olup, hem kullanıcı girişleri hem de yönlendirme işlemlerini gerçekleştiren temel denetleyicidir.

#### 2.4.4 Homework Controller

HomeworkController, projenin en önemli parçalarından biri olup, ödevlerin yönetimini sağlar. Bu controller eğitmenler için ödev oluşturma, düzenleme; öğrenciler için ise ödeve erişim ve teslim işlemlerini yürütür.

### 2.5 Model

#### 2.5.1 Announcements

Derslere ait duyuruların yönetilmesini sağlar. Öğretmenler tarafından oluşturulan duyurular, ilgili sınıfın öğrencilerine gösterilir.

#### 2.5.2 ApplicationUser

Sistemdeki tüm kullanıcıların (öğrenci ve eğitmen) kimlik bilgilerinin tutulduğu modeldir. Identity sistemiyle entegredir.

#### 2.5.3 Class_User

Bir sınıfa hangi kullanıcıların (öğrencilerin) kayıtlı olduğunu belirleyen ilişki tablosudur. Many-to-Many ilişkiyi temsil eder.

#### 2.5.4 ClassRoom

Sistemdeki tüm sınıfların temel verilerini tutan modeldir. Eğitmen tarafından oluşturulan sınıflar bu yapı üzerinden tanımlanır.

#### 2.5.5 Comment

Ödevlere yapılan öğrenci yorumlarını temsil eder. Geri bildirim sürecini destekler.

#### 2.5.6 ErrorViewModel

Uygulama sırasında oluşan hataları kullanıcıya göstermek için kullanılan ViewModel sınıfıdır.

#### 2.5.7 Homework

Her sınıf için tanımlanan ödevlerin temel bilgilerini içeren modeldir.

#### 2.5.8 Homework_User

Öğrencilerin her bir ödeve olan teslimat durumunu ve puan bilgisini tutar.

#### 2.5.9 TeacherRating

Öğrencilerin öğretmenlerini değerlendirdiği geri bildirim sistemi. Öğrenci memnuniyetini ölçmek için kullanılabilir.

### 2.6 Hello Sayfasının Yapımı ve İşleyişi

Hello sayfası, projemizin kullanıcıların eğitim içeriklerini keşfedip, katılım sağlayabildiği önemli bir ana sayfa niteliğindedir. Bu sayfa, kullanıcı deneyimini zenginleştirmek ve interaktif bir eğitim platformu sunmak amacıyla tasarlanmıştır.

### 2.7 Kurs Detaylar

Kullanıcıların kurslar hakkında detaylı bilgi alabilmesi ve doğrudan başvuru yapabilmesi için kapsamlı bir kurs detay sayfası tasarlandı. Bu sayfa, kullanıcı deneyimini ön planda tutarak, kursun tüm önemli bilgilerini kolay erişilebilir ve düzenli bir şekilde sunmaktadır.

### 2.8 StackBlitz Entegrasyonu

Bu projede, kullanıcı arayüzü bileşenlerinin tasarımı ve test sürecinde, tarayıcı tabanlı bir geliştirme ortamı olan StackBlitz kullanılmıştır. StackBlitz, geliştiricilere gerçek zamanlı kod yazma, derleme ve önizleme imkânı sunan bir platformdur.

### 2.9 Jitsi Meet Entegrasyonu

Bu projede, uzaktan eğitim senaryolarını desteklemek amacıyla canlı derslerin gerçekleştirilebildiği bir video konferans altyapısı kurulmuştur. Bu altyapı için, açık kaynaklı ve WebRTC teknolojisi üzerine kurulu olan Jitsi Meet platformu kullanılmıştır.

---

## 3. SONUÇ

Bu bitirme projesi, günümüzün dijital eğitim ihtiyaçlarına kapsamlı bir çözüm sunmayı amaçlayan, çok yönlü bir çevrim içi eğitim platformunun geliştirilmesini kapsamaktadır. Geliştirilen sistem, yalnızca eğitmenlerin ders verdiği değil, aynı zamanda öğrencilerin de aktif rol alarak sürece katkıda bulunduğu, etkileşim temelli bir yapıya sahiptir.

Platformda kullanıcılar, rollerine göre farklı özelliklere erişim sağlayabilir. Eğitmenler, sistem üzerinden ders açabilir, video içerikler ve eğitim materyalleri yükleyebilir, ödevler ve duyurular oluşturabilir. Ayrıca, Jitsi Meet entegrasyonu sayesinde canlı ders başlatma, ekran paylaşma ve anlık etkileşim kurma gibi imkanlara sahiptirler.

Öğrenciler ise oluşturulan derslere katılabilir, içerikleri izleyebilir, ödevleri takip edip teslim edebilir ve eğitmenleri puanlayarak içerik kalitesine katkıda bulunabilir. Bu puanlama sistemi, eğitmenlere geri bildirim sağlarken platformun dinamik ve sürekli gelişen bir yapıda olmasını desteklemektedir.

Projeye entegre edilen StackBlitz çevrim içi kod editörü ile öğrenciler doğrudan tarayıcı üzerinden uygulamalı olarak kod yazabilir. Bu özellik, özellikle yazılım odaklı eğitimlerde kullanıcıların öğrendiklerini anında pratiğe dökebilmesine olanak tanır.

Sistem, kullanıcı deneyimini ön planda tutan, sade ve anlaşılır bir arayüz ile geliştirilmiş; mobil uyumluluğa ve performansa dikkat edilmiştir. ASP.NET Core altyapısıyla geliştirilen platformda güvenli kimlik doğrulama, rol bazlı yetkilendirme ve Entity Framework Core ile veri yönetimi gibi modern web geliştirme standartları uygulanmıştır.

### Genişletilebilirlik ve Gelecek Potansiyeli

Projenin mimarisi, gelecekte yeni modüllerin entegre edilebileceği şekilde esnek tasarlanmıştır. İlerleyen zamanlarda;

- Sertifika desteği
- Yapay zeka destekli içerik öneri sistemi
- Gelişmiş sınav/quiz modülü
- Bildirim sistemi
- Eğitmenler için istatistik ve analiz panelleri

gibi özelliklerin eklenmesi ile platform daha da kapsamlı hale getirilebilir.

---

## 4. KAYNAKLAR

[1] Microsoft. (2024). Get started with ASP.NET Core MVC and EF Core tutorial. Microsoft Docs.  
[2] Microsoft. (2024). Entity Framework Core overview. Microsoft Docs.  
[3] Jitsi. (2025). IFrame API – Jitsi Meet Handbook.  
[4] StackBlitz. (2023). Embedding projects. StackBlitz Docs.  
[5] Moodle HQ. (2024). Moodle LMS – GitHub repository.  
[6] Patika.dev. (2024). Yazılım öğrenme ve kariyer platformu.  
[7] Workintech. (2024). Yazılım geliştirme bootcamp platformu.  
[8] ASP.NET Core Documentation | Microsoft  
[9] Entity Framework Core Documentation | Microsoft  
[10] Jitsi Meet Official Website  
[11] StackBlitz Developer Docs  
[12] WebRTC Official Website  
[13] GitHub - Awesome ASP.NET Core Projects  
[14] Microsoft Learn - Learn to Build Modern Web Apps with ASP.NET Core  

---

**Not**: Bu doküman, Bandırma Onyedi Eylül Üniversitesi Bilgisayar Mühendisliği Bölümü Lisans Bitirme Projesi tez dokümanıdır. Tam tez metni için yukarıdaki içerikler referans alınmıştır.

