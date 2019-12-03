-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 03. 10:51
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

SET FOREIGN_KEY_CHECKS=0;
SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `latvanyossagokdb`
--
CREATE DATABASE IF NOT EXISTS `latvanyossagokdb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `latvanyossagokdb`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `latvanyossagok`
--

DROP TABLE IF EXISTS `latvanyossagok`;
CREATE TABLE IF NOT EXISTS `latvanyossagok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(100) NOT NULL,
  `leiras` varchar(255) NOT NULL,
  `ar` int(11) NOT NULL DEFAULT '0',
  `varos_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_varos_latvanyossag` (`varos_id`)
) ENGINE=InnoDB AUTO_INCREMENT=75 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `latvanyossagok`
--

INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES
(1, 'Alcsúti Arborétum', 'szíííp', 0, 1),
(2, 'Habsburg kastély és kápolna', 'szíííp', 2600, 1),
(3, 'Diána Pihenõpark', 'szíííp', 1100, 1),
(4, 'Pannon Golf és Country Klub', 'szíííp', 2100, 1),
(5, 'Zoltán tó', 'szíííp', 3000, 1),
(6, 'Diana tó', 'szíííp', 1300, 1),
(7, 'Alexi lovasközpont és fedett lovarda', 'szíííp', 2600, 1),
(8, 'Református templom', 'szíííp', 1700, 2),
(9, 'Faluház', 'szíííp', 1100, 2),
(10, 'Emlékpark', 'szíííp', 1000, 2),
(11, 'katolikus templom', 'szíííp', 700, 2),
(12, 'Helytörténeti Gyûjtemény és Honvédségi Múzeum', 'szíííp', 0, 3),
(13, 'Eötvös-obeliszk', 'szíííp', 2200, 3),
(14, 'Cukorgyári Árpád-házi Szent Erzsébet Kápolna', 'szíííp', 1900, 3),
(15, 'Eötvös József Emlékmúzeum', 'szíííp', 1700, 3),
(16, 'Római katolikus templom', 'szíííp', 1200, 3),
(17, 'Szent László patak', 'szíííp', 1200, 4),
(18, 'Hármas halom: Páskom-hegy', 'szíííp', 2600, 4),
(19, 'Öreg-hegy', 'szíííp', 2100, 4),
(20, 'Új-hegy', 'szíííp', 0, 4),
(21, 'Római Katolikus Templom', 'szíííp', 1200, 5),
(22, 'Szentháromság-szobor', 'szíííp', 2500, 5),
(23, 'Pázmándy-Petheõ-Lyka-Brauch-kastély', 'szíííp', 2100, 5),
(24, 'Szûts-Ivánkay-kastély', 'szíííp', 1800, 5),
(25, 'Sajnovics-Batthyány-Dréher-kastély', 'szíííp', 2100, 6),
(26, 'Sajnovics emlékkút Sajnovics János-szoborral', 'szíííp', 1900, 6),
(27, 'kalandpark', 'szíííp', 1100, 6),
(28, 'állatsimogató', 'szíííp', 600, 6),
(29, 'Barokk r.k. templom', 'szíííp', 2700, 6),
(30, 'HANGYA Szövetkezet egykori többfunkciós épülete', 'szíííp', 0, 6),
(31, '1848/49-es emlékmû és köztéri alkotás', 'szíííp', 1300, 6),
(32, 'Tordasi Csárda és környezete horgásztóval, vadasparkkal, tájházzal', 'szíííp', 1400, 6),
(33, 'Római Katolikus Templom', 'szíííp', 1600, 7),
(34, 'Gótikus torony', 'szíííp', 2500, 7),
(35, 'Földvár - kerekdomb', 'szíííp', 0, 7),
(36, 'Vajda János szobor', 'szíííp', 700, 7),
(37, 'I. Vh. Szobor és sétány', 'szíííp', 2100, 7),
(38, 'Klasszicista Ürményi-mauzóleum', 'szíííp', 2300, 7),
(39, 'Vajda János Emlékház', 'szíííp', 1900, 7),
(40, 'Egykori Dreher-birtok (Mariannapuszta) víztoronya és mintagazdaságának épületei, terménytárolói', 'szíííp', 1700, 7),
(41, 'Pogányvár, késõ bronzkori földvár', 'szíííp', 2400, 7),
(42, 'Puskás Ferenc Labdarúgó Akadémia', 'szíííp', 800, 8),
(43, 'Noll-tanya', 'szíííp', 2600, 8),
(44, 'Református templom', 'szíííp', 1300, 8),
(45, 'Római Katolikus Templom', 'szíííp', 0, 8),
(46, 'Egykori nemesi kúriák', 'szíííp', 2500, 8),
(47, 'Hõsi emlékmûvek', 'szíííp', 600, 8),
(48, 'Óceánrepülõk (Endresz György és Magyar Sándor) emlékmûve', 'szíííp', 900, 8),
(49, 'Majorsági épületek (Szúnyogpuszta)', 'szíííp', 1900, 8),
(50, 'Brunszvik-kastély', 'szíííp', 0, 9),
(51, 'Milleniumi Emlékoszlop', 'szíííp', 1900, 9),
(52, 'Dreher Mauzóleum', 'szíííp', 0, 9),
(53, 'Brunszvik Mauzóleum', 'szíííp', 1800, 9),
(54, 'Óvodamúzeum', 'szíííp', 2600, 9),
(55, 'Beethoven Emlékmúzeum', 'szíííp', 1600, 9),
(56, 'arborétum', 'szíííp', 0, 9),
(57, 'Magyar-kút', 'szíííp', 2200, 10),
(58, 'Kálvária', 'szíííp', 1300, 10),
(59, 'Református templom', 'szíííp', 900, 10),
(60, 'Katolikus templom', 'szíííp', 1200, 10),
(61, 'Nepumuki Szent János-szobor', 'szíííp', 2900, 10),
(62, 'Szent Orbán-szobor', 'szíííp', 800, 10),
(63, 'Mária szobrok', 'szíííp', 2300, 10),
(64, 'Présházak, pincék', 'szíííp', 1200, 10),
(65, 'Szent Vendel-szobor', 'szíííp', 1400, 10),
(66, 'I. világháborús emlékmû', 'szíííp', 1100, 10),
(67, 'II. világháborús emlékmû', 'szíííp', 1000, 10),
(68, 'Honfoglalási emlékkõ', 'szíííp', 0, 10),
(69, 'Kitelepítési emlékkõ', 'szíííp', 0, 10),
(70, 'Szovjet hõsi emlékmû', 'szíííp', 1600, 10),
(71, 'Trianoni emlékoszlop', 'szíííp', 0, 10),
(72, '1956-os kopjafa', 'szíííp', 0, 10),
(73, 'Köztéri prések', 'szíííp', 800, 10),
(74, 'Korda Stúdió', 'szíííp', 1900, 10);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

DROP TABLE IF EXISTS `varosok`;
CREATE TABLE IF NOT EXISTS `varosok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(100) NOT NULL,
  `lakossag` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nev` (`nev`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `varosok`
--

INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES
(1, 'Alcsútdoboz', 1427),
(2, 'Baracska', 2729),
(3, 'Ercsi', 8567),
(4, 'Gyúró', 1254),
(5, 'Ráckeresztúr', 3226),
(6, 'Tordas', 2113),
(7, 'Vál', 2394),
(8, 'Felcsút', 1688),
(9, 'Martonvásár', 5650),
(10, 'Etyek', 3922);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD CONSTRAINT `fk_varos_latvanyossag` FOREIGN KEY (`varos_id`) REFERENCES `varosok` (`id`);
SET FOREIGN_KEY_CHECKS=1;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
