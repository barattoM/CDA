// Utilisation de l'Ajax pour appeler l'API et récuperer les enregistrements
var contenu = document.getElementById("divContenu");
var boutton=document.getElementById("ok");
var inputs= document.querySelectorAll("input");

// on définit une requete
const req = new XMLHttpRequest();
const req2 = new XMLHttpRequest();
//on envoi la requête

req.open('GET', 'https://api.nasa.gov/planetary/apod?api_key=wNRj67i7e4U5BfKIloj24kFEGMdZfict1kgs8XRd', true);
req.send(null);

// req2.open('GET', 'https://www.mmobomb.com/api1/games', true);
// req2.send(null);


//on vérifie les changements d'états de la requête
req.onreadystatechange = function (event) {
    if (this.readyState === XMLHttpRequest.DONE) {
        if (this.status === 200) {
            // la requete a abouti et a fournit une reponse
            //on décode la réponse, pour obtenir un objet
            reponse = JSON.parse(this.responseText);
            console.log(this.responseText);
            console.log(reponse);
            reponses= [];
            contenu.innerHTML="";
            if(!Array.isArray(reponse)){
                reponses[0]=reponse;
            }else{
                reponses=reponse;
            }
            console.log(reponses);
            for (let i = 0; i < reponses.length; i++) {
                bloc=document.createElement("div");
                bloc.className= "colonne";
                date=document.createElement("div");
                date.className= "center";
                date.innerHTML=reponses[i].date;
                img=document.createElement("img");
                img.setAttribute("src",reponses[i].url);
                bloc.appendChild(date);
                bloc.appendChild(img);
                contenu.appendChild(bloc);
            }
            console.log("Réponse reçue: %s", this.responseText);
        } else {
            console.log("Status de la réponse: %d (%s)", this.status, this.statusText);
        }
    }
};

boutton.addEventListener("click",function(e) {
    url="https://api.nasa.gov/planetary/apod?api_key=wNRj67i7e4U5BfKIloj24kFEGMdZfict1kgs8XRd&start_date="+inputs[0].value+"&end_date="+inputs[1].value;
    req.open('GET', url, true);
    req.send(null);
});

