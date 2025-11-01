# Güvenlik Politikası

## 🛡️ Desteklenen Versiyonlar

Güvenlik güncellemeleri şu versiyonlar için sağlanmaktadır:

| Versiyon | Destekleniyor          |
| -------- | --------------------- |
| 1.0.x    | :white_check_mark:    |
| < 1.0    | :x:                   |

## 🚨 Güvenlik Açığı Bildirimi

Güvenlik açığı bulduysanız, lütfen **public issue açmayın**. Bunun yerine:

1. **Email gönderin**: security@example.com (örnek - gerçek email ekleyin)
2. **Private Security Advisory**: GitHub Security Advisory kullanın
3. **Detaylı bilgi verin**:
   - Açığın türü ve etkisi
   - Tekrarlanabilir adımlar
   - Potansiyel çözüm önerileri

### Güvenlik Açığı Bildirimi Şablonu

```
Güvenlik Açığı: [Başlık]
Etkilenen Versiyon: [Versiyon]
Ciddiyet: [Kritik/Yüksek/Orta/Düşük]
Açıklama: [Detaylı açıklama]
Tekrarlanabilir Adımlar: [Adımlar]
Etki: [Etkilenen sistem ve kullanıcılar]
```

## 🔒 Güvenlik Özellikleri

### Uygulanan Güvenlik Önlemleri

#### 1. Kimlik Doğrulama ve Yetkilendirme

- ✅ **ASP.NET Core Identity**: Güvenli kullanıcı yönetimi
- ✅ **Email Doğrulama**: Hesap aktivasyonu için zorunlu email doğrulama
- ✅ **Şifre Politikaları**: Minimum şifre gereksinimleri
- ✅ **Two-Factor Authentication**: 2FA desteği (Identity UI ile)
- ✅ **Account Lockout**: Başarısız giriş denemelerinde hesap kilitleme

#### 2. Veri Koruma

- ✅ **Şifre Hashleme**: PBKDF2 algoritması ile şifre hashleme
- ✅ **SQL Injection Koruması**: Entity Framework parametreli sorgular
- ✅ **XSS Koruması**: Razor engine otomatik HTML encoding
- ✅ **CSRF Koruması**: Anti-forgery token'ları

#### 3. Dosya Yükleme Güvenliği

- ⚠️ **Dosya Tipi Kontrolü**: Şu anda sınırlı (geliştirilmeli)
- ⚠️ **Dosya Boyutu Limiti**: Yapılandırılabilir limit (geliştirilmeli)
- ⚠️ **Virus Taraması**: Henüz uygulanmadı (production için gerekli)

#### 4. Ağ Güvenliği

- ✅ **HTTPS**: Production'da HTTPS zorunlu
- ✅ **HSTS**: HTTP Strict Transport Security
- ✅ **CORS**: Cross-Origin Resource Sharing kontrolleri

## ⚠️ Bilinen Güvenlik Sorunları

### Yüksek Öncelikli

1. **Dosya Yükleme Güvenliği**
   - **Durum**: Dosya tipi kontrolü eksik
   - **Etki**: Kötü amaçlı dosya yükleme riski
   - **Çözüm**: MIME type kontrolü ve dosya imza kontrolü eklenmeli

2. **Rate Limiting**
   - **Durum**: API rate limiting yok
   - **Etki**: Brute force saldırılarına açık
   - **Çözüm**: ASP.NET Core Rate Limiting middleware eklenmeli

### Orta Öncelikli

3. **Input Validation**
   - **Durum**: Bazı endpoint'lerde yetersiz input validation
   - **Etki**: XSS ve injection riskleri
   - **Çözüm**: Data annotations ve FluentValidation eklenmeli

4. **Error Handling**
   - **Durum**: Detaylı hata mesajları production'da gösteriliyor
   - **Etki**: Bilgi sızıntısı riski
   - **Çözüm**: Generic error messages kullanılmalı

## 🔐 Güvenlik En İyi Uygulamaları

### Geliştiriciler İçin

1. **Dependency Güncellemeleri**
   ```bash
   dotnet list package --outdated
   dotnet add package PackageName --version LatestVersion
   ```

2. **Güvenlik Analizi**
   ```bash
   dotnet list package --vulnerable
   ```

3. **Secrets Yönetimi**
   - Development: User Secrets kullanın
   - Production: Azure Key Vault veya benzeri

4. **Code Review**
   - Tüm PR'lar güvenlik açısından gözden geçirilmeli
   - Özellikle authentication/authorization kodları

### Production Deployment

1. **Environment Variables**
   ```bash
   # Connection string'i environment variable olarak ayarlayın
   export ConnectionStrings__DefaultConnection="Server=..."
   ```

2. **HTTPS Zorunlu**
   ```csharp
   // Program.cs
   app.UseHttpsRedirection();
   app.UseHsts();
   ```

3. **Error Handling**
   ```csharp
   // Production'da detaylı hataları gizleyin
   if (!app.Environment.IsDevelopment())
   {
       app.UseExceptionHandler("/Home/Error");
   }
   ```

4. **Logging**
   - Hassas bilgileri loglamayın (şifreler, token'lar)
   - Log dosyalarını güvenli saklayın

## 📋 Güvenlik Checklist

### Development

- [ ] Şifreler hashleniyor mu?
- [ ] SQL injection koruması var mı?
- [ ] XSS koruması aktif mi?
- [ ] CSRF token'ları kullanılıyor mu?
- [ ] Input validation yapılıyor mu?
- [ ] Authorization kontrolleri var mı?

### Production

- [ ] HTTPS zorunlu mu?
- [ ] Connection string güvenli mi?
- [ ] Secrets environment variable'da mı?
- [ ] Error messages generic mi?
- [ ] Logging güvenli mi?
- [ ] Backup stratejisi var mı?

## 🔍 Güvenlik Taraması

### Otomatik Tarama

1. **NuGet Paket Güvenliği**
   ```bash
   dotnet list package --vulnerable
   ```

2. **Code Analysis**
   ```bash
   dotnet build /p:RunCodeAnalysis=true
   ```

3. **OWASP Dependency Check** (opsiyonel)
   ```bash
   dependency-check --project "EduHub" --scan ./Classroom
   ```

### Manuel İnceleme

- [ ] Authentication flow gözden geçirildi
- [ ] Authorization kontrolleri test edildi
- [ ] File upload güvenliği kontrol edildi
- [ ] Input validation test edildi
- [ ] Error handling kontrol edildi

## 📚 Güvenlik Kaynakları

- [OWASP Top 10](https://owasp.org/www-project-top-ten/)
- [ASP.NET Core Security](https://docs.microsoft.com/aspnet/core/security/)
- [CWE Top 25](https://cwe.mitre.org/top25/)

## 📞 İletişim

Güvenlik soruları için: security@example.com (örnek - gerçek email ekleyin)

---

**Not**: Bu belge sürekli güncellenmektedir. Düzenli olarak kontrol edin.

