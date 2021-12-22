var menus = document.getElementsByClassName("menu");

for (i = 0; i < menus.length; i++) {
    menus[i].addEventListener("click", function (e) {

        if (e.target.parentNode.nextElementSibling != null) {
            if (e.target.parentNode.nextElementSibling.getAttribute("class") == "sousMenus colonne") {
                //On referme le menu qui a déja ouvert si il y en a un
                for (i = 0; i < menus.length; i++) {
                    if (menus[i].getAttribute("ouvert") == "true") {
                        menus[i].setAttribute("ouvert", "false");
                        menus[i].children[1].setAttribute("class", "sousMenus colonne");
                        menus[i].children[0].children[0].setAttribute("class", "fas fa-sort-down");
                    }
                }
                //On affecte l'attribut ouvert au menu ouvert
                e.target.parentNode.parentNode.setAttribute("ouvert", "true");
                e.target.parentNode.children[0].setAttribute("class", "fas fa-sort-up");
                //On affiche le sous menu et on met un bord arrondi au dernier enfant de ce sous menu
                e.target.parentNode.nextElementSibling.setAttribute("class", "visible colonne");
                //e.target.parentNode.nextElementSibling.lastElementChild.setAttribute("class","borderArrondi");
            } else {
                e.target.setAttribute("ouvert", "false");
                e.target.parentNode.nextElementSibling.setAttribute("class", "sousMenus colonne");
                e.target.parentNode.children[0].setAttribute("class", "fas fa-sort-down");
            }
        }


    })
}

