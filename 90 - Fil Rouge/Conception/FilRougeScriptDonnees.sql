INSERT INTO `tva` (`IdTVA`, `tauxTVA`) VALUES
(1, 20),
(2, 6);

INSERT INTO `categoriesclient` (`IdCategorieClient`, `libelleCategClient`, `infoReglement`, `coefCategClient`) VALUES
(1, 'Particulier', '1', 4),
(2, 'Professionnel', '2', 2);

INSERT INTO `etatscommande` (`IdEtatCommande`, `libelleEtatCommande`) VALUES
(1, 'En attente '),
(2, 'En cours'),
(3, 'Terminé');

INSERT INTO `fournisseurs` (`IdFournisseur`, `nomFournisseur`) VALUES
(1, 'MenageService AFPA'),
(2, 'Space X ');

INSERT INTO `roles` (`IdRole`, `libelleRole`) VALUES
(1, 'Admin'),
(2, 'Client');

INSERT INTO `pays` (`IdPays`, `nomPays`) VALUES
(3, 'Belgique'),
(1, 'France'),
(2, 'Russie'),
(4, 'Somalie');

INSERT INTO `villes` (`IdVille`, `libelleVIlle`, `codePostal`, `IdPays`) VALUES
(1, 'Dunkerque', '59240', 1),
(2, 'Moscou', '59696', 2),
(3, 'Mogadiscio', '6369', 4),
(4, 'Brussel', '5269', 3);

INSERT INTO `adresses` (`IdAdresse`, `emailAdresse`, `telMobile`, `telFixe`, `adressePostale`, `province`, `complementAdresse`, `IdVille`) VALUES
(1, 'Maxance@Bootstrap.com', '0602030203', '0328569569', '58 rue de l\'afpa ', 'Nord', '59240 dunkerque', 1),
(2, 'Martine.Poix@Afpa.fr', '06080502', '0328569565', '96 rue de l\'eglise ', 'Nord', '59380 socx', 1);

INSERT INTO `users` (`IdUser`, `nomUser`, `prenomUser`, `EmailUser`, `mdpUser`, `IdRole`) VALUES
(1, 'Dhaker', 'Maxance', 'Maxance@Bootstrap.com', '1010', 2),
(2, 'Poix', 'Martine', 'Martine.Poix@Afpa.fr', '1212', 1);

INSERT INTO `clients` (`IdUser`, `refClient`, `coefClient`, `IdCategorieClient`) VALUES
(1, '1234', 4, 1),
(2, '1325', 2, 2);

INSERT INTO `rubriques` (`IdRubrique`, `libelleRubrique`, `IdRubriqueMere`) VALUES
(1, 'Corde', 1),
(2, 'Vent ', 2),
(3, 'Percussion', 3);

INSERT INTO `reglements` (`IdReglement`, `typePaiement`) VALUES
(1, 'Cheque'),
(2, 'Carte Bleu'),
(3, 'Paypal'),
(4, 'Bitcoin');

INSERT INTO `commandes` (`IdCommande`, `NumeroCommande`, `dateCommande`, `IdUser`, `IdAdresse`) VALUES
(11, '12', '2021-12-21', 1, 1),
(12, '36', '2021-12-29', 2, 2);

INSERT INTO `progressionscommande` (`IdProgressionsCommande`, `IdCommande`, `IdEtatCommande`, `dateEtatCommande`) VALUES
(1, 11, 1, '2021-12-22'),
(2, 12, 3, '2021-12-28');

INSERT INTO `produits` (`IdProduit`, `libelleProduit`, `description`, `refProduit`, `prixHorsTaxe`, `photo`, `stock`, `IdRubrique`) VALUES
(1, 'Guitare', 'Une superbe guitare qui fait du bruit quand on la forte ', '12312', '149.9900', 'image de guitare', 10, 1),
(2, 'TamTam', 'Un tamtam antique fait par des vodou africain , fabriqué en chine ', '12521', '8.9900', 'image du tamtam', 9, 3),
(3, 'Trompette', 'La trompette de Louis Armstrong , 100% certifié par louis lui même après sa mort ', '15651', '999.9900', 'image Trompette', 1, 2);

INSERT INTO `approvisionnements` (`IdApprovisionnement`, `IdProduit`, `IdFournisseur`, `refFournisseur`) VALUES
(1, 3, 2, '15252'),
(2, 2, 1, '15252');

INSERT INTO `factures` (`IdFacture`, `IdReglement`, `IdCommande`, `datePaiement`, `montantPaiement`) VALUES
(1, 2, 11, '2021-12-20', '169.6600'),
(2, 4, 12, '2021-12-13', '125.9900');

INSERT INTO `historiquetva` (`IdHistoriqueTVA`, `IdProduit`, `IdTVA`, `dateTVA`) VALUES
(1, 3, 1, '2021-12-15'),
(2, 1, 2, '2021-12-30');

INSERT INTO `lignescommande` (`IdLigneCommande`, `IdProduit`, `IdCommande`, `quantiteProduit`) VALUES
(1, 2, 12, 4),
(2, 1, 11, 6);

INSERT INTO `livraisons` (`IdLivraison`, `IdCommande`, `IdAdresse`, `dateLivraison`, `quantiteLivraison`) VALUES
(1, 11, 1, '2021-12-23', 6),
(2, 12, 2, '2021-12-24', 7);


























