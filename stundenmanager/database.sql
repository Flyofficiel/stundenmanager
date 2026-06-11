drop database if exists stundenmanager;
create database stundenmanager;
use stundenmanager;
create table stundenplan(
tag enum('Monday','Tuesday','Wednesday','Thursday','Friday'),
1stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
2stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
3stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
4stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
5stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
6stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
7stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') ,
8stunde enum('Deutsch','Mathe','Fimau','WN','English','FICTL','FINDT') 

);
create table schüler(
vorname varchar(100),
nachname varchar(100),
klasse varchar(100)
);
create table lehrer(
vorname varchar(100),
nachname varchar(100),
fach varchar(100),
pdw varchar(8)

);
insert into stundenplan (tag,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values ('Monday','Deutsch', 'Deutsch', 'Mathe', 'Mathe', 'FIMAU', 'FIMAU', 'WN', 'WN');
insert into stundenplan (tag,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values ('Tuesday','English', 'English', 'Deutsch', 'Deutsch', 'FICTL', 'FICTL', 'FINDT', 'FINDT' );
insert into stundenplan (tag,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values ('Wednesday','Deutsch', 'Deutsch', 'Mathe', 'Mathe', 'FIMAU', 'FIMAU', 'WN', 'WN');
insert into stundenplan (tag,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values ('Thursday','English', 'English', 'Deutsch', 'Deutsch', 'FICTL', 'FICTL', 'FINDT', 'FINDT');
insert into stundenplan (tag,1stunde,2stunde,3stunde,4stunde,5stunde,6stunde,7stunde,8stunde) values ('Friday','Deutsch', 'Deutsch', 'Mathe', 'Mathe', 'FIMAU', 'FIMAU', 'WN', 'WN');

insert into schüler (vorname,nachname,klasse) values ('Lucas','Huber','FI3/24');

insert into lehrer(vorname,nachname,fach,pdw) values ('Florian','Walny','Mathe','test');

select * from stundenplan;
select * from schüler;
select * from lehrer;