<?php

class AuteursManager 
{
	public static function add(Auteurs $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Auteurs $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Auteurs $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Auteurs::getAttributes(),"Auteurs",["IdAuteur" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Auteurs::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Auteurs",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}