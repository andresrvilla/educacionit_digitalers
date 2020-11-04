Use master;
drop database if exists DigitalersCompras;
create database DigitalersCompras;
Use DigitalersCompras;

create table Facturas
(
	Letra 		char,
	Numero 	int,
    ClienteID  int,
    ArticuloID int,
	Fecha 		date,
	Monto 		money,
	primary key (Letra, Numero)
);

create table Articulos
(
	ArticuloID	int,
	Nombre 	varchar(50),
	Precio 	money,
	Stock 		int,
	primary key (ArticuloID)
);

create table Clientes
(
	ClienteID      	int,
	Nombre    		varchar(50),
	Apellido   	varchar(50),
	Cuit       	char(16),
	Direccion  	varchar(50),
    Comentarios 	varchar(50),
    primary key (ClienteID)
);

create table agenda(
	Contacto int,
	Nombre varchar(20),
	Domicilio varchar(30),
	Telefono varchar(9),
	primary key (Contacto)
);

insert into articulos(ArticuloID, Nombre, Precio, Stock) values (1, 'Destornillador', 25, 50);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (2, 'Pinza'         , 35, 22);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (3, 'Martillo'      , 15, 28);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (4, 'Maza'          , 35, 18);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (5, 'Balde'         , 55, 13);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (6,  'Cinta'	 , 110, 50);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (7,  'Espatula'  , 20 , 22);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (8,  'Fratas'    , 35 , 28);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (9,  'Regrla'    , 20 , 78);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (10, 'Tenaza'    , 12 , 13);

insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 1, 1, 1, '2011/10/18', 500);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 2, 2, 2, '2011/10/18', 2500);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 3, 3, 3, '2011/10/18', 320);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 4, 4, 4, '2011/10/18', 120);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 1, 1, 1, '2011/11/18', 5000);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 2, 2, 2, '2011/11/18', 200);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 3, 3, 3, '2011/11/18', 3020);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 4, 4, 4, '2011/11/18', 1200);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 5, 5, 5, getdate()   , 3300);

insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (1 , 'Carlos'  , 'Diaz' , '21-15977008-8', 'Aguero 635'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (2 , 'Martín'  , 'Gomez' , '19-39552864-5', 'Nazca 1532'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (3 , 'Esteban', 'Suarez', '20-31447315-8', 'Chipre 5'     , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (4 , 'Susana', 'Villalba' , '21-22982335-2', 'Jufre 3651'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (5, 'Lucía'   , 'Perez', '19-10584471-9', 'Belgrano 6525', NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (6 , 'Mario'  , 'Pena' , '20-13817008-8', 'Aguero 635'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (7 , 'Jorge'  , 'Rios' , '20-37562854-5', 'Nazca 1532'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (8 , 'Valeria', 'Lagos', '20-25487418-8', 'Chipre 5'     , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (9 , 'Natalia', 'Peña' , '20-25982665-2', 'Jufre 3651'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (10, 'Juan'   , 'Khorn', '20-23587171-9', 'Belgrano 6525', NULL);

insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (1, 'Alberto Mores', 'Colon 123', '4234567');
insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (2, 'Juan Torres', 'Avellaneda 135', '4458787');
insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (3, 'Carla Paez', 'Lima 2335', '6658747');