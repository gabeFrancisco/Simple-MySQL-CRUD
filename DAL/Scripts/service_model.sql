
/*MYSQL TABLE CONTENT... JUST FOR REMINDING PURPOSES*/
 
USE SERVICECLIENT;

CREATE TABLE SERVICE(
	IDSERVICE INT PRIMARY KEY AUTO_INCREMENT,
    TITLE VARCHAR(50) NOT NULL,
    SERVICEDESC LONGTEXT NOT NULL,
    CLIENTNAME VARCHAR(50)  NOT NULL,

);