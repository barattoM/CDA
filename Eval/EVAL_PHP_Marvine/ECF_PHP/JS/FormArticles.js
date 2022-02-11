var img=document.getElementById("photo");
var inputImg=document.getElementById("inputPhoto")

//On charge l'image si c'est un formulaire autre que l'ajout
if(inputImg.value!=""){
    img.src="./IMG/"+inputImg.value;
}

inputImg.addEventListener("input", function(){
    img.src=img.src="./IMG/"+inputImg.value;
})

