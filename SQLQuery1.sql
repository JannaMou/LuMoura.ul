CREATE TABLE Agendamento (
    AgendamentoID INT IDENTITY(1, 1) PRIMARY KEY,
    Nome varchar(100) not null,
    Telefone int not null,
    Servico Varchar (100) not null,
    DataAgendamento varchar(50) NOT NULL,
    Observacoes varchar(100),
    DataCadastro DATETIME DEFAULT GETDATE()
);

select * from Agendamento