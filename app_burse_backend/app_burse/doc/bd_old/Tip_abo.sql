 DROP TABLE IF EXISTS Tip_abo;
 CREATE TABLE Tip_abo (
COD_ABO                          Integer, 
SUMA                             Numeric(10,2), 
DENUMIRE                         Char(50), 
DATA                             DateTime, 
DATA_OP                          DateTime);
insert into Tip_abo values(1,12.50,'Abonament valabil pe UNA LINIE URBANA','2008-01-02',2007-01-17 12:48);
insert into Tip_abo values(2,15.00,'Abonament valabil pe DOUA LINII URBANE','2008-01-02',2007-01-17 12:48);
insert into Tip_abo values(3,20.00,'Abonament valabil pe TOATE LINIILE URBANE','2008-01-02',2007-01-17 12:48);
insert into Tip_abo values(4,27.00,'Abonament valabil preorasenesc','2007-11-23',2007-11-23 11:45);
insert into Tip_abo values(5,15.00,'Abonament valabil pe UNA LINIE URBANA','2008-03-13',2008-03-18 14:33);
insert into Tip_abo values(6,17.50,'Abonament valabil pe DOUA LINII URBANE','2008-03-13',2008-03-18 14:33);
insert into Tip_abo values(7,25.00,'Abonament valabil pe TOATE LINIILE URBANE','2008-03-13',2008-03-18 14:33);
insert into Tip_abo values(8,17.50,'Abonament  preorasenesc 1 lin','2017-11-15',2008-03-18 14:33);
insert into Tip_abo values(9,41.50,'Abonament preorasenesc 2 lin','2017-12-15',2018-01-05 09:01);
insert into Tip_abo values(10,62.50,'Abonament toate lin Buc+IF','2017-12-15',2018-01-05 09:01);
insert into Tip_abo values(11,42.50,'Abonament 1 lin preoras+toate lin Buc','2017-12-15',2018-01-05 09:01);
insert into Tip_abo values(12,32.50,'Abonament 1 lin Buc+ 1 linie preoras','2017-12-15',2018-01-05 09:01);
insert into Tip_abo values(13,40.00,'Abonament metropolitan','2021-08-01',2021-08-03 09:03);
