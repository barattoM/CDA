<?php

// Gestion Catalogue ==> Liste Lignes de Paniers
$idUtilisateur=$_SESSION["utilisateur"]->getIdUtilisateur();
$panier=PaniersManager::getList(null,["IdClient"=>$idUtilisateur]);
if($panier == false){ //Si le client n'a pas de panier on lui en crée un
	PaniersManager::add(new Paniers(["IdClient"=>$idUtilisateur,"DatePanier"=>"2022-01-31","AdresseLivraison"=>"ChezMoi"]));
	LignesPaniersManager::add(new LignesPaniers(["IdArticle"=>$_GET["idArticle"],"IdPanier"=>PaniersManager::getList(null,["IdClient"=>$idUtilisateur])[0]->getIdPanier(),"Quantite"=>1]));
}else if(!$_GET['mode']){
	LignesPaniersManager::add(new LignesPaniers(["IdArticle"=>$_GET["idArticle"],"IdPanier"=>$panier[0]->getIdPanier(),"Quantite"=>1]));
}

if(isset($_GET['mode'])){
	$elm = new LignesPaniers($_POST);
	switch ($_GET['mode']) {
		case "Ajouter": {
			$elm = LignesPaniersManager::add($elm);
			break;
		}
		case "Modifier": {
			$elm = LignesPaniersManager::update($elm);
			break;
		}
		case "Supprimer": {
			$elm = LignesPaniersManager::delete($elm);
			break;
		}
	}
}
header("location:index.php?page=ListeLignesPaniers&id=".$idUtilisateur);