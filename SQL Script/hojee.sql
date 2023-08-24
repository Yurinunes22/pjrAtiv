use JukasBankss

create procedure psValidaLogin
@cpfCliente char(11),
@SenhaLogin char(6)
as
select * from Cliente
where cpfCliente=@cpfCliente and SenhaLogin=@SenhaLogin
exec psValidaLogin '11122233344','123456'

insert into Cliente
values ('Donald','11122233344','13988884444','donald@gmail.com','Rua da esperança','55','Casa','Santos','São Paulo','11340789','Masculino','03/05/88','123456')


drop procedure psValidaLogin