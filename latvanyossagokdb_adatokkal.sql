-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Nov 25. 23:00
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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `latvanyossagok`
--

CREATE TABLE `latvanyossagok` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `leiras` varchar(255) NOT NULL,
  `ar` int(11) NOT NULL DEFAULT '0',
  `varos_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `latvanyossagok`
--

INSERT INTO `latvanyossagok` (`id`, `nev`, `leiras`, `ar`, `varos_id`) VALUES
(1, 'római katolikus templom a Kossuth utcában', 'leírás', 193, 1),
(2, 'több mûemlék parasztház a Kossuth utcában- Deák F.u.8., Kossuth u.2.4.6.9.10. Balaton utca', 'leírás', 499, 1),
(3, 'szõlõhegyi pincék- Becehegy, Felsõcsetény dûlõ 94. népi mûemlék, Major -féle présház, Klein Böske-fé', 'leírás', 472, 1),
(4, 'Ádám-féle présház, Szántai-féle présház, Rhédey-féle présház, Varga-féle présház, Kozlovszky-féle pr', 'leírás', 754, 1),
(5, 'Templomkertben kõkereszt 1848', 'leírás', 912, 1),
(6, 'Sírkövek a temetõben', 'leírás', 390, 1),
(7, 'Botka kastély Kossuth 98.', 'leírás', 182, 2),
(8, 'R.k. templom 1778.', 'leírás', 928, 2),
(9, 'Templomkert', 'leírás', 680, 2),
(10, 'I.II vh-s emlékmû', 'leírás', 991, 2),
(11, 'Szent Flórián szobor', 'leírás', 336, 3),
(12, 'R.k.templom ', 'leírás', 536, 3),
(13, '3 db kõkereszt', 'leírás', 948, 4),
(14, 'Nagyboldogasszony templom ', 'leírás', 1070, 4),
(15, 'Világháborús emlékmû és kõkereszt (Béke tér)', 'leírás', 485, 4),
(16, 'Szent Ilona kápolna Temetõ u.1. orgona', 'leírás', 1132, 5),
(17, 'kõkereszt : Vitéz-kereszt, Alsódiás Madách u.', 'leírás', 396, 5),
(18, 'Nepomuki Szent János szobor', 'leírás', 653, 5),
(19, 'Népi lakóházak ( Esze Tamás u.4., Lilom u.1., Toldi M.u.15.,  Pásztorház- Kossuth L.u.97.) ', 'leírás', 623, 5),
(20, 'Havas Boldogasszony temlom', 'leírás', 241, 5),
(21, 'Lakóház és pince Toldi 22.', 'leírás', 257, 5),
(22, 'Sok reneszánsz kõkereszt és síremlék', 'leírás', 491, 5),
(23, 'Szõlõhegyi pincék Darnay-féle boronapince,Zalay-köz 4., Prõce présház', 'leírás', 827, 5),
(24, 'Rk. templom', 'leírás', 384, 6),
(25, 'Kõkeresztek', 'leírás', 693, 6),
(26, 'Temetõkápolna  és tornya', 'leírás', 789, 6),
(27, 'Festetics Kastély', 'leírás', 205, 7),
(28, 'Balatoni Múzeum', 'leírás', 511, 7),
(29, 'Pethõ-ház', 'leírás', 493, 7),
(30, 'Magyarok Nagyasszonya plébániatemplom', 'leírás', 979, 7),
(31, 'Festetics kripta', 'leírás', 515, 7),
(32, 'Georgikon Majormúzeum', 'leírás', 375, 7),
(33, 'Kis-Szent Teréz Bazilika', 'leírás', 189, 7),
(34, 'R.k. plébániaház Fõ tér 5.', 'leírás', 481, 7),
(35, 'Szentháromság szobor', 'leírás', 859, 7),
(36, 'Amazon szálló', 'leírás', 478, 7),
(37, 'Kastély u.5.7.8.10.14. 16.11.', 'leírás', 227, 7),
(38, 'Szent Miklós temetõ és temetõkápolna és kereszt,  Szomorú Krisztus szobor', 'leírás', 472, 7),
(39, 'Szent Flórián szobor', 'leírás', 715, 7),
(40, 'Balaton u.17.', 'leírás', 1006, 7),
(41, 'Kertváros- Présház Ifjúság u. 55.', 'leírás', 620, 7),
(42, 'Szendrey-telep- ', 'leírás', 682, 7),
(43, 'Sziget-fürdõ, Hajókikötõ, Hullám szálló, Helikon strand', 'leírás', 1095, 7),
(44, 'Premontrei volt ferences  Rendház épülete', 'leírás', 858, 7),
(45, 'Vajda János Gimnázium Fõ tér 9.', 'leírás', 254, 7),
(46, 'Városháza Fõ tér 1.', 'leírás', 238, 7),
(47, 'Berzsenyi-villa Helikon u.15.', 'leírás', 187, 7),
(48, 'Szent Flórián szobor- Tapolcai út.1.', 'leírás', 848, 7),
(49, 'Zsinagóga', 'leírás', 780, 7),
(50, 'Sopron u. Harangtorony', 'leírás', 443, 7),
(51, 'Magtár Georgikon u. 23.', 'leírás', 241, 7),
(52, 'Pálmaház és üvegházak Georgikon 21/b', 'leírás', 903, 7),
(53, 'Helikon emlékmû', 'leírás', 674, 7),
(54, 'Georgikon u.20., Széchenyi u.8., Deák F.u.57.', 'leírás', 1009, 7),
(55, 'Sörház és pálinkafõzõ Deák F.u.30.32.', 'leírás', 866, 7),
(56, 'Széchenyi u.8., Jobs szanatórium- Csók I.u.1.', 'leírás', 360, 7),
(57, 'Erzsébet királyné u.12., Munkácsy M.u.5.', 'leírás', 679, 7),
(58, 'Sopron u.2.- volt Ispotály, 7., Lehel u.2.,Bástya u. 2-6., Kisfaludy u.2., Lovassy u. 2.-volt majors', 'leírás', 936, 7),
(59, 'Sopron utcai harangtorony', 'leírás', 832, 7),
(60, 'Georgikon u.1.lakóház és istálló', 'leírás', 1063, 7),
(61, 'Kossuth L.u.1.2.3.6.9.10.11.12.13.16.17.21.22.24.28.30.33.35.42. - Pamer-ház- 45.89.48- Postapalota', 'leírás', 1082, 7),
(62, 'Polgármesteri Hivatal ', 'leírás', 1136, 7),
(63, 'Fenékpuszta, Szent Ilona szobor, majorsági épületek,római kori épületel maradványai, ', 'leírás', 860, 7),
(64, 'Római Katolikus templom -falképek, oltárasztal, orgona, tabernákulum', 'leírás', 311, 8),
(65, 'Református templom - berendezése', 'leírás', 244, 8),
(66, 'Felsõmándi Nemestóthy Szabó család sírboltja', 'leírás', 288, 8),
(67, 'Zoltay-Kastély', 'leírás', 1061, 8),
(68, 'Szentgyörgyvári vár maradványai ( Bélavár)', 'leírás', 1030, 8),
(69, 'Pálos kolostor és templom helye', 'leírás', 658, 9),
(70, 'Szent-István szobor', 'leírás', 291, 9),
(71, 'Szent Mihály arkangyal templom, Piéta szobor', 'leírás', 562, 9),
(72, 'Temetõ kápolna 1799.', 'leírás', 159, 10),
(73, 'Rk. templom', 'leírás', 932, 10),
(74, 'Római Katolikus templom, harang ', 'leírás', 417, 10),
(75, 'kõkereszt', 'leírás', 987, 11),
(76, 'harangtorony', 'leírás', 1099, 11),
(77, 'Római Katolikus templom berendezése', 'leírás', 803, 12),
(78, 'Hertelendy-Kúria', 'leírás', 1039, 12),
(79, 'A temetõben Hertelendy György sírköve', 'leírás', 977, 12),
(80, 'Szent Kereszt Kápolna,  ', 'leírás', 484, 13),
(81, 'Szent Mihály Kápolna, ', 'leírás', 399, 13),
(82, 'Szûz Mária neve kápolna, ', 'leírás', 274, 13),
(83, 'Helikon Taverna, Festetics pince és présház', 'leírás', 897, 13),
(84, 'Rk .templom', 'leírás', 959, 13),
(85, 'Templomkertben Szent Vendel szobor és kõkereszt', 'leírás', 982, 13),
(86, ' Lakóházak, ( Berzsenyi 56., Petõfi u.137., Simon I.u.,)', 'leírás', 361, 13),
(87, 'Római Katolikus  Szent Adorján templom', 'leírás', 371, 14),
(88, 'Szociális Otthon- volt bencés rendház Deák F.u.3.', 'leírás', 916, 14),
(89, 'Temetõkápolna kriptával', 'leírás', 1147, 14),
(90, 'Modrovits Geregely apát szobra', 'leírás', 233, 14),
(91, 'Apátsági borpince', 'leírás', 219, 14),
(92, 'Szent-István szobor', 'leírás', 289, 14),
(93, 'Méhész szakiskola volt- volt Szentkirályi kúria', 'leírás', 990, 14),
(94, 'Római katolikus templom  Szent Kozma és Damján', 'leírás', 943, 15),
(95, 'Pethõ kúria', 'leírás', 849, 15),
(96, 'Kivándorlási kereszt', 'leírás', 502, 15),
(97, 'Szent Kozma és Damján kápolna barokk', 'leírás', 547, 15),
(98, 'Kotsy-malom (múzeum)', 'leírás', 452, 15),
(99, 'Plébániaház 1750.', 'leírás', 1126, 15),
(100, 'Római katolikus kápolna, ', 'leírás', 845, 15),
(101, 'Tátika-vár,', 'leírás', 265, 15),
(102, 'Lakóház -Fõ út 97., Vadász u.20., ', 'leírás', 371, 15),
(103, 'Bortároló pince volt lakóház -Világosvár dûlõ présház', 'leírás', 1028, 15),
(104, 'Kõkeresztek', 'leírás', 406, 15),
(105, 'Szentháromság és Szent Vendel szobor', 'leírás', 378, 16),
(106, 'Récéskúti Bazilika', 'leírás', 328, 16),
(107, 'Cirill-Metód emlékoszlop', 'leírás', 453, 16),
(108, 'Szent István kápolna és emlékoszlop', 'leírás', 747, 16),
(109, 'Szent Adorján Bazilika rom', 'leírás', 669, 16),
(110, 'R.k. plébániaház Dózsa GY.u.23.', 'leírás', 1074, 16),
(111, 'Vár és bencés apátság romjai', 'leírás', 754, 16),
(112, 'R.k. templom', 'leírás', 1045, 16),
(113, 'Hadrianus zarándoktemplom', 'leírás', 494, 16),
(114, 'A salzburgi érsekség emlékoszlopa', 'leírás', 225, 16),
(115, '8353 Zalaszántó, Vadász u.', 'leírás', 967, 15),
(116, '8353 Vindornyalak Zrínyi köz 1.', 'leírás', 162, 12),
(117, 'helytörténeti kiállítás a Jüngling Zoltán Közösségi Házban (Kossuth u. 64.)', 'leírás', 1122, 1),
(118, 'Közmûvelõdéstörténeti gyûjtemény a Mûvelõdési Házban', 'leírás', 492, 13),
(119, 'Helytörténeti múzeum  Zalaapáti, Deák F. u. 6.', 'leírás', 683, 14),
(120, 'Cserépkályha kiállítás  (Szentkirályi kastély)  Zalaapáti, Jókai M. u. 130. ', 'leírás', 357, 14),
(121, 'Kotsy-malom (múzeum)', 'leírás', 647, 15),
(122, '8353 Vindornyalak Zrínyi köz 1.', 'leírás', 629, 12),
(123, 'Pele Apó tanösvény, Szobakõ barlang, Szépkilátó', 'leírás', 1032, 1),
(124, 'Vadlánlik-domb, Diási sz?l?k északi végz?dése felett', 'leírás', 463, 5),
(125, 'Szoroshadi út – Pénzesgödrök', 'leírás', 642, 5),
(126, 'Kerek-hegy, Kûmell (Ördög-szikla)', 'leírás', 284, 5),
(127, 'Varsás-hegy', 'leírás', 1142, 5),
(128, 'Lakatos tet? (kis tisztás)', 'leírás', 436, 5),
(129, 'Helyileg védett faóriások és famatuzsálemek', 'leírás', 391, 5),
(130, 'Helyileg védett fasorok (Sirály utcai és Fürd? utcai vadgesztenye fasor)', 'leírás', 236, 5),
(131, 'Helyileg védett nádasok', 'leírás', 426, 5),
(132, 'Festetics Kastély parkja', 'leírás', 850, 7),
(133, '400 éves gesztenyefa', 'leírás', 872, 8),
(134, 'Nemzeti Park', 'leírás', 647, 9),
(135, ' Szt. Miklós forrás,', 'leírás', 744, 9),
(136, '„Bazaltutca” (természetes bazaltfal), ', 'leírás', 438, 15),
(137, 'Kovácsi-hegy bazaltfolyosó', 'leírás', 882, 15),
(138, 'Kovácsi és Vátka falu templomának romjai', 'leírás', 1147, 15),
(139, 'Tátika-hegy, barlang- Hidegháti major, Alsótátika: Szentkereszt sziklafal, Bükk-tetõ, Farkas-hegy', 'leírás', 1013, 15),
(140, 'õsbükkös', 'leírás', 521, 15),
(141, 'Rakottyás-tó ( õslápmaradvány)', 'leírás', 406, 15),
(142, '\"A Tatárháti út mellett \"\"kunhalmok\"\"\"', 'leírás', 412, 15),
(143, 'Kis-Balaton, Bivaly csorda a település határában ', 'leírás', 885, 16),
(144, 'Buddhista Sztúpa, Az Emberi jogok parkjában található a buddhista sztupa, melyet 1992-93-ban emeltek', 'leírás', 250, 15),
(145, 'Templom a Szentháromság szoborral, Szent Vendel szobor… ', 'leírás', 451, 16),
(146, 'Csettegõkút, Vadlánylik barlang, Rendõrkutyatemetõ', 'leírás', 953, 9),
(147, 'Bormúzeum', 'leírás', 405, 8),
(148, 'Széchenyi pince', 'leírás', 1116, 8),
(149, 'Simándy József Emlékszoba Fejér György Városi Könyvtár', 'leírás', 1149, 7),
(150, 'Mikus Galéria', 'leírás', 430, 7),
(151, 'Halápy János emlékszoba Balatoni Múzeum', 'leírás', 699, 7),
(152, 'Szendrey Júlia emlékszoba ', 'leírás', 695, 7),
(153, 'Kis-Balaton–Ház, ', 'leírás', 573, 16);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `varosok`
--

CREATE TABLE `varosok` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) NOT NULL,
  `lakossag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- A tábla adatainak kiíratása `varosok`
--

INSERT INTO `varosok` (`id`, `nev`, `lakossag`) VALUES
(1, 'Balatongyörök', 1383),
(2, 'Bókaháza', 263),
(3, 'Esztergályhorváti', 429),
(4, 'Gétye', 112),
(5, 'Gyenesdiás', 3667),
(6, 'Karmacs', 783),
(7, 'Keszthely', 19652),
(8, 'Szentgyörgyvár', 324),
(9, 'Vállus', 127),
(10, 'Várvölgy', 1043),
(11, 'Vindornyafok ', 131),
(12, 'Vindornyalak', 85),
(13, 'Vonyarcvashegy', 2273),
(14, 'Zalaapáti', 1671),
(15, 'Zalaszántó', 941),
(16, 'Zalavár', 959);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_varos_latvanyossag` (`varos_id`);

--
-- A tábla indexei `varosok`
--
ALTER TABLE `varosok`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nev` (`nev`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=154;

--
-- AUTO_INCREMENT a táblához `varosok`
--
ALTER TABLE `varosok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=159;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `latvanyossagok`
--
ALTER TABLE `latvanyossagok`
  ADD CONSTRAINT `fk_varos_latvanyossag` FOREIGN KEY (`varos_id`) REFERENCES `varosok` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
