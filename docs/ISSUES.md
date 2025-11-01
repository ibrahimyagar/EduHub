# 📋 Issue ve TODO Listesi

Bu dokümanda projenin açık geliştirme konuları, iyileştirmeler ve bilinen bug'lar listelenmiştir.

## 🔴 Kritik Öncelikli (Blocker)

### 1. Dosya Yükleme Güvenlik Sorunları
**Dosya**: `Classroom/Controllers/HomeworkController.cs:244-258`  
**Sorun**: Dosya tipi kontrolü, MIME type kontrolü ve dosya imza kontrolü eksik  
**Risk**: Kötü amaçlı dosya yükleme (malware, script dosyaları)  
**Öncelik**: KRİTİK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] MIME type kontrolü ekle
- [ ] Dosya uzantısı whitelist oluştur
- [ ] Dosya imza kontrolü ekle
- [ ] Dosya boyutu limiti ekle (config'den)
- [ ] Virus taraması entegrasyonu (production için)

---

### 2. Input Validation Eksiklikleri
**Dosyalar**: Tüm Controller'lar  
**Sorun**: Yetersiz input validation, HTML sanitization yok  
**Risk**: XSS, SQL Injection (Entity Framework koruyor ama ekstra önlem gerekli)  
**Öncelik**: KRİTİK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Data Annotations ekle (modellere)
- [ ] FluentValidation entegrasyonu
- [ ] HTML sanitization library ekle
- [ ] String length limitleri
- [ ] Regex validation (e-posta, kod formatı vb.)

---

### 3. Test Coverage Eksikliği
**Sorun**: Hiç test yok (%0 coverage)  
**Risk**: Regression bug'ları, production hataları  
**Öncelik**: KRİTİK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Test projesi oluştur
- [ ] Unit testler yaz (min %70 coverage)
- [ ] Integration testler yaz
- [ ] E2E testler yaz (critical path'ler)
- [ ] CI/CD'ye test entegrasyonu

---

## 🟠 Yüksek Öncelikli

### 4. Rate Limiting Eksikliği
**Sorun**: API rate limiting yok  
**Risk**: Brute force saldırıları, DDoS  
**Öncelik**: YÜKSEK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] ASP.NET Core Rate Limiting middleware ekle
- [ ] IP bazlı throttling
- [ ] Endpoint bazlı rate limit ayarları
- [ ] Configuration yapılandırması

---

### 5. Service Layer Eksikliği
**Sorun**: Business logic controller'larda, SRP ihlali  
**Risk**: Kod tekrarı, bakım zorluğu  
**Öncelik**: YÜKSEK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] `IClassroomService` interface oluştur
- [ ] `ClassroomService` implementation
- [ ] `IHomeworkService` interface ve implementation
- [ ] Controller'ları refactor et
- [ ] Dependency Injection yapılandır

---

### 6. Repository Pattern Eksikliği
**Sorun**: Data access logic controller'larda  
**Risk**: Test edilebilirlik düşük, kod tekrarı  
**Öncelik**: YÜKSEK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] `IClassroomRepository` interface
- [ ] `ClassroomRepository` implementation
- [ ] Generic repository pattern (opsiyonel)
- [ ] Unit of Work pattern (opsiyonel)

---

### 7. ViewModel Kullanımı Eksikliği
**Sorun**: ViewBag kullanımı fazla, tip güvenliği yok  
**Risk**: Runtime hataları, bakım zorluğu  
**Öncelik**: YÜKSEK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] `ClassroomIndexViewModel` oluştur
- [ ] `HomeworkListViewModel` oluştur
- [ ] Tüm ViewBag kullanımlarını kaldır
- [ ] View'ları güncelle

---

## 🟡 Orta Öncelikli

### 8. Pagination Eksikliği
**Sorun**: Büyük listelerde performans sorunu  
**Risk**: Yavaş sayfa yükleme, kullanıcı deneyimi  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Tüm listelerde pagination ekle
- [ ] PageSize configuration
- [ ] UI'da sayfalama component'i
- [ ] Search/filter özelliği (opsiyonel)

---

### 9. Async/Await Kullanımı Eksikliği
**Sorun**: Controller metodları sync  
**Risk**: Thread blocking, ölçeklenebilirlik  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Tüm controller metodlarını async yap
- [ ] Database sorgularını async yap
- [ ] File I/O operasyonlarını async yap
- [ ] Performance test

---

### 10. Caching Eksikliği
**Sorun**: Cache mekanizması yok  
**Risk**: Gereksiz database sorguları  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Memory Cache entegrasyonu
- [ ] Redis entegrasyonu (production için)
- [ ] Cache invalidation stratejisi
- [ ] Cache key naming convention

---

### 11. Error Handling İyileştirmesi
**Sorun**: Generic error handling yetersiz  
**Risk**: Bilgi sızıntısı, kötü kullanıcı deneyimi  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Global exception handler iyileştir
- [ ] Custom exception types
- [ ] Error logging (structured logging)
- [ ] User-friendly error messages
- [ ] Error tracking (Sentry/Application Insights)

---

### 12. Hardcoded Values
**Dosya**: `HomeController.cs:169-178`  
**Sorun**: Magic numbers ve hardcoded değerler  
**Risk**: Bakım zorluğu  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Configuration'a taşı (appsettings.json)
- [ ] Constants class oluştur
- [ ] Enum kullan (Roles için)

---

### 13. Magic Strings
**Sorun**: Rol kontrolünde boolean kullanımı  
**Risk**: Kod okunabilirliği düşük  
**Öncelik**: ORTA  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] `UserRole` enum oluştur
- [ ] Boolean yerine enum kullan
- [ ] Extension methods ekle

---

## 🟢 Düşük Öncelikli

### 14. Code Refactoring
**Sorun**: Bazı controller'lar çok uzun (400+ satır)  
**Risk**: Bakım zorluğu  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] ClassroomController'ı böl (400+ satır)
- [ ] Helper methods oluştur
- [ ] Duplicate code'u refactor et

---

### 15. Hardcoded Kurs Verileri
**Dosya**: `HelloController.cs:7-800`  
**Sorun**: Kurs verileri kodda  
**Risk**: Bakım zorluğu  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Database'e taşı
- [ ] Admin panel ekle (kurs yönetimi)
- [ ] CRUD operasyonları

---

### 16. Email Servisi Eksikliği
**Sorun**: Email doğrulama var ama email gönderme servisi yok  
**Risk**: Email özellikleri çalışmıyor  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Email service interface oluştur
- [ ] SMTP configuration
- [ ] Email template'leri
- [ ] Email gönderme fonksiyonları

---

### 17. Logging İyileştirmesi
**Sorun**: Yetersiz logging  
**Risk**: Debug zorluğu  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Structured logging (Serilog)
- [ ] Log levels belirle
- [ ] Log rotation
- [ ] Log aggregation (production için)

---

### 18. Database Index Eksiklikleri
**Sorun**: Foreign key'lerde index yok  
**Risk**: Yavaş sorgular  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] UnicCode için index
- [ ] ClassUser composite index
- [ ] Homework DueDate index
- [ ] Performance test

---

### 19. API Dokümantasyonu
**Sorun**: Swagger/OpenAPI yok  
**Risk**: API kullanımı zor  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] Swagger/OpenAPI entegrasyonu
- [ ] XML comments ekle
- [ ] API versioning
- [ ] Postman collection

---

### 20. Real-time Bildirimler
**Sorun**: SignalR yok  
**Risk**: Kullanıcı deneyimi eksik  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Yapılacaklar**:
- [ ] SignalR entegrasyonu
- [ ] Notification hub
- [ ] Client-side JavaScript
- [ ] Notification service

---

## 🐛 Bilinen Bug'lar

### Bug #1: TeacherRating Navigation Properties
**Dosya**: `Models/TeacherRating.cs`  
**Sorun**: Navigation properties tanımlı ama FK yok  
**Risk**: Lazy loading çalışmayabilir  
**Öncelik**: ORTA  
**Durum**: Açık  

**Çözüm**: Migration ile FK ekle

---

### Bug #2: Duplicate Code
**Dosya**: `ClassroomController.cs:44-61`  
**Sorun**: Teacher/Student listesi sorguları tekrarlanıyor  
**Risk**: Kod tekrarı  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

**Çözüm**: Helper method oluştur

---

### Bug #3: Null Reference Risk
**Dosya**: `ClassroomController.cs:233`  
**Sorun**: Null check eksik  
**Risk**: NullReferenceException  
**Öncelik**: ORTA  
**Durum**: Açık  

**Çözüm**: Null check ekle

---

## ✨ Feature Requests

### Feature #1: Dosya Versiyonlama
**Açıklama**: Ödev dosyalarında versiyonlama  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

---

### Feature #2: Ödev Şablonları
**Açıklama**: Öğretmenler için ödev şablonları  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

---

### Feature #3: Toplu İşlemler
**Açıklama**: Toplu puanlama, toplu duyuru  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

---

### Feature #4: Raporlama
**Açıklama**: Öğrenci/öğretmen performans raporları  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

---

### Feature #5: Çoklu Dil Desteği
**Açıklama**: i18n/localization  
**Öncelik**: DÜŞÜK  
**Durum**: Açık  

---

## 📊 Özet

### Öncelik Dağılımı

- 🔴 **Kritik**: 3 issue
- 🟠 **Yüksek**: 4 issue
- 🟡 **Orta**: 8 issue
- 🟢 **Düşük**: 13 issue

**Toplam**: 28 issue

### Kategori Dağılımı

- 🐛 **Bug**: 3
- 🔒 **Güvenlik**: 4
- 🏗️ **Mimari**: 5
- ⚡ **Performans**: 4
- 🧪 **Test**: 1
- ✨ **Feature**: 5
- 🔧 **Refactoring**: 6

---

**Son Güncelleme**: 2025-01-XX  
**Versiyon**: 1.0.0

