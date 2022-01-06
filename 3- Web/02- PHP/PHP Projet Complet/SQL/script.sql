DROP DATABASE IF EXISTS baseproduits;

CREATE DATABASE IF NOT EXISTS baseproduits DEFAULT CHARACTER
SET latin1 COLLATE latin1_swedish_ci;

USE baseproduits;

DROP TABLE IF EXISTS categories;

CREATE TABLE IF NOT EXISTS categories (
  idCategorie int (11) NOT NULL AUTO_INCREMENT,
  LibelleCategorie varchar (50) NOT NULL,
  PRIMARY KEY (idCategorie)
) ENGINE = InnoDB DEFAULT CHARSET = latin1;

DROP TABLE IF EXISTS produits;

CREATE TABLE IF NOT EXISTS produits (
  idProduit int (11) NOT NULL AUTO_INCREMENT,
  libelleProduit varchar (50) NOT NULL,
  prix int (11) NOT NULL,
  dateDePeremption date NOT NULL,
  idCategorie int (11) NOT NULL,
  PRIMARY KEY (idProduit),
  KEY FK_Produit_Categorie (idCategorie)
) ENGINE = InnoDB DEFAULT CHARSET = latin1;

DROP TABLE IF EXISTS utilisateurs;

CREATE TABLE IF NOT EXISTS utilisateurs (
  idUtilisateur int(11) NOT NULL AUTO_INCREMENT,
  nom varchar(50) NOT NULL,
  prenom varchar(50) NOT NULL,
  motDePasse varchar(50) NOT NULL,
  adresseMail varchar(50) NOT NULL,
  role int(11) NOT NULL COMMENT '2 Admin 1 User',
  pseudo varchar(50) NOT NULL,
  PRIMARY KEY (idUtilisateur)
) ENGINE = InnoDB DEFAULT CHARSET = latin1;

CREATE TABLE IF NOT EXISTS `texte` (
  `idTexte` int(11) NOT NULL AUTO_INCREMENT,
  `codeTexte` varchar(150) NOT NULL,
  `FR` longtext NOT NULL,
  `EN` longtext NOT NULL,
  PRIMARY KEY (`idTexte`)
) ENGINE=MyISAM AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

ALTER TABLE produits
ADD   CONSTRAINT FK_Produit_Categorie FOREIGN KEY (idCategorie) REFERENCES categories (idCategorie);

INSERT INTO
  categories (idCategorie, LibelleCategorie)
VALUES   (1, 'périssable'),(2, 'éternel');

INSERT INTO   produits (idProduit, libelleProduit, prix, dateDePeremption, idCategorie  )
VALUES (1, 'gomme', 2, '2020-11-30', 1);

INSERT INTO   produits (idProduit, libelleProduit, prix, dateDePeremption, idCategorie  )
VALUES(2, 'crayon', 1, '2020-11-30', 2);

INSERT INTO `utilisateurs` (`idUtilisateur`, `nom`, `prenom`, `motDePasse`, `adresseMail`, `role`, `pseudo`) VALUES
(7, 'ad', 'ad', '11d437a3e6695447bd1bf2331651049e', 'ad', 2, 'ad'),
(8, 'u', 'u', '1d0a5a28d53430e7f2293a1f36682f23', 'u', 1, 'u');

INSERT INTO `texte` (`idTexte`, `codeTexte`, `FR`, `EN`) VALUES
(1, 'Accueil', 'Choisissez entre Produits et Catégories', 'Choose between products and categories'),
(2, 'Accueil', 'Accueil', 'Home'),
(3, 'Inscription', 'Inscription', 'Sign In'),
(4, 'Identification', 'Identification', 'Log In'),
(5, 'Liste de produits', 'Liste de produits', 'List of products'),
(6, 'DétailProduit', 'Détail du produit', 'Product description'),
(7, 'Mise à jour du produit', 'Mise à jour du produit', 'Update product'),
(8, 'Détail du produit', 'Détail du produit', 'Product description'),
(9, 'Liste des Catégories', 'Liste des Catégories', 'Categories list'),
(10, 'Gestion des catégories', 'Gestion des catégories', 'Categories gestion'),
(11, 'Mise à jour de la catégorie', 'Mise à jour de la catégorie', 'Update category'),
(12, 'Bonjour', 'Bonjour', 'Hello'),
(13, 'Déconnecter', 'Déconnecter', 'Deconnexion'),
(14, 'Connecter', 'Connecter', 'Connection'),
(15, 'Produits', 'Produits', 'Products'),
(16, 'Categories', 'Catégories', 'Categories'),
(17, 'Libellé', 'Libellé', 'Gas bubble'),
(18, 'Ajouter', 'Ajouter', 'Add'),
(19, 'Modifier', 'Modifier', 'Modify'),
(20, 'Supprimer', 'Supprimer', 'Delete'),
(21, 'une catégorie', 'une catégorie', 'category'),
(22, 'Annuler', 'Annuler', 'Cancel'),
(23, 'Pseudo', 'Pseudo', 'Pseudo'),
(24, 'Mot De Passe', 'Mot De Passe', 'Password'),
(25, 'Valider', 'Valider', 'Ok'),
(26, 'S\'inscrire', 'S\'inscrire', 'Sign In'),
(27, 'Nom', 'Nom', 'Last name'),
(28, 'Prenom', 'Prenom', 'First name'),
(29, 'Confirmation du mot de passe', 'Confirmation du mot de passe', 'Confirm password'),
(30, 'Adresse mail', 'Adresse mail', 'Mail'),
(31, 'Role (1 : user - 2 : admin)', 'Role (1 : user - 2 : admin)', 'Role (1 : user - 2 : admin)'),
(32, 'Editer', 'Editer', 'Edit'),
(33, 'un produit', 'un produit', 'product'),
(34, 'Prix', 'Prix', 'Price'),
(35, 'Date de péremption', 'Date de péremption', 'Expiry date'),
(36, 'Categorie', 'Categorie', 'Category');