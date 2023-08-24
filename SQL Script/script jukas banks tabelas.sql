create table Cliente(
idCliente int identity,
Nome varchar (50)not null,
cpfCliente varchar (11)not null,
Celular char (11) not null,
Email varchar (50) not null,
Logradouro varchar (50) not null,
numero varchar (10) not null,
Complemento varchar (10) not null,
Cidade varchar (50) not null,
Estado varchar (30) not null,
cep char (8) not null,
Genero varchar (20) not null,
DataNascimento datetime not null,
SenhaLogin char (6) not null,

constraint pk_Cliente primary key (idCliente),
constraint uk_Cliente_cpf unique (cpfCliente),

)

create table Conta (
idConta int identity,
idCliente int not null,
dataAbertura datetime not null,
saldo decimal (10,2)not null,
tipoConta varchar (50) not null,
StatusConta varchar (7),
SenhaConta char (6),

constraint pk_Conta primary key (idConta),
constraint fk_Conta_Cliente foreign key (idCliente) references Cliente (idCliente),
Constraint ck_conta_StatusConta check (StatusConta in ('ativa','inativa'))
)

create table TipoOperacao (
idTipoOperacao int identity,
nomeOperacao varchar (50) not null,
constraint pk_TipoOperacao primary key (idTipoOperacao)
)


create table movimentacao(
idMovimentacao int identity,
idContaOrigem int not null,
idContaDestino int not null,
idTipoOperacao int not null,
dataHora datetime not null,
valorMovimentacao decimal not null,

constraint pk_Movimentacao primary key (idMovimentacao),
constraint fk_movimentacao_Conta_Origem foreign key (idContaOrigem) references Conta (idConta),
constraint fk_movimentacao_Conta_Destino foreign key (idContaDestino) references Conta(idConta),
constraint fk_movimentacao_tipo_Operacao foreign key (idTipoOperacao) references TipoOperacao (idTipoOperacao)
)

create table Agendamento (
IdAgendamento int identity,
idContaOrigem int not null,
IdContaDestino int not null,
idTipoOperacao int not null,
dataHora datetime not null,
valorAgendamento decimal not null,
StatusAgendamento varchar (10)  

constraint pk_Agendamento primary key (idAgendamento),
constraint fk_Agendamento_Conta_Origem foreign key (idContaOrigem) references Conta (idConta),
constraint fk_Agendamento_Conta_Destino foreign key (idContaDestino) references Conta(idConta),
constraint fk_Agendamento_Tipo_Operacao foreign key (idTipoOperacao) references TipoOperacao(idTipoOperacao),
Constraint ck_Agendamento_Status_Agendamento check (StatusAgendamento in ('Em espera','Concluido','Cancelado'))
)

select * from Cliente
select * from Conta
select * from TipoOperacao
select * from movimentacao
select * from Agendamento

drop database JukasBankss
drop table Cliente