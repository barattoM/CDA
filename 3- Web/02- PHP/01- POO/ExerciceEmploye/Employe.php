<?php

class Employe
{

    /*****************Attributs***************** */
    private $_nom ;
    private $_prenom;
    private $_dateEmbauche ;
    private $_poste ;
    private $_salaire ;
    private $_service ;
    private $_agence ;
    private $_enfants=[];

    /*****************Accesseurs***************** */
    
    public function getNom()
    {
        return $this->_nom;
    }

    public function setNom($nom)
    {
        $this->_nom = $nom;
    }

    public function getPrenom()
    {
        return $this->_prenom;
    }

    public function setPrenom($prenom)
    {
        $this->_prenom = $prenom;
    }

    public function getDateEmbauche()
    {
        return $this->_dateEmbauche;
    }

    public function setDateEmbauche($dateEmbauche)
    {
        $this->_dateEmbauche = $dateEmbauche;
    }

    public function getPoste()
    {
        return $this->_poste;
    }

    public function setPoste($poste)
    {
        $this->_poste = $poste;
    }

    public function getSalaire()
    {
        return $this->_salaire;
    }

    public function setSalaire($salaire)
    {
        $this->_salaire = $salaire;
    }

    public function getService()
    {
        return $this->_service;
    }

    public function setService($service)
    {
        $this->_service = $service;
    }

    public function getAgence()
    {
        return $this->_agence;
    }

    public function setAgence($agence)
    {
        $this->_agence = $agence;
    }

    public function getEnfants()
    {
        return $this->_enfants;
    }

    public function setEnfants($enfants)
    {
        $this->_enfants = $enfants;
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
        foreach ($data as $key => $value) {
            $methode = "set" . ucfirst($key); //ucfirst met la 1ere lettre en majuscule
            if (is_callable(([$this, $methode]))) // is_callable verifie que la methode existe
            {
                $this->$methode($value);
            }
        }
    }

    /*****************Autres Méthodes***************** */

    public function toString()
    {
        $aff = "<br>### SALARIE ###<br>";
        $aff .= "Nom : " . $this->getNom() . " Prenom : " . $this->getPrenom() . "<br>DateEmbauche : " . $this->getDateEmbauche()->format('Y-m-d') . "<br>PosteEntreprise : " . $this->getPoste() . "<br>Salaire : " . $this->getSalaire() . "K<br>Service : " . $this->getService() . "<br>";
        $aff .= ($this->anciennete() >= 1) ? "Il a des chèques vacances<br>" : "Il n'a pas de chèques vacances<br>";
        $aff .= "@@@ AGENCE @@@<br>" . $this->getAgence()->toString();
        $aff .= "°°° ENFANTS °°°<br>";
        if (count($this->getEnfants()) != 0)
        {
            $aff .= "Il a ".count($this->getEnfants())." enfants :<br>";
            foreach ($this->getEnfants() as $enfant)
            {
                $aff .= $enfant->toString()."--------<br>";
            }
        }
        else
        {
            $aff .= "Il n'a pas d'enfant<br>";
        }
        $aff .= "$$$ CHEQUES NOEL $$$<br>";
        $cheques = $this->chequeNoel();
        if (array_sum($cheques) != 0)
        {
            $aff .= "Il a des droit à des chèques noël :<br>";
            foreach ($cheques as $key=>$nbCheque)
            {
                if ($nbCheque != 0)
                {
                    $aff .= $nbCheque . " chèque(s) de ".$key."<br>";
                }
            }
        }
        else
        {
            $aff .= "Pas de chèques de Noël<br>";
        }
        return $aff;
    }

    public function anciennete()
    {
            $auj = new DateTime("now");
            return date_diff($this->_dateEmbauche,$auj)->format('%y');
    }

    public function primeAnnuelle()
        {
            $prime = 0.05 * $this->_salaire + 0.02 * $this->anciennete();
            $auj = new DateTime("now");
            if ($auj->format('d-m') =="04-01")//30-11
            {
                echo "L'ordre de transfert d'un montant de ".$prime." a été envoyé à la banque";               
            }
            return $prime;
        }

    public static function compareToNomPrenom($e1, $e2)
    {
        if ($e1->getNom() < $e2->getNom()){
            return -1;
        }
        else if ($e1->getNom() > $e2->getNom()){
            return 1;
        }
        else if ($e1->getPrenom() < $e2->getPrenom()){
            return -1;
        }
        else if ($e1->getPrenom() > $e2->getPrenom()){
            return 1;
        }
        return 0;
    }

    public static function compareToServiceNomPrenom($e1, $e2)
    {
        if ($e1->getService() < $e2->getService()){
            return -1;
        }
        else if ($e1->getService() > $e2->getService()){
            return 1;
        }
        else{
            return self::compareToNomPrenom($e1, $e2);
        }

    }

    private function prime()
    {
        return $this->getSalaire() * 1000 * 0.05 + $this->getSalaire() * 1000 * 0.02 * $this->anciennete();
    }
    
    public function masseSalariale()
    {
        return $this->getSalaire() * 1000 + $this->prime();
    }

    public function chequeNoel()
    {
        $cheque = ["20" => 0, "30" => 0, "50" => 0];
        foreach ($this->getEnfants() as $enfant)
        {
            $montant=$enfant->chequeNoel();
            if($montant!=0){
                $cheque[$montant] ++;
            }
            
        }
        return $cheque;
    }
}

?>