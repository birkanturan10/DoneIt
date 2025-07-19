✅ DoneIt
Günlük görevlerinizi kolayca yönetin. Basit, pratik, verimli.

📌 Proje Açıklaması
DoneIt, bireylerin günlük görevlerini oluşturup takip edebileceği sade bir yapılacaklar listesi (To-Do List) uygulamasıdır. Görevleri tarihleriyle birlikte ekleyebilir, listeleyebilir, silebilir ve tamamlandı olarak işaretleyebilirsiniz.

Uygulama, katmanlı mimari kullanılarak ASP.NET MVC çatısı altında geliştirilmiştir.

🔧 Kullanılan Teknolojiler
ASP.NET MVC (.NET 8)

C#

Entity Framework Core

MSSQL Server

Katmanlı Mimari (Entity, DataAccess, Business, WebUI)

Razor View Engine

HTML/CSS (temel)

🧩 Katmanlar Hakkında
Entity Layer → TaskItem gibi veri modelleri yer alır.

Data Access Layer (DAL) → Veritabanı işlemleri (DbContext, CRUD işlemleri).

Business Layer → İş mantığı ve servisler.

WebUI → Kullanıcı arayüzü (Views, Controllers).

🚀 Projeyi Çalıştırmak
Projeyi ilk kez açacaklar için adım adım:

Visual Studio ile DoneIt.sln dosyasını açın.

DataAccessLayer > Context.cs dosyasındaki bağlantı cümlesini kendi SQL Server yapınıza göre düzenleyin.

Package Manager Console üzerinden aşağıdaki komutları çalıştırın:

Add-Migration InitialCreate
Update-Database
DoneIt.WebUI projesini Startup Project olarak ayarlayın.

Uygulamayı F5 ile çalıştırın.

✨ Özellikler
Görev ekleme

Görev listeleme

Görev silme

Görevi tamamlanmış olarak işaretleme

Tarihe göre sıralama

Basit, kullanıcı dostu arayüz
