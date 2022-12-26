REM extra hobby TABLE employees
REM 
REM employees are having sports 
REM only if the sport is practiced in a club this sport are stored in this DATABASE
REM The id of a club of one sport can be identical to a id of a club of another sport
REM an employee can be a member of more clubs for the same sport.

REM ********************************
REM drop tables 
REM ********************************
Prompt **** dropping tables ****
DROP TABLE employee_sports CASCADE CONSTRAINTS;
DROP TABLE sports	CASCADE CONSTRAINTS;
DROP TABLE sport_clubs CASCADE CONSTRAINTS;


REM **************************
REM create tables 
REM **************************

Prompt ***** Creating sports table *******

CREATE TABLE sports
	( sport_id		NUMBER(2) 
		CONSTRAINT sport_id_pk PRIMARY KEY 
	, name			VARCHAR2(15)
		CONSTRAINT sport_name_nn	NOT NULL
	);
	
Prompt **** table sports created ****
Prompt ***** Creating sport_clubs table *******	

CREATE TABLE sport_clubs
	( club_id     NUMBER(2)
	,sport_id     NUMBER(2)
		CONSTRAINT sport_club_hob_FK REFERENCES sports (sport_id)
	, club_name		VARCHAR2(25)
		CONSTRAINT club_name_nn	NOT NULL
	 ,club_location		NUMBER(4)
		CONSTRAINT club_loc_nn	NOT NULL	 
		CONSTRAINT sport_club_loc_fk REFERENCES locations (location_id)
	 ,CONSTRAINT club_sport_id_PK PRIMARY KEY(club_id,sport_id)
	 );

Prompt **** table sport_clubs created ****
Prompt ***** Creating employee_sports table *****
CREATE TABLE employee_sports
	( sport_id 			NUMBER(2) 
		CONSTRAINT emp_sport_id_nn NOT NULL
	 ,employee_number	NUMBER(6)
		CONSTRAINT emp_nr_nn	NOT NULL
		CONSTRAINT emp_nr_fk REFERENCES employees(employee_id)
	 ,club_id			NUMBER(2)
		CONSTRAINT emp__club_id_nn	NOT NULL
	 ,CONSTRAINT emp_sport_id_PK PRIMARY KEY(sport_id,employee_number,club_id)
	 , CONSTRAINT emp_sport_club_fk FOREIGN KEY (club_id, sport_id)  REFERENCES sport_clubs (club_id,sport_id)
	 );

Prompt **** table employee_sports created ****

REM inserts values into tables 
Prompt **** tabellen vullen ****

INSERT INTO   sports
VALUES (1, 'tennis');
INSERT INTO   sports
VALUES (2, 'soccer');
INSERT INTO   sports
VALUES (3, 'rugby');
INSERT INTO   sports
VALUES (4, 'basket');
INSERT INTO   sports
VALUES (5, 'volley');
INSERT INTO   sports
VALUES (6, 'swimming');

prompt *** sports filled out

INSERT INTO   sport_clubs
VALUES (10,1,'tennisrevalation', 1800);
INSERT INTO   sport_clubs
VALUES (11,1,'tennisclub',1700);
INSERT INTO  sport_clubs
VALUES (12,1,'tennis for women',1400);
INSERT INTO  sport_clubs
VALUES (10,2,'soccerrevalation',1500);
INSERT INTO  sport_clubs
VALUES (11,2,'soccerteam',1700);
INSERT INTO  sport_clubs
VALUES (13,3,'rugbyteam', 1700);
INSERT INTO  sport_clubs
VALUES (13,4,'basketteam', 1700);
INSERT INTO  sport_clubs
VALUES (14,2,'soccerfamily', 2500);
INSERT INTO  sport_clubs
VALUES (14,3,'rugbyclub', 1400);
INSERT INTO  sport_clubs
VALUES (15,4,'basketclub', 1800);
INSERT INTO  sport_clubs
VALUES (15,5,'volleyteam', 1700);
INSERT INTO  sport_clubs
VALUES (16,6,'swimmingclub',1800 );
INSERT INTO  sport_clubs
VALUES (17,6,'swimteam', 2500);
INSERT INTO  sport_clubs
VALUES (16,5,'volleyclub', 1800);
INSERT INTO  sport_clubs
VALUES (17,3,'rugbyfamily', 1800);

prompt *** sport_clubs filled out

INSERT INTO  employee_sports (sport_id, employee_number, club_id)
VALUES (1,104,11);
INSERT INTO  employee_sports
VALUES (1,104,10);
INSERT INTO  employee_sports
VALUES (2,174,14);
INSERT INTO  employee_sports
VALUES (2,149,14);
INSERT INTO  employee_sports
VALUES (3,149,13);
INSERT INTO  employee_sports
VALUES (4,143,15);
INSERT INTO  employee_sports
VALUES (4,142,15);
INSERT INTO  employee_sports
VALUES (5,206,16);
INSERT INTO  employee_sports
VALUES (6,206,16);
INSERT INTO  employee_sports
VALUES (5,200,16);
INSERT INTO  employee_sports
VALUES (6,205,17);
INSERT INTO  employee_sports
VALUES (6,176,17);
INSERT INTO  employee_sports
VALUES (5,144,16);
INSERT INTO  employee_sports
VALUES (5,176,16);
INSERT INTO  employee_sports
VALUES (4,107,15);
INSERT INTO  employee_sports
VALUES (4,149,13);
prompt *** employee_sports filled out
Prompt **** tables filled out
