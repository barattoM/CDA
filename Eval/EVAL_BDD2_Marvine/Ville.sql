1.	Obtenir la liste des villes qui ont un nom d''au moins 40 lettres

SELECT * 
FROM villes_france 
WHERE LENGTH(ville_nom_reel)>40

2.	Obtenir la liste des départements d’outre-mer, c’est-à-dire ceux dont le numéro de département commence par “97”

SELECT * 
FROM departements 
WHERE departement_code LIKE "97%";

3.	Obtenir la liste des départements des Hauts-de-France trier par ordre alphabétique des noms de département (sans jointure)

SELECT * 
FROM departements 
where departement_regionId=(SELECT region_id FROM regions WHERE region_nom="Hauts-de-France")
order by departement_nom;

4.	Obtenir le nom de toutes les villes, ainsi que le nom du département associé. Les plus peuplées en 2012 apparaitront en premier

SELECT ville_nom_reel,departement_nom

FROM villes_france 

INNER JOIN departements ON ville_departement=departement_id

order by ville_population_2012 DESC

5.	Obtenir la liste du nom de chaque département, associé à son code et du nombre de commune au sein de ces départements, en triant afin d’obtenir en priorité les départements qui possèdent le plus de communes

SELECT departement_nom, departement_code, count(Distinct ville_commune) as nbCommune

FROM departements

LEFT JOIN villes_france ON ville_departement=departement_id

GROUP BY departement_nom

ORDER BY nbCommune DESC ;

6.	Obtenir la liste des départements, classés en fonction de leur superficie (plus grand en premier)

SELECT departement_nom, SUM(ville_surface) as superficie

FROM departements

INNER JOIN villes_france ON ville_departement=departement_id

GROUP BY departement_nom

ORDER BY superficie DESC;

7.	Compter le nombre de villes dont le nom commence par “Saint”

SELECT count(*)

FROM villes_france

WHERE ville_nom_reel LIKE 'Saint%';


8.	Obtenir la liste des villes qui ont un nom existants plusieurs fois, et trier afin d’obtenir en premier celles dont le nom est le plus souvent utilisé par plusieurs communes

SELECT ville_nom_reel, count(*) as nbVilleMemeNom

FROM villes_france

GROUP BY ville_nom_reel

HAVING nbVilleMemeNom>1

ORDER BY nbVilleMemeNom DESC ;

9.	Obtenir en une seule requête SQL la liste des villes dont la superficie est supérieure à la superficie moyenne

SELECT ville_nom_reel, ville_surface

FROM villes_france

WHERE ville_surface>(SELECT AVG(ville_surface) FROM villes_france);

10.	Obtenir la liste des départements qui possèdent plus de 1.5 millions d’habitants en 2012

SELECT departement_nom, SUM(ville_population_2012) as habitants

FROM departements 

INNER JOIN villes_france ON ville_departement=departement_id

GROUP BY departement_nom

HAVING habitants>1500000;


11.	Remplacez les tirets par un espace vide, pour toutes les villes commençant par “SAINT-” (dans la colonne qui contient les noms en majuscule)

SELECT REPLACE(ville_nom,"-"," ")

FROM villes_france

WHERE ville_nom like "SAINT-%";

12.	Supplémentaire. Obtenir la liste des 50 villes ayant la plus faible superficie

SELECT ville_nom_reel, ville_surface

FROM villes_france

ORDER BY ville_surface ASC 
Limit 50 ;

13.	Ajouter une colonne region_nbDepartement dans la table regions (mettre le code dans le script de réponse)

ALTER TABLE regions ADD region_nbDepartement INT;

14.	Ecrire une procédure stockée (nommée MajRegion), qui vient mettre à jour cette colonne

DELIMITER $

CREATE PROCEDURE MajRegion()
BEGIN

	/* update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=1 ) WHERE region_id=1;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=2 ) WHERE region_id=2;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=3 ) WHERE region_id=3;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=4 ) WHERE region_id=4;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=5 ) WHERE region_id=5;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=6 ) WHERE region_id=6;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=7 ) WHERE region_id=7;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=8 ) WHERE region_id=8;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=9 ) WHERE region_id=9;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=10 ) WHERE region_id=10;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=11 ) WHERE region_id=11;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=12 ) WHERE region_id=12;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=13 ) WHERE region_id=13;
    update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=14 ) WHERE region_id=14; */

    DECLARE i INT DEFAULT 0;
    label1: LOOP
        SET i=i+1;
        update regions set region_nbDepartement=(SELECT COUNT(*) FROM departements WHERE departement_regionId=i ) WHERE region_id=i;
        IF i = 14 THEN 
            LEAVE label1;
        END IF;
    END LOOP label1;
END
$
DELIMITER ;

15.	Créer une vue qui regroupe les 3 tables

CREATE VIEW Villes 
AS 
SELECT 
region_id,
region_nom,
departement_id,
departement_code,
departement_nom,
departement_nom_uppercase,
departement_slug,
departement_nom_soundex,
ville_id,
ville_slug,
ville_nom,
ville_nom_simple,
ville_nom_reel,
ville_nom_soundex,
ville_nom_metaphone,
ville_code_postal,
ville_commune,
ville_code_commune,
ville_arrondissement,
ville_canton,
ville_amdi,
ville_population_2010,
ville_population_1999,
ville_population_2012,
ville_densite_2010,
ville_surface,
ville_longitude_deg,
ville_latitude_deg,
ville_longitude_grd,
ville_latitude_grd,
ville_longitude_dms,
ville_latitude_dms,
ville_zmin,
ville_zmax
FROM regions
INNER JOIN departements ON region_id=departement_regionId
INNER JOIN villes_france ON ville_departement=departement_id