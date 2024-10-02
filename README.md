# 🎓 Online Student Management System - Backend

Bu proje, **Online Student Management System** için geliştirilmiş bir **ASP.NET Core Web API** uygulamasıdır. Öğrenci ve öğretmenlerin kurslara katılımını ve kurs içeriklerini yönetmek amacıyla oluşturulmuştur. Şu anda sadece **backend** kısmı tamamlanmış olup, frontend entegrasyonu ileriki aşamalarda yapılacaktır.

## 📋 Proje Yapısı ve Kullanılan Teknolojiler

| Teknoloji/Framework       | Açıklama                                                |
| ------------------------- | ------------------------------------------------------ |
| **.NET Framework**        | `.NET 8`                                                |
| **ASP.NET Core Web API**  | API endpoint'leri ve CRUD işlemleri için kullanıldı     |
| **Entity Framework Core** | ORM (Object-Relational Mapping) için                    |
| **SQL Server**            | Veritabanı yönetim sistemi                              |
| **Swagger**               | API dökümantasyonu ve test aracı                        |
| **AutoMapper**            | Veri transfer nesneleri (DTO) ve Entity dönüşümleri     |
| **Postman**               | API test ve geliştirme süreçlerinde kullanıldı          |

## 📦 Proje Özellikleri

- **Student (Öğrenci)**: Öğrencilerin kayıt, güncelleme ve silme işlemlerini yapabileceğiniz bir model.
- **Teacher (Öğretmen)**: Öğretmenlerin eklenmesi ve kurslarla ilişkilendirilmesi.
- **Course (Kurs)**: Öğrenci ve öğretmenlerin yer aldığı kurs bilgilerini içerir.
- **Enrollment (Kayıt)**: Öğrencilerin kurslara kayıt işlemlerini yönetir.
- **CourseContent (Kurs İçeriği)**: Kurslara ait içeriklerin (metin veya bağlantı) yönetimi yapılır.

### 🔗 Projedeki İlişkiler ve Veri Modeli

- **Student** ve **Course** arasında **Many-to-Many** ilişki (Enrollment tablosu ile).
- **Course** ve **Teacher** arasında **One-to-Many** ilişki.
- **Course** ve **CourseContent** arasında **One-to-Many** ilişki.
### 🎨 Backend Mimarisi

Proje mimarisi, Entity Framework Core ile ASP.NET Core Web API yapısını kullanarak CRUD işlemlerini veritabanı ile uyumlu bir şekilde gerçekleştirir. Aşağıda projenin backend veri akışını özetleyen basit bir mimari diyagramı görebilirsiniz:

```plaintext
+---------------------+      +-----------------+      +----------------+
|     Web API         | ---> | Entity Models   | ---> | SQL Server DB  |
| (ASP.NET Core)      |      | (EF Core)       |      |                |
+---------------------+      +-----------------+      +----------------+
```

## 🚀 Kurulum Adımları

Bu projeyi kendi makinenizde çalıştırmak için aşağıdaki adımları takip edebilirsiniz:

1. **Gereksinimler:**
   - Visual Studio 2022 (veya üzeri)
   - .NET 8 SDK
   - Microsoft SQL Server (veya SQL Server Express)
   - Postman veya Swagger (API testleri için)

2. **Proje Bağımlılıklarını Yükleme:**

   Projenin kök dizininde aşağıdaki komutu çalıştırın:

   ```bash
   dotnet restore
   ```
   Bu komut, .csproj dosyasında belirtilen tüm bağımlılıkları indirir ve projenizin çalışması için gerekli olan paketleri kurar.
3. **Veritabanı Yapılandırması**

   `appsettings.json` dosyasındaki `ConnectionStrings` bölümünü kendi veritabanı bağlantı bilgilerinizle güncelleyin. Bu ayar, projenin SQL Server ile iletişim kurmasını sağlar.



  #### Örnek Bağlantı Dizesi:
  
  ```json
  "ConnectionStrings": {
    "SchoolDatabase": "Server=localhost\\SQLEXPRESS;Database=OnlineStudentManagementSystemDB;Integrated Security=True;TrustServerCertificate=True"
  }
  ```

4. **Veritabanı Migration İşlemleri**
 Entity Framework Core migration işlemini uygulayın ve veritabanı tablolarını oluşturun:


   ```bash
   dotnet ef migrations add InitialCreate
   ```
Bu komut, InitialCreate adında bir migration dosyası oluşturur ve tüm tabloları (Students, Teachers, Courses, Enrollments, CourseContents) yapılandırır.
Ardından, veritabanını güncellemek için:

 ```bash
  dotnet ef database update
   ```
Bu komut, oluşturulan migration'ları uygulayarak veritabanı tablolarını SQL Server'a yansıtır.

Not: Migration işlemini başarıyla tamamladığınızda OnlineStudentManagementSystemDB veritabanı, belirtilen tablolar ile birlikte oluşturulmuş olacaktır.

## 📍 API Endpoint'leri

Aşağıdaki API endpoint'leri proje içinde şu ana kadar oluşturulmuş ve test edilmiştir:

### 📚 Student Controller

- **`GET /api/Students`** - Tüm öğrencileri listele.
- **`GET /api/Students/{id}`** - Belirli bir öğrenciyi ID ile getir.
- **`POST /api/Students`** - Yeni öğrenci ekle.
- **`PUT /api/Students/{id}`** - Mevcut bir öğrenciyi güncelle.
- **`DELETE /api/Students/{id}`** - Öğrenciyi sil.

### 👨‍🏫 Teacher Controller

- **`GET /api/Teachers`** - Tüm öğretmenleri listele.
- **`GET /api/Teachers/{id}`** - Belirli bir öğretmeni ID ile getir.
- **`POST /api/Teachers`** - Yeni öğretmen ekle.
- **`PUT /api/Teachers/{id}`** - Mevcut bir öğretmeni güncelle.
- **`DELETE /api/Teachers/{id}`** - Öğretmeni sil.

### 📘 Course Controller

- **`GET /api/Courses`** - Tüm kursları listele.
- **`GET /api/Courses/{id}`** - Belirli bir kursu ID ile getir.
- **`POST /api/Courses`** - Yeni kurs ekle.
- **`PUT /api/Courses/{id}`** - Mevcut bir kursu güncelle.
- **`DELETE /api/Courses/{id}`** - Kursu sil.

### 🔄 Enrollment Controller

- **`GET /api/Enrollments`** - Tüm kayıtları listele.
- **`POST /api/Enrollments`** - Öğrenciyi bir kursa kaydet.
- **`DELETE /api/Enrollments/{id}`** - Kayıt işlemini sil.

### 📝 CourseContent Controller

- **`GET /api/CourseContents`** - Tüm kurs içeriklerini listele.
- **`GET /api/CourseContents/{id}`** - Belirli bir kurs içeriğini ID ile getir.
- **`POST /api/CourseContents`** - Yeni kurs içeriği ekle.
- **`PUT /api/CourseContents/{id}`** - Mevcut bir kurs içeriğini güncelle.
- **`DELETE /api/CourseContents/{id}`** - Kurs içeriğini sil.

## 🔄 Gelecek Geliştirmeler

- 🖼 **Frontend Entegrasyonu**: Angular ile kullanıcı arayüzü oluşturma.
- 🔒 **Rol Tabanlı Yetkilendirme**: Öğrenci, öğretmen ve admin için farklı yetkilendirme kuralları ekleme.
- 📊 **Kullanıcı Yönetimi**: JWT tabanlı kimlik doğrulama ve kullanıcı rolleri ile ilgili ek geliştirmeler.


## 💬 İletişim ve Geri Bildirim
### 📩 Proje ile ilgili herhangi bir soru, öneri veya geri bildiriminiz mi var? Bana ulaşmaktan çekinmeyin!

### 🔗 E-posta: sumeyrapolaat@gmail.com


