<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = FiltreThemeManager::getList();
//Création du template de la grid
echo '<div class="grid-col-5 gridListe">';

echo '<div class="caseListe grid-columns-span-5">Liste des FiltreTheme </div>';
echo '<div class="caseListe grid-columns-span-5">
<div></div>
<div class="caseListe"><a href="index.php?page=FormFiltreTheme&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe">IdCitation</div>';
echo '<div class="caseListe">IdTheme</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe">'.$unObjet->getIdCitation().'</div>';
echo '<div class="caseListe">'.$unObjet->getIdTheme().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormFiltreTheme&mode=Afficher&id='.$unObjet->getIdFiltreTheme().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormFiltreTheme&mode=Modifier&id='.$unObjet->getIdFiltreTheme().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormFiltreTheme&mode=Supprimer&id='.$unObjet->getIdFiltreTheme().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-5">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';