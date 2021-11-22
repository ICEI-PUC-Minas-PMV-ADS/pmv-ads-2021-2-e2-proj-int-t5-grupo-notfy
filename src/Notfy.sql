-- Criação do banco de dados
CREATE DATABASE Notfy;
USE Notfy;

-- Criando as tabelas do banco de dados
CREATE TABLE Notificadores (
	Codigo bigint PRIMARY KEY,
	Nome varchar(255),
	RG varchar(8),
	CPF_CNPJ varchar(20),
	Logradouro varchar(255),
	Complemento varchar(150),
	Bairro varchar(150),
	Cidade varchar(150),
	Estado char(2),
	Email varchar(150));

CREATE TABLE Notificandos (
	Codigo bigint PRIMARY KEY,
	Nome varchar(255),
	Tipo char(1),
	CPF_CNPJ varchar(20),
	Email varchar(150));

CREATE TABLE Notificações (
	Matricula_Imovel bigint PRIMARY KEY,
	Endereço varchar(255),
	Data_1_Tenativa datetime,
	Data_2_Tenativa datetime,
	Data_3_Tenativa datetime,
	Concluido char(2),
	ID_Endereço bigint,
	Cod_Notificando bigint,
	Sequencia_de_Entrega char(3));

CREATE TABLE Endereços (
	Codigo bigint PRIMARY KEY,
	ID_Notificando varchar(255),
	Logradouro varchar(255),
	Complemento varchar(150),
	Bairro varchar(150),
	Cidade varchar(150),
	Estado char(2),
	Email varchar(150));


-- Populando as Tabelas do Banco de Dados (Inserindo Dados)

-- Populando a Tabela Notificadores
INSERT INTO Notificadores values 