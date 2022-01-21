DROP DATABASE IF EXISTS CitationBase ;

CREATE DATABASE IF NOT EXISTS `CitationBase` DEFAULT CHARACTER SET utf8 ;

USE `CitationBase`;


--
-- Table structure for table `Themes`
--
CREATE TABLE Themes(
   IdTheme INT AUTO_INCREMENT PRIMARY KEY,
   LibelleTheme VARCHAR(150)
)ENGINE=InnoDB;


--
-- Table structure for table `Pays`
--
CREATE TABLE Pays(
   IdPays INT AUTO_INCREMENT PRIMARY KEY,
   NomPays VARCHAR(150)  NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Auteurs`
--
CREATE TABLE Auteurs(
   IdAuteur INT AUTO_INCREMENT PRIMARY KEY,
   NomAuteur VARCHAR(150)  NOT NULL,
   PrenomAuteur VARCHAR(150)  NOT NULL,
   DateDeNaissance DATE,
   IdPays INT NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Citations`
--
CREATE TABLE Citations(
   IdCitation INT AUTO_INCREMENT PRIMARY KEY,
   TexteCitation TEXT NOT NULL,
   DateCitation DATE NOT NULL,
   IdAuteur INT NOT NULL
   
)ENGINE=InnoDB;


--
-- Table structure for table `FiltreTheme`
--
CREATE TABLE FiltreTheme(
    IdFiltreTheme INT AUTO_INCREMENT PRIMARY KEY,
   IdCitation INT,
   IdTheme INT
)ENGINE=InnoDB;

Alter table Auteurs Add Constraint fk_Auteurs_Pays FOREIGN KEY(IdPays) REFERENCES Pays(IdPays);
Alter table Citations Add Constraint fk_Citations_Auteur FOREIGN KEY(IdAuteur) REFERENCES Auteurs(IdAuteur);
Alter table FiltreTheme Add Constraint fk_FiltreTheme_Citations FOREIGN KEY(IdCitation) REFERENCES Citations(IdCitation);
Alter table FiltreTheme Add Constraint fk_FiltreTheme_Themes FOREIGN KEY(IdTheme) REFERENCES Themes(IdTheme);
