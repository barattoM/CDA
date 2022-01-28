
<footer></footer>
<?php
 if (substr($page[1],0,4)=="Form"){
    echo ' <script src="./JS/VerifForm.js"></script>';
 }
 if($page[1]=="ListeArticles"){
   echo ' <script src="./JS/test.js"></script>';
 }
 //echo ' <script src="./JS/script.js"></script>';
echo '</body>
</html>';