<div class="demiPage colonne">
    <form action="index.php?page=actionInscription" method="POST">
        <div>
            <label for="nom"><?php echo texte("Nom")?></label>
            <input type="text" name="nom" required />
        </div>
        <div>
            <label for="prenom"><?php echo texte("Prenom")?></label>
            <input type="text" name="prenom" required />
        </div>
        <div>
            <label for="motDePasse"><?php echo texte("Mot De Passe")?></label>
            <input type="password" name="motDePasse" required />
        </div>
        <div>
            <label for="confirmation"><?php echo texte("Confirmation du mot de passe")?></label>
            <input type="password" name="confirmation" required />
        </div>
        <div>
            <label for="adresseMail"><?php echo texte("Adresse mail")?></label>
            <input type="text" name="adresseMail" required />
        </div>
        <div>
            <label for="role"><?php echo texte("Role (1 : user - 2 : admin)")?></label>
            <input type="text" name="role" required />
        </div>
        <div>
            <label for="pseudo"><?php echo texte("Pseudo")?></label>
            <input type="text" name="pseudo" required />
        </div>
        <div>
            <div></div>
            <button type="submit"><?php echo texte("Valider")?></button>
            <div></div>
        </div>

    </form>