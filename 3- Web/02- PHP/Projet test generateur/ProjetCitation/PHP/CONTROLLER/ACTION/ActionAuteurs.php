<?php
$elm = new Auteurs($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = AuteursManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = AuteursManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = AuteursManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeAuteurs");