<?php
$elm = new Pays($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = PaysManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = PaysManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = PaysManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListePays");