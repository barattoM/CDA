<?php

class FiltreThemeManager 
{

	public static function add(FiltreTheme $obj)
	{
 		return DAO::add($obj);
	}

	public static function update(FiltreTheme $obj)
	{
 		return DAO::update($obj);
	}

	public static function delete(FiltreTheme $obj)
	{
 		return DAO::delete($obj);
	}

	public static function findById($id)
	{
 		return DAO::select(FiltreTheme::getAttributes(),"FiltreTheme",["IdFiltreTheme" => $id])[0];
	}

	public static function getList(array $nomColonnes=null,  array $conditions = null, string $orderBy = null, string $limit = null, bool $api = false, bool $debug = false)
	{
 		$nomColonnes = ($nomColonnes==null)?FiltreTheme::getAttributes():$nomColonnes;
		return DAO::select($nomColonnes,"FiltreTheme",   $conditions ,  $orderBy,  $limit ,  $api,  $debug );	}
}