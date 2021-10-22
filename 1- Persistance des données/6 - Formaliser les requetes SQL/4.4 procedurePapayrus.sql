DELIMITER $

CREATE PROCEDURE `test`()
BEGIN
	update vente set prix1=prix1+prix1*0.04, prix2=prix2+prix2*0.02;
    update vente set prix3=prix2;
END
$
DELIMITER ;