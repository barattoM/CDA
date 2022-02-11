<nav>
    <?php 
        if($_SESSION["utilisateur"]->getRole()==2){
            echo "<a href='index.php?page=ListeArticles'><div class=\"bouttonNav center\">Articles</div></a>
            <a href='index.php?page=ListeTypesArticles'><div class=\"bouttonNav center\">Types d'articles</div></a>
            <a href='index.php?page=ListePaniers'><div class=\"bouttonNav center\">Paniers</div></a>
            <a href='index.php?page=ListeUtilisateurs'><div class=\"bouttonNav center\">Clients</div></a>";
        }else{
            echo "<a href='index.php?page=ListeLignesPaniers&id=".$_SESSION["utilisateur"]->getIdUtilisateur()."'><div class=\"bouttonNav center\">Panier</div></a>";  
        }
    ?>


<a href='index.php?page=Catalogue'><div class="bouttonNav center">Catalogue</div></a>


</nav>