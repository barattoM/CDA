<?php

class ThemesManager 
{

	public static function add(Themes $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(Themes $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(Themes $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(Themes::getAttributes(),"Themes",["IdTheme" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?Themes::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"Themes",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}