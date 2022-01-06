<?php

class Service
{
	public static function add(Categories $obj)
	{
 		$db=DbConnect::getDb();
		$q=$db->prepare("INSERT INTO Categories (LibelleCategorie) VALUES (:LibelleCategorie)");
		// vérifier qu'il ne contient pas de ;
		$q->bindValue(":LibelleCategorie", $obj->getLibelleCategorie(), PDO::PARAM_STR);
		$q->execute();
	}

	private static function conditionSelect($conditions){
		$req=" WHERE";
		foreach($conditions as $nomColonne=>$valeur){
			// cas du in
			if(is_array($valeur)){
				$req.= $nomColonne." IN (".$valeur[0].",".$valeur[1].") AND ";
			}else if(strpos($valeur,"%")){//cas like
				$req.= $nomColonne.' LIKE "'.$valeur.'" AND ';
			}else if(strpos($valeur,"-")){//cas between
				$tab=explode("-",$valeur);
				$req.= $nomColonne." BETWEEN ".$tab[0]." AND ".$tab[1]." AND ";
			}else{//cas valeur simple
				$req.= $nomColonne." = ".$valeur." AND ";
			}	
		}
		//On retire le dernier AND
		$req=substr($req,strlen($req)-4);
		return $req;
	}
}