<?php
echo json_encode(creerSelect(null,"Categories",["LibelleCategorie"],"",["IdTypeProduit"=>$_POST['idType']]));