-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 21 jan. 2022 à 09:58
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
-- Base de données : `citationbase`
--

-- --------------------------------------------------------

--
-- Structure de la table `auteurs`
--

DROP TABLE IF EXISTS `auteurs`;
CREATE TABLE IF NOT EXISTS `auteurs` (
  `IdAuteur` int(11) NOT NULL AUTO_INCREMENT,
  `NomAuteur` varchar(150) NOT NULL,
  `PrenomAuteur` varchar(150) NOT NULL,
  `DateDeNaissance` date DEFAULT NULL,
  `IdPays` int(11) NOT NULL,
  PRIMARY KEY (`IdAuteur`),
  KEY `fk_Auteurs_Pays` (`IdPays`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `auteurs`
--

INSERT INTO `auteurs` (`IdAuteur`, `NomAuteur`, `PrenomAuteur`, `DateDeNaissance`, `IdPays`) VALUES
(1, 'Thacker', 'Maxence', '2000-01-01', 1),
(2, 'Poix', 'Martine', '1901-01-06', 2);

-- --------------------------------------------------------

--
-- Structure de la table `citations`
--

DROP TABLE IF EXISTS `citations`;
CREATE TABLE IF NOT EXISTS `citations` (
  `IdCitation` int(11) NOT NULL AUTO_INCREMENT,
  `TexteCitation` text NOT NULL,
  `DateCitation` date NOT NULL,
  `IdAuteur` int(11) NOT NULL,
  PRIMARY KEY (`IdCitation`),
  KEY `fk_Citations_Auteur` (`IdAuteur`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `citations`
--

INSERT INTO `citations` (`IdCitation`, `TexteCitation`, `DateCitation`, `IdAuteur`) VALUES
(1, 'Une boucle à tête chercheuse', '2021-10-20', 1),
(2, 'Et si on mettait un find by pseudo ?', '2022-01-19', 1),
(3, 'Ha bon j’achète le chinois pour tout le monde ?', '2021-11-15', 1),
(4, 'T\'est viré', '2020-09-01', 2),
(5, 'Bruno maintenant tu mets combien de doigt ? ', '2022-01-10', 2),
(6, 'Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.Lorem ipsum dolor sit amet consectetur adipisicing elit. Fugiat, asperiores pariatur molestias aliquid deleniti culpa officia iure consequuntur quas, dignissimos similique architecto doloribus distinctio laudantium! Hic, saepe voluptatum. Quam, eveniet.', '2022-01-11', 2),
(7, 'Tous les noirs sont mort !', '2020-12-15', 2);

-- --------------------------------------------------------

--
-- Structure de la table `filtretheme`
--

DROP TABLE IF EXISTS `filtretheme`;
CREATE TABLE IF NOT EXISTS `filtretheme` (
  `IdFiltreTheme` int(11) NOT NULL AUTO_INCREMENT,
  `IdCitation` int(11) DEFAULT NULL,
  `IdTheme` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdFiltreTheme`),
  KEY `fk_FiltreTheme_Citations` (`IdCitation`),
  KEY `fk_FiltreTheme_Themes` (`IdTheme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `pays`
--

DROP TABLE IF EXISTS `pays`;
CREATE TABLE IF NOT EXISTS `pays` (
  `IdPays` int(11) NOT NULL AUTO_INCREMENT,
  `NomPays` varchar(150) NOT NULL,
  PRIMARY KEY (`IdPays`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `pays`
--

INSERT INTO `pays` (`IdPays`, `NomPays`) VALUES
(1, 'Kazakhstan '),
(2, 'France');

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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

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
(18, 'Envoyer', 'Envoyer', 'Send');

-- --------------------------------------------------------

--
-- Structure de la table `themes`
--

DROP TABLE IF EXISTS `themes`;
CREATE TABLE IF NOT EXISTS `themes` (
  `IdTheme` int(11) NOT NULL AUTO_INCREMENT,
  `LibelleTheme` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`IdTheme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `utilisateurs`
--

INSERT INTO `utilisateurs` (`idUtilisateur`, `nom`, `prenom`, `adresseMail`, `motDePasse`, `role`) VALUES
(1, 'Toto', 'Titi', 'Toto@gmail.com', '476334eb362568772aeed9edcaa92bc1', 1);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `auteurs`
--
ALTER TABLE `auteurs`
  ADD CONSTRAINT `fk_Auteurs_Pays` FOREIGN KEY (`IdPays`) REFERENCES `pays` (`IdPays`);

--
-- Contraintes pour la table `citations`
--
ALTER TABLE `citations`
  ADD CONSTRAINT `fk_Citations_Auteur` FOREIGN KEY (`IdAuteur`) REFERENCES `auteurs` (`IdAuteur`);

--
-- Contraintes pour la table `filtretheme`
--
ALTER TABLE `filtretheme`
  ADD CONSTRAINT `fk_FiltreTheme_Citations` FOREIGN KEY (`IdCitation`) REFERENCES `citations` (`IdCitation`),
  ADD CONSTRAINT `fk_FiltreTheme_Themes` FOREIGN KEY (`IdTheme`) REFERENCES `themes` (`IdTheme`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
