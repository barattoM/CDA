<?php
class Ville
{
    private $_idVille;
    private $_nomVille;
    private $_numeroDepartement;
    private $_codePostal;
    private $_dateMAJ;

    public function getIdVille()
    {
        return $this->_idVille;
    }
    public function setIdVille($_idVille)
    {
        return $this->_idVille = $_idVille;
    }
    public function getNomVille()
    {
        return $this->_nomVille;
    }
    public function setNomVille($_nomVille)
    {
        return $this->_nomVille = $_nomVille;
    }
    public function getNumeroDepartement()
    {
        return $this->_numeroDepartement;
    }
    public function setNumeroDepartement($_numeroDepartement)
    {
        return $this->_numeroDepartement = $_numeroDepartement;
    }
    public function getCodePostal()
    {
        return $this->_codePostal;
    }
    public function setCodePostal($_codePostal)
    {
        return $this->_codePostal = $_codePostal;
    }
    public function getDateMAJ()
    {
        return $this->_dateMAJ;
    }

    public function setDateMAJ($dateMAJ)
    {
        $this->_dateMAJ = $dateMAJ;
    }

    public function __construct(array $options = [])
    {
        if (!empty($options))
        {
            $this->hydrate($options);
        }
    }

    public function hydrate($data)
    {
        foreach ($data as $key => $value)
        {
            $methode = "set" . ucfirst($key);
            if (is_callable(([$this, $methode])))
            {
                $this->$methode($value);
            }
        }
    }

    public function toString()
    {
        return ""; 
    }

   
}