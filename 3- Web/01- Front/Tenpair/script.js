var tabPlateau=[];
var tabPlateauCompress=[];
var selection=0;
var plateau=document.getElementsByClassName("plateau")[0];
var cases=document.getElementsByClassName("case");
var caseSelect;
var deal=document.getElementById("deal")
var hint=document.getElementById("hint")

initPlateau();

deal.addEventListener("click",addGrid);
hint.addEventListener("click",conseil);

/**
 * Initialise le plateau de jeu
 * @returns void
 */
function initPlateau(){
    for(let i=0;i<27;i++){
        let nb=Math.floor(Math.random() * (9 - 1 +1)) + 1;
        tabPlateau[i]=nb;
        let caseGrille=document.createElement("div");
        caseGrille.className="case center";
        caseGrille.setAttribute("position",i);
        caseGrille.innerHTML=nb;
        caseGrille.addEventListener("click",selectCase);
        plateau.appendChild(caseGrille);
    }
    tabPlateauCompress=tabPlateau;
}

function selectCase(e){
    //On regarde si la case n'est pas une case vide
    if(e.target.innerHTML!=""){
        if(selection==0){
            e.target.classList.add("select");
            caseSelect=e.target;
            selection=1;
        }else{
            //pour la déselection
            if(e.target.classList.contains("select")){
                e.target.classList.remove("select");
                caseSelect=null;
                selection=0;
            }else if(checkSelection(e.target)){//on regarde si la selection est possible comme paire
                validation(e.target);
            }
        }      
    }
}

/**
 * retourne true si la case est selectionnable comme paire ou false sinon
 * @param {} Case 
 * @returns bool
 */
function checkSelection(Case){
    //case modulo 9 (en dessous ou au dessus) / case adjacente (suivante ou precedente)
    let positionCase=Case.getAttribute("position");
    let positionCaseSelect=caseSelect.getAttribute("position");
    let max = Math.max(positionCase,positionCaseSelect);
    let min= Math.min(positionCase,positionCaseSelect);

    //Verif verticale
    if(positionCase%9==positionCaseSelect%9){ //meme colonne
        let valide=true;
        //on vérifie si il n'y a pas de valeur entre les 2 selections
        for(let i=min+9;i<max;i=i+9){
            if(tabPlateau[i]!=""){//si entre les 2 selections il y a une valeur alors la selection ne peut pas se faire
                valide=false;
            }  
        }
        if(valide && checkTotal(Case)){
            return true;
        }
    }else{ //Verif horizontale
        let valide=true;
        //on vérifie si il n'y a pas de valeur entre les 2 selections
        for(let i=min+1;i<max;i++){
            if(tabPlateau[i]!=""){//si entre les 2 selections il y a une valeur alors la selection ne peut pas se faire
                valide=false;
            }  
        }
        if(valide && checkTotal(Case)){
            return true;
        }
    }
    return false;
}

/**
 * retourne true si la somme des cases selectionner est 10, false sinon
 * @param {*} Case 
 * @returns bool
 */
function checkTotal(Case){
    if(Case.innerHTML*1+caseSelect.innerHTML*1==10 || Case.innerHTML*1==caseSelect.innerHTML*1){
        return true;
    }else{
        return false;
    }
}

/**
 * Enleve les valeurs valider du plateau (visuel), met les valeurs du tabPlateau à jour ( "" )
 * @returns void
 */
function validation(Case){
    let positionCase=Case.getAttribute("position");
    let positionCaseSelect=caseSelect.getAttribute("position");
    //On enleve les valeurs du tableau
    tabPlateau[positionCase]="";
    tabPlateau[positionCaseSelect]="";
    //On enleve les valeurs du visuel
    Case.innerHTML="";
    caseSelect.innerHTML="";
    //On remet à zéro la case selectionné
    caseSelect.classList.remove("select");
    selection=0;
    caseSelect=null;
}

/**
 * Met à jour le tabPlateauCompress et ajoute ce nouveau plateau à l'ancien
 */
function addGrid(){
    //Mise à jour du tabPlateauCompress
    tabPlateauCompress=tabPlateau.filter(nb => nb!=""); //On enleve les espaces pour le tableau plateau compressé
    taille = tabPlateau.length;

    //On regarde si la dernière ligne est complète ou non, si oui on ne fait rien sinon on finis la ligne avec des cases ""
    test=tabPlateauCompress.length%9 // 0 à 8 (0 si la ligne et finis ,1 si 1 colonne; 2 si 2 colonne ...)
    if(test!=0){
        for(let i=0;i<9-test;i++){
            tabPlateauCompress.push("");
        }
    }

    //On concatène les 2 tableaux 
    tabPlateau=tabPlateau.concat(tabPlateauCompress);
    console.log(tabPlateau)
    //On ajoute le nouveau tableau au visuel
    for(let i=taille;i<tabPlateau.length;i++){
        let caseGrille=document.createElement("div");
        caseGrille.className="case center";
        caseGrille.setAttribute("position",i);
        caseGrille.innerHTML=tabPlateau[i];
        caseGrille.addEventListener("click",selectCase);
        plateau.appendChild(caseGrille);
    }
    
}

function conseil(){
   //recherche vertical (basse car haute sera déja fait)

   //recherche horizontal (droite car gauche sera déja fait)
   
}
    
