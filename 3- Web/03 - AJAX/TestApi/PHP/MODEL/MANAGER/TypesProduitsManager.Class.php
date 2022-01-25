<?php

class TypesProduitsManager 
{

	public static function add(TypesProduits $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(TypesProduits $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(TypesProduits $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(TypesProduits::getAttributes(),"TypesProduits",["IdTypeProduit" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?TypesProduits::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"TypesProduits",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}