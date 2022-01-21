<?php

include "./PHP/CONTROLLER/Outils.php";

spl_autoload_register("ChargerClasse");

Parametres::init();

DbConnect::init();

session_start();

/******Les langues******/
/***On récupère la langue***/
if (isset($_GET['lang']) && TextesManager::checkIfLangExist($_GET['lang'])) {
	 // tester si la langue est gérée
	$_SESSION['lang'] = $_GET['lang'];
}else if (isset($_COOKIE['lang'])) {
	$_SESSION['lang'] = $_COOKIE['lang'];
}else{
	$_SESSION['lang'] = 'FR';
}
//Crée un cookie lang sur la machine de l'utilisateur d'une durée de 10h.
setcookie("lang", $_SESSION['lang'], time()+36000, '/');
/******Fin des langues******/

$routes=[
	"Default"=>["PHP/VIEW/FORM/","FormInscriptionConnexion","Connexion & Inscription",0,false],
	"Accueil"=>["PHP/VIEW/GENERAL/","Accueil","Accueil",0,false],

	"ActionConnexion"=>["PHP/CONTROLLER/ACTION/","ActionConnexion","Action de la connexion",0,false],
	"ActionInscription"=>["PHP/CONTROLLER/ACTION/","ActionInscription","Action de l'inscription",0,false],
	"ActionDeconnexion"=>["PHP/CONTROLLER/ACTION/","ActionDeconnexion","Action de deconnexion",0,false],

	"ListeMailAPI"=>["PHP/MODEL/API/","ListeMailAPI", "ListeMailAPI",0,true],

	"ListeAuteurs"=>["PHP/VIEW/LISTE/","ListeAuteurs","Liste Auteurs",0,false],
	"FormAuteurs"=>["PHP/VIEW/FORM/","FormAuteurs","Formulaire Auteurs",0,false],
	"ActionAuteurs"=>["PHP/CONTROLLER/ACTION/","ActionAuteurs","Action Auteurs",0,false],

	"ListeCitations"=>["PHP/VIEW/LISTE/","ListeCitations","Liste Citations",0,false],
	"FormCitations"=>["PHP/VIEW/FORM/","FormCitations","Formulaire Citations",0,false],
	"ActionCitations"=>["PHP/CONTROLLER/ACTION/","ActionCitations","Action Citations",0,false],

	"ListeFiltreTheme"=>["PHP/VIEW/LISTE/","ListeFiltreTheme","Liste FiltreTheme",0,false],
	"FormFiltreTheme"=>["PHP/VIEW/FORM/","FormFiltreTheme","Formulaire FiltreTheme",0,false],
	"ActionFiltreTheme"=>["PHP/CONTROLLER/ACTION/","ActionFiltreTheme","Action FiltreTheme",0,false],

	"ListePays"=>["PHP/VIEW/LISTE/","ListePays","Liste Pays",0,false],
	"FormPays"=>["PHP/VIEW/FORM/","FormPays","Formulaire Pays",0,false],
	"ActionPays"=>["PHP/CONTROLLER/ACTION/","ActionPays","Action Pays",0,false],

	"ListeThemes"=>["PHP/VIEW/LISTE/","ListeThemes","Liste Themes",0,false],
	"FormThemes"=>["PHP/VIEW/FORM/","FormThemes","Formulaire Themes",0,false],
	"ActionThemes"=>["PHP/CONTROLLER/ACTION/","ActionThemes","Action Themes",0,false],

	"ListeUtilisateurs"=>["PHP/VIEW/LISTE/","ListeUtilisateurs","Liste Utilisateurs",0,false],
	"FormUtilisateurs"=>["PHP/VIEW/FORM/","FormUtilisateurs","Formulaire Utilisateurs",0,false],
	"ActionUtilisateurs"=>["PHP/CONTROLLER/ACTION/","ActionUtilisateurs","Action Utilisateurs",0,false],

];

if(isset($_GET["page"]))
{

	$page=$_GET["page"];

	if(isset($routes[$page]))
	{
		AfficherPage($routes[$page]);
	}
	else
	{
		AfficherPage($routes["Default"]);
	}
}
else
{
	AfficherPage($routes["Default"]);
}