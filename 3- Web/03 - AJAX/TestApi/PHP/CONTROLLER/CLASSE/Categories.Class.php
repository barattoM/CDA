<?php

class Categories 
{

	/*****************Attributs***************** */

	private $_IdCategorie;
	private $_LibelleCategorie;
	private $_IdTypeProduit;
	private static $_attributes=["IdCategorie","LibelleCategorie","IdTypeProduit"];
	/***************** Accesseurs ***************** */


	public function getIdCategorie()
	{
		return $this->_IdCategorie;
	}

	public function setIdCategorie(int $IdCategorie)
	{
		$this->_IdCategorie=$IdCategorie;
	}

	public function getLibelleCategorie()
	{
		return $this->_LibelleCategorie;
	}

	public function setLibelleCategorie(string $LibelleCategorie)
	{
		$this->_LibelleCategorie=$LibelleCategorie;
	}

	public function getIdTypeProduit()
	{
		return $this->_IdTypeProduit;
	}

	public function setIdTypeProduit(int $IdTypeProduit)
	{
		$this->_IdTypeProduit=$IdTypeProduit;
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
		return "IdCategorie : ".$this->getIdCategorie()."LibelleCategorie : ".$this->getLibelleCategorie()."IdTypeProduit : ".$this->getIdTypeProduit()."\n";
	}
}