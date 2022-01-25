<?php
global $regex;
$mode = $_GET['mode'];
$disabled = " ";
switch ($mode) {
	case "Afficher":
	case "Supprimer":
		$disabled = " disabled ";
		break;
}

if (isset($_GET['id'])) {
	$elm = ArticlesManager::findById($_GET['id']);
} else {
	$elm = new Articles();
}
echo '<main class="center">';

echo '<form class="GridForm" action="index.php?page=ActionArticles&mode='.$_GET['mode'].'" method="post"/>';

echo '<div class="caseForm col-span-form">Formulaire Articles</div>';
	echo '<div class="noDisplay"><input type="hidden" value="'.$elm->getIdArticle().'" name=IdArticle></div>';
echo '<label for=LibelleArticle class="caseForm">'.texte("LibelleArticle").'</label>';
echo '<div class="caseForm"><input type="text" '.$disabled .'value="'.$elm->getLibelleArticle().'" name=LibelleArticle pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=QuantiteStockee class="caseForm">'.texte("QuantiteStockee").'</label>';
echo '<div class="caseForm"><input type="text" '.$disabled .'value="'.$elm->getQuantiteStockee().'" name=QuantiteStockee pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<label for=IdCategorie class="caseForm">'.texte("IdCategorie").'</label>';
echo '<div class="caseForm"><input type="text" '.$disabled .'value="'.$elm->getIdCategorie().'" name=IdCategorie pattern="'.$regex["*"].'"></div>';
echo '<div class="caseForm"><i class="fas fa-question-circle"></i></div>';
echo '<div class="caseForm"><i class="fas fa-check-circle"></i></div>';

echo '<div class="caseForm col-span-form">
	<div></div>
	<div><a href="index.php?page=ListeArticles"><button type="button"><i class="fas fa-sign-out-alt fa-rotate-180"></i></button></a></div>
	<div class="flex-0-1"></div>';
	echo ($mode == "Afficher") ? "" : " <div><button type=\"submit\"><i class=\"fas fa-paper-plane\"></i></button></div>";
	echo'<div></div>
	</div>';

echo'</form>';

echo '</main>';