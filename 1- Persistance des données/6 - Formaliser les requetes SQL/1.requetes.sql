1- Afficher toutes les informations concernant les employé

SELECT * FROM employe ;

2- Afficher toutes les informations concernant les départements

SELECT * FROM dept ;

3-Afficher le nom, la date d embauche ,le numero du supérieur, le numéro de départements et le salaire de tous les employés

SELECT nom, dateemb, nosup, nodep, salaire FROM employe ;

4- Afficher le titre de tous les employés

SELECT titre from employe ;

5- Afficher les différentes valeurs des titres des employés

SELECT DISTINCT titre from employe ;

6. Afficher le nom, le numéro d employé et le numéro du département des employés dont le titre est «Secrétaire».

SELECT nom, noemp, nodep FROM employe where titre="Secrétaire";

7. Afficher le nom et le numéro de département dont le numéro de département est supérieur à 40

SELECT nom, nodept From dept Where nodept>40;

8.Afficher le nom et le prénom des employés dont le nom est alphabétiquement antérieur au prénom.

SELECT nom, prenom from employe where nom<prenom;

9.Afficher le nom, le salaire et le numéro du département des employés dont le titre est «Représentant», le numéro de département est 35et le salaire est supérieur à 20000.

SELECT nom, salaire, nodep from employe where titre="Représentant" and nodep=35 and salaire>20000;

10.Afficher le nom, le titre et le salaire des employés dont le titre est «Représentant» ou dont le titre est «Président».

SELECT nom, titre, salaire from employe where titre="Représentant" or titre="Président";

11.Afficher le nom, le titre, le numéro de département, le salaire des employés du département 34, dont le titre est «Représentant» ou «Secrétaire». 

SELECT nom,titre,nodep,salaire from employe where nodep=34 and (titre="Représentant" or titre="Secrétaire");

12.Afficher le nom, le titre, le numéro de département, le salaire des employés dont le titre est Représentant, ou dont le titre est Secrétaire dans le département numéro 34. 

SELECT nom,titre,nodep,salaire from employe where titre="Représentant" or (titre="Secrétaire" and nodep=34);

13.Afficher le nom, et le salaire des employés dont le salaire est compris entre 20000et 30000.

SELECT nom,salaire from employe where salaire BETWEEN 20000 and 30000;

15.Afficher le nom des employés commençant par la lettre «H». 

SELECT nom from employe where nom LIKE "H%";

16.Afficher le nom des employés se terminant par la lettre «n». 

SELECT nom from employe where nom LIKE "%n";

17.Afficher le nom des employés contenant la lettre «u» en 3èmeposition. 

SELECT nom from employe where subString(nom,3,1)="u";

18.Afficher le salaire et le nom des employés du service 41classés par salaire croissant. 

SELECT salaire, nom from employe where nodep=41 ORDER by salaire;

19.Afficher le salaire et le nom des employés du service 41classés par salaire décroissant. 

SELECT salaire ,nom from employe where nodep=41 ORDER by salaire DESC;

20.Afficher le titre, le salaire et le nom des employés classés par titre croissant et par salaire décroissant. 

Select titre, salaire, nom from employe order by titre , salaire DESC;

21.Afficher le taux de commission, le salaire et le nom des employés classés par taux de commission croissante.

Select tauxcom, salaire, nom from employe order by tauxcom;

22.Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission n est pas renseigné. 

SELECT nom, salaire,tauxcom, titre from employe where tauxcom is NULL;

23.Afficher le nom, le salaire, le taux de commission et le titre des employés dont le taux de commission est renseigné.

SELECT nom, salaire, tauxcom, titre from employe where tauxcom is not null;

24.Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est inférieur à 15. 

select nom, salaire, tauxcom, titre from employe where tauxcom<15;

25.Afficher le nom, le salaire, le taux de commission, le titre des employés dont le taux de commission est supérieur à 15

select nom, salaire, tauxcom, titre from employe where tauxcom>15;

26.Afficher le nom, le salaire, le taux de commission et la commission des employés dont le taux de commission n est pas nul.(la commission est calculée en multipliant le salaire par le taux de commission)

select nom, salaire, tauxcom ,(salaire*tauxcom) as commission from employe where tauxcom is not null;

27.Afficher le nom, le salaire, le taux de commission, la commission des employés dont le taux de commission n est pas nul, classé par taux de commission croissant. 

select nom, salaire, tauxcom, (salaire*tauxcom) as commission from employe where tauxcom is not null ORDER by commission;

28. Afficher le nom et le prénom (concaténés) des employés. Renommer les colonnes

SELECT concat(nom, " ", prenom ) as nomEmploye from employe;

29.Afficher les 5 premières lettres du nom des employés. 

select subString(nom,1,5) from employe;

30. Afficher le nom et le rang de la lettre«r» dans le nom des employés. 

select nom, Locate("r",nom) from employe;

31. Afficher le nom, le nom en majuscule et le nom en minuscule de l employé dont le nom est Vrante

select nom, upper(nom), lower(nom) from employe where nom="Vrante";

32.Afficher le nom et le nombre de caractères du nom des employés. 

select nom, length(nom) from employe;