<?php

class CommandesManager 
{

	public static function add(Commandes $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Commandes $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Commandes $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Commandes::getAttributes(),"Commandes",["idCommande" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Commandes::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Commandes",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}