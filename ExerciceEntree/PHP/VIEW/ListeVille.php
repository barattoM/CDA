<?php
$liste = VilleManager::getList();
?>
    <div id="crudBarreOutil">
        <a class=" crudBtn crudBtnOutil" href='index.php?codePage=formVille&mode=ajout'>Ajouter </a>
    </div>
    <div id="crudTableau">
        <table>
            <thead >
                <th class="crudColonne">Nom de la ville</th>
            </thead>
            <?php foreach ($liste as $elt)
                    {
                        echo '<tr>';
                        echo '<td class="crudColonne">' . $elt->getNomVille() . '</td>';
            ?>
            <td>
                <a class=" crudBtn crudBtnEdit"
                    href='index.php?codePage=formVille&mode=edit&id=<?php echo $elt->getIdVille(); ?>'>Afficher </a>
                <a class=" crudBtn crudBtnModif"
                    href='index.php?codePage=formVille&mode=modif&id=<?php echo $elt->getIdVille(); ?>'>Modifier</a>
                <a class=" crudBtn crudBtnSuppr"
                    href='index.php?codePage=formVille&mode=delete&id=<?php echo $elt->getIdVille(); ?>'>Supprimer</a></td>
            </tr>
            <?php }?>

        </table>
    </div>