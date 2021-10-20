A.	Requêtes simples

1.	Afficher les noms de département

select * from department;

2.	Afficher les numéros et noms de département

select nodep, nomdep from department;

3.	Afficher toutes les propriétés des employés

select * from employe

4.	Afficher les fonctions des employés

select fonction from employe

5.	Afficher les fonctions des employés sans double

select distinct fonction from employe

6.	Afficher les noms des employés avec leur date d embauche, ainsi que la date d embauche augmentée d une journée

select nomemp, datemb, ADDDATE(datemb, INTERVAL 1 DAY) from employe;

7.	Afficher les noms des employés suivis d un espace, suivi de leur fonction

select concat(nomemp, " ", fonction) from employe;


B.	Requêtes avec clause “where”

1.	Donner la liste des numéros et noms des employés du département 30

select noemp, nomemp from employe where nodep=30;

2.	Donner la liste des numéros et noms des ouvriers ainsi que leur numéro de département

select noemp, nomemp, nodep from employe where fonction="Ouvrier"

3.	Donner les noms et numéros des départements dont le numéro est supérieur ou égal à 30

select nomdep, nodep from departement where nodep>=30;

4.	Donner les noms, salaires et commissions des employés dont la commission excède le salaire

select nomemp, sala, comm from employe where sala<comm;

5.	Donner les noms et salaires des vendeurs du département 30 dont le salaire est supérieur à 1500 €

select nomemp, sala from employe where fonction="vendeur" and nodep=30 and sala>1500

6.	Donner la liste des noms, fonctions et salaires des directeurs et des présidents

select nomemp, fonction, sala from employe where fonction in ("directeur","president")

7.	Donner la liste des noms, fonctions et salaires des directeurs et des employés qui ont un salaire > 2500 €

select noemp, fonction, sala from employe where fonction="directeur" or sala>2500

8.	Donner la liste des noms, numéros de département des directeurs et des ouvriers du département 10

select nomemp, nodep from employe where fonction in ("directeur","ouvrier") and nodep=10

9.	Donner la liste des noms, fonctions et numéros de département des employés du département 10 qui ne sont ni ouvrier ni directeur

select nomemp, fonction, nodep from employe where nodep=10 and fonction not in ("directeur","ouvrier")

10.	Donner la liste des noms, fonctions et numéros de département des directeurs qui ne sont pas directeur dans le département 30



11.	Donner la liste des noms, fonctions et salaires des employés qui gagnent entre 1200 € et 1300 €



12.	Donner la liste des noms, numéros de département et fonctions des employés « ouvrier », « analyste » ou « vendeur »



13.	Donner les employés qui ne sont pas "vendeur"



14.	Donner la liste des employés dont la première lettre du nom est un "C"



15.	Donner la liste des employés qui n ont pas de commission



16.	Donner la liste des employés qui ont une commission et qui sont dans le département 30 ou 20



