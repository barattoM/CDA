<?php

class Themes 
{

	/*****************Attributs***************** */

	private $_IdTheme;
	private $_LibelleTheme;
	private static $_attributes=["IdTheme","LibelleTheme"];
	/***************** Accesseurs ***************** */


	public function getIdTheme()
	{
		return $this->_IdTheme;
	}

	public function setIdTheme(int $IdTheme)
	{
		$this->_IdTheme=$IdTheme;
	}

	public function getLibelleTheme()
	{
		return $this->_LibelleTheme;
	}

	public function setLibelleTheme(?string $LibelleTheme)
	{
		$this->_LibelleTheme=$LibelleTheme;
	}

	public static function getAttributes()
	{
		return self::$_attributes;
	}

	/*****************Constructeur***************** */

	public function __construct(array $options = [])
	{
 		if (!empty($options)) // empty : renvoi vrai si le tableau est vide
		{
			$this->hydrate($options);
		}
	}
	public function hydrate($data)
	{
 		foreach ($data as $key => $value)
		{
 			$methode = "set".ucfirst($key); //ucfirst met la 1ere lettre en majuscule
			if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
			{
				$this->$methode($value===""?null:$value);
			}
		}
	}

	/*****************Autres Méthodes***************** */

	/**
	* Transforme l'objet en chaine de caractères
	*
	* @return String
	*/
	public function toString()
	{
		return "IdTheme : ".$this->getIdTheme()."LibelleTheme : ".$this->getLibelleTheme()."\n";
	}
}