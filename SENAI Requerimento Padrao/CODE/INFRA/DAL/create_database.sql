create database if not exists DB_Requerimento_Padrao_Oficial;

use DB_Requerimento_Padrao_Oficial;

create table if not exists CATEGORIA_CLIENTE ( -- 1
	id_categoria_cliente int primary key auto_increment,
    categoria_cliente varchar(255) not null,
    UNIQUE(categoria_cliente)
);

create table if not exists CLIENTE ( -- 2
	id_cliente int primary key auto_increment,
	id_categoria_cliente int,
    url_foto_usuario varchar(300),
    nome_completo varchar(200) not null,
    matricula varchar(200) not null,
    nome_social varchar(200),
    cpf varchar(200) not null,
    rg varchar(200) not null,
    orgao_emissor varchar(200) not null,
    email varchar(200) not null,
    situacao varchar(200) not null,
    
    constraint fk_id_categoria_cliente foreign key (id_categoria_cliente) references categoria_cliente(id_categoria_cliente) 
);

create table if not exists TELEFONE ( -- 3
	id_telefone int primary key auto_increment,
    id_cliente int not null,
    numero_telefone varchar(200) not null,
    whatsapp boolean not null,
    categoria_telefone varchar(200),
    
    constraint fk_id_telefone_cliente foreign key (id_cliente) references cliente(id_cliente)
);

create table if not exists ENDERECO ( -- 4
	id_endereco int primary key auto_increment,
    id_cliente int not null,
    logradouro varchar(300) not null,
    numero varchar(100) not null,
    cep varchar(100) not null,
    bairro varchar(200),
    complemento varchar(200),
    cidade varchar(200) not null,
    uf varchar(200) not null,
    categoria_endereco varchar(200) not null,
    
    constraint fk_id_endereco_cliente foreign key (id_cliente) references cliente(id_cliente)
);

create table if not exists FUNCAO ( -- 5
id_funcao int primary key auto_increment,
funcao varchar(255) not null,
nivel_permissao varchar(10) not null
);

create table if not exists ITEM_REQUERIMENTO ( -- 5
item_requerimento int primary key auto_increment,
id_funcao int,
nome varchar(255) not null,
valor decimal not null,

constraint fk_id_funcao_item_requerimento foreign key (id_funcao) references funcao (id_funcao)
);

create table if not exists TIPO_CAMPO ( -- 6
id_tipo_campo int primary key auto_increment,
tipo_campo varchar(55) not null
);

create table if not exists CAMPO_ADICIONAL ( -- 7
id_campo_adicional int primary key auto_increment,
id_tipo_campo int,
descricao varchar(255) not null,

constraint fk_id_tipo_campo foreign key (id_tipo_campo) references tipo_campo(id_tipo_campo)
);

create table if not exists ITEM_CAMPOS_ADICIONAIS ( -- 8
id_item_campos_adicionais int primary key auto_increment,
item_requerimento int,
id_campo_adicional int,

constraint fk_item_requerimento foreign key (item_requerimento) references item_requerimento(item_requerimento),
constraint fk_id_campo_adicional foreign key (id_campo_adicional) references campo_adicional(id_campo_adicional)
);

create table if not exists TIPO_CAMPO_DATA ( -- 9
id_tipo_campo_data int primary key auto_increment,
id_tipo_campo int,

constraint fk_id_tipo_data_campo foreign key (id_tipo_campo) references tipo_campo(id_tipo_campo)
);

create table if not exists TIPO_CAMPO_TEXTO ( -- 10
id_tipo_campo_texto int primary key auto_increment,
id_tipo_campo int,

constraint fk_id_tipo_texto_campo foreign key (id_tipo_campo) references tipo_campo(id_tipo_campo)
);

create table if not exists TIPO_CAMPO_SELECAO ( -- 11
id_tipo_campo_selecao int primary key auto_increment,
id_tipo_campo int,
 constraint fk_id_tipo_selecao_campo foreign key (id_tipo_campo) references tipo_campo(id_tipo_campo)
);

create table if not exists OPCAO_SELECAO ( -- 12
id_opcao_selecao int primary key auto_increment,
id_tipo_campo_selecao int,
texto varchar(55) not null,

constraint fk_id_tipo_campo_selecao foreign key (id_tipo_campo_selecao) references tipo_campo_selecao(id_tipo_campo_selecao)
);

create table if not exists DOCUMENTO ( -- 13
id_documento int primary key auto_increment,
documento varchar(255) not null
);

create table if not exists DOCUMENTO_CLIENTE ( -- 14 
id_documento_cliente int primary key auto_increment,
id_cliente int,
id_documento int,
data_cadastro datetime not null,
diretorio_arquivo varchar(55) not null,

constraint fk_id_cliente_documento_cliente foreign key (id_cliente) references cliente (id_cliente),
constraint fk_id_documento_documento_cliente foreign key (id_documento) references documento (id_documento)
);

create table if not exists DOCUMENTO_ITEM_REQUERIMENTO ( -- 15
id_documento_item_requerimento int primary key auto_increment,
id_documento int,
item_requerimento int,

constraint fk_id_documento_documento_item_requerimento foreign key (id_documento) references documento (id_documento),
constraint fk_item_requerimento_documento_item_requerimento foreign key (item_requerimento) references item_requerimento(item_requerimento)
);

create table if not exists usuario ( -- 17
id_usuario int primary key auto_increment,
id_funcao int,
url_foto_usuario varchar(300),
nome_completo varchar(255) not null,
matricula varchar(55) not null,
email_institucional varchar(55),
senha varchar(55) not null,
situacao varchar(55) not null,

constraint fk_id_funcao_usuario foreign key (id_funcao) references funcao (id_funcao)
);

create table if not exists TELEFONE_USUARIO ( -- 18 
id_telefone_usuario int primary key auto_increment,
id_usuario int,
numero_telefone varchar(11) not null,
whatsapp boolean not null,
categoria_telefone varchar(55),

constraint fk_id_usuario_telefone foreign key (id_usuario) references usuario(id_usuario)
);

create table if not exists ENDERECO_USUARIO ( -- 19 
id_endereco_usuario int primary key auto_increment,
id_usuario int not null,
logradouro varchar(300) not null,
numero varchar(100) not null,
cep varchar(100) not null,
bairro varchar(200),
complemento varchar(200),
cidade varchar(200) not null,
uf varchar(200) not null,
categoria_endereco varchar(200) not null,
    
constraint fk_id_usuario_endereco foreign key (id_usuario) references usuario(id_usuario)
);

create table if not exists MODALIDADE ( -- 20
id_modalidade int primary key auto_increment,
modalidade varchar(25)
);

create table if not exists CURSO ( -- 21
id_curso int primary key auto_increment,
nome_curso varchar(255) not null
);

create table if not exists MODALIDADE_CURSO ( -- 22
id_modalidade_curso int primary key auto_increment,
id_modalidade int,
id_curso int,

constraint fk_id_modalidade foreign key (id_modalidade) references modalidade (id_modalidade),
constraint fk_id_curso foreign key (id_curso) references curso (id_curso)
);

create table if not exists REQUERIMENTO ( -- 23
id_requerimento int primary key auto_increment,
id_modalidade_curso int,
item_requerimento int,
modulo_periodo int not null,
turno varchar(20) not null,
informacoes_adicionais varchar(255),
data_hora_pedido datetime not null,
situacao varchar(20) not null,

constraint fk_id_modalidade_curso_requerimento foreign key (id_modalidade_curso) references modalidade_curso (id_modalidade_curso),
constraint fk_item_requerimento_requerimento foreign key (item_requerimento) references item_requerimento (item_requerimento)
);

create table if not exists CLIENTE_REQUERIMENTO ( -- 24
id_cliente_requerimento int primary key auto_increment,
id_cliente int,
id_requerimento int,
constraint fk_id_cliente_requerimento foreign key (id_cliente) references cliente(id_cliente),
constraint fk_id_requerimento_requerimento foreign key (id_requerimento) references requerimento(id_requerimento) 
);

create table if not exists REQUERIMENTO_USUARIO ( -- 25 
id_requerimento_usuario int primary key auto_increment,
id_requerimento int,
id_usuario int,
data_cadastro datetime not null,
acao varchar(255) not null,
justificativa_cancelamento varchar(255) not null,

constraint fk_id_requerimento foreign key (id_requerimento) references requerimento(id_requerimento),
constraint fk_id_usuario_requerimento foreign key (id_usuario) references usuario(id_usuario)
);