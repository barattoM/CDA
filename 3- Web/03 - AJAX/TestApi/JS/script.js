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



req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            categ.innerHTML=reponse;
            article.innerHTML="";
            description.innerHTML="";
            idCateg= document.getElementById("IdCategorie");
            idCateg.addEventListener("change",chargeArticle);
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

req2.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            description.innerHTML="";
            article.innerHTML=reponse;
            idArticle=document.getElementById("IdArticle");
            idArticle.addEventListener("change",chargeDescription);
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

req3.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            //reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            description.innerHTML="Libelle : ";
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};



function chargeCategorie(){
    req.open('POST','index.php?page=CategorieAPI',true);
    req.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    req.send("idType="+type.value);
}

function chargeArticle(){
    req2.open('POST','index.php?page=ArticleAPI',true);
    req2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    req2.send("idCateg="+document.getElementById("IdCategorie").value);
}

function chargeDescription(){
    req3.open('POST','index.php?page=DescriptionArticleAPI',true);
    req3.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    req3.send("idArticle="+document.getElementById("IdArticle").value);
}