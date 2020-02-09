# EmployeeProject
C#'da MSSQL DATABASE kullanarak Dinamik olark Çalışan Kaydının Eklenip Silinebildiği ayrıca
yanlış girdi veya kayıt düzenlenmesi istenildiği takdirde kayıtların düzenlenebildiği C# Form Örneği.




![AdminGiris](https://user-images.githubusercontent.com/44782947/74104936-ab40f900-4b6a-11ea-8f67-ddcdc0eace8b.jpg)


Programı Başlattığımızda 'Admin Giriş Paneli' ile Karşılaşıyoruz.
Bu Formda eğer Kullanıcı adı ve Şifre doğruysa bizi "Ana Menü" Paneline Atması Gerekiyor.


![AnaMenu](https://user-images.githubusercontent.com/44782947/74104991-f529df00-4b6a-11ea-942d-ac3a0f2d1ff6.jpg)


Kullanıcı adı ve Şifre doğru girildiğinde 'Ana Menu' Formumuza Geçiş Sağlamış olduk.
Buradan dilediğimiz menü seçeneklerinden birini seçerek programı kullanmaya başlayabiliriz.


![CalisanGoruntule](https://user-images.githubusercontent.com/44782947/74105020-42a64c00-4b6b-11ea-86e6-2cc9dc7405da.jpg)


'Goruntule' Formuna Geçersek hali hazırda DataBase'mizde bulunan Çalışan Kayıtlarını Listeleyen bir Form bizi karşılar
Bu Formdan Geri Tuşuna Basarak Tekrar 'Ana Menu' Formuna Geçiş Sağlayabiliriz.


![CalisanEkle](https://user-images.githubusercontent.com/44782947/74105062-9b75e480-4b6b-11ea-8030-0b83030948d6.jpg)


'Calisan Ekle' Formuna Geçersek Programda Kendi Kararlaştırdığm Çalışan field'larını (alanlarını) girerek yeni bir Çalışan Ekleyebiliriz.
Çalışan Ekle Butonuna basıldığında DataBase'mize dinamik bir şekilde çalışan kaydı ekleyebiliriz.
Dilersek 'Goruntule' Formunda Olduğu gibi Geri Tuşuna Basarak 'Ana Menu' Formuna tekrar dönebiliriz.


![CalisanSil](https://user-images.githubusercontent.com/44782947/74105123-26ef7580-4b6c-11ea-85d9-9a0a808cf1d6.jpg)


'Calisan Sil' Formuna Geçersek Tıpkı 'Goruntule' Formunda olduğu gibi hali hazırda DataBase'mizde ekli çalışan kayıtlarını gösterir.
listelenen elemanların 'id' bilgisine çift tıklayark silmek istediğimiz çalışan kaydını seçip bunu programdaki field (alanlara) aktararak
silinecek çalışanın bilgilerini daha rahat görebiliriz.Ayrıca Çalışan Sil Butonuna tıklayarak Seçilen Elemanı DataBasemizden
Dinamik olarak silebiliriz.Dilersek yine tıpkı diğer Formlarımızda olduğu gibi Geri Butonu ile 'Ana Menu' Formuna Dönebiliriz.


![CalisanDuzenle](https://user-images.githubusercontent.com/44782947/74105200-bc8b0500-4b6c-11ea-9672-444cd9206e49.jpg)


'Calisan Duzenle' Formunda ise yanlış eklenen field'ları yine silme menüsünde olduğu gibi listelenen elemanın 'id'sine çift tıklayarak
Çalışan Düzenle Butonuna basarak dilediğimiz şekilde düzenleyebiliriz. Geri Buttonuna tıklayarak yine 'Ana Menu' Formuna Geçiş sağlayabiliriz.


![InfoButtonAtMainMenu](https://user-images.githubusercontent.com/44782947/74105232-14c20700-4b6d-11ea-97c3-2028574428a3.jpg)


Eklediğim ufak bir ayrıntı :) eğer Admin Giriş Panelinde sağ üstte bulunan 'info buton'a tıklarsanız. Programı yazan yazılımcı ve Nickname'ini 
görebilirsiniz.
