# 📸 Proje Görselleri Ekleme Rehberi

Bu rehber, proje görsellerini GitHub'a nasıl ekleyeceğinizi açıklar.

## 📁 Görselleri Nereye Eklemeliyim?

Tüm görselleri `docs/screenshots/` klasörüne ekleyin.

## 🎯 Hangi Görselleri Eklemeliyim?

### Öncelikli Görseller

1. **Ana Sayfa (Hello Sayfası)**
   - Kurs kataloğu görünümü
   - Dosya: `homepage.png` veya `course-catalog.png`

2. **Sınıf Detay Sayfası**
   - Öğretmen ve öğrenci görünümü
   - Dosya: `classroom-detail.png`

3. **Ödev Sistemi**
   - Ödev listesi ve detay sayfası
   - Dosya: `homework-list.png`, `homework-detail.png`

4. **Canlı Ders (Jitsi Meet)**
   - Canlı ders ekranı
   - Dosya: `live-lesson.png`

5. **Kod Editörü (StackBlitz)**
   - StackBlitz editör ekranı
   - Dosya: `code-editor.png`

6. **Ödeme Sayfası**
   - Kurs satın alma formu
   - Dosya: `payment-form.png`

7. **Kullanıcı Dashboard**
   - Ana sayfa görünümü (giriş yapmış kullanıcı)
   - Dosya: `dashboard.png`

## 📝 Görsel Ekleme Adımları

### 1. Ekran Görüntüsü Alın

**Windows:**
- `Win + Shift + S` tuşlarına basın
- Ekran görüntüsü almak istediğiniz alanı seçin
- Otomatik olarak panoya kopyalanır

**Mac:**
- `Cmd + Shift + 4` tuşlarına basın
- Ekran görüntüsü almak istediğiniz alanı seçin

**Alternatif:**
- Uygulamayı çalıştırın
- Browser'da ekran görüntüsü alın (F12 > DevTools > Device Toolbar)

### 2. Görseli Kaydedin

1. Görseli `docs/screenshots/` klasörüne kaydedin
2. Dosya adını küçük harf ve tire ile yazın (kebab-case)
   - ✅ İyi: `homepage-dashboard.png`
   - ❌ Kötü: `HomePage_Dashboard.PNG`

### 3. Görsel Formatı

- **Format**: PNG (önerilen) veya JPG
- **Boyut**: Maksimum 1920x1080px
- **Dosya Boyutu**: Her görsel maksimum 1MB (2MB'a kadar kabul edilebilir)
- **Kalite**: Net ve okunabilir olmalı

### 4. README.md'ye Ekleyin

`README.md` dosyasındaki "Ekran Görüntüleri" bölümüne görseli ekleyin:

```markdown
![Açıklama](docs/screenshots/dosya-adi.png)
```

**Örnek:**
```markdown
![Ana Sayfa - Kurs Kataloğu](docs/screenshots/homepage.png)
![Sınıf Detay Sayfası](docs/screenshots/classroom-detail.png)
```

### 5. Git'e Ekleyin

```bash
git add docs/screenshots/homepage.png
git commit -m "docs: Ana sayfa ekran görüntüsü eklendi"
git push origin main
```

## 🎨 Görsel İyileştirme İpuçları

### Tarayıcı Görünümü
- Tam ekran görünümü alın
- Mümkünse responsive tasarımı gösterin (mobil ve desktop)

### Gizlilik
- Kişisel bilgileri gizleyin (isim, email vb.)
- Test verileri kullanın
- Hassas bilgileri maskeleyin

### Düzen
- Görselleri aynı boyutta tutun
- Tutarlı bir stil kullanın
- Açıklayıcı dosya isimleri verin

## 📋 Örnek Görsel Listesi

Eklenmesi önerilen görseller:

- [ ] `homepage.png` - Ana sayfa (Hello Controller)
- [ ] `course-detail.png` - Kurs detay sayfası
- [ ] `payment-form.png` - Ödeme formu
- [ ] `dashboard.png` - Kullanıcı dashboard'u
- [ ] `classroom-list.png` - Sınıf listesi
- [ ] `classroom-detail.png` - Sınıf detay sayfası
- [ ] `homework-list.png` - Ödev listesi
- [ ] `homework-submit.png` - Ödev teslim sayfası
- [ ] `live-lesson.png` - Canlı ders (Jitsi Meet)
- [ ] `code-editor.png` - Kod editörü (StackBlitz)
- [ ] `teacher-rating.png` - Öğretmen değerlendirme
- [ ] `announcements.png` - Duyurular sayfası
- [ ] `create-classroom.png` - Sınıf oluşturma formu
- [ ] `join-classroom.png` - Sınıfa katılma sayfası

## 🔍 Görsel Optimizasyonu

Görselleri optimize etmek için:

**Online Araçlar:**
- [TinyPNG](https://tinypng.com/) - PNG/JPG sıkıştırma
- [Squoosh](https://squoosh.app/) - Görsel optimizasyonu

**Komut Satırı (ImageMagick):**
```bash
# PNG sıkıştırma
magick convert input.png -quality 85 output.png

# JPG sıkıştırma
magick convert input.jpg -quality 85 output.jpg
```

## ✅ Kontrol Listesi

Görsel eklemeden önce:

- [ ] Görsel net ve okunabilir mi?
- [ ] Dosya adı doğru formatta mı? (kebab-case)
- [ ] Dosya boyutu 1MB'ın altında mı?
- [ ] Kişisel bilgiler gizlendi mi?
- [ ] README.md'ye eklendi mi?
- [ ] Git'e commit edildi mi?

---

**İpucu**: Görselleri ekledikten sonra README.md'deki yorum satırlarını kaldırıp görselleri aktif hale getirin!

