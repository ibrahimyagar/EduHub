# 🧪 Test Planı

## 📋 Test Stratejisi

### Test Piramidi

```
        /\
       /E2E\         (10%)
      /------\
     /Integration\   (20%)
    /------------\
   /   Unit Tests \  (70%)
  /----------------\
```

### Test Türleri

1. **Unit Tests** (70%)
   - Controller testleri
   - Service testleri (gelecekte)
   - Model validation testleri

2. **Integration Tests** (20%)
   - Database testleri
   - Identity testleri
   - File upload testleri

3. **E2E Tests** (10%)
   - Kullanıcı akışları
   - Critical path'ler

## 🎯 Test Kapsamı

### Kritik İş Mantığı

- ✅ Sınıf oluşturma
- ✅ Sınıfa katılma
- ✅ Ödev oluşturma
- ✅ Ödev teslim etme
- ✅ Ödev puanlama
- ✅ Duyuru paylaşma
- ✅ Öğretmen değerlendirme

### Güvenlik Testleri

- ✅ Authorization kontrolleri
- ✅ Input validation
- ✅ File upload güvenliği
- ✅ SQL injection koruması
- ✅ XSS koruması

## 📝 Test Senaryoları

### HomeController Testleri

#### Test: CreateClassRoom_ValidInput_Success
```csharp
[Fact]
public async Task CreateClassRoom_ValidInput_Success()
{
    // Arrange
    var userId = "user-123";
    var model = new ClassRoom
    {
        Name = "Test Class",
        Description = "Test Description"
    };
    
    // Act
    var result = await controller.CreateClassRoom(model);
    
    // Assert
    Assert.IsType<RedirectToActionResult>(result);
    Assert.True(db.ClassRoom.Any(c => c.Name == "Test Class"));
}
```

#### Test: JoinClassRoom_InvalidCode_ReturnsError
```csharp
[Fact]
public async Task JoinClassRoom_InvalidCode_ReturnsError()
{
    // Arrange
    var model = new JoinClassRoomModel
    {
        ClassRoomUnicCode = "INVALID"
    };
    
    // Act
    var result = await controller.JoinClassRoom(model);
    
    // Assert
    Assert.IsType<ViewResult>(result);
    Assert.False(controller.ModelState.IsValid);
}
```

### ClassroomController Testleri

#### Test: Index_UserNotMember_ReturnsForbid
```csharp
[Fact]
public async Task Index_UserNotMember_ReturnsForbid()
{
    // Arrange
    var classroomId = 1;
    var userId = "unauthorized-user";
    
    // Act
    var result = await controller.Index(classroomId);
    
    // Assert
    Assert.IsType<ForbidResult>(result);
}
```

#### Test: Announcements_ValidInput_CreatesAnnouncement
```csharp
[Fact]
public async Task Announcements_ValidInput_CreatesAnnouncement()
{
    // Arrange
    var classroomId = 1;
    var content = "Test announcement";
    
    // Act
    var result = await controller.Announcements(content, classroomId);
    
    // Assert
    Assert.IsType<RedirectToActionResult>(result);
    Assert.True(db.Announcements.Any(a => a.Contents == content));
}
```

### HomeworkController Testleri

#### Test: CreateHomework_ValidInput_CreatesHomework
```csharp
[Fact]
public async Task CreateHomework_ValidInput_CreatesHomework()
{
    // Arrange
    var classroomId = 1;
    var title = "Test Homework";
    var description = "Test Description";
    var dueDate = DateTime.Now.AddDays(7);
    
    // Act
    var result = await controller.CreateHomework(title, description, dueDate, classroomId);
    
    // Assert
    Assert.IsType<RedirectToActionResult>(result);
    Assert.True(db.Homework.Any(h => h.Name == title));
    // Tüm öğrencilere atandı mı kontrol et
    var studentCount = db.ClassUser.Count(cu => 
        cu.ClassRoomId == classroomId && !cu.Roles);
    var homeworkUserCount = db.HomeworkUser.Count(hu => 
        hu.Homework.ClassRoomId == classroomId);
    Assert.Equal(studentCount, homeworkUserCount);
}
```

#### Test: AddHomework_FileUpload_SavesFile
```csharp
[Fact]
public async Task AddHomework_FileUpload_SavesFile()
{
    // Arrange
    var homeworkId = 1;
    var classroomId = 1;
    var file = CreateMockFile("test.pdf", "application/pdf");
    
    // Act
    var result = await controller.AddHomework(homeworkId, classroomId, null, file);
    
    // Assert
    Assert.IsType<RedirectToActionResult>(result);
    var homeworkUser = db.HomeworkUser.FirstOrDefault(hu => 
        hu.HomeworkId == homeworkId);
    Assert.NotNull(homeworkUser.Work);
    Assert.True(homeworkUser.Work.Contains(".pdf"));
}
```

### Güvenlik Testleri

#### Test: FileUpload_InvalidFileType_Rejects
```csharp
[Fact]
public async Task FileUpload_InvalidFileType_Rejects()
{
    // Arrange
    var file = CreateMockFile("malicious.exe", "application/x-msdownload");
    
    // Act
    var result = await controller.AddHomework(1, 1, null, file);
    
    // Assert
    Assert.IsType<BadRequestResult>(result);
}
```

#### Test: Authorization_UnauthorizedUser_ReturnsForbid
```csharp
[Fact]
public async Task Authorization_UnauthorizedUser_ReturnsForbid()
{
    // Arrange
    var unauthorizedUserId = "unauthorized-user";
    SetCurrentUser(unauthorizedUserId);
    
    // Act
    var result = await controller.MakeTeacher("student-id", 1);
    
    // Assert
    Assert.IsType<ForbidResult>(result);
}
```

## 🔧 Test Setup

### Test Projesi Oluşturma

```bash
dotnet new xunit -n Classroom.Tests
cd Classroom.Tests
dotnet add reference ../Classroom/Classroom.csproj
dotnet add package Moq
dotnet add package FluentAssertions
dotnet add package Microsoft.EntityFrameworkCore.InMemory
```

### Test Database

```csharp
public class TestDbContext : ApplicationDbContext
{
    public TestDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("TestDb");
    }
}
```

### Mock Setup

```csharp
public class ControllerTestBase
{
    protected ApplicationDbContext DbContext { get; }
    protected Mock<ILogger<TController>> Logger { get; }
    protected ClaimsPrincipal User { get; }
    
    public ControllerTestBase()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(Guid.NewGuid().ToString())
            .Options;
        DbContext = new ApplicationDbContext(options);
        Logger = new Mock<ILogger<TController>>();
        User = CreateTestUser();
    }
    
    protected ClaimsPrincipal CreateTestUser(string userId = "test-user")
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, userId),
            new Claim(ClaimTypes.Name, "Test User"),
            new Claim(ClaimTypes.Email, "test@example.com")
        };
        return new ClaimsPrincipal(new ClaimsIdentity(claims, "Test"));
    }
}
```

## 📊 Test Coverage Hedefleri

### Minimum Coverage

- **Controllers**: %80+
- **Services**: %90+ (gelecekte)
- **Models**: %70+ (validation)
- **Critical Paths**: %100

### Coverage Raporu

```bash
dotnet test --collect:"XPlat Code Coverage"
reportgenerator -reports:**/coverage.cobertura.xml -targetdir:coverage -reporttypes:Html
```

## 🚀 CI/CD Entegrasyonu

### GitHub Actions Test Job

```yaml
test:
  runs-on: ubuntu-latest
  steps:
    - uses: actions/checkout@v3
    - uses: actions/setup-dotnet@v3
      with:
        dotnet-version: '8.0.x'
    - run: dotnet restore
    - run: dotnet build --no-restore
    - run: dotnet test --no-build --verbosity normal --collect:"XPlat Code Coverage"
    - uses: codecov/codecov-action@v3
      with:
        files: '**/coverage.cobertura.xml'
```

## 📋 Test Checklist

### Unit Test Checklist

- [ ] Test adı açıklayıcı mı? (MethodName_Scenario_ExpectedResult)
- [ ] Arrange-Act-Assert pattern kullanıldı mı?
- [ ] Mock'lar doğru setup edildi mi?
- [ ] Edge case'ler test edildi mi?
- [ ] Exception senaryoları test edildi mi?

### Integration Test Checklist

- [ ] Database state temizlendi mi?
- [ ] Test data doğru oluşturuldu mu?
- [ ] Transaction rollback yapıldı mı?
- [ ] Concurrent test çalıştırılabilir mi?

## 🔍 Test Senaryoları Listesi

### HomeController (8 test)

1. ✅ CreateClassRoom_ValidInput_Success
2. ✅ CreateClassRoom_InvalidInput_ReturnsView
3. ✅ JoinClassRoom_ValidCode_Success
4. ✅ JoinClassRoom_InvalidCode_ReturnsError
5. ✅ JoinClassRoom_AlreadyMember_ReturnsError
6. ✅ Index_ReturnsUserClassrooms
7. ✅ Teacher_ReturnsTeacherClassrooms
8. ✅ Student_ReturnsStudentClassrooms

### ClassroomController (12 test)

1. ✅ Index_ValidId_ReturnsView
2. ✅ Index_InvalidId_ReturnsNotFound
3. ✅ Index_UserNotMember_ReturnsForbid
4. ✅ Announcements_ValidInput_CreatesAnnouncement
5. ✅ MakeTeacher_ValidInput_Success
6. ✅ MakeTeacher_Unauthorized_ReturnsForbid
7. ✅ RemoveStudent_ValidInput_Success
8. ✅ ArchivedClassroom_ValidInput_Success
9. ✅ DeleteClassroom_ValidInput_Success
10. ✅ RateTeacher_ValidInput_CreatesRating
11. ✅ RateTeacher_ExistingRating_UpdatesRating
12. ✅ DeleteAnnonucements_ValidInput_Success

### HomeworkController (10 test)

1. ✅ CreateHomework_ValidInput_CreatesHomework
2. ✅ CreateHomework_AssignsToAllStudents
3. ✅ AddHomework_ValidFile_SavesFile
4. ✅ AddHomework_ValidText_SavesText
5. ✅ AddHomework_PastDueDate_ReturnsForbid
6. ✅ HomeworkGrade_ValidInput_UpdatesPoint
7. ✅ HomeworkList_ReturnsSubmissions
8. ✅ Index_ReturnsHomeworkDetails
9. ✅ TeachIndex_ValidInput_ReturnsView
10. ✅ TeachIndex_UpdateHomework_Success

### CommentController (4 test)

1. ✅ AddComment_ValidInput_CreatesComment
2. ✅ AddComment_UserNotMember_ReturnsForbid
3. ✅ RemoveComment_ValidInput_Success
4. ✅ RemoveComment_InvalidId_ReturnsNotFound

### Güvenlik Testleri (6 test)

1. ✅ FileUpload_InvalidFileType_Rejects
2. ✅ FileUpload_FileTooLarge_Rejects
3. ✅ Authorization_UnauthorizedUser_ReturnsForbid
4. ✅ InputValidation_XSS_Encodes
5. ✅ SQLInjection_Attempt_Rejects
6. ✅ CSRF_MissingToken_Rejects

**Toplam**: 40+ test

## 📈 Test Metrikleri

### Coverage Metrikleri

- **Line Coverage**: %70+ (hedef)
- **Branch Coverage**: %60+ (hedef)
- **Method Coverage**: %80+ (hedef)

### Test Performansı

- **Unit Tests**: < 100ms/test
- **Integration Tests**: < 500ms/test
- **E2E Tests**: < 2s/test

## 🔄 Test Maintenance

### Test Güncelleme

- Her yeni feature için test yazılmalı
- Her bug fix için regression test eklenmeli
- Kod değişikliklerinde testler güncellenmeli

### Test Review

- PR'larda test coverage kontrol edilmeli
- Test kalitesi code review'da değerlendirilmeli
- Flaky testler düzeltilmeli

---

**Test Plan Versiyonu**: 1.0.0  
**Son Güncelleme**: 2025-01-XX

