<?php

class Commandes 
{

	/*****************Attributs***************** */

	private $_idCommande;
	private $_idClient;
	private $_idArticle;
	private $_dateCommande;
	private $_quantiteCommande;
	private $_cde_total;
	private static $_attributes=["idCommande","idClient","idArticle","dateCommande","quantiteCommande","cde_total"];
	/***************** Accesseurs ***************** */


	public function getIdCommande()
	{
		return $this->_idCommande;
	}

	public function setIdCommande(int $idCommande)
	{
		$this->_idCommande=$idCommande;
	}

	public function getIdClient()
	{
		return $this->_idClient;
	}

	public function setIdClient(?int $idClient)
	{
		$this->_idClient=$idClient;
	}

	public function getIdArticle()
	{
		return $this->_idArticle;
	}

	public function setIdArticle(?int $idArticle)
	{
		$this->_idArticle=$idArticle;
	}

	public function getDateCommande()
	{
		return is_null($this->_dateCommande)?null:$this->_dateCommande->format('Y-n-j');
	}

	public function setDateCommande(?string $dateCommande)
	{
		$this->_dateCommande=is_null($dateCommande)?null:DateTime::createFromFormat("Y-n-j",$dateCommande);
	}

	public function getQuantiteCommande()
	{
		return $this->_quantiteCommande;
	}

	public function setQuantiteCommande(?int $quantiteCommande)
	{
		$this->_quantiteCommande=$quantiteCommande;
	}

	public function getCde_total()
	{
		return $this->_cde_total;
	}

	public function setCde_total(?int $cde_total)
	{
		$this->_cde_total=$cde_total;
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
		return "IdCommande : ".$this->getIdCommande()."IdClient : ".$this->getIdClient()."IdArticle : ".$this->getIdArticle()."DateCommande : ".$this->getDateCommande()."QuantiteCommande : ".$this->getQuantiteCommande()."Cde_total : ".$this->getCde_total()."\n";
	}
}