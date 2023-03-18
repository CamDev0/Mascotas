
/*
use master
go
DROP DATABASE MascotasElHuerfanito
go
*/

create database MascotasElHuerfanito
go

use MascotasElHuerfanito
go

CREATE TABLE DataMascotas
(
id int identity(1,1) primary key not null,
Nombre nvarchar(50) not null,
Edad int not null,
Tipo nvarchar(50) not null,
Color nvarchar(50) not null,
);
go

CREATE TABLE tblClientes
(
id_CLI int identity(1,1) primary key not null,
idAdop int not null,
nombre nvarchar(50) not null,
apellido nvarchar(50) not null,
telefono nvarchar(50) not null,
direccion nvarchar(50) not null,
);
go

CREATE TABLE tblAdopcion
(
idMascota int not null,
nombreMascota nvarchar(50) not null,
tipoMascota nvarchar(50) not null,
)


CREATE TABLE tblAcceso
(
usuario nvarchar(20) not null,
clave nvarchar(20) not null
)

ALTER TABLE tblAdopcion
	ADD CONSTRAINT FK_IDMascota FOREIGN KEY (idMascota) REFERENCES DataMascotas(id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
;

INSERT INTO tblAcceso VALUES 
('Sara', '1111'), ('Luis', '2222'), ('Camilo', '3333'),
('Gabriel', '4444'), ('Juan', '5555'), ('Valentina', '6666')

Select * from DataMascotas
Select * from tblClientes
Select * from tblAdopcion
Select * from tblAcceso

 
 