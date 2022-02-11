-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 27 jan. 2022 à 15:38
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `exercice1`
--

-- --------------------------------------------------------

--
-- Structure de la table `articles`
--

DROP TABLE IF EXISTS `articles`;
CREATE TABLE IF NOT EXISTS `articles` (
  `idArticle` int(11) NOT NULL AUTO_INCREMENT,
  `descriptionArticle` varchar(50) DEFAULT NULL,
  `prixArticle` int(11) DEFAULT NULL,
  PRIMARY KEY (`idArticle`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `articles`
--

INSERT INTO `articles` (`idArticle`, `descriptionArticle`, `prixArticle`) VALUES
(1, 'ciseaux', 6),
(2, 'règle 30 cm', 4),
(3, 'règle 20 cm', 3),
(4, 'stylo plume', 12),
(5, 'feutre tableau blanc', 4),
(6, 'feuille', 2);

-- --------------------------------------------------------

--
-- Structure de la table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT,
  `nomClient` varchar(50) DEFAULT NULL,
  `prenomClient` varchar(50) DEFAULT NULL,
  `dateEntreeClient` date DEFAULT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `clients`
--

INSERT INTO `clients` (`idClient`, `nomClient`, `prenomClient`, `dateEntreeClient`) VALUES
(1, 'talon', 'marc', '1999-10-22'),
(2, 'talon', 'sophie', '2004-11-16'),
(3, 'talleux', 'vincent', '2005-06-21'),
(4, 'durand', 'sophie', '2006-12-21'),
(5, 'durant', 'serge', '2005-04-05'),
(6, 'dupond', 'yves', '2005-12-04');

-- --------------------------------------------------------

--
-- Structure de la table `commandes`
--

DROP TABLE IF EXISTS `commandes`;
CREATE TABLE IF NOT EXISTS `commandes` (
  `idCommande` int(11) NOT NULL AUTO_INCREMENT,
  `idClient` int(11) DEFAULT NULL,
  `idArticle` int(11) DEFAULT NULL,
  `dateCommande` date DEFAULT NULL,
  `quantiteCommande` int(11) DEFAULT NULL,
  `cde_total` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCommande`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `commandes`
--

INSERT INTO `commandes` (`idCommande`, `idClient`, `idArticle`, `dateCommande`, `quantiteCommande`, `cde_total`) VALUES
(1, 2, 6, '2014-07-07', 9, 18),
(2, 2, 5, '2014-07-08', 1, 4),
(3, 3, 1, '2014-07-09', 12, 72),
(4, 4, 5, '2014-07-08', 2, 8),
(5, 5, 1, '2014-07-07', 5, 30),
(6, 5, 2, '2014-07-07', 1, 4);

-- --------------------------------------------------------

--
-- Structure de la table `textes`
--

DROP TABLE IF EXISTS `textes`;
CREATE TABLE IF NOT EXISTS `textes` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(50) NOT NULL,
  `fr` longtext NOT NULL,
  `en` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `textes`
--

INSERT INTO `textes` (`idTexte`, `codeTexte`, `fr`, `en`) VALUES
(1, 'Bonjour', 'Bonjour', 'Hello'),
(2, 'Connexion', 'Connexion', 'Log in'),
(3, 'Deconnexion', 'Deconnexion', 'Log out'),
(4, 'Accueil', 'Accueil', 'Home'),
(5, 'AdresseEmail', 'Adresse email', 'Email address'),
(6, 'Mdp', 'Mot de passe', 'Password'),
(7, 'Inscription', 'Inscription', 'Registration'),
(8, 'Nom', 'Nom', 'Surname'),
(9, 'Prenom', 'Prenom', 'Name'),
(10, 'InfoMdpLegend', 'Veuillez saisir au moins', 'Please enter at least'),
(11, 'UneMajuscule', '1 majuscule', '1 uppercase'),
(12, 'UneMinuscule', '1 minuscule', '1 lowercase'),
(13, 'UnChiffre', '1 chiffre', '1 number'),
(14, 'UnCaractereSpecial', '1 caractère spécial ( ! @ & # * ^ $ % +)', '1 special character ( ! @ & # * ^ $ % +)'),
(15, 'MinimumCaractere', '8 caractères', '8 character'),
(16, 'Confirmation', 'Confirmation', 'Confirmation'),
(17, 'Reset', 'Réinitialisation', 'Reset'),
(18, 'inputDefault', 'Choisir une valeur', 'Choose a value'),
(19, 'Envoyer', 'Envoyer', 'Send');

-- --------------------------------------------------------

--
-- Structure de la table `utilisateurs`
--

DROP TABLE IF EXISTS `utilisateurs`;
CREATE TABLE IF NOT EXISTS `utilisateurs` (
  `idUtilisateur` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) NOT NULL,
  `prenom` varchar(50) NOT NULL,
  `adresseMail` varchar(50) NOT NULL,
  `motDePasse` varchar(50) NOT NULL,
  `role` int(11) NOT NULL COMMENT '2 Admin 1 User',
  PRIMARY KEY (`idUtilisateur`),
  UNIQUE KEY `adresseMail` (`adresseMail`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

ALTER TABLE Commandes ADD CONSTRAINT fk_Commandes_CLients FOREIGN KEY (idClient) REFERENCES Clients(idClient);
ALTER TABLE Commandes ADD CONSTRAINT fk_Commandes_Articles FOREIGN KEY (idArticle) REFERENCES Articles(idArticle);