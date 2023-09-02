create table Cliente(
idCliente int identity,
nome varchar (50)not null,
cpfCliente varchar (11)not null,
celular char (11) not null,
email varchar (50) not null,
Logradouro varchar (50) not null,
numero varchar (10) not null,
complemento varchar (10) not null,
cidade varchar (50) not null,
estado varchar (30) not null,
cep char (8) not null,
genero varchar (20) not null,
dataNascimento datetime not null,
senhaLogin char (6) not null,

constraint pk_Cliente primary key (idCliente),
constraint uk_Cliente_cpf unique (cpfCliente),

)

create table Conta (
idConta int identity,
idCliente int not null,
dataAbertura datetime not null,
dataEncerramento datetime,
saldo decimal (10,2)not null,
tipoConta varchar (50) not null,
statusConta varchar (7),
senhaConta char (6) not null,

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
select * from cliente