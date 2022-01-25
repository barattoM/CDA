<?php

class TypesProduits 
{

	/*****************Attributs***************** */

	private $_IdTypeProduit;
	private $_LibelleTypeProduit;
	private static $_attributes=["IdTypeProduit","LibelleTypeProduit"];
	/***************** Accesseurs ***************** */


	public function getIdTypeProduit()
	{
		return $this->_IdTypeProduit;
	}

	public function setIdTypeProduit(int $IdTypeProduit)
	{
		$this->_IdTypeProduit=$IdTypeProduit;
	}

	public function getLibelleTypeProduit()
	{
		return $this->_LibelleTypeProduit;
	}

	public function setLibelleTypeProduit(?string $LibelleTypeProduit)
	{
		$this->_LibelleTypeProduit=$LibelleTypeProduit;
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
		return "IdTypeProduit : ".$this->getIdTypeProduit()."LibelleTypeProduit : ".$this->getLibelleTypeProduit()."\n";
	}
}