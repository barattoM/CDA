-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: baseproduits
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
-- Current Database: `baseproduits`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `baseproduits` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `baseproduits`;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `idCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleCategorie` varchar(50) NOT NULL,
  PRIMARY KEY (`idCategorie`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'périssable'),(2,'éternel');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produits` (
  `idProduit` int(11) NOT NULL AUTO_INCREMENT,
  `libelleProduit` varchar(50) NOT NULL,
  `prix` int(11) NOT NULL,
  `dateDePeremption` date NOT NULL,
  `idCategorie` int(11) NOT NULL,
  PRIMARY KEY (`idProduit`),
  KEY `FK_Produit_Categorie` (`idCategorie`),
  CONSTRAINT `FK_Produit_Categorie` FOREIGN KEY (`idCategorie`) REFERENCES `categories` (`idCategorie`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produits`
--

LOCK TABLES `produits` WRITE;
/*!40000 ALTER TABLE `produits` DISABLE KEYS */;
INSERT INTO `produits` VALUES (1,'gomme',2,'2020-11-30',1),(2,'crayon',1,'2020-11-30',2);
/*!40000 ALTER TABLE `produits` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `texte`
--

DROP TABLE IF EXISTS `texte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `texte` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(50) NOT NULL,
  `fr` longtext NOT NULL,
  `en` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `texte`
--

LOCK TABLES `texte` WRITE;
/*!40000 ALTER TABLE `texte` DISABLE KEYS */;
INSERT INTO `texte` VALUES (1,'Accueil','Choisissez entre Produits et Catégories','Choose between products and categories'),(2,'Accueil','Accueil','Home'),(3,'Inscription','Inscription','Sign In'),(4,'Identification','Identification','Log In'),(5,'Liste de produits','Liste de produits','List of products'),(6,'DétailProduit','Détail du produit','Product description'),(7,'Mise à jour du produit','Mise à jour du produit','Update product'),(8,'Détail du produit','Détail du produit','Product description'),(9,'Liste des Catégories','Liste des Catégories','Categories list'),(10,'Gestion des catégories','Gestion des catégories','Categories gestion'),(11,'Mise à jour de la catégorie','Mise à jour de la catégorie','Update category'),(12,'Bonjour','Bonjour','Hello'),(13,'Déconnecter','Déconnecter','Deconnexion'),(14,'Connecter','Connecter','Connection'),(15,'Produits','Produits','Products'),(16,'Categories','Catégories','Categories'),(17,'Libellé','Libellé','Gas bubble'),(18,'Ajouter','Ajouter','Add'),(19,'Modifier','Modifier','Modify'),(20,'Supprimer','Supprimer','Delete'),(21,'une catégorie','une catégorie','category'),(22,'Annuler','Annuler','Cancel'),(23,'Pseudo','Pseudo','Pseudo'),(24,'Mot De Passe','Mot De Passe','Password'),(25,'Valider','Valider','Ok'),(26,'S\'inscrire','S\'inscrire','Sign In'),(27,'Nom','Nom','Last name'),(28,'Prenom','Prenom','First name'),(29,'Confirmation du mot de passe','Confirmation du mot de passe','Confirm password'),(30,'Adresse mail','Adresse mail','Mail'),(31,'Role (1 : user - 2 : admin)','Role (1 : user - 2 : admin)','Role (1 : user - 2 : admin)'),(32,'Editer','Editer','Edit'),(33,'un produit','un produit','product'),(34,'Prix','Prix','Price'),(35,'Date de péremption','Date de péremption','Expiry date'),(36,'Categorie','Categorie','Category');
/*!40000 ALTER TABLE `texte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `textes`
--

DROP TABLE IF EXISTS `textes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `textes` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(50) NOT NULL,
  `fr` longtext NOT NULL,
  `en` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `textes`
--

LOCK TABLES `textes` WRITE;
/*!40000 ALTER TABLE `textes` DISABLE KEYS */;
INSERT INTO `textes` VALUES (1,'Bonjour','Bonjour','Hello'),(2,'Connexion','Connexion','Log in'),(3,'Deconnexion','Deconnexion','Log out'),(4,'Accueil','Accueil','Home'),(5,'AdresseEmail','Adresse email','Email address'),(6,'Mdp','Mot de passe','Password'),(7,'Inscription','Inscription','Registration'),(8,'Nom','Nom','Surname'),(9,'Prenom','Prenom','Name'),(10,'InfoMdpLegend','Veuillez saisir au moins','Please enter at least'),(11,'UneMajuscule','1 majuscule','1 uppercase'),(12,'UneMinuscule','1 minuscule','1 lowercase'),(13,'UnChiffre','1 chiffre','1 number'),(14,'UnCaractereSpecial','1 caractère spécial ( ! @ & # * ^ $ % +)','1 special character ( ! @ & # * ^ $ % +)'),(15,'MinimumCaractere','8 caractères','8 character'),(16,'Confirmation','Confirmation','Confirmation'),(17,'Reset','Réinitialisation','Reset'),(18,'inputDefault','Choisir une valeur','Choose a value'),(19,'Envoyer','Envoyer','Send'),(20,'Bonjour','Bonjour','Hello'),(21,'Connexion','Connexion','Log in'),(22,'Deconnexion','Deconnexion','Log out'),(23,'Accueil','Accueil','Home'),(24,'AdresseEmail','Adresse email','Email address'),(25,'Mdp','Mot de passe','Password'),(26,'Inscription','Inscription','Registration'),(27,'Nom','Nom','Surname'),(28,'Prenom','Prenom','Name'),(29,'InfoMdpLegend','Veuillez saisir au moins','Please enter at least'),(30,'UneMajuscule','1 majuscule','1 uppercase'),(31,'UneMinuscule','1 minuscule','1 lowercase'),(32,'UnChiffre','1 chiffre','1 number'),(33,'UnCaractereSpecial','1 caractère spécial ( ! @ & # * ^ $ % +)','1 special character ( ! @ & # * ^ $ % +)'),(34,'MinimumCaractere','8 caractères','8 character'),(35,'Confirmation','Confirmation','Confirmation'),(36,'Reset','Réinitialisation','Reset'),(37,'inputDefault','Choisir une valeur','Choose a value'),(38,'Envoyer','Envoyer','Send');
/*!40000 ALTER TABLE `textes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `utilisateurs` (
  `idUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `motDePasse` varchar(50) NOT NULL,
  `adresseMail` varchar(50) NOT NULL,
  `role` int(11) NOT NULL COMMENT '2 Admin 1 User',
  `pseudo` varchar(50) NOT NULL,
  PRIMARY KEY (`idUtilisateur`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilisateurs`
--

LOCK TABLES `utilisateurs` WRITE;
/*!40000 ALTER TABLE `utilisateurs` DISABLE KEYS */;
INSERT INTO `utilisateurs` VALUES (7,'ad','ad','11d437a3e6695447bd1bf2331651049e','ad',2,'ad'),(8,'u','u','1d0a5a28d53430e7f2293a1f36682f23','u',1,'u');
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

-- Dump completed on 2022-02-11  8:25:07
