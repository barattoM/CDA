<?php

class PaysManager 
{

	public static function add(Pays $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Pays $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Pays $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Pays::getAttributes(),"Pays",["IdPays" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Pays::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Pays",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}