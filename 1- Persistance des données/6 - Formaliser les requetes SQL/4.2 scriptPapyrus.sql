1. Quelles sont les commandes du fournisseur 09120 ?

select e.* from entcom as e inner join fournis on e.numfou=fournis.numfou where fournis.numfou=09120

2. Afficher le code des fournisseurs pour lesquels des commandes ont été passées.

select distinct f.numfou from fournis as f inner join entcom as e on f.numfou=e.numfou

3. Afficher le nombre de commandes fournisseurs passées, et le nombre de fournisseur concernés.

select count(*),count(distinct(numfou)) from entcom

4. Editer les produits ayant un stock inférieur ou égal au stock d alerte et dont la quantité annuelle est inférieur est inférieure à 1000(informations à fournir : n° produit, libellé produit, stock, stock actuel d alerte, quantité annuelle)

update produit set ... where stkphy<=stkale and qteann<1000

5. Quels sont les fournisseurs situés dans les départements 75 78 92 77 ? L’affichage (département, nom fournisseur) sera effectué par département décroissant, puis par ordre alphabétique

select numfou from fournis where substring(posfou,1,2) in (75,78,92,77)

6. Quelles sont les commandes passées au mois de mars et avril ?

select numcom from entcom where Month(datcom) in (03,04)

7. Quelles sont les commandes du jour qui ont des observations particulières ?(Affichage numéro de commande, date de commande)

select numcom, datcom from entcom where obscom <> "";

8. Lister le total de chaque commande par total décroissant (Affichage numéro de commande et total)

SELECT numcom, SUM(qtecde*priuni) as total FROM ligcom GROUP BY numcom order by total DESC;

9. Lister les commandes dont le total est supérieur à 10 000€ ; on exclura dans le calcul du total les articles commandés en quantité supérieure ou égale à 1000. (Affichage numéro de commande et total)

SELECT numcom, SUM(qtecde*priuni) as total FROM ligcom WHERE qtecde<1000 GROUP BY numcom having total>10000;

10.Lister les commandes par nom fournisseur (Afficher le nom du fournisseur, le numéro de commande et la date)

Select  nomfou, e.numcom, e.datcom from entcom as e inner join fournis as f on e.numfou=f.numfou order by nomfou;

11.Sortir les produits des commandes ayant le mot urgent en observation? (Afficher le numéro de commande, le nom du fournisseur, le libellé du produit et le sous total = quantité commandée * Prix unitaire)

select e.numcom, nomfou, libart, qtecde*priuni from fournis as f inner join entcom as e on f.numfou=e.numfou inner join ligcom as l on l.numcom=e.numcom inner join produit as p on p.codart=l.codart where obscom="Commande urgente";

12.Coder de 2 manières différentes la requête suivante : Lister le nom des fournisseurs susceptibles de livrer au moins un article

SELECT fournis.numfou FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart WHERE stkphy > 0 GROUP BY fournis.numfou
SELECT numfou FROM (SELECT fournis.numfou, stkphy as stock FROM fournis INNER JOIN vente ON fournis.numfou = vente.numfou INNER JOIN produit ON vente.codart = produit.codart) as e WHERE stock > 0 GROUP BY numfou

13.Coder de 2 manières différentes la requête suivante Lister les commandes (Numéro et date) dont le fournisseur est celui de la commande 70210 :

Select numcom, datcom From entcom as e inner join fournis as f on f.numfou=e.numfou  where e.numfou=(Select numfou from entcom where numcom=70210);

14.Dans les articles susceptibles d’être vendus, lister les articles moins chers (basés sur Prix1) que le moins cher des rubans (article dont le premier caractère commence par R). On affichera le libellé de l’article et prix1

SELECT libart, prix1 from vente as v inner join produit as p on v.codart=p.codart where prix1<(SELECT MIN(prix1) from vente where codart like "R%") and stkphy>0;

15.Editer la liste des fournisseurs susceptibles de livrer les produits dont le stock est inférieur ou égal à 150 % du stock d alerte. La liste est triée par produit puis fournisseur

select numfou, v.codart from vente as v INNER JOIN produit as p on p.codart=v.codart where stkphy<=(stkale*1.5) order by codart, numfou;

16.Éditer la liste des fournisseurs susceptibles de livrer les produit dont le stock est inférieur ou égal à 150 % du stock d alerte et un délai de livraison d au plus 30 jours. La liste est triée par fournisseur puis produit

select numfou, v.codart from vente as v INNER JOIN produit as p on p.codart=v.codart where stkphy<=(stkale*1.5) and delliv<=30 order by codart, numfou;

17.Avec le même type de sélection que ci-dessus, sortir un total des stocks par fournisseur trié par total décroissant

select numfou, sum(stkphy) as totalStock from vente as v INNER JOIN produit as p on p.codart=v.codart group by numfou order by totalStock desc;

18.En fin d année, sortir la liste des produits dont la quantité réellement commandée dépasse 90% de la quantité annuelle prévue.

Select libart, sum(qtecde) as totalCommande, qteann from produit as p inner join ligcom as l on l.codart=p.codart group by libart having totalCommande>(qteann*0.9);

19.Calculer le chiffre d affaire par fournisseur pour l année 93 sachant que les prix indiqués sont hors taxes et que le taux de TVA est 20%.

SELECT numfou, SUM(qtecde*priuni*0.2) as total FROM ligcom as l inner join entcom as e on e.numcom=l.numcom where YEAR(datcom)=2018 group by numfou; 

1. Application d une augmentation de tarif de 4% pour le prix 1, 2% pour le prix2 pour le fournisseur 9180

update vente set prix1=prix1+prix1*0.04, prix2=prix2+prix2*0.02 where numfou=9180;

2. Dans la table vente, mettre à jour le prix2 des articles dont le prix2 est null, en affectant a valeur de prix.

update vente set prix2=prix1 where prix2=0;

3. Mettre à jour le champ obscom en positionnant '*****' pour toutes les commandes dont le fournisseur a un indice de satisfaction <5

update entcom set obscom="*****" where numfou in (select numfou from fournis where satisf<5)

4. Suppression du produit I110

Delete from produit where codart="I110"

5. Suppression des entête de commande qui n ont aucune ligne

delete from entcom where numcom not in (Select distinct numcom from ligcom)