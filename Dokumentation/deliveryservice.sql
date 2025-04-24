-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 24, 2025 at 09:26 PM
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
-- Database: `deliveryservice`
--

-- --------------------------------------------------------

--
-- Table structure for table `address`
--

CREATE TABLE `address` (
  `addressID` int(11) NOT NULL,
  `country` varchar(80) NOT NULL,
  `postzip` int(11) NOT NULL,
  `city` varchar(45) NOT NULL,
  `street` varchar(45) NOT NULL,
  `housenr` varchar(10) NOT NULL,
  `apartmentnr` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `address`
--

INSERT INTO `address` (`addressID`, `country`, `postzip`, `city`, `street`, `housenr`, `apartmentnr`) VALUES
(1, 'Deutscheland', 187, 'Prag', 'Street', '69', NULL),
(2, 'Deutschesland', 24, 'Westerland', 'Straße', '34', NULL),
(3, 'Iran', 8679, 'Uspekistan', 'Hallallstraße', '3', NULL),
(4, 'Pingin Insel', 123, 'Es ist eine Insel', 'mit pinguinen', '-', NULL),
(5, 'Australien', 69806, 'Hallow', 'Strada', '678', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderID` int(11) NOT NULL,
  `userID` int(11) NOT NULL,
  `addressID` int(11) NOT NULL,
  `handovertime` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`orderID`, `userID`, `addressID`, `handovertime`) VALUES
(1, 10, 2, '2025-04-24 21:09:40'),
(2, 9, 1, '2025-04-24 21:09:40'),
(3, 7, 2, '2025-04-24 21:20:14'),
(4, 6, 1, '2025-04-24 21:20:15'),
(5, 8, 1, '2025-04-24 21:20:15');

-- --------------------------------------------------------

--
-- Table structure for table `order_has_product`
--

CREATE TABLE `order_has_product` (
  `productD` int(11) NOT NULL,
  `orderID` int(11) NOT NULL,
  `amount` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `order_has_product`
--

INSERT INTO `order_has_product` (`productD`, `orderID`, `amount`) VALUES
(1, 1, 34),
(1, 2, 3),
(2, 2, 1),
(3, 1, 34),
(3, 2, 22);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `productID` int(11) NOT NULL,
  `name` varchar(80) NOT NULL,
  `productdescription` varchar(255) DEFAULT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`productID`, `name`, `productdescription`, `price`) VALUES
(1, 'Döner Pommes', 'Döner mit Pommes', 5),
(2, 'Kebab', NULL, 4),
(3, 'Falafel', 'Ich glaub ich hab das falsch geschrieben (:', 8.45),
(4, 'Eis', 'Ais', 1),
(5, 'Marmeladendöner', 'Von manchen banausen auch Krapfen oder Berliener genannt', 12),
(6, 'Ei', 'Ei', 0);

-- --------------------------------------------------------

--
-- Table structure for table `productgroup`
--

CREATE TABLE `productgroup` (
  `productgroupID` int(11) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `productgroup`
--

INSERT INTO `productgroup` (`productgroupID`, `name`) VALUES
(0, 'Appetizers'),
(1, 'Main meals'),
(2, 'Replenishments');

-- --------------------------------------------------------

--
-- Table structure for table `product_has_productgroup`
--

CREATE TABLE `product_has_productgroup` (
  `productID` int(11) NOT NULL,
  `productgroupID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `product_has_productgroup`
--

INSERT INTO `product_has_productgroup` (`productID`, `productgroupID`) VALUES
(1, 0),
(2, 1),
(3, 2);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `usertypeID` int(11) NOT NULL,
  `firstname` varchar(80) NOT NULL,
  `lastname` varchar(80) NOT NULL,
  `e-mail` varchar(80) NOT NULL,
  `password` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userID`, `usertypeID`, `firstname`, `lastname`, `e-mail`, `password`) VALUES
(6, 2, 'Max', 'Mustermann', 'max@muster.com', '1234'),
(7, 1, 'Jonny', 'Sinz', 'hereisjonny@email.com', 'password'),
(8, 1, 'Darth', 'Wader', 'deinVaddern@imper.ium', '69420'),
(9, 2, 'Alle', 'Meine', 'entchen@schwimmen.auf', 'dem See'),
(10, 3, 'Bannana', 'Bannana', 'Baba@nana.aaa', 'gugu');

-- --------------------------------------------------------

--
-- Table structure for table `usertype`
--

CREATE TABLE `usertype` (
  `usertypeID` int(11) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `usertype`
--

INSERT INTO `usertype` (`usertypeID`, `name`) VALUES
(1, 'Consumer'),
(2, 'Employee'),
(3, 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `user_has_address`
--

CREATE TABLE `user_has_address` (
  `userID` int(11) NOT NULL,
  `addressID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `user_has_address`
--

INSERT INTO `user_has_address` (`userID`, `addressID`) VALUES
(6, 4),
(7, 3),
(8, 2),
(9, 5),
(10, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `address`
--
ALTER TABLE `address`
  ADD PRIMARY KEY (`addressID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderID`,`userID`,`addressID`),
  ADD UNIQUE KEY `bestellungID_UNIQUE` (`orderID`),
  ADD UNIQUE KEY `user_userID_UNIQUE` (`userID`),
  ADD KEY `fk_Order_Address1_idx` (`addressID`);

--
-- Indexes for table `order_has_product`
--
ALTER TABLE `order_has_product`
  ADD PRIMARY KEY (`productD`,`orderID`),
  ADD KEY `fk_Produkt_has_Bestellung_Bestellung1_idx` (`orderID`),
  ADD KEY `fk_Produkt_has_Bestellung_Produkt1_idx` (`productD`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`productID`),
  ADD UNIQUE KEY `ProduktID_UNIQUE` (`productID`);

--
-- Indexes for table `productgroup`
--
ALTER TABLE `productgroup`
  ADD PRIMARY KEY (`productgroupID`);

--
-- Indexes for table `product_has_productgroup`
--
ALTER TABLE `product_has_productgroup`
  ADD PRIMARY KEY (`productID`,`productgroupID`),
  ADD KEY `fk_Produkt_has_Produktgruppe_Produktgruppe1_idx` (`productgroupID`),
  ADD KEY `fk_Produkt_has_Produktgruppe_Produkt1_idx` (`productID`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userID`,`usertypeID`),
  ADD UNIQUE KEY `UserID_UNIQUE` (`userID`),
  ADD KEY `fk_user_user_type1_idx` (`usertypeID`);

--
-- Indexes for table `usertype`
--
ALTER TABLE `usertype`
  ADD PRIMARY KEY (`usertypeID`),
  ADD UNIQUE KEY `usertypeID_UNIQUE` (`usertypeID`);

--
-- Indexes for table `user_has_address`
--
ALTER TABLE `user_has_address`
  ADD PRIMARY KEY (`userID`,`addressID`),
  ADD KEY `fk_Benutzer_has_Adresse_Adresse1_idx` (`addressID`),
  ADD KEY `fk_Benutzer_has_Adresse_Benutzer1_idx` (`userID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `address`
--
ALTER TABLE `address`
  MODIFY `addressID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `orderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `productID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `usertype`
--
ALTER TABLE `usertype`
  MODIFY `usertypeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `fk_Bestellung_user1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Order_Address1` FOREIGN KEY (`addressID`) REFERENCES `address` (`addressID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `order_has_product`
--
ALTER TABLE `order_has_product`
  ADD CONSTRAINT `fk_Produkt_has_Bestellung_Bestellung1` FOREIGN KEY (`orderID`) REFERENCES `order` (`orderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Produkt_has_Bestellung_Produkt1` FOREIGN KEY (`productD`) REFERENCES `product` (`productID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `product_has_productgroup`
--
ALTER TABLE `product_has_productgroup`
  ADD CONSTRAINT `fk_Produkt_has_Produktgruppe_Produkt1` FOREIGN KEY (`productID`) REFERENCES `product` (`productID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Produkt_has_Produktgruppe_Produktgruppe1` FOREIGN KEY (`productgroupID`) REFERENCES `productgroup` (`productgroupID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_user_user_type1` FOREIGN KEY (`usertypeID`) REFERENCES `usertype` (`usertypeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user_has_address`
--
ALTER TABLE `user_has_address`
  ADD CONSTRAINT `fk_Benutzer_has_Adresse_Adresse1` FOREIGN KEY (`addressID`) REFERENCES `address` (`addressID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Benutzer_has_Adresse_Benutzer1` FOREIGN KEY (`userID`) REFERENCES `user` (`userID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
