-- 1 Creación de la base de datos
create database dbaplicacion;

-- 2.1 Tabla tipo_permiso
create table tipo_permiso(
	id integer primary key identity,
	descripcion varchar(256) not null
);

-- 2.2 Tabla permiso
create table permiso(
	id integer primary key identity,
	id_tipo_permiso integer not null,
	nombre_empleado varchar(30) not null,
	apellidos_empleado varchar(50) not null,
	fecha_permiso datetime not null,
	FOREIGN KEY (id_tipo_permiso) REFERENCES tipo_permiso (id)
);

-- 3.1 Populado: tipo_permiso
INSERT INTO tipo_permiso ("descripcion")
VALUES	('Enfermedad'),
		('Diligencias'),
		('Nacimiento'),
		('Fallecimiento'),
		('Boda');
		
-- 3.2 Populado: permiso		
INSERT INTO permiso ("id_tipo_permiso", "nombre_empleado", "apellidos_empleado", "fecha_permiso") 
VALUES 	(1, 'Aaron', 'Marsden', '2020-01-16 15:19:15'),
		(2, 'Rhonda', 'Zenia', '2020-01-17 15:19:40'),
		(3, 'Martha', 'Kennan', '2020-01-18 15:57:23'),
		(4, 'Claire', 'Blythe', '2020-01-19 15:58:08'),
		(5, 'Ferris', 'Vance', '2020-01-20 16:02:02');
		
-- 4.1 Eliminación de registros de tablas
delete from permiso;
delete from tipo_permiso;

-- 4.2 Reinicio de los campos autoincrementales (identity)
DBCC CHECKIDENT ("permiso", RESEED, 0); 	
DBCC CHECKIDENT ("tipo_permiso", RESEED, 0); 

-- 5 Eliminación de tablas del sistema
drop table permiso;
drop table tipo_permiso;