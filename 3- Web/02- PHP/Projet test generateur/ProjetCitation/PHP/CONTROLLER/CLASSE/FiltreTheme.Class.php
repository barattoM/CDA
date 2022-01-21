<?php

class FiltreTheme 
{

	/*****************Attributs***************** */

	private $_IdFiltreTheme;
	private $_IdCitation;
	private $_IdTheme;
	private static $_attributes=["IdFiltreTheme","IdCitation","IdTheme"];
	/***************** Accesseurs ***************** */


	public function getIdFiltreTheme()
	{
		return $this->_IdFiltreTheme;
	}

	public function setIdFiltreTheme(int $IdFiltreTheme)
	{
		$this->_IdFiltreTheme=$IdFiltreTheme;
	}

	public function getIdCitation()
	{
		return $this->_IdCitation;
	}

	public function setIdCitation(?int $IdCitation)
	{
		$this->_IdCitation=$IdCitation;
	}

	public function getIdTheme()
	{
		return $this->_IdTheme;
	}

	public function setIdTheme(?int $IdTheme)
	{
		$this->_IdTheme=$IdTheme;
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
		return "IdFiltreTheme : ".$this->getIdFiltreTheme()."IdCitation : ".$this->getIdCitation()."IdTheme : ".$this->getIdTheme()."\n";
	}
}