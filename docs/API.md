# 📡 API Dokümantasyonu

EduHub MVC pattern kullanır, ancak REST API endpoint'leri de mevcuttur. Bu dokümantasyon tüm controller action'larını listeler.

## 🔐 Kimlik Doğrulama

Tüm endpoint'ler `[Authorize]` attribute ile korunmuştur (HelloController hariç).

```csharp
[Authorize]
public class HomeController : Controller
```

## 📋 Endpoint'ler

### HomeController

#### GET /Home/Index
Ana sayfa - Kullanıcının sınıflarını listeler.

**Yetkilendirme**: Authenticated users

**Response**: View (sınıf listesi)

---

#### GET /Home/Teacher
Öğretmen olarak bulunduğu sınıfları listeler.

**Yetkilendirme**: Authenticated users

**Response**: View (öğretmen sınıfları)

---

#### GET /Home/Student
Öğrenci olarak bulunduğu sınıfları listeler.

**Yetkilendirme**: Authenticated users

**Response**: View (öğrenci sınıfları)

---

#### GET /Home/Archived
Arşivlenmiş sınıfları listeler.

**Yetkilendirme**: Authenticated users

**Response**: View (arşivlenmiş sınıflar)

---

#### GET /Home/JoinClassRoom
Sınıfa katılma formunu gösterir.

**Yetkilendirme**: Authenticated users

**Response**: View (form)

---

#### POST /Home/JoinClassRoom
Benzersiz kod ile sınıfa katılır.

**Yetkilendirme**: Authenticated users

**Request Body**:
```json
{
  "ClassRoomUnicCode": "ABC1234"
}
```

**Response**: 
- Success: Redirect to /Home/Index
- Error: View with error message

**Validasyon**:
- Kod boş olamaz
- Kod geçerli bir sınıfa ait olmalı
- Kullanıcı zaten sınıf üyesi olmamalı

---

#### GET /Home/CreateClassRoom
Sınıf oluşturma formunu gösterir.

**Yetkilendirme**: Authenticated users

**Response**: View (form)

---

#### POST /Home/CreateClassRoom
Yeni sınıf oluşturur.

**Yetkilendirme**: Authenticated users

**Request Body**:
```json
{
  "Name": "Matematik 101",
  "Description": "Temel matematik dersi"
}
```

**Response**: 
- Success: Redirect to /Home/Index
- Error: View with validation errors

**Özellikler**:
- Otomatik benzersiz kod oluşturur (7 karakter)
- Otomatik renk atar
- Oluşturan kullanıcıyı öğretmen olarak ekler

---

### ClassroomController

#### GET /Classroom/Index?id={id}
Sınıf detay sayfasını gösterir.

**Yetkilendirme**: Sınıf üyesi olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: View (sınıf detayları)

**İçerik**:
- Sınıf bilgileri
- Öğretmen listesi
- Öğrenci listesi
- Duyurular
- Ödevler
- En yakın ödev
- Öğretmen değerlendirmeleri

---

#### POST /Classroom/Announcements
Sınıfa duyuru ekler.

**Yetkilendirme**: Sınıf üyesi olmalı

**Query Parameters**:
- `announcements` (string, required): Duyuru içeriği
- `classroomId` (int, required): Sınıf ID

**Response**: Redirect to /Classroom/Index?id={classroomId}

---

#### POST /Classroom/MakeTeacher
Öğrenciyi öğretmen yapar.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `userId` (string, required): Kullanıcı ID
- `classroomId` (int, required): Sınıf ID

**Response**: Redirect to /Classroom/Index?id={classroomId}

---

#### POST /Classroom/RemoveStudent
Öğrenciyi sınıftan çıkarır (soft delete).

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `userId` (string, required): Kullanıcı ID
- `classroomId` (int, required): Sınıf ID

**Response**: Redirect to /Classroom/Index?id={classroomId}

---

#### POST /Classroom/ArchivedClassroom
Sınıfı arşivler.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: Redirect to /Home/Index

---

#### POST /Classroom/DeleteClassroom
Sınıfı siler (soft delete).

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: Redirect to /Home/Index

---

#### POST /Classroom/UnarchivedClassroom
Sınıfı arşivden çıkarır.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: Redirect to /Home/Index

---

#### POST /Classroom/UnenrollClassroom
Kullanıcıyı sınıftan ayrılır.

**Yetkilendirme**: Sınıf üyesi olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: Redirect to /Home/Index

---

#### POST /Classroom/DeleteAnnonucements
Duyuruyu siler (soft delete).

**Yetkilendirme**: Duyuru sahibi veya sınıf öğretmeni olmalı

**Query Parameters**:
- `classroomId` (int, required): Sınıf ID
- `announcementsId` (int, required): Duyuru ID

**Response**: Redirect to /Classroom/Index?id={classroomId}

---

#### POST /Classroom/RateTeacher
Öğretmeni değerlendirir.

**Yetkilendirme**: Sınıf öğrencisi olmalı

**Query Parameters**:
- `classroomId` (int, required): Sınıf ID
- `teacherId` (string, required): Öğretmen ID
- `rating` (int, required): Puan (1-5)
- `comment` (string, optional): Yorum

**Response**: Redirect to /Classroom/Index?id={classroomId}

**Not**: Her öğrenci bir öğretmeni bir sınıf için sadece bir kez değerlendirebilir (güncelleme yapılabilir)

---

### HomeworkController

#### GET /Homework/Index?HomeworkId={id}
Ödev detay sayfasını gösterir.

**Yetkilendirme**: Ödev atanmış kullanıcı olmalı

**Query Parameters**:
- `HomeworkId` (int, required): Ödev ID

**Response**: View (ödev detayları)

---

#### GET /Homework/TeachIndex?id={id}
Öğretmen için ödev yönetim sayfası.

**Yetkilendirme**: Öğretmen olmalı

**Query Parameters**:
- `id` (int, required): Ödev ID

**Response**: View (ödev yönetimi)

---

#### POST /Homework/TeachIndex
Ödev bilgilerini günceller.

**Yetkilendirme**: Öğretmen olmalı

**Query Parameters**:
- `questionTitle` (string, required): Ödev başlığı
- `description` (string, required): Ödev açıklaması
- `dueDateTime` (DateTime, required): Teslim tarihi
- `homeworkId` (int, required): Ödev ID

**Response**: Redirect to /Homework/TeachIndex?id={homeworkId}

---

#### GET /Homework/CreateHomework?id={id}
Ödev oluşturma formunu gösterir.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `id` (int, required): Sınıf ID

**Response**: View (form)

---

#### POST /Homework/CreateHomework
Yeni ödev oluşturur.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `questionTitle` (string, required): Ödev başlığı
- `description` (string, required): Ödev açıklaması
- `dueDateTime` (DateTime, required): Teslim tarihi
- `classroomId` (int, required): Sınıf ID

**Response**: Redirect to /Classroom/Index?id={classroomId}

**Özellikler**:
- Otomatik olarak sınıftaki tüm öğrencilere atanır
- Her öğrenci için Homework_User kaydı oluşturulur (Point = -1)

---

#### GET /Homework/AddHomework?HomeworkId={id}
Ödev teslim formunu gösterir.

**Yetkilendirme**: Ödev atanmış öğrenci olmalı

**Query Parameters**:
- `HomeworkId` (int, required): Ödev ID

**Validasyon**:
- Teslim tarihi geçmemiş olmalı

**Response**: View (form)

---

#### POST /Homework/AddHomework
Ödev teslim eder (metin veya dosya).

**Yetkilendirme**: Ödev atanmış öğrenci olmalı

**Request**:
- `HomeworkId` (int, required): Ödev ID
- `ClassroomId` (int, required): Sınıf ID
- `HwText` (string, optional): Metin içerik
- `HomeworkFile` (IFormFile, optional): Dosya

**Validasyon**:
- Teslim tarihi geçmemiş olmalı
- Metin veya dosya (en az biri) olmalı

**Response**: Redirect to /Homework/Index?HomeworkId={HomeworkId}

**Dosya Yükleme**:
- Dosyalar `wwwroot/uploads/homeworks/` klasörüne kaydedilir
- Dosya adı: `{GUID}_{OriginalFileName}`
- Dosya yolu: `/uploads/homeworks/{GUID}_{OriginalFileName}`

---

#### GET /Homework/HomeworkList?HomeworkId={id}&ClassroomId={id}
Öğretmen için ödev teslim listesi.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `HomeworkId` (int, required): Ödev ID
- `ClassroomId` (int, required): Sınıf ID

**Response**: View (teslim listesi)

---

#### POST /Homework/HomeworkGrade
Ödev puanı verir.

**Yetkilendirme**: Sınıf öğretmeni olmalı

**Query Parameters**:
- `Grade` (int, required): Puan (0-100)
- `ClassRoomId` (int, required): Sınıf ID
- `HomeworkId` (int, required): Ödev ID
- `HomeworkUserId` (int, required): Homework_User ID

**Response**: Redirect to /Homework/HomeworkList

---

### CommentController

#### POST /Comment/AddComment
Duyuruya yorum ekler.

**Yetkilendirme**: Sınıf üyesi olmalı

**Query Parameters**:
- `AnnouncementId` (int, required): Duyuru ID
- `ClassroomId` (int, required): Sınıf ID
- `description` (string, required): Yorum içeriği

**Response**: Redirect to /Classroom/Index?id={ClassroomId}

---

#### POST /Comment/RemoveComment
Yorumu siler (soft delete).

**Yetkilendirme**: Sınıf üyesi olmalı

**Query Parameters**:
- `AnnouncementId` (int, required): Duyuru ID
- `ClassroomId` (int, required): Sınıf ID
- `CommentId` (int, required): Yorum ID

**Response**: Redirect to /Classroom/Index?id={ClassroomId}

---

### HelloController

#### GET /Hello/Index
Landing page (kurs listesi).

**Yetkilendirme**: Yok (public)

**Response**: View (kurs listesi)

**Not**: Eğer kullanıcı authenticated ise /Home/Index'e yönlendirilir

---

#### GET /Hello/Detail?title={title}
Kurs detay sayfası.

**Yetkilendirme**: Yok (public)

**Query Parameters**:
- `title` (string, required): Kurs başlığı

**Response**: View (kurs detayları)

---

## 🔒 Yetkilendirme Detayları

### Rol Kontrolü

```csharp
// Öğretmen kontrolü
var isTeacher = db.ClassUser.Any(cu => 
    cu.ClassRoomId == classroomId && 
    cu.ApplicationUserId == userId && 
    cu.Roles);

// Öğrenci kontrolü
var isStudent = db.ClassUser.Any(cu => 
    cu.ClassRoomId == classroomId && 
    cu.ApplicationUserId == userId && 
    !cu.Roles);
```

### Sınıf Üyeliği Kontrolü

```csharp
var isMember = db.ClassUser.Any(cu => 
    cu.ClassRoomId == classroomId && 
    cu.ApplicationUserId == userId && 
    !cu.IsDelete);
```

## 📝 Hata Kodları

- **200 OK**: İşlem başarılı
- **400 Bad Request**: Geçersiz istek
- **401 Unauthorized**: Kimlik doğrulama gerekli
- **403 Forbidden**: Yetki yok
- **404 Not Found**: Kayıt bulunamadı
- **500 Internal Server Error**: Sunucu hatası

## 🔄 Response Format

### Başarılı Response
- View return: HTML sayfa
- Redirect: HTTP 302 Found

### Hata Response
- View return: HTML sayfa (hata mesajı ile)
- ModelState: Validation errors

## 📚 Örnek Kullanımlar

### cURL Örnekleri

**Sınıf Oluşturma** (POST):
```bash
curl -X POST "https://example.com/Home/CreateClassRoom" \
  -H "Cookie: .AspNetCore.Identity.Application=..." \
  -d "Name=Matematik 101" \
  -d "Description=Temel matematik dersi"
```

**Duyuru Ekleme** (POST):
```bash
curl -X POST "https://example.com/Classroom/Announcements?announcements=Yarın%20sınav%20var&classroomId=1" \
  -H "Cookie: .AspNetCore.Identity.Application=..."
```

**Ödev Teslim Etme** (POST - Dosya ile):
```bash
curl -X POST "https://example.com/Homework/AddHomework" \
  -H "Cookie: .AspNetCore.Identity.Application=..." \
  -F "HomeworkId=1" \
  -F "ClassroomId=1" \
  -F "HomeworkFile=@/path/to/file.pdf"
```

## ⚠️ Notlar

1. **CSRF Token**: Tüm POST isteklerinde CSRF token gerekli
2. **File Upload**: Maksimum dosya boyutu yapılandırılabilir (şu anda limit yok)
3. **Pagination**: Listelerde pagination yok (eklenmeli)
4. **Async**: Endpoint'ler sync (async'e çevrilmeli)

## 🔮 Gelecek API İyileştirmeleri

- [ ] RESTful API endpoint'leri (JSON response)
- [ ] Swagger/OpenAPI dokümantasyonu
- [ ] API versioning
- [ ] Rate limiting
- [ ] API authentication (JWT)
- [ ] Response caching
- [ ] HATEOAS support

---

**Son Güncelleme**: 2025-01-XX  
**Versiyon**: 1.0.0

