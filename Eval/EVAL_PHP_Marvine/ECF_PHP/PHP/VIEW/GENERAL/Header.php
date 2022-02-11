<body class="colonne">
    <header>
        <div class="demi"></div>
        <div class="demi"><img src="./IMG/logo.jpg" alt=""></div>
        <div class="titre center color1"><?php echo texte($titre); ?></div>
        <div class="colonne">
            <?php

            if (isset($_SESSION['utilisateur'])) {
                echo '<div class="center">'. texte('Bonjour') ." ". $_SESSION['utilisateur']->getNom() . '</div>';
                echo '<div><a href="index.php?page=ActionDeconnexion" class="center">'. texte("Deconnexion") .'</a></div>';
            } else {
                echo '<a href="index.php?page=Default" class="center">'. texte("Connexion") .'</a>';
            }
            ?>

        </div>
        <div class="demi"></div>
    </header>