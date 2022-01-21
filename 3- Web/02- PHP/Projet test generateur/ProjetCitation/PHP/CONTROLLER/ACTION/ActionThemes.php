<?php
$elm = new Themes($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = ThemesManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = ThemesManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = ThemesManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeThemes");