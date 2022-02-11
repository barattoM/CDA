
<footer>
   <div class="grid-col-3">
      <div class="colonne color1">
         <div class="center bold">Services et Garanties</div>
         <div><a href="index.php?page=cestPasImplemente">Garanties et assurances</a></div>
         <div><a href="index.php?page=cestPasImplemente">Mon espace Client</a></div>
         <div><a href="index.php?page=cestPasImplemente">Nos magasins</a></div>
      </div>
      <div class="colonne color1">
         <div class="center bold">Livraison et paiement</div>
         <div><a href="index.php?page=cestPasImplemente">Les modes et frais de livraison</a></div>
         <div><a href="index.php?page=cestPasImplemente">Livraison en europe</a></div>
         <div><a href="index.php?page=cestPasImplemente">Livraison à l'international</a></div>
      </div>
      <div class="colonne color1">
         <div class="center bold">Conatactez-nous</div>
         <div><a href="index.php?page=cestPasImplemente">Contact Service Client</a></div>
         <div><a href="index.php?page=cestPasImplemente">Contact publicité</a></div>
         <div><a href="index.php?page=cestPasImplemente">Recrutement</a></div>
      </div>
   </div>
</footer>
<?php
 if (substr($page[1],0,4)=="Form"){
    echo ' <script src="./JS/VerifForm.js"></script>';
 }
 if($page[1]=="FormArticles"){
   echo ' <script src="./JS/FormArticles.js"></script>';
 }
 echo ' <script src="./JS/script.js"></script>';
echo '</body>
</html>';