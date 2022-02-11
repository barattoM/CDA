<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div>';
 

$objets = CommandesManager::getList();
//Création du template de la grid
echo '<div class="grid-col-8 gridListe">';

echo '<div class="caseListe titreListe grid-columns-span-8">Liste des Commandes </div>';
echo '<div class="caseListe grid-columns-span-8">
<div></div>
<div class="caseListe"><a href="index.php?page=FormCommandes&mode=Ajouter"><i class="fas fa-plus"></i></a></div>
<div></div>
</div>';

echo '<div class="caseListe labelListe">IdClient</div>';
echo '<div class="caseListe labelListe">IdArticle</div>';
echo '<div class="caseListe labelListe">DateCommande</div>';
echo '<div class="caseListe labelListe">QuantiteCommande</div>';
echo '<div class="caseListe labelListe">Cde_total</div>';

//Remplissage de div vide pour la structure de la grid
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';
echo '<div class="caseListe"></div>';

// Affichage des ennregistrements de la base de données
foreach($objets as $unObjet)
{
echo '<div class="caseListe donneeListe">'.$unObjet->getIdClient().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getIdArticle().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getDateCommande().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getQuantiteCommande().'</div>';
echo '<div class="caseListe donneeListe">'.$unObjet->getCde_total().'</div>';
echo '<div class="caseListe"> <a href="index.php?page=FormCommandes&mode=Afficher&id='.$unObjet->getIdCommande().'"><i class="fas fa-file-contract"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormCommandes&mode=Modifier&id='.$unObjet->getIdCommande().'"><i class="fas fa-pen"></i></a></div>';
                                                    
echo '<div class="caseListe"> <a href="index.php?page=FormCommandes&mode=Supprimer&id='.$unObjet->getIdCommande().'"><i class="fas fa-trash-alt"></i></a></div>';
}
//Derniere ligne du tableau (bouton retour)
echo '<div class="caseListe grid-columns-span-8">
	<div></div>
	<a href="index.php?page=Accueil"><button><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a>
	<div></div>
</div>';

echo'</div>'; //Grid
echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';