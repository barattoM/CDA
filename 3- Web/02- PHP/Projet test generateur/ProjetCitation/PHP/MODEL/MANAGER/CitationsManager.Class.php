<?php

class CitationsManager 
{

	public static function add(Citations $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Citations $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Citations $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Citations::getAttributes(),"Citations",["IdCitation" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Citations::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Citations",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}