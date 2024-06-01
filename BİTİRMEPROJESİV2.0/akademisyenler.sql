-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 May 2024, 16:15:19
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `akademisyenler`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `akademisyenler`
--

CREATE TABLE `akademisyenler` (
  `ID` int(11) NOT NULL,
  `KULLANICI_ADI` varchar(40) NOT NULL,
  `SIFRE` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `akademisyenler`
--

INSERT INTO `akademisyenler` (`ID`, `KULLANICI_ADI`, `SIFRE`) VALUES
(1, 'Prof.Dr. Ayşe Kaya', 'AYSE123'),
(2, 'Öğr.Üyesi Mehmet Demir', 'MEHMET123'),
(3, 'Yrd.Doç. Zeynep Kara', 'ZEYNEP123'),
(4, 'Dr.Öğr.Üyesi Elif Arslan', 'ELIF123'),
(5, 'Doç.Dr. Ahmet Yılmaz', 'AHMET123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `ogrenciler`
--

CREATE TABLE `ogrenciler` (
  `Egitim_Ogretim_Donemi` varchar(20) NOT NULL,
  `Ogrenci_No` int(10) NOT NULL,
  `Ogrenci_Ad_Soyad` varchar(50) NOT NULL,
  `Proje_Id` int(11) NOT NULL,
  `Proje_Ad` varchar(150) DEFAULT NULL,
  `Puan` int(11) DEFAULT NULL,
  `Juri_1` varchar(50) NOT NULL,
  `Juri_2` varchar(50) NOT NULL,
  `Juri_3` varchar(50) NOT NULL,
  `Juri_4` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `ogrenciler`
--

INSERT INTO `ogrenciler` (`Egitim_Ogretim_Donemi`, `Ogrenci_No`, `Ogrenci_Ad_Soyad`, `Proje_Id`, `Proje_Ad`, `Puan`, `Juri_1`, `Juri_2`, `Juri_3`, `Juri_4`) VALUES
('2022', 2024, 'Mauro Icardi', 3169, 'Galatasarayı şampiyon yapma', 25, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020BAHAR', 21593878, 'ELÇİM ELALDI', 2, 'Bir sosyal medya uygulaması için kullanıcı etkileşim analizi ve iyileştirme önerileri sunma.\n', 11, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020BAHAR', 21593880, 'ENDAM ELHAKAN', 1, 'Bir çevrimiçi alışveriş platformu için kullanıcı arayüzü tasarımı ve prototip geliştirme.\n', 13, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020BAHAR', 21595228, 'AHMET TOKUŞTEPE', 3, 'Bir mobil sağlık uygulaması için kullanıcı geri bildirim sistemini oluşturma.\n', 13, 'Doç.Dr. Ahmet Yılmaz', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20202021GÜZ     ', 21613236, 'İREM KARADAĞ', 12, 'Bir çevrimiçi etkinlik yönetimi platformu geliştirme.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara'),
('20192020BAHAR', 21617229, 'AHMET YILDIRIM', 5, 'Bir eğitim platformu için interaktif öğrenme materyalleri tasarlama.\n', 11, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020BAHAR', 21617230, 'BURAK YILMAZ ', 6, 'Bir hayvan barınağı için web sitesi ve bağış toplama platformu oluşturma.\n', 70, 'Doç.Dr. Ahmet Yılmaz', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020GÜZ     ', 21617231, 'DENİZ KARADAĞ', 7, 'Bir çevrimiçi randevu planlama uygulaması geliştirme.\n', 25, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020GÜZ     ', 21617232, 'EMRE YILMAZ', 8, 'Bir hava durumu uygulaması için kullanıcı dostu bir arayüz tasarlama.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20202021BAHAR   ', 21617233, 'FATMA DEMİR', 9, 'Bir kütüphane için online katalog ve rezervasyon sistemi oluşturma.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara'),
('20202021BAHAR   ', 21617234, 'GÖZDE YILMAZ        ', 10, 'Bir müzik akışı platformu için kişiselleştirilmiş öneri algoritması geliştirme.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Dr.Öğr.Üyesi Elif Arslan'),
('20202021GÜZ     ', 21617235, 'HASAN ALİ KAYA', 11, 'Bir fitness uygulaması için antrenman takibi ve ilerleme izleme özellikleri ekleme.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20212022BAHAR      ', 21632236, 'JALE KILIÇ', 13, 'Bir öğrenci değerlendirme ve not yönetim sistemi oluşturma.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20192020BAHAR', 21697269, 'A.SAFA DÖĞENCİ', 4, 'Yerel bir işletme için dijital pazarlama stratejisi geliştirme ve uygulama.\n', 0, 'Doç.Dr. Ahmet Yılmaz', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20212022BAHAR      ', 22232436, 'KEMAL ÖZTÜRK ', 17, 'Bir seyahat planlama uygulaması geliştirme.\r\n', 8, 'Doç.Dr. Ahmet Yılmaz', 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara'),
('2023-2024', 22293055, 'Yusuf Taşdemir', 832, 'Şampiyonluk kupasının kimin olacağı', 12, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('2023-2024', 22293100, 'Tuğba Taşdelen', 9213, 'Ego otobüsleirndeki kalabalık.', 42, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('2023-2024', 22293150, 'Yusuf Taşdelen', 99999, 'ABVLHKASEVBKAEBVŞLAEBJVNA', 20, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('20222023BAHAR       ', 22293157, 'YUSUF ÇİMEN', 16, 'Bir yemek tarifi paylaşım platformu oluşturma.\r\n', 71, 'Prof.Dr. Ayşe Kaya', 'Doç.Dr. Ahmet Yılmaz', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('2022-2023 BAHAR', 22293380, 'BeyzaNur Yılmaz', 341, 'Kağıt toplama makinesi yapma.', 0, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('2023-2024 Bahar Döne', 22293410, 'Ahmet Yılmaz', 37, 'Ankaranın Hava Kirliliği ile ilgili araştırma.', 51, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Doç.Dr. Ahmet Yılmaz'),
('2023-2024', 22298732, 'İlayda Uzun', 54, 'Canlıların en uzun hayatta kalma süreleri.', 0, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Yrd.Doç. Zeynep Kara', 'Dr.Öğr.Üyesi Elif Arslan'),
('2023-2024 bahar', 22298733, 'İlayda Taşdelen', 1905, 'Fenerbahçenin şampiyon olamama sorunu.', 20, 'Prof.Dr. Ayşe Kaya', 'Öğr.Üyesi Mehmet Demir', 'Doç.Dr. Ahmet Yılmaz', 'Yrd.Doç. Zeynep Kara');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `projeler`
--

CREATE TABLE `projeler` (
  `PROJE_ID` int(8) NOT NULL,
  `OGRENCI_ADI` varchar(50) NOT NULL,
  `PROJE_ADI` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `projeler`
--

INSERT INTO `projeler` (`PROJE_ID`, `OGRENCI_ADI`, `PROJE_ADI`) VALUES
(1, 'ENDAM ELHAKAN', 'Bir çevrimiçi alışveriş platformu için kullanıcı arayüzü tasarımı ve prototip geliştirme.\r\n'),
(2, 'ELÇİM ELALDI', 'Bir sosyal medya uygulaması için kullanıcı etkileşim analizi ve iyileştirme önerileri sunma.\r\n'),
(3, 'AHMET TOKUŞTEPE', 'Bir mobil sağlık uygulaması için kullanıcı geri bildirim sistemini oluşturma.\r\n'),
(4, 'A.SAFA DÖĞENCİ', 'Yerel bir işletme için dijital pazarlama stratejisi geliştirme ve uygulama.\r\n'),
(5, 'AHMET YILDIRIM', 'Bir eğitim platformu için interaktif öğrenme materyalleri tasarlama.\r\n'),
(6, 'BURAK YILMAZ ', 'Bir hayvan barınağı için web sitesi ve bağış toplama platformu oluşturma.\r\n'),
(7, 'DENİZ KARADAĞ', 'Bir çevrimiçi randevu planlama uygulaması geliştirme.\r\n'),
(8, 'EMRE YILMAZ', 'Bir hava durumu uygulaması için kullanıcı dostu bir arayüz tasarlama.\r\n'),
(9, 'FATMA DEMİR', 'Bir kütüphane için online katalog ve rezervasyon sistemi oluşturma.\r\n'),
(10, 'GÖZDE YILMAZ   ', 'Bir müzik akışı platformu için kişiselleştirilmiş öneri algoritması geliştirme.\r\n'),
(11, 'HASAN ALİ KAYA', 'Bir fitness uygulaması için antrenman takibi ve ilerleme izleme özellikleri ekleme.\r\n'),
(12, 'İREM KARADAĞ', 'Bir çevrimiçi etkinlik yönetimi platformu geliştirme.\r\n'),
(13, 'JALE KILIÇ', 'Bir öğrenci değerlendirme ve not yönetim sistemi oluşturma.\r\n'),
(17, 'KEMAL ÖZTÜRK ', 'Bir seyahat planlama uygulaması geliştirme.\r\n'),
(124, 'YUSUF ÇİMEN', 'Bir yemek tarifi paylaşım platformu oluşturma.\r\n'),
(135, 'YAKUP TAŞDELEN', 'Bir dil öğrenme uygulaması için konuşma tanıma özelliği entegrasyonu.\r\n'),
(318, 'MEHMET KARABAĞ', 'Bir sanal gerçeklik deneyimi oluşturma ve kullanıcı geri bildirimi toplama.\r\n');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `akademisyenler`
--
ALTER TABLE `akademisyenler`
  ADD PRIMARY KEY (`ID`);

--
-- Tablo için indeksler `ogrenciler`
--
ALTER TABLE `ogrenciler`
  ADD UNIQUE KEY `UNIQUE` (`Ogrenci_No`),
  ADD UNIQUE KEY `Proje_Id` (`Proje_Id`),
  ADD UNIQUE KEY `Proje_Ad` (`Proje_Ad`);

--
-- Tablo için indeksler `projeler`
--
ALTER TABLE `projeler`
  ADD PRIMARY KEY (`PROJE_ID`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `akademisyenler`
--
ALTER TABLE `akademisyenler`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Tablo için AUTO_INCREMENT değeri `projeler`
--
ALTER TABLE `projeler`
  MODIFY `PROJE_ID` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=319;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
