<?php

include "Employe.php";
include "Agence.php";
include "Enfant.php";
$a1 = new Agence(["Nom" => "Agence 1", "adresse" => "25 rue des champignons","restauration" => true ,"codePostal" => "48456" , "ville" => "Dunkerque"]);
$a2 = new Agence(["Nom" => "Agence 2", "adresse" => "3 boulevard des canard","restauration" =>true ,"codePostal" => "87687", "ville" => "Marseille"]);
$a3 = new Agence(["Nom" => "Agence 3", "adresse" => "42 avenue de la lune","restauration" =>false ,"codePostal" => "34354", "ville" => "Tanbouctou"]);

$en1 = new Enfant(["Nom" => "toto", "Prenom" => "truc", "Age" => 20]);
$en2 = new Enfant(["Nom" => "titi", "Prenom" => "machin", "Age" => 12]);
$en3 = new Enfant(["Nom" => "tata", "Prenom" => "Albert", "Age" => 18]);
$en4 = new Enfant(["Nom" => "tutu", "Prenom" => "machintruc", "Age" => 14]);
$en5 = new Enfant(["Nom" => "tyty", "Prenom" => "jesaispas", "Age" => 9]);

$e1=new Employe(["nom"=>"Dupond","prenom"=>"toto","dateEmbauche"=>new DateTime("2000-01-01"),"salaire"=>1000,"poste"=>"Balayeur","service"=>"Entretient","agence"=>$a1,"enfants"=>[$en4,$en2]]);
$e2=new Employe(["nom"=>"Thacker","prenom"=>"Maxence","dateEmbauche"=>new DateTime("2018-01-01"),"salaire"=>-100,"poste"=>"Testeur de weed","service"=>"Toxicologie","agence"=>$a3,"enfants"=>[$en1]]);
$e3=new Employe(["nom"=>"Courquin","prenom"=>"Pierre","dateEmbauche"=>new DateTime("1969-01-01"),"salaire"=>50,"poste"=>"Arracheur de cable","service"=>"Routier","agence"=>$a2,"enfants"=>[$en4,$en5]]);
$e4=new Employe(["nom"=>"Balair","prenom"=>"Quentin","dateEmbauche"=>new DateTime("1999-01-01"),"salaire"=>1200,"poste"=>"Fournisseur de foie gras","service"=>"Agro-alimentaire","agence"=>$a2,"enfants"=>[$en3,$en2]]);
$e5=new Employe(["nom"=>"Mayeux","prenom"=>"Bruno","dateEmbauche"=>new DateTime("2005-01-01"),"salaire"=>20000,"poste"=>"PDG","service"=>"Direction","agence"=>$a1]);

$listeEmploye=[$e1,$e2,$e3,$e4,$e5];
echo "Nombre d'employés : ".count($listeEmploye);
//var_dump($listeEmploye);
usort($listeEmploye,array("Employe","compareToNomPrenom"));
//var_dump($listeEmploye);
usort($listeEmploye,array("Employe","compareToServiceNomPrenom"));
//var_dump($listeEmploye);

// foreach($listeEmploye as $elt){
//     echo $elt->masseSalariale()."<br>";
// }
foreach($listeEmploye as $elt){
    echo $elt->toString();
}

