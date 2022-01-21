<?php

class Pays 
{

	/*****************Attributs***************** */

	private $_IdPays;
	private $_NomPays;
	private static $_attributes=["IdPays","NomPays"];
	/***************** Accesseurs ***************** */


	public function getIdPays()
	{
		return $this->_IdPays;
	}

	public function setIdPays(int $IdPays)
	{
		$this->_IdPays=$IdPays;
	}

	public function getNomPays()
	{
		return $this->_NomPays;
	}

	public function setNomPays(string $NomPays)
	{
		$this->_NomPays=$NomPays;
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
		return "IdPays : ".$this->getIdPays()."NomPays : ".$this->getNomPays()."\n";
	}
}