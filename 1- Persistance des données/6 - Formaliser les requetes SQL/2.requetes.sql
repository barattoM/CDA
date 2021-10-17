1. Rechercher le prénom des employés et le numéro de la région de leur département.

Select prenom, noregion from employe inner join dept on nodep=nodept;

2.Rechercher le numéro du département, le nom du département, le nom des employés classés par numéro de département (renommer les tables utilisées)

select nodept, d.nom as nomDepartement, e.nom as nomEmp from employe as e inner join dept as d on d.nodept = e.nodep order by d.nodept;

3.Rechercher le nom des employés du département Distribution. 

select e.nom from employe as e inner join dept as d on d.nodept = e.nodep where d.nom="distribution";

4.Rechercher le nom et le salaire des employés qui gagnent plus que leur patron, et le nom et le salaire de leur patron

select nom, salaire,(select nom from employe where noemp=e.nosup) as "nom supérieur", (select salaire from employe where noemp=e.nosup) as "salaire supérieur" from employe as e where salaire>(select salaire from employe where noemp=e.nosup);

5.Rechercher le nom et le titre des employés qui ont le même titre que Amartakaldire.

select nom, titre from employe where titre=(select titre from employe where nom="Amartakaldire");

6.Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus qu un seul employé du département 31, classés par numéro de département et salaire. 

select nom, salaire, nodep from employe where salaire>(select min(salaire) from employe where nodep=31) order by nodep ,salaire ;

7.Rechercher le nom, le salaire et le numéro de département des employés qui gagnent plus que tous les employés du département 31, classés par numéro de département et salaire. 

select nom, salaire, nodep from employe where salaire>(select max(salaire) from employe where nodep=31) order by nodep ,salaire ;

8.Rechercher le nom et le titre des employés du service 31 qui ont un titre que l on trouve dans le département 32.

select nom, titre from employe where nodep=31 and titre in (Select titre from employe where nodep=32);

9.Rechercher le nom et le titre des employés du service 31qui ont un titre l on ne trouve pas dans le département 32.

select nom, titre from employe where nodep=31 and titre not in (Select titre from employe where nodep=32);

10.Rechercher le nom, le titre et le salaire des employés qui ont le même titre et le même salaire que Fairent.

select nom,titre, salaire from employe where not nom="fairent" and titre=(select titre from employe where nom="fairent") and salaire=(select salaire from employe where nom="fairent");

11.Rechercher le numéro de département, le nom du département, le nom des employés, en affichant aussi les départements dans lesquels il n y a personne, classés par nuéro de département.

select nodept, d.nom, e.nom from employe as e right join dept as d on d.nodept = e.nodep order by nodept;

12.Calculer le nombre d employés de chaque titre.

select titre, count(*) from employe GROUP by titre;

13.Calculer la moyenne des salaires et leur somme, par région.

select noregion, avg(salaire) as "moyenne salaire", sum(salaire) as "somme salaire" from employe inner join dept on nodep=nodept group by noregion;

14.Afficher les numéros des départements ayant au moins 3 employés

select nodep from (select nodep,count(*)as nbEmploye from employe group by nodep) as e where e.nbEmploye>3;

15.Afficher les lettres qui sont l initiale d au moins trois employés.

select initiale from (select initiale,count(*) as totInitiale from (select LEFT(nom,1)as initiale from employe) as e group by initiale) as b where totInitiale>3

16.Rechercher le salaire maximum et le salaire minimum parmi tous les salariés et l écart entre les deux.

select min(salaire), max(salaire), (max(salaire)-min(salaire)) from employe;

17.Rechercher le nombre de titres différents. 

select count(distinct(titre)) from employe

18.Pour chaque titre, compter le nombre d employés possédant ce titre. 

select DISTINCT titre, count(*) from employe group by titre;

19.Pour chaque nom de département,afficher le nom du département et le nombre d employés.

select d.nom, count(e.noemp) from dept as d left join employe as e on nodept=nodep group by d.nom

20.Rechercher les titres et la moyenne des salaires par titre dont la moyenne est supérieure à la moyenne des salaires des Représentants.

select titre, avg(salaire) as "moyenneTitre" from employe group by titre having moyenneTitre>(select avg(salaire) from employe where titre="Représentant") ;

21.Rechercher le nombre de salaires renseignés et le nombre de taux de commission renseignés

select count(salaire), count(tauxcom) from employe