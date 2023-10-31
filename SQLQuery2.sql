CREATE TABLE Servicos (
    ServicoID INT IDENTITY(1, 1) PRIMARY KEY,
    Nome VARCHAR(255) NOT NULL,
    DuracaoEmHoras DECIMAL(4, 2) NOT NULL
);

CREATE TABLE Horarios (
    HorarioID INT IDENTITY(1, 1) PRIMARY KEY,
    Hora TIME NOT NULL
);

CREATE TABLE Agendamentos (
    AgendamentoID INT IDENTITY(1, 1) PRIMARY KEY,
    ServicoID INT,
    HorarioID INT,
    DataAgendamento DATE NOT NULL,
    NomeCliente VARCHAR(255) NOT NULL
);

CREATE TABLE Cliente (
    IdCliente      INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    Nome    VARCHAR(50) NOT NULL,
    CPF            VARCHAR(50) ,
    Telefone       VARCHAR(12) ,
    Email       VARCHAR(50) NOT NULL,        
    DataCadastro   DATETIME       DEFAULT (getdate()) NOT NULL,
);

CREATE TABLE Login
(
	IdLogin int primary key identity (1,1) NOT NULL,
	Login          VARCHAR(12) NULL,
    Senha          VARCHAR(12) NOT NULL, 
    FKCliente int not null,
	Foreign key (FKCliente) references Cliente(IdCliente)  
);

select * from Cliente