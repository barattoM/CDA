--
-- Base de données : `CDABaratto`
--
DROP DATABASE IF EXISTS CDABaratto;

CREATE DATABASE CDABaratto;

USE CDABaratto;

-- --------------------------------------------------------

--
-- Structure de la table `ville`
--

DROP TABLE IF EXISTS `ville`;
CREATE TABLE IF NOT EXISTS `ville` (
  `idVille` int Auto_increment  NOT NULL PRIMARY KEY,
  `nomVille` varchar(100) NOT NULL,
  `numeroDepartement` int NOT NULL,
  `codePostal` int NOT NULL,
  `dateMAJ` varchar(50)
) ENGINE=INNODB DEFAULT CHARSET=UTF8;

--
-- Déchargement des données de la table `ville`
--

INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville1",1,11111,"02/02/02");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville2",2,22222,"12/04/19");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville3",3,33333,"10/07/12");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville4",4,44444,"11/11/11");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville5",5,55555,"15/12/18");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville6",6,66666,"02/03/04");
INSERT INTO `ville` (`nomVille`,`numeroDepartement`,`codePostal`,`dateMAJ`) VALUES("ville7",7,77777,"01/01/97");