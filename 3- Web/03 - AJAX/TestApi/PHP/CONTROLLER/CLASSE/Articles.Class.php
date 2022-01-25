<?php

class Articles 
{

	/*****************Attributs***************** */

	private $_IdArticle;
	private $_LibelleArticle;
	private $_QuantiteStockee;
	private $_IdCategorie;
	private static $_attributes=["IdArticle","LibelleArticle","QuantiteStockee","IdCategorie"];
	/***************** Accesseurs ***************** */


	public function getIdArticle()
	{
		return $this->_IdArticle;
	}

	public function setIdArticle(int $IdArticle)
	{
		$this->_IdArticle=$IdArticle;
	}

	public function getLibelleArticle()
	{
		return $this->_LibelleArticle;
	}

	public function setLibelleArticle(string $LibelleArticle)
	{
		$this->_LibelleArticle=$LibelleArticle;
	}

	public function getQuantiteStockee()
	{
		return $this->_QuantiteStockee;
	}

	public function setQuantiteStockee(int $QuantiteStockee)
	{
		$this->_QuantiteStockee=$QuantiteStockee;
	}

	public function getIdCategorie()
	{
		return $this->_IdCategorie;
	}

	public function setIdCategorie(int $IdCategorie)
	{
		$this->_IdCategorie=$IdCategorie;
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
		return "IdArticle : ".$this->getIdArticle()."LibelleArticle : ".$this->getLibelleArticle()."QuantiteStockee : ".$this->getQuantiteStockee()."IdCategorie : ".$this->getIdCategorie()."\n";
	}
}