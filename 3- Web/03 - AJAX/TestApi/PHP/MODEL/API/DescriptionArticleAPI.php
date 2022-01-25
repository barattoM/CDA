<?php

echo json_encode(ArticlesManager::findById($_POST['idArticle']));