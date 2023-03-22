 DROP TABLE IF EXISTS TIP_BURSE;
 CREATE TABLE TIP_BURSE (
COD_BURSA                        Integer, 
DEN_BURSA                        Char(40), 
NR_BURSA                         Integer, 
SUMA_BURSA                       Numeric(7,2), 
PER_LUNI                         Integer, 
SURSA                            Char(20), 
COD_POSDRU                       Char(20), 
BANCA1                           Char(4), 
BANCA2                           Char(4), 
BANCA3                           Char(4), 
BANCA4                           Char(4), 
BANCA5                           Char(4), 
BANCA6                           Char(4), 
BANCA7                           Char(4));
insert into TIP_BURSE values(1,'Bursa "Mihail Manoilescu"',1,1500.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(2,'Bursa "N.N. Constantinescu"',1,0.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(3,'Bursa perfomanta in activ. org. si cult.',6,1000.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(4,'Bursa performanta in activ. sportive',4,800.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(5,'Bursa de cercetare',10,1000.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(6,'Bursa de performanta',10,720.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(7,'Bursa de merit',227,555.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(8,'Bursa de studiu',1810,420.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(9,'Bursa sociala',618,700.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(10,'Bursa ajutor social ocazional',135,700.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(11,'Bursa studenti straini',null,65.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(12,'Scoala de vara',5,600.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(13,'Bursa MASTERAT straini',null,75.00,11,'Buget','','','','','','','','');
insert into TIP_BURSE values(14,'Bursa DOCTORAND straini',null,85.00,11,'Buget','','','','','','','','');
insert into TIP_BURSE values(15,'Burse speciale',5,600.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(16,'Decontare CFR Moldova',null,49.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(17,'Burse TIP BD',null,1500.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(18,'Bursa vacanta de vara',null,1120.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(19,'Bursa doctorand roman I',null,851.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(20,'Bursa BD apr - aug 2008',null,7500.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(21,'Bursa Erasmus - sem.1 2008-2009',null,1269.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(22,'Premiere ECDL',null,370.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(23,'Bursa doctorand roman II',null,915.00,12,'Buget','','RNCB','BRDE','','','','','');
insert into TIP_BURSE values(24,'Bursa doctorand roman III',null,2200.00,12,'Buget','/107/1.5/S/77213','RNCB','BRDE','','','','','');
insert into TIP_BURSE values(25,'Premiere admitere master',null,900.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(26,'Premiere serbare Craciun',null,501.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(27,'Restituiri taxe',null,700.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(28,'Diferente orfani vacanta',null,25.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(29,'Diferente burse excelenta',null,342.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(30,'Diferente burse performanta',null,429.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(31,'Bursa "Meritul olimpic"',null,1050.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(32,'Bursa speciala din sponsorizare',null,250.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(33,'Ajutor deces',null,3000.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(34,'Diferente burse',null,224.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(35,'Burse din sponsorizare',null,3000.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(36,'Bursa Erasmus - sem.2 2008-2009',null,null,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(37,'Bursa specializare Moldova',null,309.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(38,'Bursa merit din venituri proprii',null,400.00,6,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(39,'Bursa Erasmus sem 2 2012-2013',null,957.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(40,'Subventie cazare',null,1516.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(41,'Burse speciale cantina',16,350.00,9,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(42,'Burse speciale magazin',6,1200.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(43,'Decontare transp.  Moldova',null,24.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(44,'Premiu POSDRU 90/2.1/S/63442',33,1400.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(45,'Bursa speciala admitere',null,700.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(46,'Bursa speciala cazare',null,2000.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(47,'Bursa Erasmus sem 2 2010-2011',null,1875.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(48,'Burse doctorand roman III',null,1850.00,12,'Buget','6/1.5/S/11','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(49,'Diferente burse din venituri',null,130.00,5,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(50,'Bursa sociala din venituri',null,700.00,5,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(51,'Bursa POSDRU /86/1.2/S/53202',null,1000.00,6,'Buget','/86/1.2/S/53202','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(52,'Bursa doctorand roman III',null,1850.00,12,'Buget','/88/1.5/S/55287','RNCB','BRDE','','','','','');
insert into TIP_BURSE values(53,'Bursa ajutor social ocaz. lauzie',null,345.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(54,'Bursa ajutor social ocaz. nou-nascut',null,345.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(55,'Premiu POSDRU 109/2.1/G/81455',null,700.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(56,'Burse orfani pt. vacanta de vara',null,345.00,2,'Buget','','','','','','','','');
insert into TIP_BURSE values(57,'Burse straini pt. vacanta de vara',null,185.00,2,'Buget','','','','','','','','');
insert into TIP_BURSE values(58,'Bursa doctorand roman III - Buget',null,1220.00,12,'Buget','','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(59,'Diferente doctorand roman III',null,2000.00,1,'Buget','/107/1.5/S/77213','','','','','','','');
insert into TIP_BURSE values(60,'Bursa speciala cazare',null,2000.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(61,'Premiu sesiune stiintifica stud',null,140.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(62,'Bursa retroact. Erasm. sem2 2013-2014',null,1689.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(63,'Bursa POSDRU / 134197',null,1917.00,1,'Buget','','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(64,'Bursa POSDRU -  134197',null,1500.00,1,'Buget','','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(65,'Bursa POSDRU / 142115',null,1917.00,1,'Buget','','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(66,'Bursa POSDRU  - 142115',null,1500.00,1,'Buget','','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(67,'Bursa POSDRU  - 1591/15/S/138907',null,1500.00,1,'Buget','1591/15/S/138907','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(68,'Bursa POSDRU  - 1591/15/S/138907',null,1917.00,1,'Buget','1591/15/S/138907','RNCB','INGB','BRDE','RZBR','BPOS','BTRL','BACX');
insert into TIP_BURSE values(69,'Bursa POSDRU/109/2.1/G/81432',null,400.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(70,'Bursa performanta',null,690.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(71,'Bursa retroctiva doctorand roman',null,4880.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(72,'Bursa mobilitate scurta durata strain',null,331.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(73,'Bursa retroact. Erasm. sem2 2014-2015',null,1493.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(74,'Bursa retroactiva "Meritul Olimpic"',null,6411.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(75,'Restituire regie camin',null,100.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(76,'Bursa speciala social',null,600.00,8,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(77,'Bursa doctorand roman buget an 1',null,1550.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(78,'Bursa doctorand roman buget an 2',null,1550.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(79,'Bursa doctorand roman buget an 3',null,1800.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(80,'Bursa studiu retroactiva sem 1 2015-2016',null,1470.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(81,'Bursa  retroactiva',null,1493.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(82,'Premii proiect CNFIS',null,500.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(83,'Bursa studiu din venituri proprii',null,84.00,5,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(84,'Bursa de performanta ptr rez invatatura',null,1000.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(85,'Bursa de merit',null,750.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(86,'Bursa de performanta ptr intreaga activ',0,1400.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(87,'Bursa CEEPUS',null,1638.36,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(88,'Bursa activ extracurriculare si voluntar',null,750.00,6,'Buget','','','','','','','','');
insert into TIP_BURSE values(89,'Bursa speciala cor ASE',null,2450.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(90,'Bursa dif.perform invat si bursastud str',null,697.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(91,'Bursa dif.perform invat si bursamast str',null,650.00,12,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(92,'Bursa merit retroactiva sem 2 2018-2019',null,3075.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(93,'Bursa merit retroactiv sem 2 2019-2020',null,3336.00,1,'Buget','','','','','','','','');
insert into TIP_BURSE values(94,'Premiu competitie proiecte',null,1000.00,null,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(95,'Bursa proiect cercetare',null,1000.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(96,'Bursa speciala Caravana Sanatatii',null,250.00,1,'Venituri Proprii','','','','','','','','');
insert into TIP_BURSE values(97,'Bursa masterat didactic',null,2097.00,12,'Buget','','','','','','','','');
insert into TIP_BURSE values(98,'',null,null,null,'','','','','','','','','');
