<?php

class Citations 
{

	/*****************Attributs***************** */

	private $_IdCitation;
	private $_TexteCitation;
	private $_DateCitation;
	private $_IdAuteur;
	private static $_attributes=["IdCitation","TexteCitation","DateCitation","IdAuteur"];
	/***************** Accesseurs ***************** */


	public function getIdCitation()
	{
		return $this->_IdCitation;
	}

	public function setIdCitation(int $IdCitation)
	{
		$this->_IdCitation=$IdCitation;
	}

	public function getTexteCitation()
	{
		return $this->_TexteCitation;
	}

	public function setTexteCitation(string $TexteCitation)
	{
		$this->_TexteCitation=$TexteCitation;
	}

	public function getDateCitation()
	{
		return $this->_DateCitation->format('Y-n-j');
	}

	public function setDateCitation(string $DateCitation)
	{
		$this->_DateCitation=DateTime::createFromFormat("Y-n-j",$DateCitation);
	}

	public function getIdAuteur()
	{
		return $this->_IdAuteur;
	}

	public function setIdAuteur(int $IdAuteur)
	{
		$this->_IdAuteur=$IdAuteur;
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
		return "IdCitation : ".$this->getIdCitation()."TexteCitation : ".$this->getTexteCitation()."DateCitation : ".$this->getDateCitation()."IdAuteur : ".$this->getIdAuteur()."\n";
	}
}