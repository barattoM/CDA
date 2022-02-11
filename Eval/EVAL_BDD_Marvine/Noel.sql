DROP DATABASE IF EXISTS Noel ;

CREATE DATABASE IF NOT EXISTS `Noel` DEFAULT CHARACTER SET utf8 ;

USE `Noel`;


--
-- Table structure for table `Enfants`
--

CREATE TABLE Enfants(
   IdEnfant INT AUTO_INCREMENT PRIMARY KEY,
   nomEnfant VARCHAR(100)  NOT NULL,
   prenomEnfant VARCHAR(100)  NOT NULL,
   adresseEnfant VARCHAR(150)  NOT NULL,
   sexeEnfant CHAR(1) NOT NULL,
   voeuEnfant VARCHAR(150)  NOT NULL,
   pourcentageSagesse INT NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `Lutins`
--

CREATE TABLE Lutins(
   IdLutin INT AUTO_INCREMENT PRIMARY KEY,
   nomLutin VARCHAR(100)  NOT NULL,
   prenomLutin VARCHAR(100)  NOT NULL
)ENGINE=InnoDB;

--
-- Table structure for table `Traineaux`
--

CREATE TABLE Traineaux(
   IdTraineau INT AUTO_INCREMENT PRIMARY KEY,
   tailleTraineau FLOAT NOT NULL,
   dateMiseService DATE NOT NULL,
   dateRevision DATE
)ENGINE=InnoDB;

--
-- Table structure for table `Tournees`
--

CREATE TABLE Tournees(
   IdTournee INT AUTO_INCREMENT PRIMARY KEY,
   heureTournee TIME NOT NULL,
   IdTraineau INT NOT NULL,
   IdLutin INT NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Cadeaux`
--

CREATE TABLE Cadeaux(
   IdCadeau INT AUTO_INCREMENT PRIMARY KEY,
   designationCadeau VARCHAR(150)  NOT NULL,
   IdTournee INT NOT NULL,
   IdEnfant INT NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Rennes`
--

CREATE TABLE Rennes(
   IdRenne INT AUTO_INCREMENT PRIMARY KEY,
   nomRenne VARCHAR(100)  NOT NULL,
   sexeRenne CHAR(1)  NOT NULL,
   ddnRenne DATE NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Responsabilites`
--

CREATE TABLE Responsabilites(
   IdResponsabilite INT AUTO_INCREMENT PRIMARY KEY,
   IdLutin INT NOT NULL,
   IdTraineau INT NOT NULL,
   dateResponsabilite DATE NOT NULL
)ENGINE=InnoDB;


--
-- Table structure for table `Equipages`
--

CREATE TABLE Equipages(
   IdEquipage INT AUTO_INCREMENT PRIMARY KEY,
   IdTournee INT NOT NULL,
   IdRenne INT NOT NULL
)ENGINE=InnoDB;


--
-- Alter table : foreign key
--

ALTER TABLE Responsabilites 
    ADD CONSTRAINT fk_Responsabilites_Traineaux FOREIGN KEY(IdTraineau) REFERENCES Traineaux(IdTraineau),
    ADD CONSTRAINT fk_Responsabilites_Lutins FOREIGN KEY(IdLutin) REFERENCES Lutins(IdLutin);

ALTER TABLE Cadeaux 
    ADD CONSTRAINT fk_Cadeaux_Tournees FOREIGN KEY(IdTournee) REFERENCES Tournees(IdTournee),
    ADD CONSTRAINT fk_Cadeaux_Enfants FOREIGN KEY(IdEnfant) REFERENCES Enfants(IdEnfant);

ALTER TABLE Tournees
   ADD CONSTRAINT fk_Tournees_Lutins FOREIGN KEY(IdLutin) REFERENCES Lutins(IdLutin),
   ADD CONSTRAINT fk_Tournees_Traineaux FOREIGN KEY(IdTraineau) REFERENCES Traineaux(IdTraineau);

ALTER TABLE Equipages
   ADD CONSTRAINT fk_Equipages_Tournees FOREIGN KEY(IdTournee) REFERENCES Tournees(IdTournee),
   ADD CONSTRAINT fk_Equipages_Rennes FOREIGN KEY(IdRenne) REFERENCES Rennes(IdRenne);