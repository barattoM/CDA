<?php

class Articles 
{

	/*****************Attributs***************** */

	private $_idArticle;
	private $_descriptionArticle;
	private $_prixArticle;
	private static $_attributes=["idArticle","descriptionArticle","prixArticle"];
	/***************** Accesseurs ***************** */


	public function getIdArticle()
	{
		return $this->_idArticle;
	}

	public function setIdArticle(int $idArticle)
	{
		$this->_idArticle=$idArticle;
	}

	public function getDescriptionArticle()
	{
		return $this->_descriptionArticle;
	}

	public function setDescriptionArticle(?string $descriptionArticle)
	{
		$this->_descriptionArticle=$descriptionArticle;
	}

	public function getPrixArticle()
	{
		return $this->_prixArticle;
	}

	public function setPrixArticle(?int $prixArticle)
	{
		$this->_prixArticle=$prixArticle;
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
		return "IdArticle : ".$this->getIdArticle()."DescriptionArticle : ".$this->getDescriptionArticle()."PrixArticle : ".$this->getPrixArticle()."\n";
	}
}