drop database if exists stundenmanager;
create database stundenmanager;
use stundenmanager;
create table stundenplan(
day datetime,
1stunde enum('Deusch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
2stunde varchar(100),
3stunde varchar(100),
4stunde varchar(100),
5stunde varchar(100),
6stunde varchar(100),
7stunde varchar(100),
8stunde varchar(100)

);
create table schüler(
vorname varchar(100),
nachname varchar(100),
klasse varchar(100)
);
create table lehrer(
vorname varchar(100),
nachname varchar(100),
fach varchar(100)

);
insert into stundenplan (day,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values (Monday,"Deutsch", "Deutsch", "Mathe", "Mathe", "FIMAU", "FIMAU", "WN", "WN");
insert into stundenplan (day,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values (Tuesday,"English", "English", "Deutsch", "Deutsch", "FICTL", "FICTL", "FINDT", "FINDT" );
insert into stundenplan (day,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values (Wednesday,"Deutsch", "Deutsch", "Mathe", "Mathe", "FIMAU", "FIMAU", "WN", "WN");
insert into stundenplan (day,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values (Thursday,"English", "English", "Deutsch", "Deutsch", "FICTL", "FICTL", "FINDT", "FINDT");
insert into stundenplan (day,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values (Friday,"Deutsch", "Deutsch", "Mathe", "Mathe", "FIMAU", "FIMAU", "WN", "WN");

select * from stundenplan;
select * from schüler;
select * from lehrer;