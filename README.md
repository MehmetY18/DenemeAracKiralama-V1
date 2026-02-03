# 🏎️ Araç Kiralama Otomasyonu v1.0

Bu proje, C# Windows Forms ve Entity Framework kullanılarak geliştirilmiş, modern arayüzlü bir **Araç Kiralama Yönetim Sistemi** çalışmasıdır. Projenin temel amacı, bir galerinin araç envanterini yönetmesi ve kiralama süreçlerini dijital ortamda takip etmesidir. 
Proje üstünde çalışmam hala devam etmektedir yeni versiyonlar için takipte kalın!

## ✨ Özellikler

- **Müşteri Paneli:** Araçları inceleme, tarih seçimi ve otomatik fiyat hesaplama.
- **Admin Paneli:** Araç ekleme/silme/güncelleme ve dinamik durum takibi.
- **Dinamik Fiyatlandırma:** Tarih aralığına göre otomatik gün ve tutar hesaplama.
- **Durum Yönetimi:** Kiralanan aracın otomatik olarak "Kirada" (Kırmızı), müsait olanın "Müsait" (Yeşil) görünmesi.
- **Teslim Al Sistemi:** Kiradan dönen aracın tek tıkla envantere geri kazandırılması.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework)
* **Veritabanı:** MS SQL Server & Entity Framework (Code First)
* **Arayüz:** MaterialSkin 2.0 (Modern UI)

## 📸 Ekran Görüntüleri

Giriş Ekranı 
<img width="1919" height="903" alt="image" src="https://github.com/user-attachments/assets/b54ca748-43b6-4640-b8ed-b8a06e90f848" />





## ⚙️ Kurulum ve Çalıştırma

1. Bu projeyi bilgisayarınıza indirin (Clone).
2. Visual Studio ile `.sln` dosyasını açın.
3. `App.config` dosyasındaki `connectionString` alanını kendi SQL Server bilgilerinize göre güncelleyin.
4. **Package Manager Console** ekranına şu komutu yazarak veritabanını oluşturun:
   ```bash
   Update-Database
5. F5 yapın
