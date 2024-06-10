-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2024 at 01:17 PM
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
  `bpm` int(11) NOT NULL,
  `alamat` text NOT NULL,
  `code` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bpm_data`
--

INSERT INTO `bpm_data` (`id`, `nik`, `nama`, `bpm`, `alamat`, `code`) VALUES
(234, '123456789', 'Burhan', 100, 'Jogja', 1),
(235, '123456789', 'Burhan', 200, 'Jogja', 1),
(247, '123456789', 'Burhan', 84, 'Jogja', 2),
(248, '123456789', 'Burhan', 97, 'Jogja', 2),
(249, '123456789', 'Burhan', 61, 'Jogja', 2),
(250, '123456789', 'Burhan', 68, 'Jogja', 2),
(251, '123456789', 'Burhan', 69, 'Jogja', 2),
(252, '123456789', 'Burhan', 93, 'Jogja', 2),
(253, '123456789', 'Burhan', 89, 'Jogja', 3),
(254, '123456789', 'Burhan', 77, 'Jogja', 3),
(255, '123456789', 'Burhan', 89, 'Jogja', 3),
(256, '123456789', 'Burhan', 62, 'Jogja', 4),
(257, '123456789', 'Burhan', 68, 'Jogja', 4),
(258, '123456789', 'Burhan', 93, 'Jogja', 4),
(259, '123456789', 'Burhan', 89, 'Jogja', 4),
(260, '123456789', 'Burhan', 64, 'Jogja', 4),
(261, '123456789', 'Burhan', 98, 'Jogja', 4),
(262, '123456789', 'Burhan', 78, 'Jogja', 4),
(263, '123456789', 'Burhan', 99, 'Jogja', 4),
(264, '123456789', 'Burhan', 97, 'Jogja', 4),
(265, '123456789', 'Burhan', 90, '', 5),
(266, '123456789', 'Burhan', 85, '', 5),
(267, '123456789', 'Burhan', 73, '', 5),
(268, '123456789', 'Burhan', 78, '', 5),
(269, '123456789', 'Burhan', 64, '', 5),
(270, '123456789', 'Burhan', 74, '', 5),
(271, '123456789', 'Burhan', 60, '', 5),
(272, '123456789', 'Burhan', 99, '', 5),
(273, '123456789', 'Burhan', 64, '', 5),
(274, '123456789', 'Burhan', 77, '', 5),
(275, '123456789', 'Burhan', 72, '', 5),
(276, '123456789', 'Burhan', 93, 'Jogja', 6),
(277, '123456789', 'Burhan', 91, 'Jogja', 6),
(278, '123456789', 'Burhan', 89, 'Jogja', 6),
(279, '123456789', 'Burhan', 70, 'Jogja', 6),
(280, '123456789', 'Burhan', 63, 'Jogja', 6),
(281, '123456789', 'Burhan', 85, 'Jogja', 6),
(282, '123456789', 'Burhan', 88, 'Jogja', 6),
(283, '123456789', 'Burhan', 99, 'Jogja', 6),
(284, '123456789', 'Burhan', 85, 'Jogja', 6),
(285, '123456789', 'Burhan', 66, 'Jogja', 6),
(286, '123456789', 'Burhan', 62, 'Jogja', 6),
(287, '123456789', 'Burhan', 83, 'Jogja', 7),
(288, '123456789', 'Burhan', 95, 'Jogja', 7),
(289, '123456789', 'Burhan', 97, 'Jogja', 7),
(290, '123456789', 'Burhan', 98, 'Jogja', 7),
(291, '123456789', 'Burhan', 98, 'Jogja', 7),
(292, '123456789', 'Burhan', 86, 'Jogja', 7),
(293, '123456789', 'Burhan', 64, 'Jogja', 7),
(294, '123456789', 'Burhan', 71, 'Jogja', 7),
(295, '123456789', 'Burhan', 67, 'Jogja', 7),
(296, '123456789', 'Burhan', 73, 'Jogja', 7),
(297, '123456789', 'Burhan', 93, 'Jogja', 8),
(298, '123456789', 'Burhan', 76, 'Jogja', 8),
(299, '123456789', 'Burhan', 71, 'Jogja', 8),
(300, '123456789', 'Burhan', 78, 'Jogja', 8),
(301, '123456789', 'Burhan', 82, 'Jogja', 8),
(302, '123456789', 'Burhan', 87, 'Jogja', 8),
(303, '123456789', 'Burhan', 80, 'Jogja', 8),
(304, '987654321', 'Asta', 96, 'Jogja', 1),
(305, '987654321', 'Asta', 68, 'Jogja', 1),
(306, '987654321', 'Asta', 87, 'Jogja', 1),
(307, '987654321', 'Asta', 79, 'Jogja', 1),
(308, '987654321', 'Asta', 61, 'Jogja', 1),
(309, '987654321', 'Asta', 82, 'Jogja', 1),
(310, '987654321', 'Asta', 81, 'Jogja', 1),
(311, '987654321', 'Asta', 77, 'Jogja', 1),
(312, '987654321', 'Asta', 87, 'Jogja', 1),
(313, '987654321', 'Asta', 97, 'Jogja', 1),
(314, '987654321', 'Asta', 98, 'Jogja', 1),
(315, '987654321', 'Asta', 99, 'Jogja', 2),
(316, '987654321', 'Asta', 73, 'Jogja', 2),
(317, '987654321', 'Asta', 96, 'Jogja', 2),
(318, '987654321', 'Asta', 82, 'Jogja', 2),
(319, '987654321', 'Asta', 75, 'Jogja', 2),
(320, '987654321', 'Asta', 63, 'Jogja', 2),
(321, '987654321', 'Asta', 67, 'Jogja', 2),
(322, '987654321', 'Asta', 98, 'Jogja', 2),
(323, '987654321', 'Asta', 81, 'Jogja', 2),
(324, '987654321', 'Asta', 90, 'Jogja', 2),
(325, '987654321', 'Asta', 61, 'Jogja', 2),
(326, '987654321', 'Asta', 66, 'Jogja', 2),
(327, '987654321', 'Asta', 86, 'Jogja', 2),
(328, '987654321', 'Asta', 72, 'Jogja', 2),
(329, '123456789', 'Burhan', 68, 'Jogja', 9),
(330, '123456789', 'Burhan', 88, 'Jogja', 9),
(331, '123456789', 'Burhan', 91, 'Jogja', 9),
(332, '123456789', 'Burhan', 60, 'Jogja', 9),
(333, '123456789', 'Burhan', 76, 'Jogja', 9),
(334, '123456789', 'Burhan', 97, 'Jogja', 10),
(335, '123456789', 'Burhan', 70, 'Jogja', 10),
(336, '123456789', 'Burhan', 67, 'Jogja', 10),
(337, '123456789', 'Burhan', 92, 'Jogja', 10),
(338, '123456789', 'Burhan', 97, 'Jogja', 10),
(339, '123456789', 'Burhan', 63, 'Jogja', 10),
(355, '123456789', 'Burhan', 82, 'Jogja', 11),
(356, '123456789', 'Burhan', 89, 'Jogja', 11),
(357, '123456789', 'Burhan', 96, 'Jogja', 11),
(358, '123456789', 'Burhan', 76, 'Jogja', 11),
(359, '123456789', 'Burhan', 81, 'Jogja', 11),
(360, '123456789', 'Burhan', 90, 'Jogja', 11),
(361, '123456789', 'Burhan', 97, 'Jogja', 11),
(362, '123456789', 'Burhan', 84, 'Jogja', 11),
(363, '123456789', 'Burhan', 80, 'Jogja', 11),
(364, '123456789', 'Burhan', 80, 'Jogja', 11),
(365, '123456789', 'Burhan', 84, 'Jogja', 11),
(366, '123456789', 'Burhan', 93, 'Jogja', 11),
(367, '123456789', 'Burhan', 64, 'Jogja', 12),
(368, '123456789', 'Burhan', 99, 'Jogja', 12),
(369, '123456789', 'Burhan', 91, 'Jogja', 12),
(370, '123456789', 'Burhan', 96, 'Jogja', 12),
(371, '123456789', 'Burhan', 67, 'Jogja', 12),
(372, '123456789', 'Burhan', 92, 'Jogja', 12),
(373, '123456789', 'Burhan', 72, 'Jogja', 12),
(374, '123456789', 'Burhan', 98, 'Jogja', 12),
(375, '123456789', 'Burhan', 99, 'Jogja', 12),
(376, '123456789', 'Burhan', 80, 'Jogja', 12),
(377, '123456789', 'Burhan', 99, 'Jogja', 12);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=378;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
