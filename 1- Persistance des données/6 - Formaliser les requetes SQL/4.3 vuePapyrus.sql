CREATE VIEW commande 
as select e.numcom, `obscom`, `datcom`, `numfou`,`numlig`, `codart`, `qtecde`, `priuni`, `qteliv`, `derliv` 
from entcom as e 
inner join ligcom as l on e.numcom=l.numcom