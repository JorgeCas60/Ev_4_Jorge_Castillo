-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 01-08-2022 a las 03:48:36
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `ev4_libros`
--

--
-- Volcado de datos para la tabla `editorial`
--

INSERT INTO `editorial` (`Id`, `Run`, `Nombre`, `FechaCreacion`, `Estado`) VALUES
(1, 932500000, 'EDITORIAL PLANETA CHILENA S.A.', '1949-07-09 00:00:00', 1),
(2, 760632961, 'EDITORIAL ARCANO IV LIMITADA', '2009-07-20 00:00:00', 1),
(3, 869727008, 'SOC EDITORIAL CUATRO VIENTOS Y CIA LIMITADA', '1975-03-02 00:00:00', 1);

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`Id`, `IdEditorial`, `Nombre`, `NroSerie`) VALUES
(100, 3, 'SOC EDITORIAL CUATRO VIENTOS Y CIA LIMITADA', 32767),
(101, 3, 'El enfoque gestalt y testigos de terapia\r\n', 32767),
(102, 3, 'FRITZ PERLS. AQUI Y AHORA', 32767),
(104, 3, 'La estructura de la magia: Lenguaje y terapia', 32767),
(105, 3, 'GESTALT TERAPIA DE LA SITUACION', 32767),
(106, 3, 'CARTA DE UN PADRE DESORIENTADO', 32767),
(107, 3, 'III FORO INTERNACIONAL DE ARQUITECTURA, ENTRE LA P', 32767),
(108, 3, 'EROS Y PATHOS', 32767),
(109, 3, 'ESTRUCTURA DE LA MAGIA I\r\n', 32767),
(110, 3, 'PALABRAS A MI MISMO', 32767),
(111, 1, 'Tu cabeza te engaña... ¡Engáñala tú!', 32767),
(112, 1, 'Eiffel', 32767),
(113, 1, 'Santiago no es Chile', 32767),
(114, 1, 'Obscuritas', 32767),
(115, 1, 'El Kybalión', 32767),
(116, 1, 'MikelTube 3. Zombie Battle Royale', 32767),
(117, 1, 'El Jardín italiano', 32767),
(118, 1, 'La sombra de Julio César', 32767),
(119, 1, 'La cinta roja', 32767),
(120, 1, 'Las costureras de Auschwitz', 32767),
(121, 2, 'MÓNICA LA NIÑA DALTÓNICA Y FEDERICO EL PERRO PSICO', 32767),
(122, 2, 'CHILE ARQUEOLÓGICO', 32767),
(123, 2, 'LA NOCHE DE LOS INVUNCHES', 32767),
(124, 2, 'MECHA SELKNAM: SORREN', 32767),
(125, 2, 'SANTIAGO DESIERTO', 32767),
(126, 2, 'FREAKSHOW', 32767),
(127, 2, 'LOCKE & KEY: JUEGOS MENTALES', 32767),
(128, 2, 'LOCKE & KEY: ENGRANAJES', 32767),
(129, 2, 'LOCKE & KEY: ENGRANAJES', 32767),
(130, 2, 'LOCKE & KEY: ABRE LA LUNA', 32767);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
