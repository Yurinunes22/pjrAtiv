use JukasBankss

create procedure ps_ValidaLogin
@cpfCliente char(11),
@SenhaLogin char(6)
as
select * from Cliente
where cpfCliente=@cpfCliente and senhaLogin=@senhaLogin

exec ps_ValidaLogin '11122233344','123456'

insert into Cliente
values ('Donald','11122233344','13988884444','donald@gmail.com','Rua da esperança','55','Casa','Santos','São Paulo','11340789','Masculino','03/05/88','123456')

select * from Conta


drop procedure ps_buscaContasPorIdCliente

insert into Conta
values (1,'09/15/2020', null, 1000000.50,'Corrente','Ativa','123456')

create procedure ps_buscaContasPorIdCliente
@idCliente int 
as
select * from Conta
where idCliente = @idCliente

exec ps_buscaContasPorIdCliente 1

/*Cadastro Cliente*/
create procedure pi_Cliente
@nome varchar (50),
@cpfCliente varchar (11),
@celular char (11),
@email varchar (50),
@Logradouro varchar (50),
@numero varchar (10),
@complemento varchar (10),
@cidade varchar (50),
@estado varchar (30),
@cep char (8),
@genero varchar (20),
@dataNascimento datetime,
@senhaLogin char (6)
as
insert into Cliente
values (@nome,@cpfCliente,@celular,@email,@logradouro,@numero,@complemento,@cidade,@estado,@cep,@genero,@dataNascimento,@senhaLogin) 

/*criar conta*/
create procedure pi_Conta_48
@idCliente int ,
@dataAbertura datetime ,
@dataEncerramento datetime,
@saldo decimal (10,2),
@tipoConta varchar (50),
@statusConta varchar (7),
@senhaConta char (6) 

as
insert into conta (idCliente,dataAbertura,dataEncerramento,saldo,tipoConta,statusConta,senhaConta)
values (@idCliente,@dataAbertura,@dataEncerramento,@saldo,@tipoConta,@statusConta,@senhaConta)
select @@identity as 'ultimoID'



