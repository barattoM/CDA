var type=document.getElementById("IdTypeProduit");
var categ=document.getElementById("categ");
var idCateg;
var article= document.getElementById("article");
var idArticle;
var description= document.getElementById("description");
var req=new XMLHttpRequest();
var req2=new XMLHttpRequest();
var req3=new XMLHttpRequest();

type.addEventListener("change",chargeCategorie);


//Lié aux types
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            categ.innerHTML=reponse;
            article.innerHTML=""; //On n'affiche plus les articles car la catégorie n'est plus selectionnée (on a changé de type donc les catégories proposée sont différentes)
            description.innerHTML=""; // On n'affiche plus la desscription de l'article car plus aucun article n'est selectionnée
            idCateg= document.getElementById("IdCategorie");
            idCateg.addEventListener("change",chargeArticle);
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

//Lié aux catégories
req2.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            description.innerHTML=""; //On n'affiche plus la desscription de l'article car plus aucun article n'est selectionnée (la catégorie à changé donc les articles aussi)
            article.innerHTML=reponse;
            idArticle=document.getElementById("IdArticle");
            idArticle.addEventListener("change",chargeDescription);
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

//Lié aux articles
req3.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            description.innerHTML="Libelle : "+reponse[0].LibelleArticle+" <br>Quantitée en stock : "+reponse[0].QuantiteStockee;
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};



function chargeCategorie(){
    if(type.value!=""){
        req.open('POST','index.php?page=CategorieAPI',true);
        req.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        req.send("idType="+type.value);
    }else{ //Si il n'y a pas de selection on reset l'affichage des catégorie, articles et description
        categ.innerHTML="";
        article.innerHTML="";
        description.innerHTML="";
    }
    
}

function chargeArticle(){
    if(idCateg.value!=""){
        req2.open('POST','index.php?page=ArticleAPI',true);
        req2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        req2.send("idCateg="+document.getElementById("IdCategorie").value);
    }else{ //Si il n'y a pas de selection on reset l'affichage des articles et description
        article.innerHTML="";
        description.innerHTML="";
    }
}

function chargeDescription(){
    if(idCateg.value!=""){
        req3.open('POST','index.php?page=DescriptionArticleAPI',true);
        req3.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
        req3.send("idArticle="+document.getElementById("IdArticle").value);
    }else{ // Si il n'y a pas de selection on reset l'affichage de la description
        description.innerHTML="";
    }
}