-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Ápr 21. 19:51
-- Kiszolgáló verziója: 10.4.16-MariaDB
-- PHP verzió: 7.4.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `dolgozo`
--
CREATE DATABASE IF NOT EXISTS `dolgozo` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dolgozo`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kifizetes`
--

CREATE TABLE `kifizetes` (
  `dolgozoid` int(11) NOT NULL,
  `osszeg` int(11) NOT NULL,
  `datum` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `kifizetes`
--

INSERT INTO `kifizetes` (`dolgozoid`, `osszeg`, `datum`) VALUES
(3, 110000, '2021-04-21 16:58:36'),
(3, 100000, '2021-04-21 16:59:49'),
(2, 150000, '2021-04-21 17:11:21'),
(2, 110000, '2021-04-21 17:14:27');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `torzs`
--

CREATE TABLE `torzs` (
  `id` int(11) NOT NULL,
  `nev` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `torzs`
--

INSERT INTO `torzs` (`id`, `nev`) VALUES
(1, 'Mekk Elek'),
(2, 'Behu Gyozol'),
(3, 'Kecske Répa'),
(4, 'Seres Róbert Eboy');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `kifizetes`
--
ALTER TABLE `kifizetes`
  ADD KEY `dolgozoid` (`dolgozoid`);

--
-- A tábla indexei `torzs`
--
ALTER TABLE `torzs`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `torzs`
--
ALTER TABLE `torzs`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kifizetes`
--
ALTER TABLE `kifizetes`
  ADD CONSTRAINT `kifizetes_ibfk_1` FOREIGN KEY (`dolgozoid`) REFERENCES `torzs` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
