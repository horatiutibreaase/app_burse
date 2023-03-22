 DROP TABLE IF EXISTS facult;
 CREATE TABLE facult (
COD_FAC                          Char(3), 
COD_FACN                         Integer, 
COD_BD                           Char(5), 
DENUMIRE                         Char(55), 
DECAN                            Char(40), 
PRODECAN1                        Char(40), 
PRODECAN2                        Char(40), 
PROD_IDD                         Char(40), 
SECR_ST                          Char(40), 
SECRETARA                        Char(40), 
TEL_DECAN                        Char(15), 
TEL_IDD                          Char(15), 
TEL_SECR                         Char(15), 
TEL_INT                          Char(15), 
UTILIZATOR                       Char(25), 
PAROLA                           Char(25), 
UTILIZATO2                       Char(25), 
PAROLA_A                         Char(25), 
PRESEDINTE                       Char(40), 
MEMBRI1                          Char(40), 
MEMBRI2                          Char(40), 
MEMBRI3                          Char(40), 
MEMBRI4                          Char(40), 
STUDENT1                         Char(40), 
STUDENT2                         Char(40), 
FOND                             Numeric(11,2), 
NR_PERF                          Integer, 
VAL_PERF                         Numeric(11,2), 
NR_PERF_NO                       Integer, 
VAL_PERF_N                       Numeric(11,2), 
NR_EXTRAC                        Integer, 
VAL_EXTRAC                       Numeric(11,2), 
NR_MERIT                         Integer, 
VAL_MERIT                        Numeric(11,2), 
PROC_MERIT                       Numeric(5,2), 
NR_STUDIU                        Integer, 
VAL_STUDIU                       Numeric(11,2), 
NR_SOCIAL                        Integer, 
VAL_SOCIAL                       Numeric(11,2), 
PROC_SOCIA                       Numeric(5,2), 
NR_BUGET_1                       Integer, 
NR_BUGET_2                       Integer, 
NR_BUGET_3                       Integer, 
NR_BUGET_4                       Integer, 
NR_MASTER1                       Integer, 
NR_MASTER2                       Integer, 
IDSIMUR                          Integer);
insert into facult values('CIG',2,'CIG','CONTABILITATE ªI INFORMATICÃ DE GESTIUNE','Prof.univ.dr.Liliana FELEGÃ','Conf.univ.dr. Valentin DUMITRU','Conf.univ.dr.Curea STEFANIA','Prof.univ.dr. Nadia ALBU','-','Hermeniuc Luminiþa','116;6597473','113','118,228','','Burse','cig','r','r','Conf.univ.dr.Valentin DUMITRU',' Hermeniuc Luminita- secretar sef','','','','Ferent Alexandra','',209643.00,2,720.00,2,1400.00,null,750.00,39,1000.00,3.00,200,750.00,134,700.00,30.00,243,240,228,0,138,156,20);
insert into facult values('FAB',6,'FABBV','FINANTE, ASIGURARI, BANCI SI BURSE DE VALORI','Conf.univ.dr.Ionela Costica','Prof.univ.dr. Emilia Câmpeanu','Conf.univ.dr. Iustina Boitan','Conf.univ.dr.Georgiana Camelia GEORGESCU','','Ec. Anca  Florentina Trifu','564','','565','','Burse','fab','r','r','Conf.univ.dr.Georgiana Camelia GEORGESCU','Secretar ºef, Anca Florentina TRIFU','','','','Sorina Elisabeta BOGDÃNESCU','',211050.00,2,720.00,2,1400.00,null,750.00,37,1000.00,3.00,191,750.00,128,700.00,30.00,241,247,249,0,152,155,21);
insert into facult values('ETA',5,'ETA','ECONOMIE TERORETICÃ ªI APLICATÃ','Conf.univ.dr. Grigore Ioan Piroºcã','Conf.univ.dr. Silvia Elena Iacob','Conf.univ.dr. Nicolae Moroianu','Conf.univ.dr. Roberta Stanef-Puicã','',' Ec.Adriana Pãun','361;366','','106','','Burse','ecg','r','r','Conf.univ.dr. Silvia Elena Iacob','Secretar sef Ec. Adriana Paun','','','','Alexandra Ioana Murariu','',118791.00,2,720.00,2,1400.00,null,750.00,15,1000.00,3.00,89,750.00,43,700.00,30.00,145,147,141,0,117,73,22);
insert into facult values('EAM',4,'EAM','ECONOMIE AGROALIMENTARA SI A MEDIULUI','Prof.univ.dr. Mirela STOIAN','Prof.univ.dr. Radulescu Carmen-Valentina','Conf.univ.dr. Simona - Roxana Patarlage','Conf.univ.dr. Catalin - Octavian Manescu','','Ec. Georgeta Sandu','','','0213191900','568','Burse','eam','r','r','Conf.univ.dr. Catalin - Octavian Manescu','Secretar Sef Georgeta Sandu','','','','Dan I Iustina Maria','',203412.00,2,720.00,2,1400.00,null,750.00,24,1000.00,3.00,121,750.00,82,700.00,30.00,236,237,214,0,180,183,18);
insert into facult values('CSI',1,'CSIE','CIBERNETICÃ, STATISTICÃ ªI INFORMATICÃ ECONOMICÃ','Prof.univ.dr.Marian Dârdalã','Prof.univ.dr. Iftimie Bogdan','Prof.univ.dr. Constanþa MIHÃESCU','Prof.univ.dr. Claudiu HERTELIU','','Costache Claudia','163; 2119009','358','119, 281,331','','Burse','csi','r','r','Prof.univ.dr. Iftimie Bogdan','Secretar sef Costache Claudia','','','','Caragea Iliana Brîndusa','',554559.00,2,720.00,2,1400.00,null,750.00,26,1000.00,3.00,179,750.00,63,700.00,30.00,594,601,582,0,439,394,15);
insert into facult values('BTU',3,'BTU','BUSINESS ªI TURISM','Prof.univ.dr.Gabriela TIGU','Prof.univ.dr. Doru PLESEA','Conf.univ.dr. Olimpia STATE','Prof.univ.dr. Andreea SASEANU','','Ec. Mirela SAGETEANU','202;340;6596305','127','347,219','','Burse','com','r','r','Prof.univ.dr. Andreea SASEANU','Ec. Mirela SAGETEANU','','','','Stud. Ana-Maria Badea','',191754.00,1,720.00,2,1400.00,null,750.00,34,1000.00,3.00,176,750.00,119,700.00,30.00,224,227,235,0,134,136,17);
insert into facult values('REI',10,'REI','RELATII ECONOMICE INTERNATIONALE','Prof.univ.dr. Hurduzeu Gheorghe','Prof.univ.dr. Ilie Anca Gabriela','Prof.univ.dr. Paun Cristian Valeriu','Conf.univ.dr. Irina David','','Doina Cãlintaru','172;2118525','169','170,171','','Burse','rei','r','r','Conf.univ.dr. Irina David','Doina Cãlintaru','','','','Serbu Sara Maria','',229743.00,2,720.00,2,1400.00,null,750.00,27,1000.00,3.00,137,750.00,68,700.00,30.00,251,261,280,0,173,189,16);
insert into facult values('MRK',9,'MRK','MARKETING','Prof. univ. dr. Calin Petrica VEGHES','Prof. univ. dr. Ionel DUMITRU','Conf. univ. dr. Carmen ACATRINEI','Prof. univ.dr. Mihai ORZAN','','Claudia ANGHEL','0213191980/464','','0213191980/467','','Burse','mrk','r','r','Conf. univ. dr. Carmen ACATRINEI','Secretar sef Claudia ANGHEL','','','','Claudia Maria MIU','',186528.00,2,720.00,2,1400.00,null,750.00,32,1000.00,3.00,159,750.00,108,700.00,30.00,222,222,217,0,113,121,23);
insert into facult values('AAF',12,'FABIZ','Administrarea Afacerilor (cu predare in limbi straine)','Conf. Univ. dr. Tanase Stamule','Lector Univ. dr. Anagnoste Sorin','Conf. Univ. dr. Stanila Georgiana Oana','','','Poparad Ivona Ioana','','','','','Burse','aaf','r','r','Conf. Univ. dr. Tanase Stamule','Lector Univ. dr. Anagnoste Sorin','','','','Stanomir Ruxandra','',139695.00,2,720.00,2,1400.00,null,750.00,24,1000.00,3.00,126,750.00,85,700.00,30.00,143,148,185,0,113,112,24);
insert into facult values('MAN',13,'MAN','MANAGEMENT','Prof.univ.dr. Ion Popa','Prof.univ.dr. Claudiu Constantin Cicea','Conf.univ.dr. Rãzvan Andrei Corboº','Prof.univ.dr Simion Cezar Petre','','Gina Gabriela Cordaº','','','','','Burse','man','r','r','Conf.univ.dr. Rãzvan Andrei Corboº','Ec.Gina Gabriela Cordaº','','','','Tudosescu Mara Elena','Ion George Daniel',206226.00,2,720.00,2,1400.00,null,750.00,25,1000.00,3.00,120,750.00,61,700.00,30.00,238,240,235,0,141,157,19);
insert into facult values('MAP',7,'MAP','ADMINISTRAÞIE ªI MANAGEMENT PUBLIC','Prof.univ dr.Nica Elvira','Prof. univ. dr. Popescu Ruxandra Irina','Lect. univ.dr. Sabie Oana Matilda','Lect. univ. dr. Burcea Stefan Gabriel','','Neleapcã Lucica Aurora','021.319.19.01','149','021.319.19.01','553, 552','Burse','map','r','r','Prof.univ.dr. Popescu Ruxandra Irina','Neleapcã Lucica Aurora','','','','Oprea Cristian','',133464.00,2,720.00,2,1400.00,null,750.00,15,1000.00,3.00,86,750.00,43,700.00,30.00,169,168,171,0,81,82,244);
insert into facult values('BBS',14,'BBS','BUCHAREST BUSINESS SCHOOL','','','','','','','','','','','','','','','','','','','','','',null,null,null,null,null,null,null,null,null,null,null,null,null,700.00,null,null,null,null,null,null,null,260);
insert into facult values('DRE',15,'DREPT','DREPT','Conf.univ.dr. Dumitru Ovidiu Ioan','Conf.univ.dr. Vidat Ana Elena Claudia','Conf.univ.dr. Ene Charlotte Valentine','','','Dutu Elena','','','','','Burse','drept','r','r','Conf. univ.dr. Vidat Ana Claudia Elena','Dutu Elena','','','','Suciu Florin-Nicusor','',25125.00,2,720.00,2,1400.00,null,750.00,null,1000.00,3.00,null,750.00,null,700.00,30.00,47,47,0,null,14,14,272);
