<?php
$p = new Ville($_POST);
switch ($_GET['mode']) {
    case "ajoutVille":
        {
            //Ajout de la date maj

            $p->setDateMAJ(date("d/m/y"));
            VilleManager::add($p);
            break;
        }
    case "modifVille":
        {
            //Ajout de la date maj

            $p->setDateMAJ(date("d/m/y"));
            VilleManager::update($p);
            break;
        }
    case "delVille":
        {
            
            VilleManager::delete($p);
            break;
        }
}

header("location:index.php?codePage=listeVille");