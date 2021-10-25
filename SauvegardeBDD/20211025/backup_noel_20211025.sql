-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: noel
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
-- Current Database: `noel`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `noel` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `noel`;

--
-- Table structure for table `cadeaux`
--

DROP TABLE IF EXISTS `cadeaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cadeaux` (
  `IdCadeau` int(11) NOT NULL AUTO_INCREMENT,
  `designationCadeau` varchar(150) NOT NULL,
  `IdTournee` int(11) NOT NULL,
  `IdEnfant` int(11) NOT NULL,
  PRIMARY KEY (`IdCadeau`),
  KEY `fk_Cadeaux_Tournees` (`IdTournee`),
  KEY `fk_Cadeaux_Enfants` (`IdEnfant`),
  CONSTRAINT `fk_Cadeaux_Enfants` FOREIGN KEY (`IdEnfant`) REFERENCES `enfants` (`IdEnfant`),
  CONSTRAINT `fk_Cadeaux_Tournees` FOREIGN KEY (`IdTournee`) REFERENCES `tournees` (`IdTournee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadeaux`
--

LOCK TABLES `cadeaux` WRITE;
/*!40000 ALTER TABLE `cadeaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadeaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfants`
--

DROP TABLE IF EXISTS `enfants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfants` (
  `IdEnfant` int(11) NOT NULL AUTO_INCREMENT,
  `nomEnfant` varchar(100) NOT NULL,
  `prenomEnfant` varchar(100) NOT NULL,
  `adresseEnfant` varchar(150) NOT NULL,
  `sexeEnfant` char(1) NOT NULL,
  `voeuEnfant` varchar(150) NOT NULL,
  `pourcentageSagesse` int(11) NOT NULL,
  PRIMARY KEY (`IdEnfant`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfants`
--

LOCK TABLES `enfants` WRITE;
/*!40000 ALTER TABLE `enfants` DISABLE KEYS */;
/*!40000 ALTER TABLE `enfants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipages`
--

DROP TABLE IF EXISTS `equipages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipages` (
  `IdEquipage` int(11) NOT NULL AUTO_INCREMENT,
  `IdTournee` int(11) NOT NULL,
  `IdRenne` int(11) NOT NULL,
  PRIMARY KEY (`IdEquipage`),
  KEY `fk_Equipages_Tournees` (`IdTournee`),
  KEY `fk_Equipages_Rennes` (`IdRenne`),
  CONSTRAINT `fk_Equipages_Rennes` FOREIGN KEY (`IdRenne`) REFERENCES `rennes` (`IdRenne`),
  CONSTRAINT `fk_Equipages_Tournees` FOREIGN KEY (`IdTournee`) REFERENCES `tournees` (`IdTournee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipages`
--

LOCK TABLES `equipages` WRITE;
/*!40000 ALTER TABLE `equipages` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lutins`
--

DROP TABLE IF EXISTS `lutins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lutins` (
  `IdLutin` int(11) NOT NULL AUTO_INCREMENT,
  `nomLutin` varchar(100) NOT NULL,
  `prenomLutin` varchar(100) NOT NULL,
  PRIMARY KEY (`IdLutin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lutins`
--

LOCK TABLES `lutins` WRITE;
/*!40000 ALTER TABLE `lutins` DISABLE KEYS */;
/*!40000 ALTER TABLE `lutins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rennes`
--

DROP TABLE IF EXISTS `rennes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rennes` (
  `IdRenne` int(11) NOT NULL AUTO_INCREMENT,
  `nomRenne` varchar(100) NOT NULL,
  `sexeRenne` char(1) NOT NULL,
  `ddnRenne` date NOT NULL,
  PRIMARY KEY (`IdRenne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rennes`
--

LOCK TABLES `rennes` WRITE;
/*!40000 ALTER TABLE `rennes` DISABLE KEYS */;
/*!40000 ALTER TABLE `rennes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `responsabilites`
--

DROP TABLE IF EXISTS `responsabilites`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `responsabilites` (
  `IdResponsabilite` int(11) NOT NULL AUTO_INCREMENT,
  `IdLutin` int(11) NOT NULL,
  `IdTraineau` int(11) NOT NULL,
  `dateResponsabilite` date NOT NULL,
  PRIMARY KEY (`IdResponsabilite`),
  KEY `fk_Responsabilites_Traineaux` (`IdTraineau`),
  KEY `fk_Responsabilites_Lutins` (`IdLutin`),
  CONSTRAINT `fk_Responsabilites_Lutins` FOREIGN KEY (`IdLutin`) REFERENCES `lutins` (`IdLutin`),
  CONSTRAINT `fk_Responsabilites_Traineaux` FOREIGN KEY (`IdTraineau`) REFERENCES `traineaux` (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `responsabilites`
--

LOCK TABLES `responsabilites` WRITE;
/*!40000 ALTER TABLE `responsabilites` DISABLE KEYS */;
/*!40000 ALTER TABLE `responsabilites` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tournees`
--

DROP TABLE IF EXISTS `tournees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tournees` (
  `IdTournee` int(11) NOT NULL AUTO_INCREMENT,
  `heureTournee` time NOT NULL,
  `IdTraineau` int(11) NOT NULL,
  `IdLutin` int(11) NOT NULL,
  PRIMARY KEY (`IdTournee`),
  KEY `fk_Tournees_Lutins` (`IdLutin`),
  KEY `fk_Tournees_Traineaux` (`IdTraineau`),
  CONSTRAINT `fk_Tournees_Lutins` FOREIGN KEY (`IdLutin`) REFERENCES `lutins` (`IdLutin`),
  CONSTRAINT `fk_Tournees_Traineaux` FOREIGN KEY (`IdTraineau`) REFERENCES `traineaux` (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tournees`
--

LOCK TABLES `tournees` WRITE;
/*!40000 ALTER TABLE `tournees` DISABLE KEYS */;
/*!40000 ALTER TABLE `tournees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `traineaux`
--

DROP TABLE IF EXISTS `traineaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `traineaux` (
  `IdTraineau` int(11) NOT NULL AUTO_INCREMENT,
  `tailleTraineau` float NOT NULL,
  `dateMiseService` date NOT NULL,
  `dateRevision` date DEFAULT NULL,
  PRIMARY KEY (`IdTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `traineaux`
--

LOCK TABLES `traineaux` WRITE;
/*!40000 ALTER TABLE `traineaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `traineaux` ENABLE KEYS */;
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
