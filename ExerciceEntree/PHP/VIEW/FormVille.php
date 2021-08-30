<?php
$mode = $_GET['mode'];

echo '<div id="DivSousTitre">';

//en fonction du mode, on modifie l'entet du form
switch ($mode) {
    case "ajout":
        {
            echo '<h5>Ajouter une nouvelle ville</h5></div>
	<form id="formulaire" method="post" action="index.php?codePage=actionVille&mode=ajoutVille">';
            // Quand le formulaire sera soumit par clic sur le bouton, les informations qu il contient seront stockées dans la variable $_POST, parce que la methode post a été sélectionnée
            break;
        }
    case "edit":
        {
            echo '<h5>Editer une ville</h5></div>
	<form id="formulaire" method="post" >';
            // Quand le formulaire sera soumit par clic sur le bouton, les informations qu il contient seront stockées dans la variable $_POST, parce que la methode post a été sélectionnée
            break;
        }
    case "modif":
        {
            echo '<h5>Modifier une ville</h5></div>
	<form id="formulaire" method="post" action="index.php?codePage=actionVille&mode=modifVille">';
            // Quand le formulaire sera soumit par clic sur le bouton, les informations qu il contient seront stockées dans la variable $_POST, parce que la methode post a été sélectionnée
            break;
        }
    case "delete":
        {
            echo '<h5>Supprimer une ville</h5></div>
	<form id="formulaire" method="post" action="index.php?codePage=actionVille&mode=delVille">';
            // Quand le formulaire sera soumit par clic sur le bouton, les informations qu il contient seront stockées dans la variable $_POST, parce que la methode post a été sélectionnée
            break;
        }
}
if (isset($_GET['id'])) {
    $ville = VilleManager::findById($_GET['id']);
}

// on crée les inputs du formulaire
// il faut que les name des input correspondent aux attributs de la class
// si on a les informations (cas edit, modif, supp) on les mets à jour
?>
<input type="hidden" name="idVille" <?php if (isset($ville)) echo 'value="'.$ville->getIdVille().'"'; ?>>

<div class="ligneDetail">
    <div class="libelleInput"> Nom :</div>
    <div class="input"> <input type="text" pattern="[a-zA-Z \-]{1,}" name="nomVille"
            <?php if (isset($ville)) echo 'value="'.$ville->getNomVille().'"'; if ($mode=="delete" || $mode=="edit") echo 'disabled';  ?>></div>
</div>

<div class="ligneDetail">
    <div class="libelleInput">
        Numéro du département :</div>
    <div class="input"> <input type="number" name="numeroDepartement" <?php if (isset($ville)) echo 'value="'.$ville->getNumeroDepartement().'"'; if ($mode=="delete" || $mode=="edit") echo 'disabled';?>>
    </div>
</div>

<div class="ligneDetail">
    <div class="libelleInput">
        Code postal :</div>
    <div class="input">
        <input type="number" name="codePostal"
            <?php if (isset($ville)) echo 'value="'.$ville->getCodePostal().'"'; if ($mode=="delete" || $mode=="edit") echo 'disabled';?>>
    </div>
</div>

<?php

if($mode!="ajout"){
    echo '
    <div class="ligneDetail">
        <div class="libelleInput">Date de mise à jour :</div>
        <div class="input">
            <input type="text" name="dateMAJ"'; if (isset($ville)) echo 'value="'.$ville->getDateMAJ().'"'; echo 'disabled';echo'>
        </div>
    </div>';
}




// en fonction du mode, on affiche les boutons utiles
	switch ($mode) {
		case "ajout":
			{
				echo '<div class="ligneDetail"><input type="submit" value="Ajouter" class=" crudBtn crudBtnEdit"/>'; break;
			}
		case "modif":
			{
				echo '<div class="ligneDetail"><input type="submit" value="Modifier" class=" crudBtn crudBtnModif"/>'; break;
			}
		case "delete":
			{
				echo '<div class="ligneDetail"><input type="submit" value="Supprimer" class=" crudBtn crudBtnSuppr" />'; break;
			}
        
        default:
        {
            echo '<div class="ligneDetail">';
        }
    }
// dans tous les cas, on met le bouton annuler
    ?>
    <a href="index.php?codePage=listeVille" class=" crudBtn crudBtnRetour">Annuler</a>
</div>

</form>
