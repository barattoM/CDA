var tabPlateau=[];
var tabPlateauCompress=[];
var selection=0;
var plateau=document.getElementsByClassName("plateau")[0];
var cases=document.getElementsByClassName("case");
var caseSelect;

initPlateau();

/**
 * Initialise le plateau de jeu
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

    // //Mise à jour du tabPlateauCompress
    // do{
    //     let index = tabPlateau
    // }while()
