<?php
$elm = new Commandes($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = CommandesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = CommandesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = CommandesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeCommandes");