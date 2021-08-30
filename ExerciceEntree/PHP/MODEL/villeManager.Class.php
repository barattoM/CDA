<?php
class VilleManager
{
    public static function add(Ville $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("INSERT INTO Ville (nomVille,numeroDepartement,codePostal,dateMAJ) VALUES (:nomVille,:numeroDepartement,:codePostal,:dateMAJ)");
        $q->bindValue(":nomVille", $obj->getNomVille());
        $q->bindValue(":numeroDepartement", $obj->getNumeroDepartement());
        $q->bindValue(":codePostal", $obj->getCodePostal());
        $q->bindValue(":dateMAJ", $obj->getDateMAJ());
        $q->execute();
    }

    public static function update(Ville $obj)
    {
        $db = DbConnect::getDb();
        $q = $db->prepare("UPDATE Ville SET nomVille=:nomVille, numeroDepartement=:numeroDepartement, codePostal=:codePostal , dateMAJ=:dateMAJ WHERE idVille=:idVille");
        $q->bindValue(":nomVille", $obj->getNomVille());
        $q->bindValue(":numeroDepartement", $obj->getNumeroDepartement());
        $q->bindValue(":codePostal", $obj->getCodePostal());
        $q->bindValue(":dateMAJ", $obj->getDateMAJ());
        $q->bindValue(":idVille", $obj->getIdVille());
        $q->execute();
    }

    public static function delete(Ville $obj)
    {
        $db = DbConnect::getDb();
        $db->exec("DELETE FROM Ville WHERE idVille=" . $obj->getIdVille());
    }

    public static function findById($id)
    {
        $db = DbConnect::getDb();
        $id = (int) $id;  // on verifie que id est numerique, evite l'injection SQL
        $q = $db->query("SELECT * FROM Ville WHERE idVille=" . $id);
        $results = $q->fetch(PDO::FETCH_ASSOC);
        if ($results != false)
        {
            return new Ville($results);
        }
        else
        {
            return false;
        }
    }

    public static function getList()
    {
        $db = DbConnect::getDb();
        $liste = [];
        $q = $db->query("SELECT * FROM Ville");
        while ($donnees = $q->fetch(PDO::FETCH_ASSOC))
        {
            if ($donnees != false)
            {
                $liste[] = new Ville($donnees);
            }
        }
        return $liste;  // tableau contenant les objets Ville
    }
}