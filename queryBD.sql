--Tabla de redes sociales de la empresa
create table RRSS(
	nombreRedSocial varchar(20),
	nombreUsuarioRS varchar (20),
	claveRS varchar(120)
	primary key (nombreRedSocial)
)

--Tabla Pais
create table Pais(
	idPais int,
	nombrePais varchar(30)
	primary key(idPais)
)
--Tabla de Cliente
create table Cliente(
	cedula int,
	nombre varchar (30),
	apellido1 varchar (30),
	apellido2 varchar(30),
	ciudad varchar(30),
	pais int, 
	correoElectronico varchar(30)
	primary key (cedula),
	foreign key (pais) references Pais(idPais)
		on delete cascade
		on update cascade
)

--Tabla Servicio
create table Servicio(
	idServicio int,
	descripcion varchar(30),
	formaDePago varchar(30),
	estadoServicio varchar(30)
	primary key (idServicio)
)

--Tabla RedSocialCliente
create table RedSocialCliente(
	idRedSocial int,
	nombreRedSocial varchar(30)
	primary key (idRedSocial)
)

--Tabla CampannaMercadeo
create table CampannaMercadeo(
	idCampannaMercadeo int,
	nombreCampanna varchar(40),
	fechaInicio date,
	fechaFinal date,
	costoCampanna int
	primary key (idCampannaMercadeo)
)


--Tabla intermedia entre las redes sociales del cliente y cliente
create table IntermediaRSClienteyCliente(
	cedula int,
	idRedSocial int,
	primary key(cedula, idRedSocial),
	foreign key (cedula) references Cliente(cedula)
		 on delete cascade
		 on update cascade,
	foreign key (idRedSocial) references RedSocialCliente(idRedSocial)
		on delete cascade
		on update cascade
)
--Tabla intermedia entre Servicio y Pais
create table IntermediaServicioyPais(
	idServicio int,
	idPais int,
	primary key(idServicio, idPais),
	foreign key (idServicio) references Servicio(idServicio)
		on delete cascade
		on update cascade,
	foreign key (idPais) references Pais(idPais)
		on delete cascade
		on update cascade

)

--Tabla intermedia entre Cliente y Servicio
create table IntermediaClienteyServicio(
	idServicio int,
	cedula int,
	estadoServicio varchar(30),
	idPais int,
	primary key(idServicio, cedula),
	foreign key (idServicio) references Servicio(idServicio)
		on delete cascade
		on update cascade,
	foreign key (cedula) references Cliente(cedula)
		on delete cascade
		on update cascade,
)

--Tabla intermedia entre Pais y CampannaMercadeo
create table IntermediaPaisyCampannaMercadeo(
	idCampannaMercadeo int,
	idPais int,
	primary key(idCampannaMercadeo, idPais),
	foreign key (idCampannaMercadeo) references CampannaMercadeo(idCampannaMercadeo)
		on delete cascade
		on update cascade,
	foreign key (idPais) references Pais(idPais)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre Cliente y CampannaMercadeo
create table IntermediaCampannaMercadeoyCliente(
	cedula int,
	idCampannaMercadeo int
	primary key(cedula, idCampannaMercadeo)
	foreign key (cedula) references Cliente(cedula)
		on delete cascade
		on update cascade,
	foreign key (idCampannaMercadeo) references CampannaMercadeo(idCampannaMercadeo)
		on delete cascade
		on update cascade
)

--Tabla intermedia entre intermediaRRSSyCliente y RRSS de la empresa

insert into RRSS values('Twitter', '@CableMio', 'sacudimeElCable2017!')
select * from RRSS
insert into Pais values(47, 'Noruega')
select * from Pais
insert into Cliente values(1, 'Pablo', 'Corrales', 'Mora','San Jose',506, 'pablo@pabloocm.xyz')
select * from Cliente
insert into Servicio values(2, 'Fibra','quincenal','inactivo')
select * from Servicio
insert into RedSocialCliente values(2, 'Facebook')
select * from RedSocialCliente
insert into CampannaMercadeo values(1, 'Conquistando al cacheton', '2017-02-01', '2017-06-01', 3000)
select * from CampannaMercadeo
select nombreRedSocial from RRSS
insert IntermediaPaisyCampannaMercadeo values(1, 506)

Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Servicio.formaDePago='quincenal' and Servicio.idServicio= 1 and Cliente.cedula =1
Select Servicio.idServicio, descripcion, nombre, apellido1, apellido2, formaDePago from Cliente join IntermediaClienteyServicio on IntermediaClienteyServicio.cedula= Cliente.cedula join Servicio on Servicio.idServicio = IntermediaClienteyServicio.idServicio where Cliente.cedula = 4
select Cliente.cedula, nombre from Cliente, IntermediaCampannaMercadeoyCliente, CampannaMercadeo where IntermediaCampannaMercadeoyCliente.cedula = 3 and IntermediaCampannaMercadeoyCliente.idCampannaMercadeo = 1
select nombrePais from Pais, CampannaMercadeo, IntermediaPaisyCampannaMercadeo where IntermediaPaisyCampannaMercadeo.idPais=Pais.idPais and CampannaMercadeo.idCampannaMercadeo = 1
select nombrePais from Pais, Servicio, IntermediaServicioyPais where Pais.idPais = IntermediaServicioyPais.idPais and Servicio.idServicio = 1