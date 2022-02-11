const requ = new XMLHttpRequest();
var grid= document.getElementsByClassName("gridListe")[0];
var boutton=document.getElementById("boutton");

// console.log(grid.children[7]); //Début des données
// console.log(grid.children.length);
// console.log(grid.children[grid.children.length-1]) //Fin des données + boutton retour arrière

//suppression des données déja existante
for(let i=grid.children.length-1;i>=7;i--){
   grid.children[i].remove();
}


/**** GET */
requ.open('GET', 'https://localhost:44316/api/Articles', true);
requ.send();

requ.onreadystatechange = function(event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            console.log("Réponse reçue: %s", this.responseText);;
            console.log(this.responseText);
            reponse=JSON.parse(this.responseText);
            console.log(reponse);
            
            //création des lignes de données
            for (let i = 0; i < reponse.length; i++) {
                //case description
                description=document.createElement("div");
                description.className="caseListe donneeListe";
                description.innerHTML=reponse[i].descriptionArticle;
                grid.appendChild(description);

                //case prix
                prix=document.createElement("div");
                prix.className="caseListe donneeListe";
                prix.innerHTML=reponse[i].prixArticle+" €";
                grid.appendChild(prix);

                //case afficher
                afficher=document.createElement("div");
                afficher.className="caseListe";
                hrefAfficher=document.createElement("a");
                hrefAfficher.setAttribute("href","index.php?page=FormArticles&mode=Afficher&id="+reponse[i].idArticle);
                icone=document.createElement("i");
                icone.className="fas fa-file-contract";
                hrefAfficher.appendChild(icone);
                afficher.appendChild(hrefAfficher);
                grid.appendChild(afficher);

                //case modifier
                modifier=document.createElement("div");
                modifier.className="caseListe";
                hrefModifier=document.createElement("a");
                hrefModifier.setAttribute("href","index.php?page=FormArticles&mode=Modifier&id="+reponse[i].idArticle);
                icone=document.createElement("i");
                icone.className="fas fa-pen";
                hrefModifier.appendChild(icone);
                modifier.appendChild(hrefModifier);
                grid.appendChild(modifier);

                //case supprimer
                supprimer=document.createElement("div");
                supprimer.className="caseListe";
                hrefSupprimer=document.createElement("a");
                hrefSupprimer.setAttribute("href","index.php?page=FormArticles&mode=Supprimer&id="+reponse[i].idArticle);
                icone=document.createElement("i");
                icone.className="fas fa-trash-alt";
                hrefSupprimer.appendChild(icone);
                supprimer.appendChild(hrefSupprimer);
                grid.appendChild(supprimer);

            }
            //rajout du boutton retour
            b=boutton.content.cloneNode(true);
            grid.appendChild(b);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};