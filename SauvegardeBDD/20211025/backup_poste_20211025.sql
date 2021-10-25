-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: poste
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `poste`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `poste` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `poste`;

--
-- Table structure for table `bureauxposte`
--

DROP TABLE IF EXISTS `bureauxposte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bureauxposte` (
  `IdBureauxPoste` int(11) NOT NULL AUTO_INCREMENT,
  `codePostal` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdBureauxPoste`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bureauxposte`
--

LOCK TABLES `bureauxposte` WRITE;
/*!40000 ALTER TABLE `bureauxposte` DISABLE KEYS */;
/*!40000 ALTER TABLE `bureauxposte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `centrestri`
--

DROP TABLE IF EXISTS `centrestri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `centrestri` (
  `IdCentreTri` int(11) NOT NULL AUTO_INCREMENT,
  `nomCentre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdCentreTri`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `centrestri`
--

LOCK TABLES `centrestri` WRITE;
/*!40000 ALTER TABLE `centrestri` DISABLE KEYS */;
/*!40000 ALTER TABLE `centrestri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courriers`
--

DROP TABLE IF EXISTS `courriers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courriers` (
  `IdCourrier` int(11) NOT NULL AUTO_INCREMENT,
  `adresseDestinataire` varchar(50) NOT NULL,
  `adresseEmetteur` varchar(50) DEFAULT NULL,
  `dateEnvoi` varchar(50) DEFAULT NULL,
  `dateReception` varchar(50) DEFAULT NULL,
  `IdType` int(11) NOT NULL,
  `IdBureauxPoste` int(11) NOT NULL,
  PRIMARY KEY (`IdCourrier`),
  KEY `IdType` (`IdType`),
  KEY `IdBureauxPoste` (`IdBureauxPoste`),
  CONSTRAINT `courriers_ibfk_1` FOREIGN KEY (`IdType`) REFERENCES `types` (`IdType`),
  CONSTRAINT `courriers_ibfk_2` FOREIGN KEY (`IdBureauxPoste`) REFERENCES `bureauxposte` (`IdBureauxPoste`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courriers`
--

LOCK TABLES `courriers` WRITE;
/*!40000 ALTER TABLE `courriers` DISABLE KEYS */;
/*!40000 ALTER TABLE `courriers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `distributions`
--

DROP TABLE IF EXISTS `distributions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `distributions` (
  `IdDistribution` int(11) NOT NULL AUTO_INCREMENT,
  `IdBureauxPoste` int(11) DEFAULT NULL,
  `IdCentreTri` int(11) DEFAULT NULL,
  `IdTransport` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdDistribution`),
  KEY `IdBureauxPoste` (`IdBureauxPoste`),
  KEY `IdCentreTri` (`IdCentreTri`),
  KEY `IdTransport` (`IdTransport`),
  CONSTRAINT `distributions_ibfk_1` FOREIGN KEY (`IdBureauxPoste`) REFERENCES `bureauxposte` (`IdBureauxPoste`),
  CONSTRAINT `distributions_ibfk_2` FOREIGN KEY (`IdCentreTri`) REFERENCES `centrestri` (`IdCentreTri`),
  CONSTRAINT `distributions_ibfk_3` FOREIGN KEY (`IdTransport`) REFERENCES `transports` (`IdTransport`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `distributions`
--

LOCK TABLES `distributions` WRITE;
/*!40000 ALTER TABLE `distributions` DISABLE KEYS */;
/*!40000 ALTER TABLE `distributions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transports`
--

DROP TABLE IF EXISTS `transports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transports` (
  `IdTransport` int(11) NOT NULL AUTO_INCREMENT,
  `typeTransport` varchar(50) DEFAULT NULL,
  `taxeCarbone` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdTransport`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transports`
--

LOCK TABLES `transports` WRITE;
/*!40000 ALTER TABLE `transports` DISABLE KEYS */;
/*!40000 ALTER TABLE `transports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `types`
--

DROP TABLE IF EXISTS `types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `types` (
  `IdType` int(11) NOT NULL AUTO_INCREMENT,
  `nomType` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdType`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `types`
--

LOCK TABLES `types` WRITE;
/*!40000 ALTER TABLE `types` DISABLE KEYS */;
/*!40000 ALTER TABLE `types` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-25 11:49:33
