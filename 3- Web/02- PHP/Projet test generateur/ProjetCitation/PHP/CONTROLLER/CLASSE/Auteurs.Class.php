<?php

class Auteurs 
{

	/*****************Attributs***************** */

	private $_IdAuteur;
	private $_NomAuteur;
	private $_PrenomAuteur;
	private $_DateDeNaissance;
	private $_IdPays;
	private static $_attributes=["IdAuteur","NomAuteur","PrenomAuteur","DateDeNaissance","IdPays"];
	/***************** Accesseurs ***************** */


	public function getIdAuteur()
	{
		return $this->_IdAuteur;
	}

	public function setIdAuteur(int $IdAuteur)
	{
		$this->_IdAuteur=$IdAuteur;
	}

	public function getNomAuteur()
	{
		return $this->_NomAuteur;
	}

	public function setNomAuteur(string $NomAuteur)
	{
		$this->_NomAuteur=$NomAuteur;
	}

	public function getPrenomAuteur()
	{
		return $this->_PrenomAuteur;
	}

	public function setPrenomAuteur(string $PrenomAuteur)
	{
		$this->_PrenomAuteur=$PrenomAuteur;
	}

	public function getDateDeNaissance()
	{
		return is_null($this->_DateDeNaissance)?null:$this->_DateDeNaissance->format('Y-n-j');
	}

	public function setDateDeNaissance(?string $DateDeNaissance)
	{
		$this->_DateDeNaissance=is_null($DateDeNaissance)?null:DateTime::createFromFormat("Y-n-j",$DateDeNaissance);
	}

	public function getIdPays()
	{
		return $this->_IdPays;
	}

	public function setIdPays(int $IdPays)
	{
		$this->_IdPays=$IdPays;
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
		return "IdAuteur : ".$this->getIdAuteur()."NomAuteur : ".$this->getNomAuteur()."PrenomAuteur : ".$this->getPrenomAuteur()."DateDeNaissance : ".$this->getDateDeNaissance()."IdPays : ".$this->getIdPays()."\n";
	}
}