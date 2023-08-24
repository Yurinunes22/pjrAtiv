/*-----------------------------------------------------------------1-----------------------------------------------------------------*/
insert into Cliente
values ('Donald','11122233344','13988884444','donald@gmail.com','Rua da esperança','55','Casa','Santos','São Paulo','11340789','Masculino','03/05/88','123456'),
	   ('Margarida','11122233388','13999884444','margarida@gmail.com','Rua da Paz','75','Apto 2','São Vicente','São Paulo','11340777','Feminino','02/07/99','11122233388','654321'),
	   ('Patinhas','11122233311','13933884444','Patinhas@gmail.com','Rua Gloria Pires','22','Casa','Santos','São Paulo','11340722','Masculino','01/09/95','11122233311','222333'),
	   ('Huguinho','11122233322','13999884412','Huguinho@gmail.com','Rua do Mateus','78','Casa','Cubatão','São Paulo','11320777','Masculino','02/07/88','11122233322','333444'),
	   ('Luizinho','22122233388','13999885544','LUiz@gmail.com','Rua 11 de Setembro','66','Apto 35','Praia Grande','São Paulo','11340666','Masculino','03/12/96','22122233388','555666'),
	   ('Zezinho','44455533388','32999887788','Zezinho@gmail.com','Rua do lol','12','Apto 27','São João del Rei','Minas Gerais','11340999','Masculino','02/07/99','44455533388','777888'),
	   ('Mickey','99922233388','13999884444','margarida@gmail.com','Rua da Paz','75','Casa','São Vicente','São Paulo','11340777','Masculino','09/10/97','99922233388','999111'),
	   ('Minie','88822233388','11977884444','minie@gmail.com','Rua da Vida','785','Apto 109','São Paulo','São Paulo','11380333','Feminino','02/12/96','88822233388','888111');

select * from Cliente 
select * from Conta 
select * from tipoOperacao
select * from Agendamento
select * from movimentacao


/*-----------------------------------------------------------------2-----------------------------------------------------------------*/

insert into Conta (idCliente,dataAbertura,saldo,tipoConta,StatusConta)
values(1,'20/9/2012 13:00',1000.00,'Corrente','Ativa'),
      (2,'12/7/2014 12:00',450.50,'Poupança','Inativa'),
	  (3,'2/3/2015 11:00',650000.50,'Corrente','Ativa'),
	  (4,'20/5/2015 10:00',500.00,'Poupança','Ativa'),
	  (5,'25/9/2018 9:00',3500.00,'Corrente','Ativa'),
	  (6,'2/9/2012 8:30',700.25,'Poupança','Inativa'),
	  (7,'20/7/2019 7:00',9500.25,'Corrente','Ativa'),
	  (8,'11/2/2022 8:00',12500.50,'Poupança','Ativa');

/*-----------------------------------------------------------------3-----------------------------------------------------------------*/

insert into Conta
values (3,'15/09/2020',1000000.50,'Corrente','Ativa'),
       (3,'18/04/2018',250000.00,'Poupança','Ativa')
        
/*-----------------------------------------------------------------4-----------------------------------------------------------------*/

insert into tipoOperacao
values('Debito'),
      ('Saque'),
	  ('Transferência')

/*-----------------------------------------------------------------5-----------------------------------------------------------------*/

insert into Agendamento 
values (10,3,3,'25/12/2023',100000.00,'Em espera')

/*-----------------------------------------------------------------6-----------------------------------------------------------------*/

update Cliente
set Logradouro = 'Rua Fernando Lazaro',numero = '100',Complemento = 'Casa' where idCliente = 8

/*-----------------------------------------------------------------7-----------------------------------------------------------------*/

update Cliente 
set Celular = '11981894377' where idCliente = 7

/*-----------------------------------------------------------------8-----------------------------------------------------------------*/

insert into movimentacao
values (7,7,2,'02/01/2023',100.00)

insert into movimentacao
values (4,4,2,'08/08/2022',250.00)

/*-----------------------------------------------------------------9-----------------------------------------------------------------*/

insert into movimentacao
values (8,8,3,'23/07/2022',1100.00)

insert into movimentacao
values (1,1,3,'03/12/2022',450.00)

/*-----------------------------------------------------------------10-----------------------------------------------------------------*/

insert into movimentacao
values (6,8,3,'28/07/2022',350.50)

insert into movimentacao
values (1,4,3,'02/04/2022',50.00)

/*-----------------------------------------------------------------11-----------------------------------------------------------------*/

select Nome,Celular,Cidade,estado from Cliente where idCliente = 2 or idCliente = 6 

/*-----------------------------------------------------------------12-----------------------------------------------------------------*/

select count (idCliente) from Cliente
where tipoConta like '%Corrente%








