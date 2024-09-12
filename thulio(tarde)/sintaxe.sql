create table Departamento(
id numeric (7) primary key,
nome varchar(40) not Null
)

select * from departamento
 
create table Empregado(
id numeric (7) primary key,
ult_Nome varchar (20) not null,
Prim_nome varchar (20) not null,
Cargo varchar (30),
salario numeric (7,2),
Dt_Admissao Date,
CPF char (11) unique,
id_depto numeric (7) references Departamento (id)
)

select * from empregado

create table cliente (
id numeric (7) primary key,
nome varchar (40) not null,
vendedor numeric (7)
)

alter table departamento add descrição varchar(30) not null
alter table departamento drop column descrição
select * from departamento

alter table cliente add foreign key (vendedor) references empregado(ID)
select * from cliente

 create table turmas
(codigo_turma numeric (6),
codigo_curso numeric(3),
codigo_funcionario numeric(6),
data_inicio date,
data_fin date,
sala numeric (2),
primary key (codigo_turma, codigo_curso) )

drop table turmas

select * from turmas

drop table departamento
