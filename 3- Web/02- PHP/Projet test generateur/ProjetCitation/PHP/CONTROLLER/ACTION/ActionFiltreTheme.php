<?php
$elm = new FiltreTheme($_POST);

switch ($_GET['mode']) {
	case "Ajouter": {
		$elm = FiltreThemeManager::add($elm);
		break;
	}
	case "Modifier": {
		$elm = FiltreThemeManager::update($elm);
		break;
	}
	case "Supprimer": {
		$elm = FiltreThemeManager::delete($elm);
		break;
	}
}

header("location:index.php?page=ListeFiltreTheme");