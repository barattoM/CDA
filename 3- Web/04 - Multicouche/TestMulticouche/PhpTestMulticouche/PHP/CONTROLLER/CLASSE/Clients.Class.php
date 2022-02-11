<?php

class Clients 
{

	/*****************Attributs***************** */

	private $_idClient;
	private $_nomClient;
	private $_prenomClient;
	private $_dateEntreeClient;
	private static $_attributes=["idClient","nomClient","prenomClient","dateEntreeClient"];
	/***************** Accesseurs ***************** */


	public function getIdClient()
	{
		return $this->_idClient;
	}

	public function setIdClient(int $idClient)
	{
		$this->_idClient=$idClient;
	}

	public function getNomClient()
	{
		return $this->_nomClient;
	}

	public function setNomClient(?string $nomClient)
	{
		$this->_nomClient=$nomClient;
	}

	public function getPrenomClient()
	{
		return $this->_prenomClient;
	}

	public function setPrenomClient(?string $prenomClient)
	{
		$this->_prenomClient=$prenomClient;
	}

	public function getDateEntreeClient()
	{
		return is_null($this->_dateEntreeClient)?null:$this->_dateEntreeClient->format('Y-n-j');
	}

	public function setDateEntreeClient(?string $dateEntreeClient)
	{
		$this->_dateEntreeClient=is_null($dateEntreeClient)?null:DateTime::createFromFormat("Y-n-j",$dateEntreeClient);
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
		return "IdClient : ".$this->getIdClient()."NomClient : ".$this->getNomClient()."PrenomClient : ".$this->getPrenomClient()."DateEntreeClient : ".$this->getDateEntreeClient()."\n";
	}
}