-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 11, 2025 at 03:34 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventdata`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `AdminID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`AdminID`, `Username`, `Password`) VALUES
(1, 'Heshan', 'Heshan123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_attendee`
--

CREATE TABLE `tbl_attendee` (
  `AttendeeID` int(11) NOT NULL,
  `FullName` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_attendee`
--

INSERT INTO `tbl_attendee` (`AttendeeID`, `FullName`, `Email`, `Password`) VALUES
(1, 'nipuna', 'nheshan@gmail.com', '12345'),
(2, 'HESHAN', 'heshan@gmail.com', '23579'),
(3, 'KAMAL', 'kamal@gmail.com', '2468'),
(4, 'vihandu semika', 'vihandu@gmail.com', 'vihandu123'),
(5, 'kaveen', 'kaveen@gmail.com', 'kaveen123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_event`
--

CREATE TABLE `tbl_event` (
  `EventName` varchar(100) NOT NULL,
  `EventID` varchar(10) NOT NULL,
  `Date` varchar(100) NOT NULL,
  `venue` varchar(100) NOT NULL,
  `Discription` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_event`
--

INSERT INTO `tbl_event` (`EventName`, `EventID`, `Date`, `venue`, `Discription`) VALUES
('kuweniya', '1', '25/12/2025', 'nelum pokuna', 'music'),
('sarigama', '2', '29/7/2025', 'kottawa', 'music'),
('aale', '3', '21/11/2025', 'jaffna', 'music');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_events`
--

CREATE TABLE `tbl_events` (
  `EventID` int(11) NOT NULL,
  `EventName` varchar(100) NOT NULL,
  `Date` date NOT NULL,
  `Venue` varchar(150) DEFAULT NULL,
  `Description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_events`
--

INSERT INTO `tbl_events` (`EventID`, `EventName`, `Date`, `Venue`, `Description`) VALUES
(2, 'Aale', '2025-06-04', 'Kaluthara', 'Music'),
(3, 'Agamana', '2025-05-31', 'malabe', 'music'),
(17, 'kuweni', '2025-06-15', 'Nelum Pokuna', 'Music');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ticket`
--

CREATE TABLE `tbl_ticket` (
  `TicketID` int(11) NOT NULL,
  `EventID` int(11) NOT NULL,
  `TicketType` varchar(50) DEFAULT NULL,
  `Price` decimal(10,2) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Available` int(11) DEFAULT NULL,
  `Sold` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_ticket`
--

INSERT INTO `tbl_ticket` (`TicketID`, `EventID`, `TicketType`, `Price`, `Quantity`, `Available`, `Sold`) VALUES
(4, 3, 'general', 1500.00, 800, NULL, 2),
(6, 2, 'General', 1000.00, 850, NULL, 0),
(16, 2, 'VVIP', 5000.00, 500, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_ticket_purchase`
--

CREATE TABLE `tbl_ticket_purchase` (
  `PurchaseID` int(11) NOT NULL,
  `AttendeeID` int(11) DEFAULT NULL,
  `TicketID` int(11) DEFAULT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `PurchaseDate` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_ticket_purchase`
--

INSERT INTO `tbl_ticket_purchase` (`PurchaseID`, `AttendeeID`, `TicketID`, `Quantity`, `PurchaseDate`) VALUES
(8, 1, 4, 2, '2025-06-01 09:01:49');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`AdminID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `tbl_attendee`
--
ALTER TABLE `tbl_attendee`
  ADD PRIMARY KEY (`AttendeeID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `tbl_events`
--
ALTER TABLE `tbl_events`
  ADD PRIMARY KEY (`EventID`);

--
-- Indexes for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  ADD PRIMARY KEY (`TicketID`),
  ADD KEY `idx_event` (`EventID`);

--
-- Indexes for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  ADD PRIMARY KEY (`PurchaseID`),
  ADD KEY `AttendeeID` (`AttendeeID`),
  ADD KEY `TicketID` (`TicketID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `AdminID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_attendee`
--
ALTER TABLE `tbl_attendee`
  MODIFY `AttendeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_events`
--
ALTER TABLE `tbl_events`
  MODIFY `EventID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  MODIFY `TicketID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  MODIFY `PurchaseID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_ticket`
--
ALTER TABLE `tbl_ticket`
  ADD CONSTRAINT `fk_event` FOREIGN KEY (`EventID`) REFERENCES `tbl_events` (`EventID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tbl_ticket_purchase`
--
ALTER TABLE `tbl_ticket_purchase`
  ADD CONSTRAINT `tbl_ticket_purchase_ibfk_1` FOREIGN KEY (`AttendeeID`) REFERENCES `tbl_attendee` (`AttendeeID`),
  ADD CONSTRAINT `tbl_ticket_purchase_ibfk_2` FOREIGN KEY (`TicketID`) REFERENCES `tbl_ticket` (`TicketID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
