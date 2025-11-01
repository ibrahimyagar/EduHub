# Changelog

Tüm önemli değişiklikler bu dosyada dokümante edilecektir.

Format [Keep a Changelog](https://keepachangelog.com/tr/1.0.0/) baz alınarak,
ve bu proje [Semantic Versioning](https://semver.org/lang/tr/) kullanmaktadır.

## [1.0.0] - 2025-01-XX

### 🎉 İlk Sürüm

#### Eklenenler

- ✅ **Kullanıcı Yönetimi**
  - ASP.NET Core Identity ile kimlik doğrulama
  - Email doğrulama sistemi
  - Şifre sıfırlama özelliği
  - Two-Factor Authentication desteği

- ✅ **Sınıf Yönetimi**
  - Öğretmenler için sınıf oluşturma
  - Benzersiz kod ile sınıfa katılma
  - Sınıf arşivleme ve geri getirme
  - Sınıf silme (soft delete)
  - Öğrenci ve öğretmen listesi görüntüleme

- ✅ **Ödev Sistemi**
  - Ödev oluşturma ve düzenleme
  - Dosya yükleme desteği
  - Ödev teslim etme
  - Ödev puanlama sistemi
  - Teslim tarihi takibi
  - En yakın ödev gösterimi

- ✅ **Duyuru Sistemi**
  - Sınıf içi duyuru paylaşımı
  - Duyuru yorumları
  - Duyuru silme

- ✅ **Öğretmen Değerlendirme**
  - Öğrenciler öğretmenleri değerlendirebilir
  - 1-5 arası puanlama
  - Yorum yapabilme
  - Ortalama puan görüntüleme

- ✅ **Kullanıcı Arayüzü**
  - Modern ve responsive tasarım
  - Bootstrap 5 kullanımı
  - Mobil uyumlu arayüz
  - Renkli sınıf kartları

#### Değiştirilenler

- N/A (İlk sürüm)

#### Düzeltilenler

- N/A (İlk sürüm)

#### Kaldırılanlar

- N/A (İlk sürüm)

#### Güvenlik

- ASP.NET Core Identity entegrasyonu
- Email doğrulama zorunluluğu
- CSRF koruması
- XSS koruması
- SQL Injection koruması (Entity Framework)

#### Bilinen Sorunlar

- ⚠️ Dosya yükleme için dosya tipi kontrolü eksik
- ⚠️ Rate limiting uygulanmadı
- ⚠️ Bazı endpoint'lerde input validation yetersiz
- ⚠️ Production error handling iyileştirilmeli

#### Gelecek Sürümler İçin Planlananlar

- [ ] Real-time bildirimler (SignalR)
- [ ] Email bildirimleri
- [ ] Dosya yükleme güvenlik iyileştirmeleri
- [ ] API rate limiting
- [ ] Unit test coverage artırılması
- [ ] Integration testleri
- [ ] Performance optimizasyonları
- [ ] Mobil uygulama (React Native)
- [ ] Çoklu dil desteği (i18n)
- [ ] Gelişmiş raporlama özellikleri

---

## [Unreleased]

### Planlananlar

- [ ] SignalR ile real-time bildirimler
- [ ] Email servisi entegrasyonu
- [ ] Dosya yükleme güvenlik iyileştirmeleri
- [ ] API rate limiting
- [ ] Swagger/OpenAPI dokümantasyonu
- [ ] Unit test coverage %80+
- [ ] Integration testleri
- [ ] Performance monitoring
- [ ] Logging iyileştirmeleri

---

## Versiyonlama Kuralları

- **MAJOR** (X.0.0): Geriye dönük uyumsuz API değişiklikleri
- **MINOR** (0.X.0): Geriye dönük uyumlu yeni özellikler
- **PATCH** (0.0.X): Geriye dönük uyumlu bug düzeltmeleri

---

## Katkıda Bulunma

Changelog'a katkıda bulunmak için:
1. Değişikliklerinizi uygun kategori altına ekleyin
2. Kısa ve açıklayıcı olun
3. Breaking changes için özel not ekleyin
4. PR açarken changelog güncellemesini dahil edin

