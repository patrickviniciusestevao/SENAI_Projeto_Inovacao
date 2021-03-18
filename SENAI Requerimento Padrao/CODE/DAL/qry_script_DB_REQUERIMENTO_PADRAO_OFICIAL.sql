create database DB_Requerimento_Padrao_Oficial;
use DB_Requerimento_Padrao_Oficial;

-- Tabela FUNCAO (FUNCOES DO USUARIO)
create table FUNCOES(
id_funcao int primary key auto_increment,
funcao varchar(100),
nivel_permissao int
);

desc FUNCOES;

select * from FUNCOES;

INSERT INTO FUNCOES (funcao, nivel_permissao)
values ('Gerente',1);