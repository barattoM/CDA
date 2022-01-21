<?php
$elm = new Citations($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = CitationsManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = CitationsManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = CitationsManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeCitations");