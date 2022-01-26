<?php

echo json_encode(ArticlesManager::getList(["LibelleArticle","QuantiteStockee"],["IdArticle"=>$_POST['idArticle']],null,null,true));