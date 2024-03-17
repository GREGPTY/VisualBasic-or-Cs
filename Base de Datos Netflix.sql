create database Netflix_Regist;
use Netflix_Regist;

Create Table usuario (
nom_usr varchar(30),
pass_word varchar(30),
email varchar(30),
credit_card varchar(10)
);
ALTER TABLE usuario ADD COLUMN plan varchar(10) AFTER email;
Alter Table usuario add primary key (nom_usr,email);
use Netflix_Regist;
INSERT INTO usuario(nom_usr,pass_word,email,plan,credit_card) values('ghost','ghoster','GhostPrincipal@Cod','Boss','Visa');
INSERT INTO usuario(nom_usr,pass_word,email,plan,credit_card) values('greg','pty','greg@Cod','BigBoss','Visa');
INSERT INTO usuario(nom_usr,pass_word,email,plan,credit_card) values('Yire00','Yire007','Yire@Cod','Premium','Visa');
INSERT INTO usuario(nom_usr,pass_word,email,plan,credit_card) values('a','a','a@Cod','Boss','Visa');
select * from usuario;

Update usuario set plan = 'Boss' where nom_usr = 'ghost';
Update usuario set plan = 'Boss' where nom_usr = 'a';
Update usuario set plan = 'Premium' where nom_usr = 'El_Mr';

select * from usuario where plan = 'BigBoss' or plan = 'Boss' and nom_usr = 'greg';
Select * from usuario where plan not in ('Boss') and plan not in ('BigBoss') ;
SELECT * FROM usuario Where (plan = 'BigBoss' or plan ='Boss') and nom_usr= 'a';

Describe usuario;

create table content(
id numeric,
Titulo varchar(30),
Genero varchar(30),
Duracion varchar(9),
Year_M numeric
);

select * from content;

alter table content Modify Column Year_M int;
alter table content Modify column id int;

insert into content(id,Titulo,Genero,Duracion,Year_M) values (1,'Rapidos y Furiosos 9','Accion','2:25:00',2021);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (2,'Toy Story','Animacion','1:21:00',1995);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (3,'Iron Man','Accion','2:06:00',2008);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (4,'La noche del demonio','Terror','1:43:00',2010);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (5,'Godzilla vs Kong','Ciencia Ficcion','1:53:00',2021);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (6,'Luca','Animacion','1:41:00',2021);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (7,'Ejército de los muertos','Accion','2:28:00',2021);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (8,'Cruella','Comedia','2:14:00',2021);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (9,'Avengers: Endgame','Accion','3:02:00',2019);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (10,'Freaky','Comedia','1:41:00',2020);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (11,'All the Bright Places','Romance','1:48:00',2020);
insert into content(id,Titulo,Genero,Duracion,Year_M) values (12,'La Reina del Flow','Drama','59:40:00',2018);
select * From content;
Describe content;