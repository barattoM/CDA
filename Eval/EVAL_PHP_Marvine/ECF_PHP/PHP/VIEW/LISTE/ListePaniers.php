<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div class="colonne">';
 

$objets = PaniersManager::getList();

if($objets==false){
	echo '<div class="center">Pas de panier en cours</div>';
}else{
	echo '<div class="grid-col-2">
			<div class="center">Client</div>
			<div class="center">Nombre d\'articles</div>
	';
	foreach($objets as $objet){
		$client=UtilisateursManager::findById($objet->getIdClient());
		echo '<div class="center">'.$client->getNom().' '.$client->getPrenom().'</div>';
		$articles=LignesPaniersManager::getList(null,["IdPanier"=>$objet->getIdPanier()]);
		$quantiteTotale=0;
		foreach($articles as $article){
			$quantiteTotale+=$article->getQuantite();
		}
		echo '<div class="center">'.$quantiteTotale.'</div>';
	}

	echo '</div>';
}

echo "<div>";
echo '	<div></div>
		<div><a href="index.php?page=Catalogue"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
		<div></div>';
echo "</div>";

echo'</div>'; //Div
echo '<div class="flex-0-1"></div>';
echo '</main>';