CREATE TABLE Servicos (
    ServicoID INT IDENTITY(1, 1) PRIMARY KEY,
    NomeServico VARCHAR(255) NOT NULL,
    DescricaoServico Varchar (200) not null,
    ValorServico Decimal (10,2) not null,
    DuracaoEmHoras DECIMAL(4, 2) NOT NULL
);

drop table Servicos


CREATE TABLE Horarios (
    HorarioID INT IDENTITY(1, 1) PRIMARY KEY,
    Hora TIME NOT NULL
);

CREATE TABLE Agendamentos (
    AgendamentoID INT IDENTITY(1, 1) PRIMARY KEY,
    FK_ServicoID INT  ,
    FK_HorarioID INT  ,
    DataAgendamento DATETIME NOT NULL,   
    NomeCliente VARCHAR(255) NOT NULL,
    Telefone Varchar (100) not null,
    Servico Varchar (100) not null,
    Descricao varchar (100),

    Foreign key (FK_ServicoID) references Servicos(ServicoID),
    Foreign key (FK_HorarioID) references Cliente(IdCliente),

);
drop table Agendamentos
CREATE TABLE Cliente (
    IdCliente      INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
    Nome    VARCHAR(50) NOT NULL,
    CPF            VARCHAR(50) ,
    Telefone       VARCHAR(12) ,
    Email       VARCHAR(50) NOT NULL,        
    DataCadastro   DATETIME (100)      DEFAULT (getdate()) NOT NULL,
);

CREATE TABLE Login
(
	IdLogin int primary key identity (1,1) NOT NULL,
	Login          VARCHAR(12) NULL,
    Senha          VARCHAR(12) NOT NULL, 
    FKCliente int not null,
	Foreign key (FKCliente) references Cliente(IdCliente)  
);

DECLARE @hora TIME = '09:00';
WHILE @hora <= '17:00'
BEGIN
    INSERT INTO Horarios (Hora)
    VALUES (@hora);
    SET @hora = DATEADD(HOUR, 1, @hora);
END;
select * from Horarios
