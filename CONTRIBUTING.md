# Katkıda Bulunma Rehberi

EduHub projesine katkıda bulunmak istediğiniz için teşekkürler! Bu belge, projeye nasıl katkıda bulunabileceğinizi açıklar.

## 🤝 Katkıda Bulunma Yolları

- 🐛 Bug raporlama
- 💡 Yeni özellik önerileri
- 📝 Dokümantasyon iyileştirmeleri
- 🔧 Kod katkıları
- 🧪 Test yazma
- 🌐 Çeviri

## 📋 Başlamadan Önce

1. Projeyi fork edin
2. Local ortamınızı hazırlayın:
   ```bash
   git clone https://github.com/YOUR_USERNAME/EduHub.git
   cd EduHub/Classroom
   dotnet restore
   ```

## 🔀 Pull Request Süreci

### 1. Branch Oluşturma

```bash
git checkout -b feature/amazing-feature
# veya
git checkout -b fix/bug-description
```

### 2. Değişiklik Yapma

- Kod standartlarına uyun (C# coding conventions)
- Anlamlı commit mesajları yazın
- Gerekli testleri ekleyin
- Dokümantasyonu güncelleyin

### 3. Commit Mesajları

Commit mesajlarınız açıklayıcı olsun:

```
feat: Ödev için dosya yükleme özelliği eklendi
fix: Sınıf silme hatası düzeltildi
docs: README güncellendi
refactor: HomeworkController kod temizliği
test: ClassroomController için birim testleri eklendi
```

### 4. Pull Request Gönderme

1. Değişikliklerinizi push edin:
   ```bash
   git push origin feature/amazing-feature
   ```

2. GitHub'da Pull Request açın
3. PR açıklamasında şunları belirtin:
   - Ne değişti?
   - Neden değişti?
   - Nasıl test edildi?
   - Screenshot (varsa)

## 📝 Kod Standartları

### C# Kod Stili

- **PascalCase**: Sınıf, metod, property isimleri
- **camelCase**: Local değişkenler, parametreler
- **Private fields**: `_camelCase` (underscore prefix)
- **Async methods**: `MethodNameAsync` suffix

Örnek:
```csharp
public class ClassroomController : Controller
{
    private readonly ApplicationDbContext _db;
    
    public async Task<IActionResult> GetClassroomAsync(int id)
    {
        var classroom = await _db.ClassRoom.FindAsync(id);
        return View(classroom);
    }
}
```

### Dosya Organizasyonu

- Her controller kendi dosyasında
- Modeller `Models/` klasöründe
- View modeller `ViewModels/` klasöründe
- Servisler `Services/` klasöründe (varsa)

### Yorum ve Dokümantasyon

- Public API'ler için XML dokümantasyon yorumları kullanın
- Karmaşık mantık için açıklayıcı yorumlar ekleyin
- TODO yorumları için issue numarası ekleyin

## 🧪 Test Yazma

### Birim Testleri

```csharp
[Fact]
public async Task CreateClassroom_ValidInput_ReturnsSuccess()
{
    // Arrange
    var controller = new HomeController(logger, db);
    
    // Act
    var result = await controller.CreateClassRoom(model);
    
    // Assert
    Assert.IsType<RedirectToActionResult>(result);
}
```

### Test Coverage

- En az %70 test coverage hedefleyin
- Kritik iş mantığı için test yazın
- Edge case'leri test edin

## 🐛 Bug Raporlama

Bug raporu oluştururken şunları ekleyin:

1. **Açıklama**: Ne oldu?
2. **Beklenen Davranış**: Ne olması gerekiyordu?
3. **Gerçekleşen Davranış**: Ne oldu?
4. **Adımlar**: Hatayı tekrarlamak için adımlar
5. **Screenshot**: Varsa görsel
6. **Ortam**: .NET versiyonu, OS, tarayıcı vb.

## 💡 Özellik Önerileri

Yeni özellik önerirken:

1. Issue açın ve "enhancement" label'ı ekleyin
2. Özelliğin amacını açıklayın
3. Kullanım senaryosunu belirtin
4. Alternatif çözümleri değerlendirin

## 📚 Dokümantasyon

Dokümantasyon katkıları:

- README.md güncellemeleri
- Kod içi yorumlar
- API dokümantasyonu
- Örnek kodlar

## ✅ Checklist

PR göndermeden önce:

- [ ] Kod derleniyor mu?
- [ ] Testler geçiyor mu?
- [ ] Kod standartlarına uygun mu?
- [ ] Dokümantasyon güncellendi mi?
- [ ] Commit mesajları açıklayıcı mı?
- [ ] Breaking change yoksa veya dokümante edildi mi?

## 📞 Sorular

Sorularınız için:
- GitHub Discussions kullanın
- Issue açın
- Maintainer'lara ulaşın

## 🙏 Teşekkürler

Katkılarınız için teşekkürler! Her katkı projeyi daha iyi hale getirir.

