-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: cantine
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
-- Current Database: `cantine`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `cantine` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `cantine`;

--
-- Table structure for table `eleves`
--

DROP TABLE IF EXISTS `eleves`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `eleves` (
  `IdUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) NOT NULL,
  `Classe` varchar(50) NOT NULL,
  `DateNaissance` date DEFAULT NULL,
  `Adresse` varchar(200) DEFAULT NULL,
  `Mail` varchar(150) NOT NULL,
  PRIMARY KEY (`IdUtilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eleves`
--

LOCK TABLES `eleves` WRITE;
/*!40000 ALTER TABLE `eleves` DISABLE KEYS */;
/*!40000 ALTER TABLE `eleves` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menudujour`
--

DROP TABLE IF EXISTS `menudujour`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menudujour` (
  `IdMenuDuJour` int(11) NOT NULL AUTO_INCREMENT,
  `IdMenu` int(11) DEFAULT NULL,
  `DateDuJour` date NOT NULL,
  PRIMARY KEY (`IdMenuDuJour`),
  KEY `FK_MenuDuJour_Menus` (`IdMenu`),
  CONSTRAINT `FK_MenuDuJour_Menus` FOREIGN KEY (`IdMenu`) REFERENCES `menus` (`IdMenu`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menudujour`
--

LOCK TABLES `menudujour` WRITE;
/*!40000 ALTER TABLE `menudujour` DISABLE KEYS */;
INSERT INTO `menudujour` VALUES (1,1,'2021-12-09'),(2,4,'2021-12-09');
/*!40000 ALTER TABLE `menudujour` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menus`
--

DROP TABLE IF EXISTS `menus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menus` (
  `IdMenu` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleMenu` varchar(150) NOT NULL,
  `Entree` varchar(150) NOT NULL,
  `Plat` varchar(150) NOT NULL,
  `Dessert` varchar(150) NOT NULL,
  `Prix` decimal(15,2) NOT NULL,
  PRIMARY KEY (`IdMenu`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menus`
--

LOCK TABLES `menus` WRITE;
/*!40000 ALTER TABLE `menus` DISABLE KEYS */;
INSERT INTO `menus` VALUES (1,'udh','zuiodfgzi','fuff','azfgreg',120.00),(3,'fezf','grzg','grzg','gzrg',12.00),(4,'ighzoei','gregz','ghtrher','rfafa',10.00),(5,'fezgfzehrt','hterhetrh','grzegreg','zgreg10',10.00);
/*!40000 ALTER TABLE `menus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reglements`
--

DROP TABLE IF EXISTS `reglements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reglements` (
  `IdReglement` int(11) NOT NULL AUTO_INCREMENT,
  `IdUtilisateur` int(11) DEFAULT NULL,
  `IdTypePaiement` int(11) DEFAULT NULL,
  `IdReservation` int(11) DEFAULT NULL,
  `DateReglement` date NOT NULL,
  PRIMARY KEY (`IdReglement`),
  KEY `FK_Reglements_Eleves` (`IdUtilisateur`),
  KEY `FK_Reglements_TypePaiements` (`IdTypePaiement`),
  KEY `FK_Reglements_Reservations` (`IdReservation`),
  CONSTRAINT `FK_Reglements_Eleves` FOREIGN KEY (`IdUtilisateur`) REFERENCES `eleves` (`IdUtilisateur`),
  CONSTRAINT `FK_Reglements_Reservations` FOREIGN KEY (`IdReservation`) REFERENCES `reservations` (`IdReservation`),
  CONSTRAINT `FK_Reglements_TypePaiements` FOREIGN KEY (`IdTypePaiement`) REFERENCES `typepaiements` (`IdTypePaiement`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reglements`
--

LOCK TABLES `reglements` WRITE;
/*!40000 ALTER TABLE `reglements` DISABLE KEYS */;
/*!40000 ALTER TABLE `reglements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservations` (
  `IdReservation` int(11) NOT NULL AUTO_INCREMENT,
  `DateReservation` date NOT NULL,
  `DateRepas` date NOT NULL,
  `IdUtilisateur` int(11) NOT NULL,
  PRIMARY KEY (`IdReservation`),
  KEY `FK_Reservations_Eleves` (`IdUtilisateur`),
  CONSTRAINT `FK_Reservations_Eleves` FOREIGN KEY (`IdUtilisateur`) REFERENCES `eleves` (`IdUtilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservationsmenus`
--

DROP TABLE IF EXISTS `reservationsmenus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reservationsmenus` (
  `IdReservationMenu` int(11) NOT NULL AUTO_INCREMENT,
  `IdMenu` int(11) DEFAULT NULL,
  `IdReservation` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdReservationMenu`),
  KEY `FK_ReservationsMenus_Menus` (`IdMenu`),
  KEY `FK_ReservationsMenus_Reservations` (`IdReservation`),
  CONSTRAINT `FK_ReservationsMenus_Menus` FOREIGN KEY (`IdMenu`) REFERENCES `menus` (`IdMenu`),
  CONSTRAINT `FK_ReservationsMenus_Reservations` FOREIGN KEY (`IdReservation`) REFERENCES `reservations` (`IdReservation`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservationsmenus`
--

LOCK TABLES `reservationsmenus` WRITE;
/*!40000 ALTER TABLE `reservationsmenus` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservationsmenus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `typepaiements`
--

DROP TABLE IF EXISTS `typepaiements`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `typepaiements` (
  `IdTypePaiement` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleTypePaiement` varchar(50) NOT NULL,
  PRIMARY KEY (`IdTypePaiement`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `typepaiements`
--

LOCK TABLES `typepaiements` WRITE;
/*!40000 ALTER TABLE `typepaiements` DISABLE KEYS */;
/*!40000 ALTER TABLE `typepaiements` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `utilisateurs` (
  `IdUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `TypeUtilisateur` int(11) NOT NULL,
  `Login` varchar(50) NOT NULL,
  `MotDePasse` varchar(50) NOT NULL,
  PRIMARY KEY (`IdUtilisateur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateurs`
--

LOCK TABLES `utilisateurs` WRITE;
/*!40000 ALTER TABLE `utilisateurs` DISABLE KEYS */;
/*!40000 ALTER TABLE `utilisateurs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-02-11  8:25:08
