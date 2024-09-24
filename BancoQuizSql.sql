CREATE DATABASE Quiz

USE Quiz

CREATE TABLE tblPergunta(
id int identity not null primary KEY,
Pergunta varchar(50) not null,
resposta1 varchar(20) not null,
resposta2 varchar(20) not null,
resposta3 varchar(20) not null, 
resposta4 varchar (20) not null,
Correta int not null
)
drop table tblPergunta
insert into tblPergunta values('Como se chama o novo FIFA?','PES','BOMBA PATCH','DREAM LEAGUE SOCCER','EAFC24',4)
insert into tblPergunta values('Quem é o maior time de SP?','Palmeiras','São Paulo','Corinthians','Santos',3)
insert into tblPergunta values('Quem descobriu o Brasil?','Jõao Kleber','Pedro Álvares Cabral','CR7','Messi',2)
insert into tblPergunta values('Quantas copas do Braisl o Corinthians tem?','7','3','0','6',2)
insert into tblPergunta values('Qual é o maior time do mundo?','Barcelona','Milan','Real Madrid','Manchester City',3)
insert into tblPergunta values('Quem é o maior artilheiro do futebol?','CR7','Pelé','Neymar','Ronaldo Fenômeno',1)

select * from tblPergunta
