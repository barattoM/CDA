<?php
$elm = new TypesProduits($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = TypesProduitsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = TypesProduitsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = TypesProduitsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeTypesProduits");