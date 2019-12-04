-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 04. 12:23
-- Kiszolgáló verziója: 10.1.36-MariaDB
-- PHP verzió: 7.2.11

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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

DROP TABLE IF EXISTS `varosok`;
CREATE TABLE IF NOT EXISTS `varosok` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nev` varchar(100) NOT NULL,
  `lakossag` int(11) NOT NULL,
  `cimer` mediumblob,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nev` (`nev`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD CONSTRAINT `fk_varos_latvanyossag` FOREIGN KEY (`varos_id`) REFERENCES `varosok` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
