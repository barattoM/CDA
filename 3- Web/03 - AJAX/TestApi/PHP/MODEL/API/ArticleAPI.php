<?php
echo json_encode(creerSelect(null,"Articles",["LibelleArticle"],"",["IdCategorie"=>$_POST['idCateg']]));