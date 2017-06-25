use master 
go

create database BD_Hospedaje
go

use BD_Hospedaje
go


create table TABLA_LICENCIA(
ID int not null,
LICENCIA varchar(10) not null,
MODIFICA varchar(50) not null)
go

insert into TABLA_LICENCIA (ID, LICENCIA,MODIFICA) values('1','0','CES')
go

update TABLA_LICENCIA set LICENCIA = '3RYTYN', MODIFICA = 'CES_ADMIN' where (ID = 1)
go

create table TABLA_USUARIO(
ID_USUARIO varchar(50) not null,
NOMBRE_USUARIO varchar(50) not null,
CONTRASEÑA_USUARIO varchar(50) not null,
TIPO_USUARIO varchar(50) not null,
MODIFICA varchar(50) not null,
constraint PK_ID_USUARIO primary key (ID_USUARIO))
go

insert into TABLA_USUARIO(ID_USUARIO, NOMBRE_USUARIO, CONTRASEÑA_USUARIO, TIPO_USUARIO, MODIFICA) values('1','CES_ADMIN','1','Programador','CES_ADMIN')
go

create table TABLA_INFO_EMPRE(
ID_EMPRE int not null,
NOMBRE varchar(50) not null,
CEDULA varchar(50) not null,
UBICACION varchar(50) not null,
TELEFONO varchar(50) not null,
CORREO varchar(50) not null,
FACEBOOK varchar(50) not null,
LEMA varchar(50) not null,
MODIFICA varchar(50) not null)
go

insert into TABLA_INFO_EMPRE(ID_EMPRE, NOMBRE, CEDULA, UBICACION, TELEFONO, CORREO, FACEBOOK, LEMA, MODIFICA) values(1,'NOMBRE','CEDULA: 1-301-XXXXXXX','UBICACION','TELEFONO','CORREO@outlook.com','@FACEBOOK','#LEMA','CES_ADMIN')
go


/*-----------------------------------------------------------------*/
/*-----------------------           -------------------------------*/
/*----------------------- Ocupacion -------------------------------*/
/*-----------------------           -------------------------------*/
/*-----------------------------------------------------------------*/

create table TABLA_HABITACION(
ID_HABITACION int not null,
CATEGORIA varchar(50) not null,
CANTIDAD_PERSONAS int not null,
PRECIO_NACIONAL decimal(10,2) not null,
PRECIO_EXTRANJERO decimal(10,2) not null,
PRECIO_GOBIERNO decimal(10,2) not null,
PRECIO_NACIONAL_IMPUESTO decimal(10,2) not null,
PRECIO_EXTRANJERO_IMPUESTO decimal(10,2) not null,
PRECIO_GOBIERNO_IMPUESTO decimal(10,2) not null,
MODIFICA varchar(50) not null,
constraint PK_ID_HABITACION primary key (ID_HABITACION))
go

create table TABLA_INVENTARIO_HABITACION(
ID_ACTIVO int not null,
ID_HABITACION_INVENTARIO int not null,
NOMBRE varchar(50) not null,
CANTIDAD_ACT int not null,
OBSERVACION varchar(50) not null,
MODIFICA varchar(50) not null
constraint PKID_CLIENTE primary key (ID_ACTIVO))
go

alter table TABLA_INVENTARIO_HABITACION
add constraint FK_ID_HABITACION_INVENTARIO foreign key (ID_HABITACION_INVENTARIO)
references TABLA_HABITACION(ID_HABITACION)
go

create table TABLA_CLIENTE(
ID_CLIENTE varchar(50) not null,
NOMBRE varchar(50) not null,
TELEFONO varchar(50) not null,
TELEFONO_EMERGENCIA varchar(50) not null,
OBSERVACION varchar(50) not null,
MODIFICA varchar(50) not null,
constraint PK_ID_CLIENTE primary key (ID_CLIENTE))
go

create table TABLA_RESERVA(
ID_RESERVA int not null,
ID_HABITACION_RESERVA int not null,
ID_CLIENTE_RESERVA varchar(50) not null,
ESTADO varchar(50) not null,
FECHA_LIMITE date not null,
FECHA_INGRESO date not null,
FECHA_SALIDA date not null,
CANTIDAD_PERSONAS  int not null,
CANTIDAD_DIAS int not null,
MODIFICA varchar(50) not null,
constraint PK_ID_RESERVA primary key (ID_RESERVA))
go

alter table TABLA_RESERVA
add constraint FK_ID_HABITACION_RESERVA foreign key (ID_HABITACION_RESERVA)
references TABLA_HABITACION(ID_HABITACION)
go

alter table TABLA_RESERVA
add constraint FK_ID_CLIENTE_RESERVA foreign key (ID_CLIENTE_RESERVA)
references TABLA_CLIENTE(ID_CLIENTE)
go


/*---------------------------------------------------------------*/
/*-----------------------         -------------------------------*/
/*----------------------- FACTURA -------------------------------*/
/*-----------------------         -------------------------------*/
/*---------------------------------------------------------------*/

create table TABLA_NUM_FACTURA(
ID_FACTURA int not null,
ID_ULTIMO_FACTURA int not null,
MODIFICA varchar(50) not null)
go

insert into TABLA_NUM_FACTURA(ID_FACTURA, ID_ULTIMO_FACTURA,MODIFICA) values(1,0,'CES_ADMIN')
go

create table TABLA_FACTURA(
ID_FACTURA int not null,
ID_RESERVA_FACTURA int not null,
FECHA date not null,
CLIENTE varchar(50) not null,
TIPO_PAGO varchar(50) not null,
SUBTOTAL decimal(10,2) not null,
IMPUESTO decimal(10,2) not null,
DESCUENTO decimal(10,2) not null,
TOTAL decimal(10,2) not null,
UTILIDAD_TOTAL decimal(10,2) not null,
MODIFICA varchar(50) not null,
constraint PK_ID_FACTURA primary key (ID_FACTURA))
go

create table TABLA_LINEA_FACTURA(
ID_FACTURA_LINEA int not null,
ID_LINEA varchar(30) not null,
ID_RESERVA_LINEA int not null,
DESCRIPCION varchar(50) not null,
PRECIO_VENTA decimal(10,2) not null,
PRECIO_VENTA_MAS_IMPUESTO decimal(10,2) not null,
TOTAL_LINEA  decimal(10,2) not null,
TOTAL_LINEA_IMPUESTO  decimal(10,2) not null,
UTILIDAD_LINEA decimal(10,2) not null,
MODIFICA varchar(50) not null)
go

alter table TABLA_LINEA_FACTURA
add constraint FK_ID_FACTURA_LINEA foreign key (ID_FACTURA_LINEA)
references TABLA_FACTURA(ID_FACTURA)
go

alter table TABLA_LINEA_FACTURA
add constraint FK_ID_RESERVA_LINEA foreign key (ID_RESERVA_LINEA)
references TABLA_RESERVA(ID_RESERVA)
go


use BD_Hospedaje
go

select * from TABLA_LICENCIA
select * from TABLA_USUARIO
select * from TABLA_INFO_EMPRE

select * from TABLA_HABITACION
select * from TABLA_INVENTARIO_HABITACION
select * from TABLA_CLIENTE
select * from TABLA_RESERVA

select * from TABLA_NUM_FACTURA
select * from TABLA_FACTURA
select * from TABLA_LINEA_FACTURA
go


/*SELECT * FROM TABLA_FACTURA WHERE ID_FACTURA = (SELECT MAX(ID_FACTURA) from TABLA_FACTURA)*/
