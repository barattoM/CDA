<?php
$elm = new Utilisateurs($_POST);
if(isset($_POST["Nom"]) && isset($_POST["Prenom"])){
	$elm->setMotDePasse(crypte($_POST["Nom"].$_POST["Prenom"]));
}
$elm->setRole(1);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = UtilisateursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = UtilisateursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$panier=PaniersManager::getList(null,["IdClient"=>$elm->getIdUtilisateur()]);
		if($panier!=false){
			$lignes=LignesPaniersManager::getList(null,["IdPanier"=>$panier[0]->getIdPanier()]);
			//On supprime les lignes du panier
			foreach($lignes as $ligne){
				LignesPaniersManager::delete($ligne);
			}
			//On supprime le panier
			PaniersManager::delete($panier[0]);
		}
	
		$elm = UtilisateursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeUtilisateurs");