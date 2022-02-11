<?php

 echo '<main>';

 echo '<div class="flex-0-1"></div>';

 echo '<div class="colonne">';
 
 echo '<div class="center">'.texte("Catalogue").'</div>';
$types= TypesArticlesManager::getList();
//Création du template de la grid
echo '<div class="colonne center">';

foreach($types as $type){
    echo "<div>Type : ".$type->getLibelleTypeArticle()."</div>";
    $articles=ArticlesManager::getList(null,["IdTypeArticle"=>$type->getIdTypeArticle()]);
    echo "<div class=\"grid-col-2 gapCatalogue\">";
    
    foreach($articles as $article){
        echo '<div class="colonne center">
            <img src="./IMG/'.$article->getPhotos().'" alt="">
            <div>
                <div class="colonne">
                    <div>'.$article->getLibelleArticle().'</div>
                    <div>'.$article->getDescriptionArticle().'</div>
                </div>';
                if($_SESSION["utilisateur"]->getRole()==1){
                    echo '<a href="index.php?page=ActionLignesPaniers&idArticle='.$article->getIdArticle().'"><i class="fas fa-cart-plus self-center"></i></a>';
                }
        echo '</div>
        </div>';
        
    }

    echo "</div>";
}

echo "</div>"; //grid
echo "</div>"; 