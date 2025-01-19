# C# Eğitim Kampı Travel Projesi 🌍✈️

Bu proje, C# Eğitim Kampında Windows Forms uygulaması kullanarak geliştirilmiş bir seyahat yönetim uygulamasıdır. Proje, kullanıcıların rehberler ve lokasyonlar hakkında çeşitli bilgiler görmesini sağlar. Ayrıca, rehberlerin yönetimi ve lokasyonların kapasite gibi istatistiksel verilerini de görüntüleyebilirsiniz.

## Projenin Amacı 🎯

Proje, kullanıcıların eğitim kampı rehberleri ve lokasyonları üzerinde işlem yapabilmesini sağlayan basit bir yönetim uygulamasıdır. Kullanıcılar rehber ekleyebilir, güncelleyebilir, silebilir ve rehberler hakkında istatistiksel verileri görüntüleyebilir.

## Proje Özellikleri ⚙️

### 1. **Form1 (Rehber Yönetimi) 🧑‍🏫**
Form1, kullanıcıların rehberler üzerinde CRUD (Create, Read, Update, Delete) işlemleri yapmasını sağlar. Bu formda aşağıdaki işlemler yapılabilir:

- **Rehber Listeleme** 📋: Veritabanındaki tüm rehberler bir veri ızgarasında (DataGridView) görüntülenir.
- **Rehber Ekleme** ➕: Kullanıcı, ad ve soyad bilgilerini girerek yeni bir rehber ekleyebilir.
- **Rehber Silme** ❌: Rehberin ID'si girilerek rehber veritabanından silinebilir.
- **Rehber Güncelleme** ✏️: Bir rehberin ad ve soyad bilgileri güncellenebilir.
- **Rehber ID ile Getirme** 🔍: Belirli bir rehberin bilgileri, ID numarası ile getirilip listelenebilir.

- ![Ekran görüntüsü 2025-01-19 143516](https://github.com/user-attachments/assets/9c080888-5eaf-449c-b96a-b1ed4edac3e0)



### 2. **İstatistik Görüntüleme 📊**
FrmStatistics, kullanıcıya lokasyonlar ve rehberler hakkında çeşitli istatistiksel bilgiler sağlar. Aşağıdaki veriler görüntülenebilir:

- **Lokasyon Sayısı** 🌐: Veritabanındaki toplam lokasyon sayısını gösterir.
- **Toplam Kapasite** 💼: Lokasyonların tümünün toplam kapasitesini hesaplar.
- **Ortalama Kapasite** 📏: Lokasyonların ortalama kapasitesini hesaplar.
- **Ortalama Lokasyon Fiyatı 💰**: Lokasyonların ortalama fiyatını hesaplar.
- **En Yüksek Kapasiteli Lokasyon** 🏙️: En yüksek kapasiteye sahip olan lokasyonun şehir ismini gösterir.
- **En Yüksek Fiyatlı Lokasyon** 💵: En yüksek fiyatlı lokasyonun şehir ismini gösterir.
- **Rehber Sayısı** 🧳: Her rehberin görev yaptığı lokasyon sayısını gösterir.

- ![Ekran görüntüsü 2025-01-19 143530](https://github.com/user-attachments/assets/1a9e1848-7c8a-4624-937f-088ced55c217)


## Kullanılan Teknolojiler 🛠️

- **C#**: Uygulama geliştirme dili.
- **Windows Forms**: Grafiksel kullanıcı arayüzü (GUI) oluşturmak için kullanılan teknoloji.
- **Entity Framework (EF)**: Veritabanı yönetimi ve işlemleri için kullanılan ORM (Object-Relational Mapping) aracı.
- **SQL Server**: Veritabanı yönetim sistemi.
