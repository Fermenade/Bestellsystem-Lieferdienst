-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2025 at 07:42 AM
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderID` int(11) NOT NULL,
  `User_userID` int(11) DEFAULT NULL,
  `state` int(11) NOT NULL,
  `timestamp` datetime NOT NULL,
  `address` varchar(1000) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `order_has_product`
--

CREATE TABLE `order_has_product` (
  `Order_orderID` int(11) NOT NULL,
  `product_productD` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `productID` int(11) NOT NULL,
  `name` varchar(80) NOT NULL,
  `description` text DEFAULT NULL,
  `price` decimal(10,0) NOT NULL,
  `imagepath` varchar(400) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `productgroup`
--

CREATE TABLE `productgroup` (
  `productgroupID` int(11) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `productgroup`
--

INSERT INTO `productgroup` (`productgroupID`, `name`) VALUES
(1, 'Brot');

-- --------------------------------------------------------

--
-- Table structure for table `product_has_productgroup`
--

CREATE TABLE `product_has_productgroup` (
  `productID` int(11) NOT NULL,
  `productgroupID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userID` int(11) NOT NULL,
  `usertypeID` int(11) NOT NULL,
  `email` varchar(80) NOT NULL,
  `password` varchar(64) NOT NULL,
  `address_addressID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userID`, `usertypeID`, `email`, `password`, `address_addressID`) VALUES
(34, 2, 'm', 'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', NULL),
(48, 3, 'a', 'e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `usertype`
--

CREATE TABLE `usertype` (
  `usertypeID` int(11) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usertype`
--

INSERT INTO `usertype` (`usertypeID`, `name`) VALUES
(1, 'Customer'),
(2, 'Employee'),
(3, 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `address`
--
ALTER TABLE `address`
  ADD PRIMARY KEY (`addressID`),
  ADD UNIQUE KEY `addressID_UNIQUE` (`addressID`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderID`),
  ADD UNIQUE KEY `orderID_UNIQUE` (`orderID`),
  ADD KEY `fk_Order_User1_idx` (`User_userID`);

--
-- Indexes for table `order_has_product`
--
ALTER TABLE `order_has_product`
  ADD PRIMARY KEY (`Order_orderID`,`product_productD`),
  ADD KEY `fk_Produkt_has_Bestellung_Produkt1_idx` (`product_productD`),
  ADD KEY `fk_Order_has_Product_Order1_idx` (`Order_orderID`);

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
  ADD PRIMARY KEY (`productgroupID`),
  ADD UNIQUE KEY `productgroupID_UNIQUE` (`productgroupID`);

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
  ADD UNIQUE KEY `email_UNIQUE` (`email`),
  ADD KEY `fk_user_user_type1_idx` (`usertypeID`),
  ADD KEY `fk_User_Address1_idx` (`address_addressID`);

--
-- Indexes for table `usertype`
--
ALTER TABLE `usertype`
  ADD PRIMARY KEY (`usertypeID`),
  ADD UNIQUE KEY `usertypeID_UNIQUE` (`usertypeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `address`
--
ALTER TABLE `address`
  MODIFY `addressID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `orderID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `productID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `productgroup`
--
ALTER TABLE `productgroup`
  MODIFY `productgroupID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=49;

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
  ADD CONSTRAINT `fk_Order_User1` FOREIGN KEY (`User_userID`) REFERENCES `user` (`userID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `order_has_product`
--
ALTER TABLE `order_has_product`
  ADD CONSTRAINT `fk_Order_has_Product_Order1` FOREIGN KEY (`Order_orderID`) REFERENCES `order` (`orderID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Produkt_has_Bestellung_Produkt1` FOREIGN KEY (`product_productD`) REFERENCES `product` (`productID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

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
  ADD CONSTRAINT `fk_User_Address1` FOREIGN KEY (`address_addressID`) REFERENCES `address` (`addressID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_user_user_type1` FOREIGN KEY (`usertypeID`) REFERENCES `usertype` (`usertypeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
