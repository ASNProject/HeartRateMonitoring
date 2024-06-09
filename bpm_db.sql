-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2024 at 01:56 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bpm_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `bpm_data`
--

CREATE TABLE `bpm_data` (
  `id` int(11) NOT NULL,
  `nik` varchar(255) NOT NULL,
  `nama` varchar(255) NOT NULL,
  `bpm` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bpm_data`
--

INSERT INTO `bpm_data` (`id`, `nik`, `nama`, `bpm`) VALUES
(1, '123456789', 'Burhan', 100),
(2, '987654321', 'Samsudin', 200),
(3, '234567890', 'Budi', 150),
(4, '57897319793', 'Gogon', 300),
(5, '123456789', 'Burhan', 200),
(6, '123456789', 'Burhan', 150),
(7, '123456789', 'Burhan', 94),
(8, '123456789', 'Burhan', 73),
(9, '123456789', 'Burhan', 60),
(10, '123456789', 'Burhan', 95),
(11, '123456789', 'Burhan', 90),
(12, '123456789', 'Burhan', 84),
(13, '123456789', 'Burhan', 95),
(14, '123456789', 'Burhan', 67),
(15, '123456789', 'Burhan', 64),
(16, '123456789', 'Burhan', 74),
(17, '123456789', 'Burhan', 82),
(18, '123456789', 'Burhan', 83),
(19, '123456789', 'Burhan', 62),
(20, '123456789', 'Burhan', 78),
(21, '123456789', 'Burhan', 82),
(22, '123456789', 'Burhan', 61),
(23, '123456789', 'Burhan', 93),
(24, '123456789', 'Burhan', 68),
(25, '123456789', 'Burhan', 66),
(26, '123456789', 'Burhan', 80),
(27, '123456789', 'Burhan', 90),
(28, '123456789', 'Burhan', 87),
(29, '123456789', 'Burhan', 62),
(30, '123456789', 'Burhan', 70),
(31, '123456789', 'Burhan', 80),
(32, '123456789', 'Burhan', 99),
(33, '123456789', 'Burhan', 82),
(34, '123456789', 'Burhan', 98),
(35, '123456789', 'Burhan', 68),
(36, '123456789', 'Burhan', 73),
(37, '123456789', 'Burhan', 68),
(38, '123456789', 'Burhan', 71),
(39, '123456789', 'Burhan', 94),
(40, '123456789', 'Burhan', 61),
(41, '123456789', 'Burhan', 67),
(42, '123456789', 'Burhan', 76),
(43, '123456789', 'Burhan', 67),
(44, '123456789', 'Burhan', 86),
(45, '123456789', 'Burhan', 96),
(46, '123456789', 'Burhan', 63),
(47, '123456789', 'Burhan', 79),
(48, '123456789', 'Burhan', 77),
(49, '123456789', 'Burhan', 75),
(50, '123456789', 'Burhan', 72),
(51, '123456789', 'Burhan', 71),
(52, '123456789', 'Burhan', 84),
(53, '123456789', 'Burhan', 78),
(54, '123456789', 'Burhan', 88),
(55, '123456789', 'Burhan', 71),
(56, '123456789', 'Burhan', 84),
(57, '123456789', 'Burhan', 92),
(58, '123456789', 'Burhan', 88),
(59, '123456789', 'Burhan', 61),
(60, '123456789', 'Burhan', 73),
(61, '123456789', 'Burhan', 95),
(62, '123456789', 'Burhan', 95),
(63, '123456789', 'Burhan', 91),
(64, '123456789', 'Burhan', 60),
(65, '123456789', 'Burhan', 89),
(66, '123456789', 'Burhan', 85),
(67, '123456789', 'Burhan', 93),
(68, '123456789', 'Burhan', 93),
(69, '123456789', 'Burhan', 64),
(70, '123456789', 'Burhan', 93),
(71, '123456789', 'Burhan', 93),
(72, '123456789', 'Burhan', 90),
(73, '123456789', 'Burhan', 78),
(74, '123456789', 'Burhan', 91),
(75, '123456789', 'Burhan', 83),
(76, '123456789', 'Burhan', 71),
(77, '123456789', 'Burhan', 99),
(78, '123456789', 'Burhan', 96),
(79, '123456789', 'Burhan', 78),
(80, '123456789', 'Burhan', 65),
(81, '123456789', 'Burhan', 66),
(82, '123456789', 'Burhan', 71),
(83, '123456789', 'Burhan', 88),
(84, '123456789', 'Burhan', 63),
(85, '123456789', 'Burhan', 72),
(86, '123456789', 'Burhan', 82),
(87, '123456789', 'Burhan', 72),
(88, '123456789', 'Burhan', 68),
(89, '123456789', 'Burhan', 87),
(90, '123456789', 'Burhan', 74),
(91, '123456789', 'Burhan', 85),
(92, '123456789', 'Burhan', 99),
(93, '123456789', 'Burhan', 61),
(94, '123456789', 'Burhan', 79),
(95, '123456789', 'Burhan', 86),
(96, '123456789', 'Burhan', 67),
(97, '123456789', 'Burhan', 99),
(98, '123456789', 'Burhan', 63),
(99, '123456789', 'Burhan', 84),
(100, '123456789', 'Burhan', 86),
(101, '123456789', 'Burhan', 63),
(102, '123456789', 'Burhan', 73),
(103, '123456789', 'Burhan', 84),
(104, '123456789', 'Burhan', 86),
(105, '123456789', 'Burhan', 63),
(106, '123456789', 'Burhan', 79),
(107, '123456789', 'Burhan', 83),
(108, '123456789', 'Burhan', 86),
(109, '123456789', 'Burhan', 71),
(110, '123456789', 'Burhan', 82),
(111, '123456789', 'Burhan', 67),
(112, '123456789', 'Burhan', 93),
(113, '123456789', 'Burhan', 93),
(114, '123456789', 'Burhan', 93),
(115, '123456789', 'Burhan', 93),
(116, '123456789', 'Burhan', 93),
(117, '123456789', 'Burhan', 93),
(118, '123456789', 'Burhan', 93),
(119, '123456789', 'Burhan', 93),
(120, '123456789', 'Burhan', 93),
(121, '123456789', 'Burhan', 93),
(122, '123456789', 'Burhan', 93),
(123, '123456789', 'Burhan', 93),
(124, '123456789', 'Burhan', 93),
(125, '123456789', 'Burhan', 93),
(126, '123456789', 'Burhan', 93),
(127, '123456789', 'Burhan', 93),
(128, '123456789', 'Burhan', 93),
(129, '123456789', 'Burhan', 93),
(130, '123456789', 'Burhan', 93),
(131, '123456789', 'Burhan', 93),
(132, '123456789', 'Burhan', 93),
(133, '123456789', 'Burhan', 93),
(134, '123456789', 'Burhan', 93),
(135, '123456789', 'Burhan', 93),
(136, '123456789', 'Burhan', 93),
(137, '123456789', 'Burhan', 93),
(138, '123456789', 'Burhan', 93),
(139, '123456789', 'Burhan', 93),
(140, '123456789', 'Burhan', 93),
(141, '123456789', 'Burhan', 93),
(142, '123456789', 'Burhan', 93),
(143, '123456789', 'Burhan', 93),
(144, '123456789', 'Burhan', 93),
(145, '123456789', 'Burhan', 93),
(146, '123456789', 'Burhan', 93),
(147, '123456789', 'Burhan', 93),
(148, '123456789', 'Burhan', 93),
(149, '123456789', 'Burhan', 93),
(150, '123456789', 'Burhan', 93),
(151, '123456789', 'Burhan', 93),
(152, '123456789', 'Burhan', 93),
(153, '123456789', 'Burhan', 93),
(154, '123456789', 'Burhan', 93),
(155, '123456789', 'Burhan', 93),
(156, '123456789', 'Burhan', 93),
(157, '123456789', 'Burhan', 93),
(158, '123456789', 'Burhan', 78),
(159, '123456789', 'Burhan', 94),
(160, '123456789', 'Burhan', 61),
(161, '123456789', 'Burhan', 85),
(162, '123456789', 'Burhan', 78),
(163, '123456789', 'Burhan', 79),
(164, '123456789', 'Burhan', 79),
(165, '123456789', 'Burhan', 79),
(166, '123456789', 'Burhan', 79),
(167, '123456789', 'Burhan', 79),
(168, '123456789', 'Burhan', 79),
(169, '123456789', 'Burhan', 79),
(170, '123456789', 'Burhan', 79),
(171, '123456789', 'Burhan', 79),
(172, '123456789', 'Burhan', 79),
(173, '123456789', 'Burhan', 79),
(174, '123456789', 'Burhan', 79),
(175, '123456789', 'Burhan', 79),
(176, '123456789', 'Burhan', 79),
(177, '123456789', 'Burhan', 79),
(178, '123456789', 'Burhan', 79),
(179, '123456789', 'Burhan', 67),
(180, '123456789', 'Burhan', 90),
(181, '123456789', 'Burhan', 92),
(182, '123456789', 'Burhan', 73),
(183, '123456789', 'Burhan', 64),
(184, '123456789', 'Burhan', 73),
(185, '123456789', 'Burhan', 92),
(186, '123456789', 'Burhan', 67),
(187, '123456789', 'Burhan', 79),
(188, '123456789', 'Burhan', 79),
(189, '123456789', 'Burhan', 74),
(190, '123456789', 'Burhan', 86),
(191, '123456789', 'Burhan', 86);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bpm_data`
--
ALTER TABLE `bpm_data`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bpm_data`
--
ALTER TABLE `bpm_data`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=192;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;