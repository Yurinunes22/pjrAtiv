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